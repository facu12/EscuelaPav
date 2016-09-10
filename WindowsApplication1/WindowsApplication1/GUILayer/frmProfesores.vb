Imports WindowsApplication1

Public Class frmProfesores

    Private Sub frm_Profesores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


    Friend Sub llenarGrid(Optional ByVal lst As List(Of Profesor) = Nothing)
        Dim oProfesorService As New ProfesorService
        dgv_profesores.Rows.Clear()

        If IsNothing(lst) Then
            lst = oProfesorService.listarProfesor()
        End If

        'Asignamos a la propiedad SelectionMode el valor FullRowSelect para que 
        'al hacer click sobre la grilla se resalte toda la fila completa. Esto puede tmb hacerse en modo diseño.
        dgv_profesores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_profesores.Rows.Clear()
        For Each oProfesor In lst

            With oProfesor
                'cargar filas del datagridview a partir de un array de strings
                dgv_profesores.Rows.Add(New String() { .legajo.ToString, .apellido.ToString, .nombre.ToString})
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
        txt_Apellido.Clear()
        txt_Nombres.Clear()
        txt_Legajo.Clear()

    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click

        'FALTA VALIDACIONES DE CAMPOS  Y TIPOS 

        If MessageBox.Show("Seguro que desea confirmar?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

            'dimensiono alumno apartir de los txt
            Dim prof As Profesor
            prof = crearProfesor()
            'dimensiono rta segun realiza con exito o no la consulta sql
            Dim rta As Boolean
            'dimensiono el servicio 
            Dim oProfesorService As New ProfesorService

            'verifico si es un nuevo alumno o modifico uno ya creado 
            If action = Action_type.Insert Then
                'tomo el alumno creado por la funcion y se la paso al servicio para crear

                rta = oProfesorService.registrarProfesor(prof)
            Else
                'tomo al alumno creado por la funcion y se lo paso al servicio para actualizar
                rta = oProfesorService.actualizarProfesor(prof)
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

    Private Function crearProfesor()
        Dim prof As New Profesor
        prof.legajo = txt_Legajo.Text
        prof.apellido = txt_Apellido.Text
        prof.nombre = txt_Nombres.Text
        Return prof

    End Function

    Private Sub btnMomentoInicial()

        'estado iniciales de los textbox
        txt_Apellido.Enabled = False
        txt_Legajo.Enabled = False
        txt_Nombres.Enabled = False

        'estados iniciales de botones
        btn_confirmar.Visible = False
        btn_confirmar.Enabled = False
        btn_cancelar.Visible = False
        btn_cancelar.Enabled = False
        btn_editar.Enabled = False
        btn_salir.Enabled = True
        btn_agregar.Enabled = True

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click

        'si cancela se limpian los datos de los txt


        If MessageBox.Show("Seguro que desea cancelar?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            limpiarCampos()
            btnMomentoInicial()
        End If

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        'setea el action tipe en insert
        action = Action_type.Insert

        'limpio campos txt
        limpiarCampos()

        'Habilita los txt para carga de datos 
        txt_Apellido.Enabled = True
        txt_Legajo.Enabled = True
        txt_Nombres.Enabled = True

        'habilito y muestro btn de confirmar y cancelar
        btn_cancelar.Enabled = True
        btn_cancelar.Visible = True
        btn_confirmar.Visible = True
        btn_confirmar.Enabled = True

    End Sub

    Private Sub dgv_listarAlumnos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_profesores.CellContentClick

        'habilito boton editar
        btn_editar.Enabled = True

        'cargo los txt con los datos de la linea seleccionada
        txt_Apellido.Text = dgv_profesores.CurrentRow.Cells.Item("col_apellido").Value
        txt_Legajo.Text = dgv_profesores.CurrentRow.Cells.Item("col_legajo").Value
        txt_Nombres.Text = dgv_profesores.CurrentRow.Cells.Item("col_nombre").Value

    End Sub


    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        'setea la variable action en update
        action = Action_type.Update

        'Habilita los txt para carga de datos excepto el legajo porque es PK 
        txt_Apellido.Enabled = True
        txt_Legajo.Enabled = False
        txt_Nombres.Enabled = True

        'habilito y muestro btn de confirmar y cancelar
        btn_cancelar.Enabled = True
        btn_cancelar.Visible = True
        btn_confirmar.Visible = True
        btn_confirmar.Enabled = True


    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        buscarProfesor(txt_busqueda_profesor.Text)
    End Sub
    Friend Sub buscarProfesor(ByVal apellido As String, Optional ByVal lst As List(Of Profesor) = Nothing)
        'busca un profesor por apellido 
        Dim oProfesorService As New ProfesorService
        dgv_profesores.Rows.Clear()

        If IsNothing(lst) Then
            lst = oProfesorService.listarProfesorConFiltros(apellido)
        End If

        'Asignamos a la propiedad SelectionMode el valor FullRowSelect para que 
        'al hacer click sobre la grilla se resalte toda la fila completa. Esto puede tmb hacerse en modo diseño.
        dgv_profesores.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_profesores.Rows.Clear()
        For Each oProfesor In lst

            With oProfesor
                'cargar filas del datagridview a partir de un array de strings
                dgv_profesores.Rows.Add(New String() { .legajo.ToString, .apellido.ToString, .nombre.ToString})
            End With
        Next
    End Sub
End Class
