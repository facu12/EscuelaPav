﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_listarAlumnos = New System.Windows.Forms.DataGridView()
        Me.col_legajo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fecha_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ano_ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_busqueda_alumnos = New System.Windows.Forms.TextBox()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.lbl_alumnos = New System.Windows.Forms.Label()
        Me.groupbox_frm = New System.Windows.Forms.GroupBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.txt_mail = New System.Windows.Forms.TextBox()
        Me.txt_ano_ingreso = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_alumno = New System.Windows.Forms.DateTimePicker()
        Me.lbl_mail = New System.Windows.Forms.Label()
        Me.lbl_fecha_nac = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.txt_documento = New System.Windows.Forms.TextBox()
        Me.lbl_documento = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.txtLegajo = New System.Windows.Forms.TextBox()
        Me.lbl_legajo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_listarAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupbox_frm.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.Location = New System.Drawing.Point(415, 521)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(113, 28)
        Me.btn_buscar.TabIndex = 26
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_listarAlumnos)
        Me.GroupBox1.Controls.Add(Me.btn_buscar)
        Me.GroupBox1.Controls.Add(Me.txt_busqueda_alumnos)
        Me.GroupBox1.Controls.Add(Me.cmdConsultar)
        Me.GroupBox1.Controls.Add(Me.lbl_alumnos)
        Me.GroupBox1.Location = New System.Drawing.Point(629, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(591, 575)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Alumnos"
        '
        'dgv_listarAlumnos
        '
        Me.dgv_listarAlumnos.AllowUserToAddRows = False
        Me.dgv_listarAlumnos.AllowUserToDeleteRows = False
        Me.dgv_listarAlumnos.AllowUserToResizeColumns = False
        Me.dgv_listarAlumnos.AllowUserToResizeRows = False
        Me.dgv_listarAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_listarAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_legajo, Me.col_apellido, Me.col_nombre, Me.col_documento, Me.col_telefono, Me.col_mail, Me.col_fecha_nac, Me.col_ano_ingreso})
        Me.dgv_listarAlumnos.Location = New System.Drawing.Point(8, 30)
        Me.dgv_listarAlumnos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_listarAlumnos.Name = "dgv_listarAlumnos"
        Me.dgv_listarAlumnos.ReadOnly = True
        Me.dgv_listarAlumnos.RowHeadersVisible = False
        Me.dgv_listarAlumnos.RowTemplate.Height = 24
        Me.dgv_listarAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_listarAlumnos.Size = New System.Drawing.Size(561, 485)
        Me.dgv_listarAlumnos.TabIndex = 19
        '
        'col_legajo
        '
        Me.col_legajo.HeaderText = "Legajo"
        Me.col_legajo.Name = "col_legajo"
        Me.col_legajo.ReadOnly = True
        '
        'col_apellido
        '
        Me.col_apellido.HeaderText = "Apelllido"
        Me.col_apellido.Name = "col_apellido"
        Me.col_apellido.ReadOnly = True
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        '
        'col_documento
        '
        Me.col_documento.HeaderText = "DNI"
        Me.col_documento.Name = "col_documento"
        Me.col_documento.ReadOnly = True
        '
        'col_telefono
        '
        Me.col_telefono.HeaderText = "Telefono"
        Me.col_telefono.Name = "col_telefono"
        Me.col_telefono.ReadOnly = True
        '
        'col_mail
        '
        Me.col_mail.HeaderText = "mail"
        Me.col_mail.Name = "col_mail"
        Me.col_mail.ReadOnly = True
        Me.col_mail.Visible = False
        '
        'col_fecha_nac
        '
        Me.col_fecha_nac.HeaderText = "fecha nac"
        Me.col_fecha_nac.Name = "col_fecha_nac"
        Me.col_fecha_nac.ReadOnly = True
        '
        'col_ano_ingreso
        '
        Me.col_ano_ingreso.HeaderText = "año ingreso"
        Me.col_ano_ingreso.Name = "col_ano_ingreso"
        Me.col_ano_ingreso.ReadOnly = True
        '
        'txt_busqueda_alumnos
        '
        Me.txt_busqueda_alumnos.Location = New System.Drawing.Point(75, 521)
        Me.txt_busqueda_alumnos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_busqueda_alumnos.Name = "txt_busqueda_alumnos"
        Me.txt_busqueda_alumnos.Size = New System.Drawing.Size(320, 22)
        Me.txt_busqueda_alumnos.TabIndex = 18
        '
        'cmdConsultar
        '
        Me.cmdConsultar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConsultar.Location = New System.Drawing.Point(597, 30)
        Me.cmdConsultar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(167, 38)
        Me.cmdConsultar.TabIndex = 17
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = False
        '
        'lbl_alumnos
        '
        Me.lbl_alumnos.AutoSize = True
        Me.lbl_alumnos.Location = New System.Drawing.Point(8, 523)
        Me.lbl_alumnos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_alumnos.Name = "lbl_alumnos"
        Me.lbl_alumnos.Size = New System.Drawing.Size(59, 17)
        Me.lbl_alumnos.TabIndex = 13
        Me.lbl_alumnos.Text = "Alumno:"
        '
        'groupbox_frm
        '
        Me.groupbox_frm.Controls.Add(Me.btn_cancelar)
        Me.groupbox_frm.Controls.Add(Me.btn_nuevo)
        Me.groupbox_frm.Controls.Add(Me.btn_salir)
        Me.groupbox_frm.Controls.Add(Me.btn_editar)
        Me.groupbox_frm.Controls.Add(Me.btn_confirmar)
        Me.groupbox_frm.Controls.Add(Me.txt_mail)
        Me.groupbox_frm.Controls.Add(Me.txt_ano_ingreso)
        Me.groupbox_frm.Controls.Add(Me.Label1)
        Me.groupbox_frm.Controls.Add(Me.dtp_alumno)
        Me.groupbox_frm.Controls.Add(Me.lbl_mail)
        Me.groupbox_frm.Controls.Add(Me.lbl_fecha_nac)
        Me.groupbox_frm.Controls.Add(Me.txt_telefono)
        Me.groupbox_frm.Controls.Add(Me.lbl_telefono)
        Me.groupbox_frm.Controls.Add(Me.txt_documento)
        Me.groupbox_frm.Controls.Add(Me.lbl_documento)
        Me.groupbox_frm.Controls.Add(Me.txtNombres)
        Me.groupbox_frm.Controls.Add(Me.lbl_nombre)
        Me.groupbox_frm.Controls.Add(Me.txtApellido)
        Me.groupbox_frm.Controls.Add(Me.lbl_apellido)
        Me.groupbox_frm.Controls.Add(Me.txtLegajo)
        Me.groupbox_frm.Controls.Add(Me.lbl_legajo)
        Me.groupbox_frm.Location = New System.Drawing.Point(19, 7)
        Me.groupbox_frm.Margin = New System.Windows.Forms.Padding(4)
        Me.groupbox_frm.Name = "groupbox_frm"
        Me.groupbox_frm.Padding = New System.Windows.Forms.Padding(4)
        Me.groupbox_frm.Size = New System.Drawing.Size(591, 575)
        Me.groupbox_frm.TabIndex = 45
        Me.groupbox_frm.TabStop = False
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_cancelar.Image = Global.WindowsApplication1.My.Resources.Resources.cancelar
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(367, 501)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(100, 66)
        Me.btn_cancelar.TabIndex = 66
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = Global.WindowsApplication1.My.Resources.Resources.agregar
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_nuevo.Location = New System.Drawing.Point(255, 501)
        Me.btn_nuevo.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(104, 66)
        Me.btn_nuevo.TabIndex = 65
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salir.Image = Global.WindowsApplication1.My.Resources.Resources.salir
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_salir.Location = New System.Drawing.Point(475, 501)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(100, 66)
        Me.btn_salir.TabIndex = 64
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_editar.Image = Global.WindowsApplication1.My.Resources.Resources.editar
        Me.btn_editar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_editar.Location = New System.Drawing.Point(367, 501)
        Me.btn_editar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(100, 66)
        Me.btn_editar.TabIndex = 63
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_confirmar.Image = Global.WindowsApplication1.My.Resources.Resources.Confirmar
        Me.btn_confirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_confirmar.Location = New System.Drawing.Point(259, 501)
        Me.btn_confirmar.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(100, 66)
        Me.btn_confirmar.TabIndex = 62
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'txt_mail
        '
        Me.txt_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mail.Location = New System.Drawing.Point(160, 233)
        Me.txt_mail.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_mail.MaxLength = 50
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(242, 22)
        Me.txt_mail.TabIndex = 61
        Me.txt_mail.Tag = "Email"
        '
        'txt_ano_ingreso
        '
        Me.txt_ano_ingreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ano_ingreso.Location = New System.Drawing.Point(160, 197)
        Me.txt_ano_ingreso.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ano_ingreso.MaxLength = 4
        Me.txt_ano_ingreso.Name = "txt_ano_ingreso"
        Me.txt_ano_ingreso.Size = New System.Drawing.Size(242, 22)
        Me.txt_ano_ingreso.TabIndex = 60
        Me.txt_ano_ingreso.Tag = "Año Ingreso"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 206)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Año Ingreso: "
        '
        'dtp_alumno
        '
        Me.dtp_alumno.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_alumno.Location = New System.Drawing.Point(160, 272)
        Me.dtp_alumno.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp_alumno.Name = "dtp_alumno"
        Me.dtp_alumno.Size = New System.Drawing.Size(241, 22)
        Me.dtp_alumno.TabIndex = 58
        '
        'lbl_mail
        '
        Me.lbl_mail.AutoSize = True
        Me.lbl_mail.Location = New System.Drawing.Point(8, 242)
        Me.lbl_mail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_mail.Name = "lbl_mail"
        Me.lbl_mail.Size = New System.Drawing.Size(46, 17)
        Me.lbl_mail.TabIndex = 57
        Me.lbl_mail.Text = "Email:"
        '
        'lbl_fecha_nac
        '
        Me.lbl_fecha_nac.AutoSize = True
        Me.lbl_fecha_nac.Location = New System.Drawing.Point(8, 272)
        Me.lbl_fecha_nac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_fecha_nac.Name = "lbl_fecha_nac"
        Me.lbl_fecha_nac.Size = New System.Drawing.Size(145, 17)
        Me.lbl_fecha_nac.TabIndex = 56
        Me.lbl_fecha_nac.Text = "Fecha de Nacimiento:"
        '
        'txt_telefono
        '
        Me.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_telefono.Location = New System.Drawing.Point(160, 165)
        Me.txt_telefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_telefono.MaxLength = 20
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(242, 22)
        Me.txt_telefono.TabIndex = 55
        Me.txt_telefono.Tag = "Telefono"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(8, 165)
        Me.lbl_telefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(68, 17)
        Me.lbl_telefono.TabIndex = 54
        Me.lbl_telefono.Text = "Telefono:"
        '
        'txt_documento
        '
        Me.txt_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_documento.Location = New System.Drawing.Point(160, 133)
        Me.txt_documento.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_documento.MaxLength = 8
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.Size = New System.Drawing.Size(242, 22)
        Me.txt_documento.TabIndex = 53
        Me.txt_documento.Tag = "Documento"
        '
        'lbl_documento
        '
        Me.lbl_documento.AutoSize = True
        Me.lbl_documento.Location = New System.Drawing.Point(8, 133)
        Me.lbl_documento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_documento.Name = "lbl_documento"
        Me.lbl_documento.Size = New System.Drawing.Size(84, 17)
        Me.lbl_documento.TabIndex = 52
        Me.lbl_documento.Text = "Documento:"
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Location = New System.Drawing.Point(160, 101)
        Me.txtNombres.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombres.MaxLength = 50
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(242, 22)
        Me.txtNombres.TabIndex = 50
        Me.txtNombres.Tag = "Nombres"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(8, 101)
        Me.lbl_nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(69, 17)
        Me.lbl_nombre.TabIndex = 49
        Me.lbl_nombre.Text = "Nombres:"
        '
        'txtApellido
        '
        Me.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido.Location = New System.Drawing.Point(160, 65)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellido.MaxLength = 50
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(242, 22)
        Me.txtApellido.TabIndex = 48
        Me.txtApellido.Tag = "Apellido"
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(8, 69)
        Me.lbl_apellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(62, 17)
        Me.lbl_apellido.TabIndex = 46
        Me.lbl_apellido.Text = "Apellido:"
        '
        'txtLegajo
        '
        Me.txtLegajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLegajo.Location = New System.Drawing.Point(160, 33)
        Me.txtLegajo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLegajo.MaxLength = 1000
        Me.txtLegajo.Name = "txtLegajo"
        Me.txtLegajo.Size = New System.Drawing.Size(242, 22)
        Me.txtLegajo.TabIndex = 47
        Me.txtLegajo.Tag = "Legajo"
        '
        'lbl_legajo
        '
        Me.lbl_legajo.AutoSize = True
        Me.lbl_legajo.Location = New System.Drawing.Point(8, 37)
        Me.lbl_legajo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_legajo.Name = "lbl_legajo"
        Me.lbl_legajo.Size = New System.Drawing.Size(55, 17)
        Me.lbl_legajo.TabIndex = 45
        Me.lbl_legajo.Text = "Legajo:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1277, 608)
        Me.Controls.Add(Me.groupbox_frm)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Cargar Alumnos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_listarAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupbox_frm.ResumeLayout(False)
        Me.groupbox_frm.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents lbl_alumnos As System.Windows.Forms.Label
    Friend WithEvents dgv_listarAlumnos As DataGridView
    Friend WithEvents txt_busqueda_alumnos As TextBox
    Friend WithEvents col_legajo As DataGridViewTextBoxColumn
    Friend WithEvents col_apellido As DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As DataGridViewTextBoxColumn
    Friend WithEvents col_documento As DataGridViewTextBoxColumn
    Friend WithEvents col_telefono As DataGridViewTextBoxColumn
    Friend WithEvents col_mail As DataGridViewTextBoxColumn
    Friend WithEvents col_fecha_nac As DataGridViewTextBoxColumn
    Friend WithEvents col_ano_ingreso As DataGridViewTextBoxColumn
    Friend WithEvents groupbox_frm As GroupBox
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents txt_mail As TextBox
    Friend WithEvents txt_ano_ingreso As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_alumno As DateTimePicker
    Friend WithEvents lbl_mail As Label
    Friend WithEvents lbl_fecha_nac As Label
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents lbl_telefono As Label
    Friend WithEvents txt_documento As TextBox
    Friend WithEvents lbl_documento As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lbl_apellido As Label
    Friend WithEvents txtLegajo As TextBox
    Friend WithEvents lbl_legajo As Label
End Class
