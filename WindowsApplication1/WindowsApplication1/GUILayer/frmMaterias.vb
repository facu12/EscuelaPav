Public Class frmMaterias


    Private Sub frmMaterias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'carga la grilla apenas abre la ventana
        llenarGrid()
        'muestra los btn al momento del inicio
        btnMomentoInicial()



    End Sub

    Enum Action_type
        Insert
        Update
    End Enum

    Public action As Action_type

    Friend Sub llenarGrid(Optional ByVal lst As List(Of Alumno) = Nothing)
        Dim oAlumnoService As New AlumnoService
        dgv_materias.Rows.Clear()

        If IsNothing(lst) Then
            lst = oAlumnoService.listarAlumnos()
        End If

        'Asignamos a la propiedad SelectionMode el valor FullRowSelect para que 
        'al hacer click sobre la grilla se resalte toda la fila completa. Esto puede tmb hacerse en modo diseño.
        dgv_materias.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_materias.Rows.Clear()
        For Each oAlumno In lst

            With oAlumno
                'cargar filas del datagridview a partir de un array de strings
                dgv_materias.Rows.Add(New String() { .legajo.ToString, .apellido.ToString, .nombre.ToString, .documento.ToString, .telefono.ToString})
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
        txt_busqueda_materia.Clear()
        txt_cod_materia.Clear()
        txt_nombre.Clear()
        txt_descripcion.Clear()


    End Sub


    Private Function crearMateria()
        'funcion que crea un alumno a partir de los campos del formulario
        Dim mat As New Materia

        mat.

        Return al

    End Function



End Class