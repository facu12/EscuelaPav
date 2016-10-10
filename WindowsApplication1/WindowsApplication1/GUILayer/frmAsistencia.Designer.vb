<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsistencia
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lbl_seleccion_año = New System.Windows.Forms.Label()
        Me.cmbAño = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvCursos = New System.Windows.Forms.DataGridView()
        Me.col_Año = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Nivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Subnivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvAsistencia = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_trimestre = New System.Windows.Forms.TextBox()
        Me.lbl_trimestre = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.mtb_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.col_legajo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_curso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_asistencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvAsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.lbl_seleccion_año)
        Me.GroupBox1.Controls.Add(Me.cmbAño)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(304, 45)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(226, 15)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(56, 19)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lbl_seleccion_año
        '
        Me.lbl_seleccion_año.AutoSize = True
        Me.lbl_seleccion_año.Location = New System.Drawing.Point(4, 17)
        Me.lbl_seleccion_año.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_seleccion_año.Name = "lbl_seleccion_año"
        Me.lbl_seleccion_año.Size = New System.Drawing.Size(88, 13)
        Me.lbl_seleccion_año.TabIndex = 1
        Me.lbl_seleccion_año.Text = "Seleccione Año: "
        '
        'cmbAño
        '
        Me.cmbAño.FormattingEnabled = True
        Me.cmbAño.Location = New System.Drawing.Point(94, 15)
        Me.cmbAño.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbAño.Name = "cmbAño"
        Me.cmbAño.Size = New System.Drawing.Size(48, 21)
        Me.cmbAño.TabIndex = 0
        Me.cmbAño.Text = "Año.."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvCursos)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 60)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(304, 297)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione Curso"
        '
        'dgvCursos
        '
        Me.dgvCursos.AllowUserToAddRows = False
        Me.dgvCursos.AllowUserToDeleteRows = False
        Me.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_Año, Me.col_Nivel, Me.col_Subnivel})
        Me.dgvCursos.Location = New System.Drawing.Point(5, 18)
        Me.dgvCursos.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvCursos.Name = "dgvCursos"
        Me.dgvCursos.ReadOnly = True
        Me.dgvCursos.RowHeadersVisible = False
        Me.dgvCursos.RowTemplate.Height = 24
        Me.dgvCursos.Size = New System.Drawing.Size(295, 274)
        Me.dgvCursos.TabIndex = 0
        '
        'col_Año
        '
        Me.col_Año.HeaderText = "Año"
        Me.col_Año.Name = "col_Año"
        Me.col_Año.ReadOnly = True
        '
        'col_Nivel
        '
        Me.col_Nivel.HeaderText = "Nivel"
        Me.col_Nivel.Name = "col_Nivel"
        Me.col_Nivel.ReadOnly = True
        '
        'col_Subnivel
        '
        Me.col_Subnivel.HeaderText = "SubNivel"
        Me.col_Subnivel.Name = "col_Subnivel"
        Me.col_Subnivel.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.mtb_fecha)
        Me.GroupBox3.Controls.Add(Me.lbl_fecha)
        Me.GroupBox3.Controls.Add(Me.lbl_trimestre)
        Me.GroupBox3.Controls.Add(Me.txt_trimestre)
        Me.GroupBox3.Controls.Add(Me.dgvAsistencia)
        Me.GroupBox3.Location = New System.Drawing.Point(335, 9)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(329, 348)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Asistencia"
        '
        'dgvAsistencia
        '
        Me.dgvAsistencia.AccessibleDescription = "sq"
        Me.dgvAsistencia.AllowUserToAddRows = False
        Me.dgvAsistencia.AllowUserToDeleteRows = False
        Me.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAsistencia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_legajo, Me.col_nombre, Me.col_curso, Me.col_asistencia})
        Me.dgvAsistencia.Enabled = False
        Me.dgvAsistencia.Location = New System.Drawing.Point(5, 51)
        Me.dgvAsistencia.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvAsistencia.Name = "dgvAsistencia"
        Me.dgvAsistencia.RowTemplate.Height = 24
        Me.dgvAsistencia.Size = New System.Drawing.Size(320, 292)
        Me.dgvAsistencia.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(580, 370)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 19)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_trimestre
        '
        Me.txt_trimestre.Location = New System.Drawing.Point(258, 22)
        Me.txt_trimestre.Name = "txt_trimestre"
        Me.txt_trimestre.Size = New System.Drawing.Size(29, 20)
        Me.txt_trimestre.TabIndex = 2
        '
        'lbl_trimestre
        '
        Me.lbl_trimestre.AutoSize = True
        Me.lbl_trimestre.Location = New System.Drawing.Point(199, 26)
        Me.lbl_trimestre.Name = "lbl_trimestre"
        Me.lbl_trimestre.Size = New System.Drawing.Size(53, 13)
        Me.lbl_trimestre.TabIndex = 3
        Me.lbl_trimestre.Text = "Trimestre:"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(17, 26)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(40, 13)
        Me.lbl_fecha.TabIndex = 4
        Me.lbl_fecha.Text = "Fecha:"
        '
        'mtb_fecha
        '
        Me.mtb_fecha.Location = New System.Drawing.Point(63, 22)
        Me.mtb_fecha.Mask = "##/##/####"
        Me.mtb_fecha.Name = "mtb_fecha"
        Me.mtb_fecha.Size = New System.Drawing.Size(100, 20)
        Me.mtb_fecha.TabIndex = 5
        '
        'col_legajo
        '
        Me.col_legajo.Frozen = True
        Me.col_legajo.HeaderText = "Legajo"
        Me.col_legajo.Name = "col_legajo"
        '
        'col_nombre
        '
        Me.col_nombre.Frozen = True
        Me.col_nombre.HeaderText = "Nombre "
        Me.col_nombre.Name = "col_nombre"
        '
        'col_curso
        '
        Me.col_curso.Frozen = True
        Me.col_curso.HeaderText = ""
        Me.col_curso.Name = "col_curso"
        Me.col_curso.Visible = False
        '
        'col_asistencia
        '
        Me.col_asistencia.Frozen = True
        Me.col_asistencia.HeaderText = "Asistencia"
        Me.col_asistencia.Name = "col_asistencia"
        Me.col_asistencia.Width = 75
        '
        'frmAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 396)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAsistencia"
        Me.Text = "frmAsistencia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvCursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvAsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lbl_seleccion_año As Label
    Friend WithEvents cmbAño As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvCursos As DataGridView
    Friend WithEvents col_Año As DataGridViewTextBoxColumn
    Friend WithEvents col_Nivel As DataGridViewTextBoxColumn
    Friend WithEvents col_Subnivel As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvAsistencia As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents mtb_fecha As MaskedTextBox
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents lbl_trimestre As Label
    Friend WithEvents txt_trimestre As TextBox
    Friend WithEvents col_legajo As DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As DataGridViewTextBoxColumn
    Friend WithEvents col_curso As DataGridViewTextBoxColumn
    Friend WithEvents col_asistencia As DataGridViewTextBoxColumn
End Class
