Public Class Form1
    Private Sub frm_Alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'carga la grilla apenas abre la ventana
        llenarGrid()
        'muestra los btn al momento del inicio
        btnMomentoInicial()

    End Sub


    Friend Sub llenarGrid(Optional ByVal lst As List(Of Alumno) = Nothing)
        Dim oAlumnoService As New AlumnoService
        dgv_listarAlumnos.Rows.Clear()

        If IsNothing(lst) Then
            lst = oAlumnoService.listarAlumnos()
        End If

        'Asignamos a la propiedad SelectionMode el valor FullRowSelect para que 
        'al hacer click sobre la grilla se resalte toda la fila completa. Esto puede tmb hacerse en modo diseño.
        dgv_listarAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_listarAlumnos.Rows.Clear()
        For Each oAlumno In lst
            With oAlumno
                'cargar filas del datagridview a partir de un array de strings
                dgv_listarAlumnos.Rows.Add(New String() { .legajo.ToString, .apellido.ToString, .nombre.ToString, .documento.ToString, .telefono.ToString})
            End With
        Next
    End Sub


    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        'Confirmación de salida.
        If MessageBox.Show("Seguro que desea salir?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub limpiarCampos()
        'limpia los campos txt del formulario
        txtApellido.Clear()
        txtLegajo.Clear()
        txtNombres.Clear()
        txt_documento.Clear()
        txt_telefono.Clear()

    End Sub


    Private Function crearAlumno()
        'funcion que crea un alumno a partir de los campos del formulario
        Dim al As New Alumno

        al.apellido = txtApellido.Text.ToString
        al.legajo = txtLegajo.Text.ToString
        al.nombre = txtNombres.Text.ToString
        al.documento = Convert.ToInt32(txt_documento.Text.ToString)
        al.telefono = Convert.ToInt32(txt_telefono.Text.ToString)
        Return al

    End Function

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        'btn confirmar manda un obj alumno al servicio

        Dim al As Alumno
        al = crearAlumno()

        'tomo el alumno creado por la funcion y se la paso al servicio para crear
        Dim oAlumnoServicio As New AlumnoService
        oAlumnoServicio.registrarAlumno(al)

        'vuelve al estado incial los btn y actualiza la grilla
        limpiarCampos()
        dgv_listarAlumnos.Refresh()
        btnMomentoInicial()

    End Sub

    Private Sub btnMomentoInicial()
        'estado iniciales de los textbox
        txt_telefono.Enabled = False
        txtApellido.Enabled = False
        txtLegajo.Enabled = False
        txtNombres.Enabled = False
        txt_documento.Enabled = False

        'estados iniciales de botones
        btn_confirmar.Visible = False
        btn_confirmar.Enabled = False
        btn_cancelar.Visible = False
        btn_cancelar.Enabled = False
        btn_editar.Enabled = False
        btn_salir.Enabled = True
        btn_nuevo.Enabled = True

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        limpiarCampos()

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click

        'limpio campos txt
        limpiarCampos()

        'Habilita los txt para carga de datos
        txt_telefono.Enabled = True
        txtApellido.Enabled = True
        txtLegajo.Enabled = True
        txtNombres.Enabled = True
        txt_documento.Enabled = True

        'habilito y muestro btn de confirmar y cancelar
        btn_cancelar.Enabled = True
        btn_cancelar.Visible = True
        btn_confirmar.Visible = True
        btn_confirmar.Enabled = True


    End Sub

    Private Sub dgv_listarAlumnos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listarAlumnos.CellContentClick

        'habilito boton editar
        btn_editar.Enabled = True

        'Dim al As Alumno


        'cargo los txt con los datos de la linea seleccionada
        txtApellido.Text = dgv_listarAlumnos.CurrentRow.Cells.Item("col_apellido").Value
        txtLegajo.Text = dgv_listarAlumnos.CurrentRow.Cells.Item("col_legajo").Value
        txtNombres.Text = dgv_listarAlumnos.CurrentRow.Cells.Item("col_nombre").Value
        txt_documento.Text = dgv_listarAlumnos.CurrentRow.Cells.Item("col_documento").Value
        txt_telefono.Text = dgv_listarAlumnos.CurrentRow.Cells.Item("col_telefono").Value


    End Sub


End Class
