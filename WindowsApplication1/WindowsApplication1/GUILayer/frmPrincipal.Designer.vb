<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.btn_profesores = New System.Windows.Forms.Button()
        Me.btn_alumnos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_profesores
        '
        Me.btn_profesores.Image = Global.WindowsApplication1.My.Resources.Resources.profesor_farsnworth_32
        Me.btn_profesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_profesores.Location = New System.Drawing.Point(364, 60)
        Me.btn_profesores.Name = "btn_profesores"
        Me.btn_profesores.Size = New System.Drawing.Size(163, 67)
        Me.btn_profesores.TabIndex = 1
        Me.btn_profesores.Text = "Profesores"
        Me.btn_profesores.UseVisualStyleBackColor = True
        '
        'btn_alumnos
        '
        Me.btn_alumnos.Image = Global.WindowsApplication1.My.Resources.Resources.alumno
        Me.btn_alumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_alumnos.Location = New System.Drawing.Point(72, 60)
        Me.btn_alumnos.Name = "btn_alumnos"
        Me.btn_alumnos.Size = New System.Drawing.Size(163, 67)
        Me.btn_alumnos.TabIndex = 0
        Me.btn_alumnos.Text = "Alumnos"
        Me.btn_alumnos.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 261)
        Me.Controls.Add(Me.btn_profesores)
        Me.Controls.Add(Me.btn_alumnos)
        Me.Name = "frmPrincipal"
        Me.Text = "frmPrincipal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_alumnos As Button
    Friend WithEvents btn_profesores As Button
End Class
