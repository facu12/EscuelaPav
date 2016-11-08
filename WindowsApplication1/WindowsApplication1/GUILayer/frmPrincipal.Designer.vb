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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnReporteNotas = New System.Windows.Forms.Button()
        Me.btnReporteAsist = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAsistencia = New System.Windows.Forms.Button()
        Me.btnNotas = New System.Windows.Forms.Button()
        Me.btn_materia = New System.Windows.Forms.Button()
        Me.btn_curso = New System.Windows.Forms.Button()
        Me.btn_profesores = New System.Windows.Forms.Button()
        Me.btn_alumnos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(8, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Gestión de Escuela"
        '
        'Button2
        '
        Me.Button2.Image = Global.WindowsApplication1.My.Resources.Resources.estadistica
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(10, 283)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 67)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Estadisticas "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnReporteNotas
        '
        Me.btnReporteNotas.Image = Global.WindowsApplication1.My.Resources.Resources.reporte
        Me.btnReporteNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporteNotas.Location = New System.Drawing.Point(10, 202)
        Me.btnReporteNotas.Name = "btnReporteNotas"
        Me.btnReporteNotas.Size = New System.Drawing.Size(163, 67)
        Me.btnReporteNotas.TabIndex = 8
        Me.btnReporteNotas.Text = "Reporte Notas"
        Me.btnReporteNotas.UseVisualStyleBackColor = True
        '
        'btnReporteAsist
        '
        Me.btnReporteAsist.Image = Global.WindowsApplication1.My.Resources.Resources.reporte
        Me.btnReporteAsist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporteAsist.Location = New System.Drawing.Point(187, 202)
        Me.btnReporteAsist.Name = "btnReporteAsist"
        Me.btnReporteAsist.Size = New System.Drawing.Size(163, 67)
        Me.btnReporteAsist.TabIndex = 7
        Me.btnReporteAsist.Text = "Reporte Asistencias"
        Me.btnReporteAsist.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReporteAsist.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.aconc
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(364, 202)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 67)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Asignar Alumnos a Curso"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAsistencia
        '
        Me.btnAsistencia.Image = Global.WindowsApplication1.My.Resources.Resources.asistencias
        Me.btnAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsistencia.Location = New System.Drawing.Point(364, 37)
        Me.btnAsistencia.Name = "btnAsistencia"
        Me.btnAsistencia.Size = New System.Drawing.Size(163, 67)
        Me.btnAsistencia.TabIndex = 5
        Me.btnAsistencia.Text = "Registrar Asistencias"
        Me.btnAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAsistencia.UseVisualStyleBackColor = True
        '
        'btnNotas
        '
        Me.btnNotas.Image = Global.WindowsApplication1.My.Resources.Resources.calificaciones
        Me.btnNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotas.Location = New System.Drawing.Point(364, 119)
        Me.btnNotas.Name = "btnNotas"
        Me.btnNotas.Size = New System.Drawing.Size(163, 67)
        Me.btnNotas.TabIndex = 4
        Me.btnNotas.Text = "Registrar Notas"
        Me.btnNotas.UseVisualStyleBackColor = True
        '
        'btn_materia
        '
        Me.btn_materia.Image = Global.WindowsApplication1.My.Resources.Resources.materias
        Me.btn_materia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_materia.Location = New System.Drawing.Point(187, 119)
        Me.btn_materia.Name = "btn_materia"
        Me.btn_materia.Size = New System.Drawing.Size(163, 67)
        Me.btn_materia.TabIndex = 3
        Me.btn_materia.Text = "Crear Materias "
        Me.btn_materia.UseVisualStyleBackColor = True
        '
        'btn_curso
        '
        Me.btn_curso.Image = Global.WindowsApplication1.My.Resources.Resources.curso
        Me.btn_curso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_curso.Location = New System.Drawing.Point(10, 119)
        Me.btn_curso.Name = "btn_curso"
        Me.btn_curso.Size = New System.Drawing.Size(163, 67)
        Me.btn_curso.TabIndex = 2
        Me.btn_curso.Text = "Crear Cursos"
        Me.btn_curso.UseVisualStyleBackColor = True
        '
        'btn_profesores
        '
        Me.btn_profesores.Image = Global.WindowsApplication1.My.Resources.Resources.profesor_farsnworth_32
        Me.btn_profesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_profesores.Location = New System.Drawing.Point(187, 37)
        Me.btn_profesores.Name = "btn_profesores"
        Me.btn_profesores.Size = New System.Drawing.Size(163, 67)
        Me.btn_profesores.TabIndex = 1
        Me.btn_profesores.Text = "Crear Profesores"
        Me.btn_profesores.UseVisualStyleBackColor = True
        '
        'btn_alumnos
        '
        Me.btn_alumnos.Image = Global.WindowsApplication1.My.Resources.Resources.alumno
        Me.btn_alumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_alumnos.Location = New System.Drawing.Point(10, 37)
        Me.btn_alumnos.Name = "btn_alumnos"
        Me.btn_alumnos.Size = New System.Drawing.Size(163, 67)
        Me.btn_alumnos.TabIndex = 0
        Me.btn_alumnos.Text = "Crear Alumnos"
        Me.btn_alumnos.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 360)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnReporteNotas)
        Me.Controls.Add(Me.btnReporteAsist)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAsistencia)
        Me.Controls.Add(Me.btnNotas)
        Me.Controls.Add(Me.btn_materia)
        Me.Controls.Add(Me.btn_curso)
        Me.Controls.Add(Me.btn_profesores)
        Me.Controls.Add(Me.btn_alumnos)
        Me.Name = "frmPrincipal"
        Me.ShowIcon = False
        Me.Text = "Gestion Escuela"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_alumnos As Button
    Friend WithEvents btn_profesores As Button
    Friend WithEvents btn_curso As Button
    Friend WithEvents btn_materia As Button
    Friend WithEvents btnNotas As Button
    Friend WithEvents btnAsistencia As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnReporteAsist As Button
    Friend WithEvents btnReporteNotas As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
End Class
