Public Class Form1
    Private listaCalificaciones As List(Of Calificaciones)

    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        Try
            lbl_Mensajes.Text = String.Empty
            Dim alumno = BDHelper.GetAlumno(txtLegajo.Text)
            If (alumno IsNot Nothing) Then
                txtNombres.Text = alumno.Nombre
                txtApellido.Text = alumno.Apellido
                cmdConsultar.Enabled = True
            Else
                cmdConsultar.Enabled = False
                lbl_Mensajes.Text = "El legajo no existe"
            End If
        Catch ex As Exception
            lbl_Mensajes.Text = ex.Message
        End Try
    End Sub

    Private Sub cmdConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConsultar.Click
        Dim fecha As DateTime
        Try
            'Limpia la ettiqueta de mensajes
            lbl_Mensajes.Text = String.Empty
            'Carga en una lista de calificaciones la consulta hecha a la base de datos
            Dim calificaciones As List(Of Calificaciones) = BDHelper.GetCalificaciones(txtLegajo.Text, cmbMaterias.SelectedValue)
            If (calificaciones.Count = 0) Then
                lbl_Mensajes.Text = "No existen calificaciones"
            End If
            'Limpia la grilla de datos anteriores
            dgvCalificaciones.Rows.Clear()
            'Por cada elemento de la lista de calificaciones, agrega una fila en la grilla 
            For Each calificacion As Calificaciones In calificaciones
                dgvCalificaciones.Rows.Add((New Object() {calificacion.Fecha, calificacion.Nota, calificacion.NombreProfesor}))
            Next

        Catch ex As Exception
            lbl_Mensajes.Text = ex.Message
        End Try
    End Sub


    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        'combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion

    End Sub

    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub dgvCalificaciones_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            lbl_Mensajes.Text = String.Empty
            BDHelper.GuardarCalificaciones(listaCalificaciones)
            lbl_Mensajes.Text = "Las calificaciones se guardaron correctamente."
        Catch ex As Exception
            lbl_Mensajes.Text = ex.Message
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            lbl_Mensajes.Text = String.Empty

            listaCalificaciones = New List(Of Calificaciones)()
            cmdConsultar.Enabled = False
            CargarCombo(cmbMaterias, BDHelper.GetMaterias(), "id_materia", "nombre_materia")
        Catch ex As Exception
            lbl_Mensajes.Text = ex.Message
        End Try
    End Sub



    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

    End Sub

    Private Sub txtLegajo_TextChanged(sender As Object, e As EventArgs) Handles txtLegajo.TextChanged

    End Sub
End Class
