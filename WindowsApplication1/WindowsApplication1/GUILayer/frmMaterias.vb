Public Class frmMaterias


    Private Sub frmMaterias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'carga la grilla apenas abre la ventana
        llenarGrid()
        'muestra los btn al momento del inicio
        btnMomentoInicial()



    End Sub

    Private Sub btnMomentoInicial()
        'estado iniciales de los textbox


        txt_cod_materia.Enabled = False
        txt_nombre.Enabled = False
        txt_descripcion.Enabled = False

        'estados iniciales de botones
        btn_confirmar.Visible = False
        btn_confirmar.Enabled = False
        btn_cancelar.Visible = False
        btn_cancelar.Enabled = False
        btn_editar.Visible = True
        btn_editar.Enabled = False
        btn_salir.Enabled = True
        btn_agregar.Visible = True
        btn_agregar.Enabled = True


    End Sub

    Enum Action_type
        Insert
        Update
    End Enum

    Public action As Action_type

    Friend Sub llenarGrid(Optional ByVal lst As List(Of Materia) = Nothing)
        Dim oMateriaService As New MateriaService
        dgv_materias.Rows.Clear()

        If IsNothing(lst) Then
            lst = oMateriaService.listarMateria()
        End If

        'Asignamos a la propiedad SelectionMode el valor FullRowSelect para que 
        'al hacer click sobre la grilla se resalte toda la fila completa. Esto puede tmb hacerse en modo diseño.
        dgv_materias.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_materias.Rows.Clear()
        For Each oMateria In lst

            With oMateria
                'cargar filas del datagridview a partir de un array de strings
                dgv_materias.Rows.Add(New String() { .codMateria.ToString, .nombre.ToString, .nombre.ToString, .descripcion.ToString})
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

        With mat
            .codMateria = Convert.ToInt64(txt_cod_materia)
            .nombre = txt_nombre.ToString
            .descripcion = txt_descripcion.ToString

        End With

        Return mat

    End Function



End Class