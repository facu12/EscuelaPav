Imports WindowsApplication1
Imports System.Text.RegularExpressions

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
                dgv_profesores.Rows.Add(New String() { .legajo.ToString, .apellido.ToString, .nombre.ToString, .tel.ToString, .dni.ToString, .año_ingreso.ToString, .mail.ToString, .fecha_nac.ToString})
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
        txt_busqueda_profesor.Clear()
        txt_documento.Clear()
        txt_mail.Clear()
        txt_telefono.Clear()
        txt_ano_ingreso.Clear()
        dtp_profesor.Value = Date.Now()
        txt_busqueda_profesor.Clear()

    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If camposCompletos(groupbox_prof) = True Then


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
                    limpiarCampos()
                    btnMomentoInicial()
                Else
                    MsgBox("operacion no se realizo con exito", vbOKOnly + MsgBoxStyle.Information, "Aviso")
                    limpiarCampos()
                    btnMomentoInicial()
                End If

            Else


            End If
        End If

    End Sub

    Private Function crearProfesor()
        Dim prof As New Profesor
        With prof

            .legajo = txt_Legajo.Text.ToString
            .apellido = txt_Apellido.Text.ToString
            .nombre = txt_Nombres.Text.ToString
            .dni = txt_documento.Text.ToString
            .fecha_nac = dtp_profesor.Value.ToString
            .mail = txt_mail.Text.ToString
            .año_ingreso = txt_ano_ingreso.Text.ToString
            .tel = txt_telefono.Text.ToString

        End With
        Return prof

    End Function

    Private Sub btnMomentoInicial()

        'estado iniciales de los textbox
        txt_Apellido.Enabled = False
        txt_Legajo.Enabled = False
        txt_Nombres.Enabled = False
        txt_ano_ingreso.Enabled = False
        txt_documento.Enabled = False
        txt_mail.Enabled = False
        txt_telefono.Enabled = False
        dtp_profesor.Enabled = False

        'estados iniciales de botones
        btn_confirmar.Visible = False
        btn_confirmar.Enabled = False
        btn_cancelar.Visible = False
        btn_cancelar.Enabled = False
        btn_editar.Enabled = False
        btn_editar.Visible = True
        btn_salir.Enabled = True
        btn_agregar.Visible = True
        btn_agregar.Enabled = True
        dgv_profesores.Enabled = True
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
        habilitarCampos()

        'habilito y muestro btn de confirmar y cancelar
        btn_cancelar.Enabled = True
        btn_cancelar.Visible = True
        btn_confirmar.Visible = True
        btn_confirmar.Enabled = True
        btn_agregar.Visible = False
        btn_agregar.Enabled = False
        btn_editar.Visible = False
        btn_editar.Enabled = False
        dgv_profesores.Enabled = False
    End Sub

    Private Sub habilitarCampos()
        'Habilita los txt para carga de datos 
        txt_telefono.Enabled = True
        txt_Apellido.Enabled = True
        txt_Nombres.Enabled = True
        txt_documento.Enabled = True
        txt_ano_ingreso.Enabled = True
        txt_mail.Enabled = True
        dtp_profesor.Enabled = True
        txt_Legajo.Enabled = True
    End Sub

    Private Sub dgv_listarProfesores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_profesores.CellContentClick

        'habilito boton editar
        btn_editar.Enabled = True

        'cargo los txt con los datos de la linea seleccionada
        txt_Apellido.Text = dgv_profesores.CurrentRow.Cells.Item("col_apellido").Value
        txt_Legajo.Text = dgv_profesores.CurrentRow.Cells.Item("col_legajo").Value
        txt_Nombres.Text = dgv_profesores.CurrentRow.Cells.Item("col_nombre").Value
        txt_ano_ingreso.Text = dgv_profesores.CurrentRow.Cells.Item("col_ano_ingreso").Value
        txt_documento.Text = dgv_profesores.CurrentRow.Cells.Item("col_dni").Value
        txt_mail.Text = dgv_profesores.CurrentRow.Cells.Item("col_mail").Value
        txt_telefono.Text = dgv_profesores.CurrentRow.Cells.Item("col_tel").Value
        dtp_profesor.Value = Convert.ToDateTime(dgv_profesores.CurrentRow.Cells.Item("col_fecha_nac").Value)

    End Sub


    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        'setea la variable action en update
        action = Action_type.Update

        'Habilita los txt para carga de datos excepto el legajo porque es PK 

        habilitarCampos()
        txt_Legajo.Enabled = False


        'habilito y muestro btn de confirmar y cancelar
        btn_agregar.Visible = False
        btn_agregar.Enabled = False
        btn_editar.Visible = False
        btn_editar.Enabled = False
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
                dgv_profesores.Rows.Add(New String() { .legajo.ToString, .apellido.ToString, .nombre.ToString, .tel.ToString, .dni.ToString, .año_ingreso.ToString, .mail.ToString, .fecha_nac.ToString})
            End With
        Next
    End Sub






    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'A PARTIR DE ACÁ, VALIDACIONES DE CAMPOS
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    'Metodos de validacion de campos numericos unicamente
    Private Sub validarNumericos(sender As Object, e As EventArgs) Handles txt_telefono.Leave, txt_ano_ingreso.Leave, txt_documento.Leave, txt_Legajo.Leave
        If Not Regex.Match(CType(sender, TextBox).Text, "^[0-9]\d*(\.\d+)?$").Success Then
            MessageBox.Show("Por favor ingrese SOLO caracteres Numéricos!")
            CType(sender, TextBox).Clear()
        End If
    End Sub

    'Validacion de campos de texto plano
    Private Sub validarTextoPlano(sender As Object, e As EventArgs) Handles txt_Nombres.Leave, txt_Apellido.Leave
        If Not Regex.Match(CType(sender, TextBox).Text, "^[a-z]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Por favor ingrese SOLO caracteres alfabéticos!")
            CType(sender, TextBox).Clear()
        End If
    End Sub

    'metodo que valida el patron del mail
    Private Sub ValidarEmail()

        'armo un patron de mail
        Dim reEmail As Regex = New Regex("([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\." +
        ")|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})",
        RegexOptions.IgnoreCase _
        Or RegexOptions.CultureInvariant _
        Or RegexOptions.IgnorePatternWhitespace _
        Or RegexOptions.Compiled)

        Dim blnPossibleMatch As Boolean = reEmail.IsMatch(txt_mail.Text)

        If blnPossibleMatch Then

            'chekea si el mail tiene el formato correcto
            If Not txt_mail.Text.Equals(reEmail.Match(txt_mail.Text).ToString) Then
                MessageBox.Show("Direccion de Email Invalida!")
            End If

        Else 'Si no pega con el patron

            MessageBox.Show("Direccion de Email Invalida!")
            txt_mail.Clear()


        End If

    End Sub
    'cuando sale del txt invoca a la validacion del mail
    Private Sub txt_mail_Leave(sender As Object, e As System.EventArgs) Handles txt_mail.Leave
        ValidarEmail() 'Valida el email

    End Sub
    'Validacion de todos los campos completos

    'La funcion recibe el control que es un groupbox ahora
    Public Function camposCompletos(ByVal groupbox As GroupBox) As Boolean
        'Recorre todos y cada uno de los controles contenidos en el contenedor
        For Each Control As Control In groupbox.Controls
            'Si el control que se esta revisando es un textbox
            If TypeOf Control Is TextBox Then
                'Verificamos que tenga informacion
                If Trim(Control.Text) = "" Then
                    'Si no tiene informacion mandamos un MSGBOX con el mensaje apropiado el cual se encuentra en el tag del control
                    MsgBox("No ha introducido datos en " & Control.Tag, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, Application.ProductName)

                    'Regresa un falso indicando que los controles no estan llenados correctamente
                    Return False
                End If
            Else

            End If

        Next
        Return True
    End Function

End Class
