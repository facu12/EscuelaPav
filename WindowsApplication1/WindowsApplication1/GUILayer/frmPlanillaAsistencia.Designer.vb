<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanillaAsistencia
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
        Me.dgv_asistencias = New System.Windows.Forms.DataGridView()
        Me.dgv_totalizador = New System.Windows.Forms.DataGridView()
        Me.lbl_curso = New System.Windows.Forms.Label()
        Me.lbl_dia = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_cursoreal = New System.Windows.Forms.Label()
        Me.dtp_dia = New System.Windows.Forms.DateTimePicker()
        Me.col_legajo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_asistencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_asistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_totalizador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_asistencias
        '
        Me.dgv_asistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_asistencias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_legajo, Me.col_nombre, Me.col_asistencia})
        Me.dgv_asistencias.Location = New System.Drawing.Point(12, 94)
        Me.dgv_asistencias.Name = "dgv_asistencias"
        Me.dgv_asistencias.RowHeadersVisible = False
        Me.dgv_asistencias.Size = New System.Drawing.Size(897, 313)
        Me.dgv_asistencias.TabIndex = 0
        '
        'dgv_totalizador
        '
        Me.dgv_totalizador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_totalizador.Location = New System.Drawing.Point(915, 94)
        Me.dgv_totalizador.Name = "dgv_totalizador"
        Me.dgv_totalizador.Size = New System.Drawing.Size(95, 313)
        Me.dgv_totalizador.TabIndex = 1
        '
        'lbl_curso
        '
        Me.lbl_curso.AutoSize = True
        Me.lbl_curso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_curso.Location = New System.Drawing.Point(22, 41)
        Me.lbl_curso.Name = "lbl_curso"
        Me.lbl_curso.Size = New System.Drawing.Size(55, 20)
        Me.lbl_curso.TabIndex = 2
        Me.lbl_curso.Text = "Curso:"
        '
        'lbl_dia
        '
        Me.lbl_dia.AutoSize = True
        Me.lbl_dia.Location = New System.Drawing.Point(196, 67)
        Me.lbl_dia.Name = "lbl_dia"
        Me.lbl_dia.Size = New System.Drawing.Size(26, 13)
        Me.lbl_dia.TabIndex = 4
        Me.lbl_dia.Text = "Dia:"
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.Location = New System.Drawing.Point(347, 9)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(284, 31)
        Me.lbl_titulo.TabIndex = 5
        Me.lbl_titulo.Text = "Planilla de Asistencias"
        '
        'lbl_cursoreal
        '
        Me.lbl_cursoreal.AutoSize = True
        Me.lbl_cursoreal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cursoreal.Location = New System.Drawing.Point(74, 42)
        Me.lbl_cursoreal.Name = "lbl_cursoreal"
        Me.lbl_cursoreal.Size = New System.Drawing.Size(77, 18)
        Me.lbl_cursoreal.TabIndex = 6
        Me.lbl_cursoreal.Text = "Curso real"
        '
        'dtp_dia
        '
        Me.dtp_dia.Location = New System.Drawing.Point(228, 61)
        Me.dtp_dia.Name = "dtp_dia"
        Me.dtp_dia.Size = New System.Drawing.Size(200, 20)
        Me.dtp_dia.TabIndex = 7
        '
        'col_legajo
        '
        Me.col_legajo.HeaderText = "Legajo"
        Me.col_legajo.Name = "col_legajo"
        Me.col_legajo.ReadOnly = True
        '
        'col_nombre
        '
        Me.col_nombre.HeaderText = "Apellido y Nombre"
        Me.col_nombre.MinimumWidth = 10
        Me.col_nombre.Name = "col_nombre"
        Me.col_nombre.ReadOnly = True
        Me.col_nombre.Width = 250
        '
        'col_asistencia
        '
        Me.col_asistencia.HeaderText = "Asistencia"
        Me.col_asistencia.Name = "col_asistencia"
        Me.col_asistencia.ReadOnly = True
        '
        'frmPlanillaAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 444)
        Me.Controls.Add(Me.dtp_dia)
        Me.Controls.Add(Me.lbl_cursoreal)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.lbl_dia)
        Me.Controls.Add(Me.lbl_curso)
        Me.Controls.Add(Me.dgv_totalizador)
        Me.Controls.Add(Me.dgv_asistencias)
        Me.Name = "frmPlanillaAsistencia"
        Me.Text = "frmPlanillaAsistencia"
        CType(Me.dgv_asistencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_totalizador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_asistencias As DataGridView
    Friend WithEvents dgv_totalizador As DataGridView
    Friend WithEvents lbl_curso As Label
    Friend WithEvents lbl_dia As Label
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_cursoreal As Label
    Friend WithEvents dtp_dia As DateTimePicker
    Friend WithEvents col_legajo As DataGridViewTextBoxColumn
    Friend WithEvents col_nombre As DataGridViewTextBoxColumn
    Friend WithEvents col_asistencia As DataGridViewTextBoxColumn
End Class
