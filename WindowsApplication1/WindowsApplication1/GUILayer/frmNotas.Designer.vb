<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotas
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
        Me.cmbAño = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvCursos = New System.Windows.Forms.DataGridView()
        Me.col_Año = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Nivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Subnivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbTipoNota = New System.Windows.Forms.ComboBox()
        Me.cmbMateria = New System.Windows.Forms.ComboBox()
        Me.dgvNotas = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.col_Legajo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Curso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbAño
        '
        Me.cmbAño.FormattingEnabled = True
        Me.cmbAño.Location = New System.Drawing.Point(126, 18)
        Me.cmbAño.Name = "cmbAño"
        Me.cmbAño.Size = New System.Drawing.Size(62, 24)
        Me.cmbAño.TabIndex = 0
        Me.cmbAño.Text = "Año.."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbAño)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 55)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(302, 18)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione Año: "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvCursos)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 365)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione Curso"
        '
        'dgvCursos
        '
        Me.dgvCursos.AllowUserToAddRows = False
        Me.dgvCursos.AllowUserToDeleteRows = False
        Me.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_Año, Me.col_Nivel, Me.col_Subnivel})
        Me.dgvCursos.Location = New System.Drawing.Point(7, 22)
        Me.dgvCursos.Name = "dgvCursos"
        Me.dgvCursos.ReadOnly = True
        Me.dgvCursos.RowHeadersVisible = False
        Me.dgvCursos.RowTemplate.Height = 24
        Me.dgvCursos.Size = New System.Drawing.Size(393, 337)
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
        Me.GroupBox3.Controls.Add(Me.cmbTipoNota)
        Me.GroupBox3.Controls.Add(Me.cmbMateria)
        Me.GroupBox3.Controls.Add(Me.dgvNotas)
        Me.GroupBox3.Location = New System.Drawing.Point(446, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(408, 428)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Notas"
        '
        'cmbTipoNota
        '
        Me.cmbTipoNota.Enabled = False
        Me.cmbTipoNota.FormattingEnabled = True
        Me.cmbTipoNota.Location = New System.Drawing.Point(224, 25)
        Me.cmbTipoNota.Name = "cmbTipoNota"
        Me.cmbTipoNota.Size = New System.Drawing.Size(170, 24)
        Me.cmbTipoNota.TabIndex = 2
        '
        'cmbMateria
        '
        Me.cmbMateria.Enabled = False
        Me.cmbMateria.FormattingEnabled = True
        Me.cmbMateria.Location = New System.Drawing.Point(40, 25)
        Me.cmbMateria.Name = "cmbMateria"
        Me.cmbMateria.Size = New System.Drawing.Size(166, 24)
        Me.cmbMateria.TabIndex = 1
        '
        'dgvNotas
        '
        Me.dgvNotas.AccessibleDescription = "sq"
        Me.dgvNotas.AllowUserToAddRows = False
        Me.dgvNotas.AllowUserToDeleteRows = False
        Me.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_Legajo, Me.col_Nombre, Me.col_Curso})
        Me.dgvNotas.Enabled = False
        Me.dgvNotas.Location = New System.Drawing.Point(7, 63)
        Me.dgvNotas.Name = "dgvNotas"
        Me.dgvNotas.RowTemplate.Height = 24
        Me.dgvNotas.Size = New System.Drawing.Size(395, 359)
        Me.dgvNotas.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(772, 450)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'col_Legajo
        '
        Me.col_Legajo.HeaderText = "Legajo"
        Me.col_Legajo.Name = "col_Legajo"
        '
        'col_Nombre
        '
        Me.col_Nombre.HeaderText = "Alumno"
        Me.col_Nombre.Name = "col_Nombre"
        '
        'col_Curso
        '
        Me.col_Curso.HeaderText = "Curso"
        Me.col_Curso.Name = "col_Curso"
        Me.col_Curso.Visible = False
        '
        'frmNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 485)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmNotas"
        Me.Text = "Notas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvCursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbAño As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvCursos As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbTipoNota As ComboBox
    Friend WithEvents cmbMateria As ComboBox
    Friend WithEvents dgvNotas As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents col_Año As DataGridViewTextBoxColumn
    Friend WithEvents col_Nivel As DataGridViewTextBoxColumn
    Friend WithEvents col_Subnivel As DataGridViewTextBoxColumn
    Friend WithEvents col_Legajo As DataGridViewTextBoxColumn
    Friend WithEvents col_Nombre As DataGridViewTextBoxColumn
    Friend WithEvents col_Curso As DataGridViewTextBoxColumn
End Class
