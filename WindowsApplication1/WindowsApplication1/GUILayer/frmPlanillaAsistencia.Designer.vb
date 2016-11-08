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
        Me.lbl_trimestre = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_cursoreal = New System.Windows.Forms.Label()
        Me.cbo_trimestre = New System.Windows.Forms.ComboBox()
        Me.btn_borrar_dia = New System.Windows.Forms.Button()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.btn_consultar = New System.Windows.Forms.Button()
        CType(Me.dgv_asistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_totalizador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_asistencias
        '
        Me.dgv_asistencias.AllowUserToAddRows = False
        Me.dgv_asistencias.AllowUserToDeleteRows = False
        Me.dgv_asistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_asistencias.Location = New System.Drawing.Point(12, 94)
        Me.dgv_asistencias.Name = "dgv_asistencias"
        Me.dgv_asistencias.ReadOnly = True
        Me.dgv_asistencias.RowHeadersVisible = False
        Me.dgv_asistencias.Size = New System.Drawing.Size(897, 313)
        Me.dgv_asistencias.TabIndex = 0
        '
        'dgv_totalizador
        '
        Me.dgv_totalizador.AllowUserToAddRows = False
        Me.dgv_totalizador.AllowUserToDeleteRows = False
        Me.dgv_totalizador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_totalizador.Location = New System.Drawing.Point(915, 94)
        Me.dgv_totalizador.Name = "dgv_totalizador"
        Me.dgv_totalizador.ReadOnly = True
        Me.dgv_totalizador.RowHeadersVisible = False
        Me.dgv_totalizador.Size = New System.Drawing.Size(95, 313)
        Me.dgv_totalizador.TabIndex = 1
        '
        'lbl_curso
        '
        Me.lbl_curso.AutoSize = True
        Me.lbl_curso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_curso.Location = New System.Drawing.Point(19, 21)
        Me.lbl_curso.Name = "lbl_curso"
        Me.lbl_curso.Size = New System.Drawing.Size(55, 20)
        Me.lbl_curso.TabIndex = 2
        Me.lbl_curso.Text = "Curso:"
        '
        'lbl_trimestre
        '
        Me.lbl_trimestre.AutoSize = True
        Me.lbl_trimestre.Location = New System.Drawing.Point(20, 66)
        Me.lbl_trimestre.Name = "lbl_trimestre"
        Me.lbl_trimestre.Size = New System.Drawing.Size(109, 13)
        Me.lbl_trimestre.TabIndex = 4
        Me.lbl_trimestre.Text = "Seleccionar Trimestre"
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
        Me.lbl_cursoreal.Location = New System.Drawing.Point(71, 22)
        Me.lbl_cursoreal.Name = "lbl_cursoreal"
        Me.lbl_cursoreal.Size = New System.Drawing.Size(77, 18)
        Me.lbl_cursoreal.TabIndex = 6
        Me.lbl_cursoreal.Text = "Curso real"
        '
        'cbo_trimestre
        '
        Me.cbo_trimestre.FormattingEnabled = True
        Me.cbo_trimestre.Location = New System.Drawing.Point(135, 62)
        Me.cbo_trimestre.Name = "cbo_trimestre"
        Me.cbo_trimestre.Size = New System.Drawing.Size(121, 21)
        Me.cbo_trimestre.TabIndex = 7
        '
        'btn_borrar_dia
        '
        Me.btn_borrar_dia.Location = New System.Drawing.Point(834, 413)
        Me.btn_borrar_dia.Name = "btn_borrar_dia"
        Me.btn_borrar_dia.Size = New System.Drawing.Size(75, 23)
        Me.btn_borrar_dia.TabIndex = 8
        Me.btn_borrar_dia.Text = "Borrar Dia"
        Me.btn_borrar_dia.UseVisualStyleBackColor = True
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Location = New System.Drawing.Point(935, 413)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cerrar.TabIndex = 9
        Me.btn_cerrar.Text = "Cerrar"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'btn_consultar
        '
        Me.btn_consultar.Location = New System.Drawing.Point(275, 61)
        Me.btn_consultar.Name = "btn_consultar"
        Me.btn_consultar.Size = New System.Drawing.Size(75, 23)
        Me.btn_consultar.TabIndex = 10
        Me.btn_consultar.Text = "Consultar"
        Me.btn_consultar.UseVisualStyleBackColor = True
        '
        'frmPlanillaAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 444)
        Me.Controls.Add(Me.btn_consultar)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_borrar_dia)
        Me.Controls.Add(Me.cbo_trimestre)
        Me.Controls.Add(Me.lbl_cursoreal)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.lbl_trimestre)
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
    Friend WithEvents lbl_trimestre As Label
    Friend WithEvents lbl_titulo As Label
    Friend WithEvents lbl_cursoreal As Label
    Friend WithEvents cbo_trimestre As ComboBox
    Friend WithEvents btn_borrar_dia As Button
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents btn_consultar As Button
End Class
