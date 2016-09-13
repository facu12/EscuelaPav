<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaterias
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_materias = New System.Windows.Forms.DataGridView()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txt_busqueda_materia = New System.Windows.Forms.TextBox()
        Me.cmdConsultar = New System.Windows.Forms.Button()
        Me.lbl_profesor = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.lbl_Mensajes = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.txt_cod_materia = New System.Windows.Forms.TextBox()
        Me.lbl_cod_materia = New System.Windows.Forms.Label()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.col_cod_materia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_materias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgv_materias)
        Me.GroupBox1.Controls.Add(Me.btn_buscar)
        Me.GroupBox1.Controls.Add(Me.txt_busqueda_materia)
        Me.GroupBox1.Controls.Add(Me.cmdConsultar)
        Me.GroupBox1.Controls.Add(Me.lbl_profesor)
        Me.GroupBox1.Location = New System.Drawing.Point(451, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 372)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Materias"
        '
        'dgv_materias
        '
        Me.dgv_materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_materias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_cod_materia, Me.col_nombre})
        Me.dgv_materias.Location = New System.Drawing.Point(9, 24)
        Me.dgv_materias.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_materias.Name = "dgv_materias"
        Me.dgv_materias.RowTemplate.Height = 24
        Me.dgv_materias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_materias.Size = New System.Drawing.Size(388, 306)
        Me.dgv_materias.TabIndex = 19
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.Location = New System.Drawing.Point(311, 347)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(85, 23)
        Me.btn_buscar.TabIndex = 26
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'txt_busqueda_materia
        '
        Me.txt_busqueda_materia.Location = New System.Drawing.Point(56, 347)
        Me.txt_busqueda_materia.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_busqueda_materia.Name = "txt_busqueda_materia"
        Me.txt_busqueda_materia.Size = New System.Drawing.Size(241, 20)
        Me.txt_busqueda_materia.TabIndex = 18
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
        Me.lbl_profesor.Location = New System.Drawing.Point(6, 349)
        Me.lbl_profesor.Name = "lbl_profesor"
        Me.lbl_profesor.Size = New System.Drawing.Size(45, 13)
        Me.lbl_profesor.TabIndex = 13
        Me.lbl_profesor.Text = "Materia:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl_descripcion)
        Me.Panel1.Controls.Add(Me.btn_cancelar)
        Me.Panel1.Controls.Add(Me.btn_confirmar)
        Me.Panel1.Controls.Add(Me.btn_salir)
        Me.Panel1.Controls.Add(Me.btn_editar)
        Me.Panel1.Controls.Add(Me.btn_agregar)
        Me.Panel1.Controls.Add(Me.lbl_Mensajes)
        Me.Panel1.Controls.Add(Me.txt_descripcion)
        Me.Panel1.Controls.Add(Me.txt_nombre)
        Me.Panel1.Controls.Add(Me.lbl_nombre)
        Me.Panel1.Controls.Add(Me.txt_cod_materia)
        Me.Panel1.Controls.Add(Me.lbl_cod_materia)
        Me.Panel1.Location = New System.Drawing.Point(4, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(429, 372)
        Me.Panel1.TabIndex = 32
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_cancelar.Image = Global.WindowsApplication1.My.Resources.Resources.cancelar
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(250, 307)
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
        Me.btn_confirmar.Location = New System.Drawing.Point(155, 307)
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
        Me.btn_editar.Location = New System.Drawing.Point(249, 306)
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
        Me.btn_agregar.Location = New System.Drawing.Point(155, 306)
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
        Me.lbl_Mensajes.Location = New System.Drawing.Point(23, 272)
        Me.lbl_Mensajes.Name = "lbl_Mensajes"
        Me.lbl_Mensajes.Size = New System.Drawing.Size(68, 13)
        Me.lbl_Mensajes.TabIndex = 27
        Me.lbl_Mensajes.Text = "[lblMensajes]"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_descripcion.Location = New System.Drawing.Point(90, 65)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(292, 20)
        Me.txt_descripcion.TabIndex = 10
        '
        'txt_nombre
        '
        Me.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nombre.Location = New System.Drawing.Point(90, 38)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(182, 20)
        Me.txt_nombre.TabIndex = 1
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(15, 40)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(45, 13)
        Me.lbl_nombre.TabIndex = 0
        Me.lbl_nombre.Text = "Materia:"
        '
        'txt_cod_materia
        '
        Me.txt_cod_materia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cod_materia.Location = New System.Drawing.Point(90, 11)
        Me.txt_cod_materia.Name = "txt_cod_materia"
        Me.txt_cod_materia.Size = New System.Drawing.Size(91, 20)
        Me.txt_cod_materia.TabIndex = 0
        '
        'lbl_cod_materia
        '
        Me.lbl_cod_materia.AutoSize = True
        Me.lbl_cod_materia.Location = New System.Drawing.Point(15, 13)
        Me.lbl_cod_materia.Name = "lbl_cod_materia"
        Me.lbl_cod_materia.Size = New System.Drawing.Size(43, 13)
        Me.lbl_cod_materia.TabIndex = 0
        Me.lbl_cod_materia.Text = "Codigo:"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(15, 67)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(69, 13)
        Me.lbl_descripcion.TabIndex = 39
        Me.lbl_descripcion.Text = "Descripcion: "
        '
        'col_cod_materia
        '
        Me.col_cod_materia.HeaderText = "Codigo"
        Me.col_cod_materia.Name = "col_cod_materia"
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Nombre"
        Me.col_nombre.Name = "col_nombre"
        '
        'frmMaterias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 385)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmMaterias"
        Me.Text = "Materias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_materias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_materias As DataGridView
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txt_busqueda_materia As TextBox
    Friend WithEvents cmdConsultar As Button
    Friend WithEvents lbl_profesor As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_descripcion As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_confirmar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_editar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents lbl_Mensajes As Label
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents txt_cod_materia As TextBox
    Friend WithEvents lbl_cod_materia As Label
    Friend WithEvents col_cod_materia As DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As DataGridViewTextBoxColumn
End Class
