<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfesores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_mail = New System.Windows.Forms.TextBox()
        Me.lbl_mail = New System.Windows.Forms.Label()
        Me.lbl_fecha_nac = New System.Windows.Forms.Label()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.txt_documento = New System.Windows.Forms.TextBox()
        Me.lbl_documento = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.lbl_Mensajes = New System.Windows.Forms.Label()
        Me.txt_Nombres = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_Apellido = New System.Windows.Forms.TextBox()
        Me.lbl_apellido = New System.Windows.Forms.Label()
        Me.txt_Legajo = New System.Windows.Forms.TextBox()
        Me.lbl_legajo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_profesores = New System.Windows.Forms.DataGridView()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_busqueda_profesor = New System.Windows.Forms.TextBox()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.lbl_profesor = New System.Windows.Forms.Label()
        Me.dtp_profesor = New System.Windows.Forms.DateTimePicker()
        Me.txt_ano_ingreso = New System.Windows.Forms.TextBox()
        Me.lbl_an_ingreso = New System.Windows.Forms.Label()
        Me.col_legajo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_ano_ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fecha_nac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_profesores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_ano_ingreso)
        Me.Panel1.Controls.Add(Me.lbl_an_ingreso)
        Me.Panel1.Controls.Add(Me.dtp_profesor)
        Me.Panel1.Controls.Add(Me.txt_mail)
        Me.Panel1.Controls.Add(Me.lbl_mail)
        Me.Panel1.Controls.Add(Me.lbl_fecha_nac)
        Me.Panel1.Controls.Add(Me.txt_telefono)
        Me.Panel1.Controls.Add(Me.lbl_telefono)
        Me.Panel1.Controls.Add(Me.txt_documento)
        Me.Panel1.Controls.Add(Me.lbl_documento)
        Me.Panel1.Controls.Add(Me.btn_cancelar)
        Me.Panel1.Controls.Add(Me.btn_confirmar)
        Me.Panel1.Controls.Add(Me.btn_salir)
        Me.Panel1.Controls.Add(Me.btn_editar)
        Me.Panel1.Controls.Add(Me.btn_agregar)
        Me.Panel1.Controls.Add(Me.lbl_Mensajes)
        Me.Panel1.Controls.Add(Me.txt_Nombres)
        Me.Panel1.Controls.Add(Me.lbl_nombre)
        Me.Panel1.Controls.Add(Me.txt_Apellido)
        Me.Panel1.Controls.Add(Me.lbl_apellido)
        Me.Panel1.Controls.Add(Me.txt_Legajo)
        Me.Panel1.Controls.Add(Me.lbl_legajo)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(457, 446)
        Me.Panel1.TabIndex = 30
        '
        'txt_mail
        '
        Me.txt_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mail.Location = New System.Drawing.Point(90, 151)
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(182, 20)
        Me.txt_mail.TabIndex = 49
        '
        'lbl_mail
        '
        Me.lbl_mail.AutoSize = True
        Me.lbl_mail.Location = New System.Drawing.Point(21, 153)
        Me.lbl_mail.Name = "lbl_mail"
        Me.lbl_mail.Size = New System.Drawing.Size(35, 13)
        Me.lbl_mail.TabIndex = 48
        Me.lbl_mail.Text = "Email:"
        '
        'lbl_fecha_nac
        '
        Me.lbl_fecha_nac.AutoSize = True
        Me.lbl_fecha_nac.Location = New System.Drawing.Point(21, 212)
        Me.lbl_fecha_nac.Name = "lbl_fecha_nac"
        Me.lbl_fecha_nac.Size = New System.Drawing.Size(111, 13)
        Me.lbl_fecha_nac.TabIndex = 47
        Me.lbl_fecha_nac.Text = "Fecha de Nacimiento:"
        '
        'txt_telefono
        '
        Me.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_telefono.Location = New System.Drawing.Point(90, 121)
        Me.txt_telefono.MaxLength = 10
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(121, 20)
        Me.txt_telefono.TabIndex = 46
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(21, 121)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(52, 13)
        Me.lbl_telefono.TabIndex = 45
        Me.lbl_telefono.Text = "Telefono:"
        '
        'txt_documento
        '
        Me.txt_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_documento.Location = New System.Drawing.Point(90, 91)
        Me.txt_documento.MaxLength = 8
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.Size = New System.Drawing.Size(121, 20)
        Me.txt_documento.TabIndex = 44
        '
        'lbl_documento
        '
        Me.lbl_documento.AutoSize = True
        Me.lbl_documento.Location = New System.Drawing.Point(21, 95)
        Me.lbl_documento.Name = "lbl_documento"
        Me.lbl_documento.Size = New System.Drawing.Size(65, 13)
        Me.lbl_documento.TabIndex = 43
        Me.lbl_documento.Text = "Documento:"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_cancelar.Image = Global.WindowsApplication1.My.Resources.Resources.cancelar
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(274, 368)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 54)
        Me.btn_cancelar.TabIndex = 38
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_confirmar
        '
        Me.btn_confirmar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_confirmar.Image = Global.WindowsApplication1.My.Resources.Resources.Confirmar
        Me.btn_confirmar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_confirmar.Location = New System.Drawing.Point(179, 368)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(75, 54)
        Me.btn_confirmar.TabIndex = 37
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_confirmar.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_salir.Image = Global.WindowsApplication1.My.Resources.Resources.salir
        Me.btn_salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_salir.Location = New System.Drawing.Point(363, 368)
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
        Me.btn_editar.Location = New System.Drawing.Point(273, 367)
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
        Me.btn_agregar.Location = New System.Drawing.Point(179, 367)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 55)
        Me.btn_agregar.TabIndex = 32
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'lbl_Mensajes
        '
        Me.lbl_Mensajes.AutoSize = True
        Me.lbl_Mensajes.Location = New System.Drawing.Point(18, 403)
        Me.lbl_Mensajes.Name = "lbl_Mensajes"
        Me.lbl_Mensajes.Size = New System.Drawing.Size(68, 13)
        Me.lbl_Mensajes.TabIndex = 27
        Me.lbl_Mensajes.Text = "[lblMensajes]"
        '
        'txt_Nombres
        '
        Me.txt_Nombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Nombres.Location = New System.Drawing.Point(90, 65)
        Me.txt_Nombres.Name = "txt_Nombres"
        Me.txt_Nombres.Size = New System.Drawing.Size(292, 20)
        Me.txt_Nombres.TabIndex = 10
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(23, 65)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(52, 13)
        Me.lbl_nombre.TabIndex = 9
        Me.lbl_nombre.Text = "Nombres:"
        '
        'txt_Apellido
        '
        Me.txt_Apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Apellido.Location = New System.Drawing.Point(90, 38)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(182, 20)
        Me.txt_Apellido.TabIndex = 1
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(21, 38)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(47, 13)
        Me.lbl_apellido.TabIndex = 0
        Me.lbl_apellido.Text = "Apellido:"
        '
        'txt_Legajo
        '
        Me.txt_Legajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Legajo.Location = New System.Drawing.Point(90, 11)
        Me.txt_Legajo.Name = "txt_Legajo"
        Me.txt_Legajo.Size = New System.Drawing.Size(91, 20)
        Me.txt_Legajo.TabIndex = 0
        '
        'lbl_legajo
        '
        Me.lbl_legajo.AutoSize = True
        Me.lbl_legajo.Location = New System.Drawing.Point(21, 13)
        Me.lbl_legajo.Name = "lbl_legajo"
        Me.lbl_legajo.Size = New System.Drawing.Size(42, 13)
        Me.lbl_legajo.TabIndex = 0
        Me.lbl_legajo.Text = "Legajo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_profesores)
        Me.GroupBox1.Controls.Add(Me.btn_buscar)
        Me.GroupBox1.Controls.Add(Me.txt_busqueda_profesor)
        Me.GroupBox1.Controls.Add(Me.cmdConsultar)
        Me.GroupBox1.Controls.Add(Me.lbl_profesor)
        Me.GroupBox1.Location = New System.Drawing.Point(485, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 443)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Profesores"
        '
        'dgv_profesores
        '
        Me.dgv_profesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_profesores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_legajo, Me.col_apellido, Me.col_nombre, Me.col_tel, Me.col_dni, Me.col_ano_ingreso, Me.col_mail, Me.col_fecha_nac})
        Me.dgv_profesores.Location = New System.Drawing.Point(6, 24)
        Me.dgv_profesores.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_profesores.Name = "dgv_profesores"
        Me.dgv_profesores.RowHeadersVisible = False
        Me.dgv_profesores.RowTemplate.Height = 24
        Me.dgv_profesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_profesores.Size = New System.Drawing.Size(400, 301)
        Me.dgv_profesores.TabIndex = 19
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.Location = New System.Drawing.Point(321, 403)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(85, 23)
        Me.btn_buscar.TabIndex = 26
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'txt_busqueda_profesor
        '
        Me.txt_busqueda_profesor.Location = New System.Drawing.Point(66, 403)
        Me.txt_busqueda_profesor.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_busqueda_profesor.Name = "txt_busqueda_profesor"
        Me.txt_busqueda_profesor.Size = New System.Drawing.Size(241, 20)
        Me.txt_busqueda_profesor.TabIndex = 18
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
        'lbl_profesor
        '
        Me.lbl_profesor.AutoSize = True
        Me.lbl_profesor.Location = New System.Drawing.Point(16, 405)
        Me.lbl_profesor.Name = "lbl_profesor"
        Me.lbl_profesor.Size = New System.Drawing.Size(49, 13)
        Me.lbl_profesor.TabIndex = 13
        Me.lbl_profesor.Text = "Profesor:"
        '
        'dtp_profesor
        '
        Me.dtp_profesor.Location = New System.Drawing.Point(164, 212)
        Me.dtp_profesor.Name = "dtp_profesor"
        Me.dtp_profesor.Size = New System.Drawing.Size(200, 20)
        Me.dtp_profesor.TabIndex = 51
        '
        'txt_ano_ingreso
        '
        Me.txt_ano_ingreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ano_ingreso.Location = New System.Drawing.Point(90, 186)
        Me.txt_ano_ingreso.MaxLength = 4
        Me.txt_ano_ingreso.Name = "txt_ano_ingreso"
        Me.txt_ano_ingreso.Size = New System.Drawing.Size(182, 20)
        Me.txt_ano_ingreso.TabIndex = 53
        '
        'lbl_an_ingreso
        '
        Me.lbl_an_ingreso.AutoSize = True
        Me.lbl_an_ingreso.Location = New System.Drawing.Point(21, 188)
        Me.lbl_an_ingreso.Name = "lbl_an_ingreso"
        Me.lbl_an_ingreso.Size = New System.Drawing.Size(70, 13)
        Me.lbl_an_ingreso.TabIndex = 52
        Me.lbl_an_ingreso.Text = "Año Ingreso :"
        '
        'col_legajo
        '
        Me.col_legajo.HeaderText = "Legajo"
        Me.col_legajo.Name = "col_legajo"
        '
        'col_apellido
        '
        Me.col_apellido.HeaderText = "Apellido"
        Me.col_apellido.Name = "col_apellido"
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        '
        'col_tel
        '
        Me.col_tel.HeaderText = "Telefono"
        Me.col_tel.Name = "col_tel"
        '
        'col_dni
        '
        Me.col_dni.HeaderText = "documento"
        Me.col_dni.Name = "col_dni"
        Me.col_dni.Visible = False
        '
        'col_ano_ingreso
        '
        Me.col_ano_ingreso.HeaderText = "ano ingreso"
        Me.col_ano_ingreso.Name = "col_ano_ingreso"
        Me.col_ano_ingreso.Visible = False
        '
        'col_mail
        '
        Me.col_mail.HeaderText = "mail"
        Me.col_mail.Name = "col_mail"
        Me.col_mail.Visible = False
        '
        'col_fecha_nac
        '
        Me.col_fecha_nac.HeaderText = "fecha_nac"
        Me.col_fecha_nac.Name = "col_fecha_nac"
        Me.col_fecha_nac.Visible = False
        '
        'frmProfesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 473)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmProfesores"
        Me.Text = "Profesores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_profesores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents lbl_Mensajes As Label
    Friend WithEvents txt_Nombres As TextBox
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents txt_Apellido As TextBox
    Friend WithEvents lbl_apellido As Label
    Friend WithEvents txt_Legajo As TextBox
    Friend WithEvents lbl_legajo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_profesores As DataGridView
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_busqueda_profesor As TextBox
    Friend WithEvents cmdConsultar As Button
    Friend WithEvents lbl_profesor As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents txt_mail As TextBox
    Friend WithEvents lbl_mail As Label
    Friend WithEvents lbl_fecha_nac As Label
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents lbl_telefono As Label
    Friend WithEvents txt_documento As TextBox
    Friend WithEvents lbl_documento As Label
    Friend WithEvents dtp_profesor As DateTimePicker
    Friend WithEvents txt_ano_ingreso As TextBox
    Friend WithEvents lbl_an_ingreso As Label
    Friend WithEvents col_legajo As DataGridViewTextBoxColumn
    Friend WithEvents col_apellido As DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As DataGridViewTextBoxColumn
    Friend WithEvents col_tel As DataGridViewTextBoxColumn
    Friend WithEvents col_dni As DataGridViewTextBoxColumn
    Friend WithEvents col_ano_ingreso As DataGridViewTextBoxColumn
    Friend WithEvents col_mail As DataGridViewTextBoxColumn
    Friend WithEvents col_fecha_nac As DataGridViewTextBoxColumn
End Class
