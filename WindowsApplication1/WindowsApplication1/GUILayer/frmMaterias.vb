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
        chkContraturno.Enabled = False

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
                dgv_materias.Rows.Add(New String() { .codMateria.ToString, .nombre.ToString, .SiNo(.esContraturno.ToString)})
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
        chkContraturno.Checked = 0


    End Sub


    Friend Function crearMateria()
        'funcion que crea un materia a partir de los campos del formulario
        Dim mate As New Materia

        mate.codMateria = txt_cod_materia.Text.ToString
        mate.nombre = txt_nombre.Text.ToString
        mate.esContraturno = mate.UnoCero(chkContraturno.Checked)



        Return mate

    End Function

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click



        'setea el action tipe en insert
        action = Action_type.Insert


        'limpio campos txt
        limpiarCampos()

        habilitarCampos()


        'habilito y muestro btn de confirmar y cancelar
        btn_agregar.Enabled = False
        btn_agregar.Visible = False
        btn_cancelar.Enabled = True
        btn_cancelar.Visible = True
        btn_confirmar.Visible = True
        btn_confirmar.Enabled = True


    End Sub

    Private Sub habilitarCampos()
        'habilito la edicion de los campos txt

        txt_cod_materia.Enabled = True
        txt_nombre.Enabled = True
        chkContraturno.Enabled = True

    End Sub


    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click

        'FALTA VALIDACIONES DE CAMPOS  Y TIPOS 

        If MessageBox.Show("Seguro que desea confirmar?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

            'dimensiono alumno apartir de los txt
            Dim mat As Materia
            mat = crearMateria()
            'dimensiono rta segun realiza con exito o no la consulta sql
            Dim rta As Boolean
            'dimensiono el servicio 
            Dim oMateriaService As New MateriaService

            'verifico si es un nuevo alumno o modifico uno ya creado 
            If action = Action_type.Insert Then
                'tomo el alumno creado por la funcion y se la paso al servicio para crear

                rta = oMateriaService.registrarMateria(mat)
            Else
                'tomo al alumno creado por la funcion y se lo paso al servicio para actualizar
                rta = oMateriaService.actualizarMateria(mat)
            End If


            'vuelve al estado incial los btn 
            limpiarCampos()
            btnMomentoInicial()

            'segun si pudo o no realizar la consulta sql, muestro un aviso
            If rta = True Then
                MsgBox("operacion realizada exitosamente", vbOKOnly + MsgBoxStyle.Information, "Aviso")
                llenarGrid()
            Else
                MsgBox("operacion no se realizo con exito", vbOKOnly + MsgBoxStyle.Information, "Aviso")

            End If

        Else

            limpiarCampos()
            btnMomentoInicial()
        End If





    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        'si cancela se limpian los datos de los txt

        If MessageBox.Show("Seguro que desea cancelar?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            limpiarCampos()
            btnMomentoInicial()

        End If
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        'setea la variable action en update
        action = Action_type.Update


        'Habilita los txt para carga de datos excepto el legajo porque es PK 
        habilitarCampos()

        'habilito y muestro btn de confirmar y cancelar, ademas oculto nuevo y editar
        btn_cancelar.Enabled = True
        btn_cancelar.Visible = True
        btn_confirmar.Visible = True
        btn_confirmar.Enabled = True
        btn_agregar.Visible = False
        btn_agregar.Enabled = False
        btn_editar.Visible = False


    End Sub

    Private Sub dgv_materias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_materias.CellContentClick


        ' boton editar y nuevo
        btn_editar.Enabled = True

        'cargo los txt con los datos de la linea seleccionada
        txt_cod_materia.Text = dgv_materias.CurrentRow.Cells.Item("col_cod_materia").Value
        txt_nombre.Text = dgv_materias.CurrentRow.Cells.Item("col_nombre").Value
        chkContraturno.Checked = TrueFlase(dgv_materias.CurrentRow.Cells.Item("col_Contraturno").Value)

    End Sub


    'Funcion creada para reemplazar en el checkbox el Si/No de la grilla por un True/False
    Private Function TrueFlase(x As String) As Boolean
        If (x = "Si") Then
            Return True
        Else Return False
        End If
    End Function

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        If Not txt_busqueda_materia.Text = "" Then
            buscarMateria(txt_busqueda_materia.Text)
        Else
            MsgBox("Introduzca un nombre de una materia!", vbOKOnly)
        End If

    End Sub

    Public Sub buscarMateria(ByVal materia As String, Optional ByVal lst As List(Of Materia) = Nothing)
        Dim oMateriaService As New MateriaService
        dgv_materias.Rows.Clear()

        If IsNothing(lst) Then
            lst = oMateriaService.listarMateriaConFiltro(materia)
        End If

        'Asignamos a la propiedad SelectionMode el valor FullRowSelect para que 
        'al hacer click sobre la grilla se resalte toda la fila completa. Esto puede tmb hacerse en modo diseño.
        dgv_materias.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_materias.Rows.Clear()
        For Each oMateria In lst

            With oMateria
                'cargar filas del datagridview a partir de un array de strings
                dgv_materias.Rows.Add(New String() { .codMateria.ToString, .nombre.ToString, .SiNo(.esContraturno.ToString)})
            End With
        Next
    End Sub
End Class