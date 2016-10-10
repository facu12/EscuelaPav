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
        Me.GroupBox3.Controls.Add(Me.dgvAsistencia)
        Me.GroupBox3.Location = New System.Drawing.Point(335, 9)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(306, 348)
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
        Me.dgvAsistencia.Enabled = False
        Me.dgvAsistencia.Location = New System.Drawing.Point(5, 17)
        Me.dgvAsistencia.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvAsistencia.Name = "dgvAsistencia"
        Me.dgvAsistencia.RowTemplate.Height = 24
        Me.dgvAsistencia.Size = New System.Drawing.Size(296, 326)
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
        'frmAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 409)
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
End Class
