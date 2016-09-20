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
        Me.col_legajo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_busqueda_profesor = New System.Windows.Forms.TextBox()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.lbl_profesor = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_profesores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
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
        Me.Panel1.Location = New System.Drawing.Point(16, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(572, 458)
        Me.Panel1.TabIndex = 30
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_cancelar.Image = Global.WindowsApplication1.My.Resources.Resources.cancelar
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(333, 378)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(100, 66)
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
        Me.btn_confirmar.Location = New System.Drawing.Point(207, 378)
        Me.btn_confirmar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(100, 66)
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
        Me.btn_salir.Location = New System.Drawing.Point(452, 378)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(100, 68)
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
        Me.btn_editar.Location = New System.Drawing.Point(332, 377)
        Me.btn_editar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(100, 68)
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
        Me.btn_agregar.Location = New System.Drawing.Point(207, 377)
        Me.btn_agregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(100, 68)
        Me.btn_agregar.TabIndex = 32
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'lbl_Mensajes
        '
        Me.lbl_Mensajes.AutoSize = True
        Me.lbl_Mensajes.Location = New System.Drawing.Point(31, 335)
        Me.lbl_Mensajes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Mensajes.Name = "lbl_Mensajes"
        Me.lbl_Mensajes.Size = New System.Drawing.Size(90, 17)
        Me.lbl_Mensajes.TabIndex = 27
        Me.lbl_Mensajes.Text = "[lblMensajes]"
        '
        'txt_Nombres
        '
        Me.txt_Nombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Nombres.Location = New System.Drawing.Point(120, 80)
        Me.txt_Nombres.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Nombres.Name = "txt_Nombres"
        Me.txt_Nombres.Size = New System.Drawing.Size(389, 22)
        Me.txt_Nombres.TabIndex = 10
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(31, 80)
        Me.lbl_nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(69, 17)
        Me.lbl_nombre.TabIndex = 9
        Me.lbl_nombre.Text = "Nombres:"
        '
        'txt_Apellido
        '
        Me.txt_Apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Apellido.Location = New System.Drawing.Point(120, 47)
        Me.txt_Apellido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(242, 22)
        Me.txt_Apellido.TabIndex = 1
        '
        'lbl_apellido
        '
        Me.lbl_apellido.AutoSize = True
        Me.lbl_apellido.Location = New System.Drawing.Point(37, 48)
        Me.lbl_apellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_apellido.Name = "lbl_apellido"
        Me.lbl_apellido.Size = New System.Drawing.Size(62, 17)
        Me.lbl_apellido.TabIndex = 0
        Me.lbl_apellido.Text = "Apellido:"
        '
        'txt_Legajo
        '
        Me.txt_Legajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Legajo.Location = New System.Drawing.Point(120, 14)
        Me.txt_Legajo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_Legajo.Name = "txt_Legajo"
        Me.txt_Legajo.Size = New System.Drawing.Size(121, 22)
        Me.txt_Legajo.TabIndex = 0
        '
        'lbl_legajo
        '
        Me.lbl_legajo.AutoSize = True
        Me.lbl_legajo.Location = New System.Drawing.Point(44, 16)
        Me.lbl_legajo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_legajo.Name = "lbl_legajo"
        Me.lbl_legajo.Size = New System.Drawing.Size(55, 17)
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
        Me.GroupBox1.Location = New System.Drawing.Point(612, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(537, 458)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Profesores"
        '
        'dgv_profesores
        '
        Me.dgv_profesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_profesores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_legajo, Me.col_apellido, Me.col_nombre})
        Me.dgv_profesores.Location = New System.Drawing.Point(8, 30)
        Me.dgv_profesores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgv_profesores.Name = "dgv_profesores"
        Me.dgv_profesores.RowHeadersVisible = False
        Me.dgv_profesores.RowTemplate.Height = 24
        Me.dgv_profesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_profesores.Size = New System.Drawing.Size(521, 377)
        Me.dgv_profesores.TabIndex = 19
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
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.Location = New System.Drawing.Point(415, 427)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(113, 28)
        Me.btn_buscar.TabIndex = 26
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'txt_busqueda_profesor
        '
        Me.txt_busqueda_profesor.Location = New System.Drawing.Point(75, 427)
        Me.txt_busqueda_profesor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_busqueda_profesor.Name = "txt_busqueda_profesor"
        Me.txt_busqueda_profesor.Size = New System.Drawing.Size(320, 22)
        Me.txt_busqueda_profesor.TabIndex = 18
        '
        'cmdConsultar
        '
        Me.cmdConsultar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmdConsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConsultar.Location = New System.Drawing.Point(597, 30)
        Me.cmdConsultar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdConsultar.Name = "cmdConsultar"
        Me.cmdConsultar.Size = New System.Drawing.Size(167, 38)
        Me.cmdConsultar.TabIndex = 17
        Me.cmdConsultar.Text = "Consultar"
        Me.cmdConsultar.UseVisualStyleBackColor = False
        '
        'lbl_profesor
        '
        Me.lbl_profesor.AutoSize = True
        Me.lbl_profesor.Location = New System.Drawing.Point(8, 430)
        Me.lbl_profesor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_profesor.Name = "lbl_profesor"
        Me.lbl_profesor.Size = New System.Drawing.Size(66, 17)
        Me.lbl_profesor.TabIndex = 13
        Me.lbl_profesor.Text = "Profesor:"
        '
        'frmProfesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 510)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents col_legajo As DataGridViewTextBoxColumn
    Friend WithEvents col_apellido As DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As DataGridViewTextBoxColumn
End Class
