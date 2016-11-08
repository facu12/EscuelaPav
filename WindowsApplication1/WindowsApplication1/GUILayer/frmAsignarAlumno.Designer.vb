<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAsignarAlumno
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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbAño = New System.Windows.Forms.ComboBox()
        Me.dgvCursos = New System.Windows.Forms.DataGridView()
        Me.col_Año = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Nivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Subnivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvAlumnos = New System.Windows.Forms.DataGridView()
        Me.col_Legajo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscarAlumno = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvCursoAlu = New System.Windows.Forms.DataGridView()
        Me.col1_legajo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col1_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col1_curso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvCursoAlu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Enabled = False
        Me.btnBuscar.Location = New System.Drawing.Point(302, 18)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbAño)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 55)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
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
        'cmbAño
        '
        Me.cmbAño.FormattingEnabled = True
        Me.cmbAño.Location = New System.Drawing.Point(126, 18)
        Me.cmbAño.Name = "cmbAño"
        Me.cmbAño.Size = New System.Drawing.Size(62, 24)
        Me.cmbAño.TabIndex = 0
        Me.cmbAño.Text = "Año.."
        '
        'dgvCursos
        '
        Me.dgvCursos.AllowUserToAddRows = False
        Me.dgvCursos.AllowUserToDeleteRows = False
        Me.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_Año, Me.col_Nivel, Me.col_Subnivel})
        Me.dgvCursos.Enabled = False
        Me.dgvCursos.Location = New System.Drawing.Point(7, 22)
        Me.dgvCursos.Name = "dgvCursos"
        Me.dgvCursos.ReadOnly = True
        Me.dgvCursos.RowHeadersVisible = False
        Me.dgvCursos.RowTemplate.Height = 24
        Me.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvCursos)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 365)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione Curso"
        '
        'dgvAlumnos
        '
        Me.dgvAlumnos.AccessibleDescription = "sq"
        Me.dgvAlumnos.AllowUserToAddRows = False
        Me.dgvAlumnos.AllowUserToDeleteRows = False
        Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_Legajo, Me.col_Nombre})
        Me.dgvAlumnos.Enabled = False
        Me.dgvAlumnos.Location = New System.Drawing.Point(14, 25)
        Me.dgvAlumnos.Name = "dgvAlumnos"
        Me.dgvAlumnos.ReadOnly = True
        Me.dgvAlumnos.RowHeadersVisible = False
        Me.dgvAlumnos.RowTemplate.Height = 24
        Me.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlumnos.Size = New System.Drawing.Size(292, 374)
        Me.dgvAlumnos.TabIndex = 4
        '
        'col_Legajo
        '
        Me.col_Legajo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.col_Legajo.HeaderText = "Legajo"
        Me.col_Legajo.Name = "col_Legajo"
        Me.col_Legajo.ReadOnly = True
        Me.col_Legajo.Width = 80
        '
        'col_Nombre
        '
        Me.col_Nombre.HeaderText = "Alumno"
        Me.col_Nombre.Name = "col_Nombre"
        Me.col_Nombre.ReadOnly = True
        Me.col_Nombre.Width = 200
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtApellido)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.btnBuscarAlumno)
        Me.GroupBox3.Controls.Add(Me.dgvAlumnos)
        Me.GroupBox3.Location = New System.Drawing.Point(425, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(319, 430)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lista de Alumnos"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(79, 405)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(146, 22)
        Me.txtApellido.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apellido"
        '
        'btnBuscarAlumno
        '
        Me.btnBuscarAlumno.Location = New System.Drawing.Point(231, 405)
        Me.btnBuscarAlumno.Name = "btnBuscarAlumno"
        Me.btnBuscarAlumno.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarAlumno.TabIndex = 3
        Me.btnBuscarAlumno.Text = "Buscar"
        Me.btnBuscarAlumno.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvCursoAlu)
        Me.GroupBox4.Location = New System.Drawing.Point(794, 21)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(293, 427)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Alumnos en Curso Actual"
        '
        'dgvCursoAlu
        '
        Me.dgvCursoAlu.AccessibleDescription = "sq"
        Me.dgvCursoAlu.AllowUserToAddRows = False
        Me.dgvCursoAlu.AllowUserToDeleteRows = False
        Me.dgvCursoAlu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCursoAlu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col1_legajo, Me.col1_nombre, Me.col1_curso})
        Me.dgvCursoAlu.Enabled = False
        Me.dgvCursoAlu.Location = New System.Drawing.Point(6, 25)
        Me.dgvCursoAlu.Name = "dgvCursoAlu"
        Me.dgvCursoAlu.ReadOnly = True
        Me.dgvCursoAlu.RowHeadersVisible = False
        Me.dgvCursoAlu.RowTemplate.Height = 24
        Me.dgvCursoAlu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCursoAlu.Size = New System.Drawing.Size(292, 374)
        Me.dgvCursoAlu.TabIndex = 5
        '
        'col1_legajo
        '
        Me.col1_legajo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.col1_legajo.HeaderText = "Legajo"
        Me.col1_legajo.Name = "col1_legajo"
        Me.col1_legajo.ReadOnly = True
        Me.col1_legajo.Width = 80
        '
        'col1_nombre
        '
        Me.col1_nombre.HeaderText = "Alumno"
        Me.col1_nombre.Name = "col1_nombre"
        Me.col1_nombre.ReadOnly = True
        Me.col1_nombre.Width = 200
        '
        'col1_curso
        '
        Me.col1_curso.HeaderText = "Curso"
        Me.col1_curso.Name = "col1_curso"
        Me.col1_curso.ReadOnly = True
        Me.col1_curso.Visible = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Location = New System.Drawing.Point(751, 189)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(37, 41)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = ">"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(750, 236)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(37, 41)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "<"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Location = New System.Drawing.Point(1012, 454)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(75, 23)
        Me.btnFinalizar.TabIndex = 7
        Me.btnFinalizar.Text = "Agregar"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'frmAsignarAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 517)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAsignarAlumno"
        Me.Text = "frmAsignarAlumno"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvCursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvCursoAlu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbAño As ComboBox
    Friend WithEvents dgvCursos As DataGridView
    Friend WithEvents col_Año As DataGridViewTextBoxColumn
    Friend WithEvents col_Nivel As DataGridViewTextBoxColumn
    Friend WithEvents col_Subnivel As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvAlumnos As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscarAlumno As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents col_Legajo As DataGridViewTextBoxColumn
    Friend WithEvents col_Nombre As DataGridViewTextBoxColumn
    Friend WithEvents dgvCursoAlu As DataGridView
    Friend WithEvents col1_legajo As DataGridViewTextBoxColumn
    Friend WithEvents col1_nombre As DataGridViewTextBoxColumn
    Friend WithEvents col1_curso As DataGridViewTextBoxColumn
    Friend WithEvents btnFinalizar As Button
End Class
