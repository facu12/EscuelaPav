<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotaAlumno
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblAlumno = New System.Windows.Forms.Label()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.lblTrimestre = New System.Windows.Forms.Label()
        Me.lblMateria = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblAlumno)
        Me.GroupBox1.Controls.Add(Me.txtNota)
        Me.GroupBox1.Controls.Add(Me.lblTrimestre)
        Me.GroupBox1.Controls.Add(Me.lblMateria)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(313, 178)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nota Alumno"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(92, 28)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(120, 17)
        Me.lblFecha.TabIndex = 9
        Me.lblFecha.Text = "Seleccione Fecha"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Fecha:"
        '
        'lblAlumno
        '
        Me.lblAlumno.AutoSize = True
        Me.lblAlumno.Location = New System.Drawing.Point(92, 56)
        Me.lblAlumno.Name = "lblAlumno"
        Me.lblAlumno.Size = New System.Drawing.Size(128, 17)
        Me.lblAlumno.TabIndex = 4
        Me.lblAlumno.Text = "Seleccione Alumno"
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(92, 149)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(125, 22)
        Me.txtNota.TabIndex = 7
        Me.txtNota.Text = "Seleccione Nota"
        '
        'lblTrimestre
        '
        Me.lblTrimestre.AutoSize = True
        Me.lblTrimestre.Location = New System.Drawing.Point(92, 118)
        Me.lblTrimestre.Name = "lblTrimestre"
        Me.lblTrimestre.Size = New System.Drawing.Size(141, 17)
        Me.lblTrimestre.TabIndex = 6
        Me.lblTrimestre.Text = "Seleccione Trimestre"
        '
        'lblMateria
        '
        Me.lblMateria.AutoSize = True
        Me.lblMateria.Location = New System.Drawing.Point(92, 87)
        Me.lblMateria.Name = "lblMateria"
        Me.lblMateria.Size = New System.Drawing.Size(128, 17)
        Me.lblMateria.TabIndex = 5
        Me.lblMateria.Text = "Seleccione Materia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nota:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Trimestre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Materia:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Alumno:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(250, 205)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(170, 205)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 2
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'frmNotaAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 243)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNotaAlumno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nota Alumno"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNota As TextBox
    Friend WithEvents lblTrimestre As Label
    Friend WithEvents lblMateria As Label
    Friend WithEvents lblAlumno As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label7 As Label
End Class
