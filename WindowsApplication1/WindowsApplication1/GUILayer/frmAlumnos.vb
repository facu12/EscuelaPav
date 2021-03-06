﻿Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub frm_Alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
    Private Sub btn_nuevo_Click_1(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        'setea el action tipe en insert
        action = Action_type.Insert

        'limpio campos txt
        limpiarCampos()
        'habilito campos txt
        habilitarCampos()


        'habilito y muestro btn de confirmar y cancelar
        btn_nuevo.Visible = False
        btn_cancelar.Enabled = True
        btn_cancelar.Visible = True
        btn_confirmar.Visible = True
        btn_confirmar.Enabled = True
        dgv_listarAlumnos.Enabled = False
    End Sub

    Private Sub btn_editar_Click_1(sender As Object, e As EventArgs) Handles btn_editar.Click

        'setea la variable action en update
        action = Action_type.Update


        'Habilita los txt para carga de datos excepto el legajo porque es PK 
        habilitarCampos()

        'habilito y muestro btn de confirmar y cancelar, ademas oculto nuevo y editar
        btn_cancelar.Enabled = True
        btn_cancelar.Visible = True
        btn_confirmar.Visible = True
        btn_confirmar.Enabled = True
        btn_nuevo.Visible = False
        btn_editar.Visible = False

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click


        'si cancela se limpian los datos de los txt

        If MessageBox.Show("Seguro que desea cancelar?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            limpiarCampos()
            btnMomentoInicial()

        End If


    End Sub

    Private Sub btn_confirmar_Click_1(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        If camposCompletos(groupbox_frm) = True Then


            If MessageBox.Show("Seguro que desea confirmar?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                'Valida todos los campos completos 

                'dimensiono alumno apartir de los txt
                Dim al As Alumno
                al = crearAlumno()
                'dimensiono rta segun realiza con exito o no la consulta sql
                Dim rta As Boolean
                'dimensiono el servicio 
                Dim oAlumnoServicio As New AlumnoService

                'verifico si es un nuevo alumno o modifico uno ya creado 
                If action = Action_type.Insert Then
                    'tomo el alumno creado por la funcion y se la paso al servicio para crear

                    rta = oAlumnoServicio.registrarAlumno(al)
                Else
                    'tomo al alumno creado por la funcion y se lo paso al servicio para actualizar
                    rta = oAlumnoServicio.actualizarAlumno(al)
                End If



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

                'vuelve al estado incial los btn 
                limpiarCampos()
                btnMomentoInicial()

            End If
        End If

    End Sub

    Private Sub btn_salir_Click_1(sender As Object, e As EventArgs) Handles btn_salir.Click

        'Confirmación de salida.
        If MessageBox.Show("Seguro que desea salir?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Me.Close()
        End If
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
                dgv_listarAlumnos.Rows.Add(New String() { .legajo.ToString, .apellido.ToString, .nombre.ToString, .documento.ToString, .telefono.ToString, .email.ToString, .fecha_nac.ToString, .año_ingreso.ToString})
            End With
        Next
    End Sub




    Private Sub limpiarCampos()
        'limpia los campos txt del formulario
        txtApellido.Clear()
        txtLegajo.Clear()
        txtNombres.Clear()
        txt_documento.Clear()
        txt_telefono.Clear()
        txt_mail.Clear()
        txt_ano_ingreso.Clear()
        dtp_alumno.Value = DateTime.Now

    End Sub


    Private Function crearAlumno()
        'funcion que crea un alumno a partir de los campos del formulario
        Dim al As New Alumno

        al.apellido = txtApellido.Text.ToString
        al.legajo = txtLegajo.Text.ToString
        al.nombre = txtNombres.Text.ToString
        al.documento = txt_documento.Text.ToString
        al.telefono = txt_telefono.Text.ToString
        al.email = txt_mail.Text.ToString
        al.año_ingreso = txt_ano_ingreso.Text.ToString
        al.fecha_nac = dtp_alumno.Value.ToString


        Return al

    End Function


    Private Sub btnMomentoInicial()
        'estado iniciales de los textbox
        txt_telefono.Enabled = False
        txtApellido.Enabled = False
        txtLegajo.Enabled = False
        txtNombres.Enabled = False
        txt_documento.Enabled = False
        txt_ano_ingreso.Enabled = False
        txt_telefono.Enabled = False
        dtp_alumno.Enabled = False
        txt_mail.Enabled = False
        'estados iniciales de botones
        btn_confirmar.Visible = False
        btn_confirmar.Enabled = False
        btn_cancelar.Visible = False
        btn_cancelar.Enabled = False
        btn_editar.Visible = True
        btn_editar.Enabled = False
        btn_salir.Enabled = True
        btn_nuevo.Visible = True
        btn_nuevo.Enabled = True
        dgv_listarAlumnos.Enabled = True

    End Sub






    Private Sub habilitarCampos()
        'Habilita los txt para carga de datos 
        txt_telefono.Enabled = True
        txtApellido.Enabled = True
        txtNombres.Enabled = True
        txt_documento.Enabled = True
        txt_ano_ingreso.Enabled = True
        txt_mail.Enabled = True
        dtp_alumno.Enabled = True
        txtLegajo.Enabled = True
    End Sub

    Private Sub dgv_listarAlumnos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_listarAlumnos.CellContentClick

        'Oculto boton editar y nuevo
        btn_editar.Enabled = True

        'Dim al As Alumno

        'cargo los txt con los datos de la linea seleccionada
        txtApellido.Text = dgv_listarAlumnos.CurrentRow.Cells.Item("col_apellido").Value
        txtLegajo.Text = dgv_listarAlumnos.CurrentRow.Cells.Item("col_legajo").Value
        txtNombres.Text = dgv_listarAlumnos.CurrentRow.Cells.Item("col_nombre").Value
        txt_documento.Text = dgv_listarAlumnos.CurrentRow.Cells.Item("col_documento").Value
        txt_telefono.Text = dgv_listarAlumnos.CurrentRow.Cells.Item("col_telefono").Value
        txt_mail.Text = dgv_listarAlumnos.CurrentRow.Cells.Item("col_mail").Value
        txt_ano_ingreso.Text = dgv_listarAlumnos.CurrentRow.Cells.Item("col_ano_ingreso").Value
        dtp_alumno.Value = Convert.ToDateTime(dgv_listarAlumnos.CurrentRow.Cells.Item("col_fecha_nac").Value)





    End Sub





    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        'invoca al metodo buscaralumno para generar la query y llenar la tabla
        buscarAlumno(txt_busqueda_alumnos.Text)

    End Sub

    Friend Sub buscarAlumno(ByVal apellido As String, Optional ByVal lst As List(Of Alumno) = Nothing)
        'busca un alumno por apellido 
        Dim oAlumnoService As New AlumnoService
        dgv_listarAlumnos.Rows.Clear()

        If IsNothing(lst) Then
            lst = oAlumnoService.listarAlumnosConFiltros(apellido)
        End If

        'Asignamos a la propiedad SelectionMode el valor FullRowSelect para que 
        'al hacer click sobre la grilla se resalte toda la fila completa. Esto puede tmb hacerse en modo diseño.
        dgv_listarAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_listarAlumnos.Rows.Clear()
        For Each oAlumno In lst

            With oAlumno
                'cargar filas del datagridview a partir de un array de strings


                dgv_listarAlumnos.Rows.Add(New String() { .legajo.ToString, .apellido.ToString, .nombre.ToString, .documento.ToString, .telefono.ToString, .email.ToString, .fecha_nac.ToString, .año_ingreso.ToString})
            End With
        Next
    End Sub



    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    'A PARTIR DE ACÁ, VALIDACIONES DE CAMPOS
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    'Metodos de validacion de campos numericos unicamente
    Private Sub validarNumericos(sender As Object, e As EventArgs) Handles txt_telefono.Leave, txt_ano_ingreso.Leave, txt_documento.Leave, txtLegajo.Leave
        If Not Regex.Match(CType(sender, TextBox).Text, "^[0-9]\d*(\.\d+)?$").Success Then
            MessageBox.Show("Por favor ingrese solo caracteres Numéricos!")
            CType(sender, TextBox).Clear()
        End If
    End Sub

    'Validacion de campos de texto plano
    Private Sub validarTextoPlano(sender As Object, e As EventArgs) Handles txtApellido.Leave, txtNombres.Leave
        For Each letra As Char In txtApellido.Text
            If Not (Char.IsLetter(letra) Or Char.IsControl(letra) Or Char.IsSeparator(letra)) Then
                MsgBox("Ha ingresado un tipo de caracter no valido. Por favor, vuelva a intentarlo", vbOK, "Error")
            End If
        Next
    End Sub

    Private Function validarTexto(texto As String) As Boolean
        Dim flag As Boolean = True
        For Each letra As Char In texto
            If Not (Char.IsLetter(letra) Or Char.IsControl(letra) Or Char.IsSeparator(letra)) Then
                Return False
            End If
            Return False
        Next
        Return flag
    End Function

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
                    MsgBox("No ha introducido datos en " & Control.Tag, MsgBoxStyle.OkOnly + MsgBoxStyle.Information)

                    'Regresa un falso indicando que los controles no estan llenados correctamente
                    Return False
                End If
            Else

            End If

        Next
        Return True
    End Function

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged

    End Sub
End Class
