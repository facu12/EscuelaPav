Public Class Form1
    Private listaCalificaciones As List(Of Calificaciones)

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Try
            lblMensajes.Text = String.Empty
            Dim alumno = BDHelper.GetAlumno(txtLegajo.Text)
            If (alumno IsNot Nothing) Then
                txtNombres.Text = alumno.Nombre
                txtApellido.Text = alumno.Apellido
                cmdConsultar.Enabled = True
            Else
                cmdConsultar.Enabled = False
                lblMensajes.Text = "El legajo no existe"
            End If
        Catch ex As Exception
            lblMensajes.Text = ex.Message
        End Try
    End Sub

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Dim fecha As DateTime
        Try
            'Limpia la ettiqueta de mensajes
            lblMensajes.Text = String.Empty
            'Carga en una lista de calificaciones la consulta hecha a la base de datos
            Dim calificaciones As List(Of Calificaciones) = BDHelper.GetCalificaciones(txtLegajo.Text, cmbMaterias.SelectedValue)
            If (calificaciones.Count = 0) Then
                lblMensajes.Text = "No existen calificaciones"
            End If
            'Limpia la grilla de datos anteriores
            dgvCalificaciones.Rows.Clear()
            'Por cada elemento de la lista de calificaciones, agrega una fila en la grilla 
            For Each calificacion As Calificaciones In calificaciones
                dgvCalificaciones.Rows.Add((New Object() {calificacion.Fecha, calificacion.Nota, calificacion.NombreProfesor}))
            Next

        Catch ex As Exception
            lblMensajes.Text = ex.Message
        End Try
    End Sub


    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    Private Sub dgvCalificaciones_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            lblMensajes.Text = String.Empty
            BDHelper.GuardarCalificaciones(listaCalificaciones)
            lblMensajes.Text = "Las calificaciones se guardaron correctamente."
        Catch ex As Exception
            lblMensajes.Text = ex.Message
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            lblMensajes.Text = String.Empty

            listaCalificaciones = New List(Of Calificaciones)()
            cmdConsultar.Enabled = False
            CargarCombo(cmbMaterias, BDHelper.GetMaterias(), "id_materia", "nombre_materia")
        Catch ex As Exception
            lblMensajes.Text = ex.Message
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lbl_documento.Click

    End Sub
End Class
