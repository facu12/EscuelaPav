<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarAsistencia
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
        Me.chk_justif = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_alumno = New System.Windows.Forms.Label()
        Me.txt_asistencia = New System.Windows.Forms.TextBox()
        Me.lbl_trimestre = New System.Windows.Forms.Label()
        Me.lbl_curso = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_justif)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbl_fecha)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lbl_alumno)
        Me.GroupBox1.Controls.Add(Me.txt_asistencia)
        Me.GroupBox1.Controls.Add(Me.lbl_trimestre)
        Me.GroupBox1.Controls.Add(Me.lbl_curso)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(235, 178)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asistencia Alumno"
        '
        'chk_justif
        '
        Me.chk_justif.AutoSize = True
        Me.chk_justif.Location = New System.Drawing.Point(86, 151)
        Me.chk_justif.Name = "chk_justif"
        Me.chk_justif.Size = New System.Drawing.Size(15, 14)
        Me.chk_justif.TabIndex = 11
        Me.chk_justif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.chk_justif.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 152)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Es Justificada:"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Location = New System.Drawing.Point(69, 69)
        Me.lbl_fecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(93, 13)
        Me.lbl_fecha.TabIndex = 9
        Me.lbl_fecha.Text = "Seleccione Fecha"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 69)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Fecha:"
        '
        'lbl_alumno
        '
        Me.lbl_alumno.AutoSize = True
        Me.lbl_alumno.Location = New System.Drawing.Point(69, 43)
        Me.lbl_alumno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_alumno.Name = "lbl_alumno"
        Me.lbl_alumno.Size = New System.Drawing.Size(98, 13)
        Me.lbl_alumno.TabIndex = 4
        Me.lbl_alumno.Text = "Seleccione Alumno"
        '
        'txt_asistencia
        '
        Me.txt_asistencia.Location = New System.Drawing.Point(69, 121)
        Me.txt_asistencia.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_asistencia.Name = "txt_asistencia"
        Me.txt_asistencia.Size = New System.Drawing.Size(95, 20)
        Me.txt_asistencia.TabIndex = 7
        Me.txt_asistencia.Text = "Ingrese Asistencia"
        '
        'lbl_trimestre
        '
        Me.lbl_trimestre.AutoSize = True
        Me.lbl_trimestre.Location = New System.Drawing.Point(69, 95)
        Me.lbl_trimestre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_trimestre.Name = "lbl_trimestre"
        Me.lbl_trimestre.Size = New System.Drawing.Size(106, 13)
        Me.lbl_trimestre.TabIndex = 6
        Me.lbl_trimestre.Text = "Seleccione Trimestre"
        '
        'lbl_curso
        '
        Me.lbl_curso.AutoSize = True
        Me.lbl_curso.Location = New System.Drawing.Point(69, 17)
        Me.lbl_curso.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_curso.Name = "lbl_curso"
        Me.lbl_curso.Size = New System.Drawing.Size(90, 13)
        Me.lbl_curso.TabIndex = 5
        Me.lbl_curso.Text = "Seleccione Curso"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 121)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Asistencia:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 95)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Trimestre:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(4, 17)
        Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(37, 13)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Curso:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(4, 43)
        Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(45, 13)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Alumno:"
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(111, 193)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(56, 19)
        Me.btnEditar.TabIndex = 4
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(171, 193)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(56, 19)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmEditarAsistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 223)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmEditarAsistencia"
        Me.Text = "Editar Asistencia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_alumno As Label
    Friend WithEvents txt_asistencia As TextBox
    Friend WithEvents lbl_trimestre As Label
    Friend WithEvents lbl_curso As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents label1 As Label
    Friend WithEvents label2 As Label
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents chk_justif As CheckBox
    Friend WithEvents Label3 As Label
End Class
