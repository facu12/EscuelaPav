Public Class Form1
    Private Sub frm_Alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'carga la grilla apenas abre la ventana
        llenarGrid()

        'estados iniciales de botones


        btn_agregar.Enabled = True
        btn_editar.Enabled = True
        btn_salir.Enabled = True




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
End Class
