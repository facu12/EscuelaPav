<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCursos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvCursos = New System.Windows.Forms.DataGridView()
        Me.año = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subnivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbProfesor = New System.Windows.Forms.ComboBox()
        Me.cmbMateria = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAgregarMateria = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvMaterias = New System.Windows.Forms.DataGridView()
        Me.col_materia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_Profesor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEliminarCurso = New System.Windows.Forms.Button()
        Me.btnEditarCurso = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNivel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSubnivel = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnAgregarCurso = New System.Windows.Forms.Button()
        Me.btnEliminarMateria = New System.Windows.Forms.Button()
        Me.btnCurso = New System.Windows.Forms.Button()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvCursos)
        Me.GroupBox1.Location = New System.Drawing.Point(403, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(325, 326)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Cursos"
        '
        'dgvCursos
        '
        Me.dgvCursos.AllowUserToAddRows = False
        Me.dgvCursos.AllowUserToDeleteRows = False
        Me.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.año, Me.nivel, Me.subnivel})
        Me.dgvCursos.Location = New System.Drawing.Point(5, 18)
        Me.dgvCursos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvCursos.Name = "dgvCursos"
        Me.dgvCursos.ReadOnly = True
        Me.dgvCursos.RowHeadersVisible = False
        Me.dgvCursos.RowTemplate.Height = 24
        Me.dgvCursos.Size = New System.Drawing.Size(320, 303)
        Me.dgvCursos.TabIndex = 0
        '
        'año
        '
        Me.año.HeaderText = "Año"
        Me.año.Name = "año"
        Me.año.ReadOnly = True
        '
        'nivel
        '
        Me.nivel.HeaderText = "Nivel"
        Me.nivel.Name = "nivel"
        Me.nivel.ReadOnly = True
        '
        'subnivel
        '
        Me.subnivel.HeaderText = "SubNivel"
        Me.subnivel.Name = "subnivel"
        Me.subnivel.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 22)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Materia:"
        '
        'cmbProfesor
        '
        Me.cmbProfesor.FormattingEnabled = True
        Me.cmbProfesor.Location = New System.Drawing.Point(178, 20)
        Me.cmbProfesor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbProfesor.Name = "cmbProfesor"
        Me.cmbProfesor.Size = New System.Drawing.Size(120, 21)
        Me.cmbProfesor.TabIndex = 10
        Me.cmbProfesor.Text = "Seleccione Profesor..."
        '
        'cmbMateria
        '
        Me.cmbMateria.FormattingEnabled = True
        Me.cmbMateria.Location = New System.Drawing.Point(54, 20)
        Me.cmbMateria.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbMateria.Name = "cmbMateria"
        Me.cmbMateria.Size = New System.Drawing.Size(120, 21)
        Me.cmbMateria.TabIndex = 15
        Me.cmbMateria.Text = "Seleccione Materia..."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAgregarMateria)
        Me.GroupBox2.Controls.Add(Me.cmbMateria)
        Me.GroupBox2.Controls.Add(Me.cmbProfesor)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 62)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(372, 46)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agregar Materias"
        '
        'btnAgregarMateria
        '
        Me.btnAgregarMateria.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarMateria.Location = New System.Drawing.Point(311, 20)
        Me.btnAgregarMateria.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAgregarMateria.Name = "btnAgregarMateria"
        Me.btnAgregarMateria.Size = New System.Drawing.Size(56, 19)
        Me.btnAgregarMateria.TabIndex = 7
        Me.btnAgregarMateria.Text = "Agregar"
        Me.btnAgregarMateria.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvMaterias)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 112)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(372, 224)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lista de Materias"
        '
        'dgvMaterias
        '
        Me.dgvMaterias.AllowUserToAddRows = False
        Me.dgvMaterias.AllowUserToDeleteRows = False
        Me.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaterias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_materia, Me.col_Profesor})
        Me.dgvMaterias.Location = New System.Drawing.Point(5, 18)
        Me.dgvMaterias.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvMaterias.Name = "dgvMaterias"
        Me.dgvMaterias.ReadOnly = True
        Me.dgvMaterias.RowHeadersVisible = False
        Me.dgvMaterias.RowTemplate.Height = 24
        Me.dgvMaterias.Size = New System.Drawing.Size(362, 202)
        Me.dgvMaterias.TabIndex = 0
        '
        'col_materia
        '
        Me.col_materia.HeaderText = "Materia"
        Me.col_materia.Name = "col_materia"
        Me.col_materia.ReadOnly = True
        Me.col_materia.Width = 150
        '
        'col_Profesor
        '
        Me.col_Profesor.HeaderText = "Profesor"
        Me.col_Profesor.Name = "col_Profesor"
        Me.col_Profesor.ReadOnly = True
        Me.col_Profesor.Width = 300
        '
        'btnEliminarCurso
        '
        Me.btnEliminarCurso.Location = New System.Drawing.Point(595, 341)
        Me.btnEliminarCurso.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEliminarCurso.Name = "btnEliminarCurso"
        Me.btnEliminarCurso.Size = New System.Drawing.Size(88, 19)
        Me.btnEliminarCurso.TabIndex = 5
        Me.btnEliminarCurso.Text = "Eliminar Curso"
        Me.btnEliminarCurso.UseVisualStyleBackColor = True
        '
        'btnEditarCurso
        '
        Me.btnEditarCurso.Location = New System.Drawing.Point(496, 341)
        Me.btnEditarCurso.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEditarCurso.Name = "btnEditarCurso"
        Me.btnEditarCurso.Size = New System.Drawing.Size(95, 19)
        Me.btnEditarCurso.TabIndex = 8
        Me.btnEditarCurso.Text = "Agregar Materias"
        Me.btnEditarCurso.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Año:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(40, 20)
        Me.txtAño.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAño.MaxLength = 4
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(30, 20)
        Me.txtAño.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nivel:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNivel
        '
        Me.txtNivel.Location = New System.Drawing.Point(140, 20)
        Me.txtNivel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNivel.MaxLength = 1
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(30, 20)
        Me.txtNivel.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SubNivel:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSubnivel
        '
        Me.txtSubnivel.Location = New System.Drawing.Point(255, 20)
        Me.txtSubnivel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSubnivel.MaxLength = 1
        Me.txtSubnivel.Name = "txtSubnivel"
        Me.txtSubnivel.Size = New System.Drawing.Size(30, 20)
        Me.txtSubnivel.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnAgregarCurso)
        Me.GroupBox4.Controls.Add(Me.txtSubnivel)
        Me.GroupBox4.Controls.Add(Me.txtAño)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtNivel)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 11)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(372, 45)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Agregar Curso"
        '
        'btnAgregarCurso
        '
        Me.btnAgregarCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCurso.Location = New System.Drawing.Point(311, 19)
        Me.btnAgregarCurso.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAgregarCurso.Name = "btnAgregarCurso"
        Me.btnAgregarCurso.Size = New System.Drawing.Size(56, 19)
        Me.btnAgregarCurso.TabIndex = 6
        Me.btnAgregarCurso.Text = "Agregar"
        Me.btnAgregarCurso.UseVisualStyleBackColor = True
        '
        'btnEliminarMateria
        '
        Me.btnEliminarMateria.Location = New System.Drawing.Point(289, 340)
        Me.btnEliminarMateria.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEliminarMateria.Name = "btnEliminarMateria"
        Me.btnEliminarMateria.Size = New System.Drawing.Size(94, 19)
        Me.btnEliminarMateria.TabIndex = 10
        Me.btnEliminarMateria.Text = "Eliminar Materia"
        Me.btnEliminarMateria.UseVisualStyleBackColor = True
        '
        'btnCurso
        '
        Me.btnCurso.Location = New System.Drawing.Point(403, 341)
        Me.btnCurso.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCurso.Name = "btnCurso"
        Me.btnCurso.Size = New System.Drawing.Size(89, 19)
        Me.btnCurso.TabIndex = 12
        Me.btnCurso.Text = "Agregar Curso"
        Me.btnCurso.UseVisualStyleBackColor = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Location = New System.Drawing.Point(618, 342)
        Me.btnFinalizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(56, 19)
        Me.btnFinalizar.TabIndex = 7
        Me.btnFinalizar.Text = "Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Location = New System.Drawing.Point(687, 342)
        Me.btn_cerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(49, 19)
        Me.btn_cerrar.TabIndex = 13
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'frmCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 372)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btnCurso)
        Me.Controls.Add(Me.btnEliminarMateria)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnEditarCurso)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.btnEliminarCurso)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmCursos"
        Me.Text = "Cursos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvCursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvCursos As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbProfesor As ComboBox
    Friend WithEvents cmbMateria As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvMaterias As DataGridView
    Friend WithEvents btnEliminarCurso As Button
    Friend WithEvents año As DataGridViewTextBoxColumn
    Friend WithEvents nivel As DataGridViewTextBoxColumn
    Friend WithEvents subnivel As DataGridViewTextBoxColumn
    Friend WithEvents btnEditarCurso As Button
    Friend WithEvents txtSubnivel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNivel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAño As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnAgregarMateria As Button
    Friend WithEvents btnAgregarCurso As Button
    Friend WithEvents btnEliminarMateria As Button
    Friend WithEvents btnCurso As Button
    Friend WithEvents col_materia As DataGridViewTextBoxColumn
    Friend WithEvents col_Profesor As DataGridViewTextBoxColumn
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents btn_cerrar As Button
End Class
