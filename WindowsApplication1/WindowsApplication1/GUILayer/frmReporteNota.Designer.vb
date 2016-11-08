<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteNota
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.txtSubnivel = New System.Windows.Forms.TextBox()
        Me.txtNivel = New System.Windows.Forms.TextBox()
        Me.txtAño = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rptNotas = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ReporteNotas1 = New WindowsApplication1.ReporteNotas()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Año Lectivo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Curso:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGenerar)
        Me.GroupBox1.Controls.Add(Me.txtSubnivel)
        Me.GroupBox1.Controls.Add(Me.txtNivel)
        Me.GroupBox1.Controls.Add(Me.txtAño)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1190, 82)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar Curso:"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(816, 41)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerar.TabIndex = 6
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'txtSubnivel
        '
        Me.txtSubnivel.Location = New System.Drawing.Point(638, 41)
        Me.txtSubnivel.Name = "txtSubnivel"
        Me.txtSubnivel.Size = New System.Drawing.Size(100, 22)
        Me.txtSubnivel.TabIndex = 5
        '
        'txtNivel
        '
        Me.txtNivel.Location = New System.Drawing.Point(377, 41)
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(100, 22)
        Me.txtNivel.TabIndex = 4
        '
        'txtAño
        '
        Me.txtAño.Location = New System.Drawing.Point(129, 41)
        Me.txtAño.Name = "txtAño"
        Me.txtAño.Size = New System.Drawing.Size(100, 22)
        Me.txtAño.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(571, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Division:"
        '
        'rptNotas
        '
        Me.rptNotas.ActiveViewIndex = -1
        Me.rptNotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rptNotas.Cursor = System.Windows.Forms.Cursors.Default
        Me.rptNotas.DisplayBackgroundEdge = False
        Me.rptNotas.DisplayStatusBar = False
        Me.rptNotas.EnableDrillDown = False
        Me.rptNotas.EnableToolTips = False
        Me.rptNotas.Location = New System.Drawing.Point(13, 110)
        Me.rptNotas.Name = "rptNotas"
        Me.rptNotas.ShowCloseButton = False
        Me.rptNotas.Size = New System.Drawing.Size(1284, 524)
        Me.rptNotas.TabIndex = 3
        '
        'frmReporteNota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 710)
        Me.Controls.Add(Me.rptNotas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmReporteNota"
        Me.Text = "Reporte de Notas Finales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents txtSubnivel As TextBox
    Friend WithEvents txtNivel As TextBox
    Friend WithEvents txtAño As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rptNotas As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ReporteNotas1 As ReporteNotas
End Class
