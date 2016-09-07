Public Class Form1
    Private Sub frm_Alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'carga la grilla apenas abre la ventana
        llenarGrid()
        'muestra los btn al momento del inicio
        btnMomentoInicial()

    End Sub

    Friend Sub llenarGrid(Optional ByVal lst As List(Of Alumno) = Nothing)

        Dim oAlumnoServicio As New AlumnoService
        'limpia la grilla
        dgv_listarAlumnos.Rows.Clear()
        'carga grilla de alumnos
        If IsNothing(lst) Then
            lst = oAlumnoServicio.listarAlumnos()
        End If


    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub limpiarCampos()
        'limpia los campos txt del formulario
        txtApellido.Clear()
        txtLegajo.Clear()
        txtNombres.Clear()
        txt_documento.Clear()

    End Sub


    Private Function crearAlumno()
        'funcion que crea un alumno a partir de los campos del formulario
        Dim al As New Alumno

        al.apellido = txtApellido.ToString
        al.legajo = txtLegajo.ToString
        al.nombre = txtNombres.ToString
        al.documento = (Convert.ToInt32(txt_documento))

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

        'estados iniciales de botones
        btn_confirmar.Visible = False
        btn_confirmar.Enabled = False

        btn_cancelar.Visible = False
        btn_cancelar.Enabled = False

        btn_editar.Enabled = True
        btn_salir.Enabled = True
        btn_nuevo.Enabled = True

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        limpiarCampos()

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click

        'limpio campos txt
        limpiarCampos()

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
        txtApellido = dgv_listarAlumnos.CurrentRow.Cells.Item("col_apellido").Value


    End Sub


End Class
