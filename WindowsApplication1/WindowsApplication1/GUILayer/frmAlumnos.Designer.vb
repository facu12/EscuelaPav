﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMensajes = New System.Windows.Forms.Label()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLegajo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.lbl_documento = New System.Windows.Forms.Label()
        Me.txt_documento = New System.Windows.Forms.TextBox()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_salir)
        Me.Panel1.Controls.Add(Me.btn_editar)
        Me.Panel1.Controls.Add(Me.btn_agregar)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.lbl_telefono)
        Me.Panel1.Controls.Add(Me.txt_documento)
        Me.Panel1.Controls.Add(Me.lbl_documento)
        Me.Panel1.Controls.Add(Me.lblMensajes)
        Me.Panel1.Controls.Add(Me.txtNombres)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtApellido)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtLegajo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(24, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(429, 372)
        Me.Panel1.TabIndex = 29
        '
        'lblMensajes
        '
        Me.lblMensajes.AutoSize = True
        Me.lblMensajes.Location = New System.Drawing.Point(23, 272)
        Me.lblMensajes.Name = "lblMensajes"
        Me.lblMensajes.Size = New System.Drawing.Size(68, 13)
        Me.lblMensajes.TabIndex = 27
        Me.lblMensajes.Text = "[lblMensajes]"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBuscar.Location = New System.Drawing.Point(311, 347)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(85, 23)
        Me.cmdBuscar.TabIndex = 26
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = False
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Location = New System.Drawing.Point(90, 65)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(292, 20)
        Me.txtNombres.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Nombres:"
        '
        'txtApellido
        '
        Me.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido.Location = New System.Drawing.Point(90, 38)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(182, 20)
        Me.txtApellido.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Apellido:"
        '
        'txtLegajo
        '
        Me.txtLegajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLegajo.Location = New System.Drawing.Point(90, 11)
        Me.txtLegajo.Name = "txtLegajo"
        Me.txtLegajo.Size = New System.Drawing.Size(91, 20)
        Me.txtLegajo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Legajo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.cmdBuscar)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.cmdConsultar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(472, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 372)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Alumnos"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 24)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(391, 306)
        Me.DataGridView1.TabIndex = 19
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(56, 347)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(241, 20)
        Me.TextBox1.TabIndex = 18
        '
        'cmdConsultar
        '
        Me.cmdConsultar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConsultar.Location = New System.Drawing.Point(448, 24)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(125, 31)
        Me.cmdConsultar.TabIndex = 17
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 349)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Alumno:"
        '
        'cmdSalir
        '
        Me.cmdSalir.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(788, 391)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(80, 36)
        Me.cmdSalir.TabIndex = 31
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = False
        '
        'lbl_documento
        '
        Me.lbl_documento.AutoSize = True
        Me.lbl_documento.Location = New System.Drawing.Point(10, 91)
        Me.lbl_documento.Name = "lbl_documento"
        Me.lbl_documento.Size = New System.Drawing.Size(65, 13)
        Me.lbl_documento.TabIndex = 28
        Me.lbl_documento.Text = "Documento:"
        '
        'txt_documento
        '
        Me.txt_documento.Location = New System.Drawing.Point(90, 92)
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.Size = New System.Drawing.Size(121, 20)
        Me.txt_documento.TabIndex = 29
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(23, 117)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(52, 13)
        Me.lbl_telefono.TabIndex = 30
        Me.lbl_telefono.Text = "Telefono:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(90, 119)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(121, 20)
        Me.TextBox2.TabIndex = 31
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salir.Image = Global.WindowsApplication1.My.Resources.Resources.salir
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_salir.Location = New System.Drawing.Point(339, 307)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 55)
        Me.btn_salir.TabIndex = 34
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
        Me.btn_editar.Location = New System.Drawing.Point(120, 307)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(75, 55)
        Me.btn_editar.TabIndex = 33
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregar.Image = Global.WindowsApplication1.My.Resources.Resources.agregar
        Me.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_agregar.Location = New System.Drawing.Point(26, 307)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 55)
        Me.btn_agregar.TabIndex = 32
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 428)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblMensajes As System.Windows.Forms.Label
    Friend WithEvents cmdBuscar As System.Windows.Forms.Button
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLegajo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdConsultar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lbl_documento As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lbl_telefono As Label
    Friend WithEvents txt_documento As TextBox
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_salir As Button
End Class
