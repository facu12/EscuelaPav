﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btn_curso = New System.Windows.Forms.Button()
        Me.btn_materia = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_profesores
        '
        Me.btn_profesores.Image = Global.WindowsApplication1.My.Resources.Resources.profesor_farsnworth_32
        Me.btn_profesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_profesores.Location = New System.Drawing.Point(485, 74)
        Me.btn_profesores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_profesores.Name = "btn_profesores"
        Me.btn_profesores.Size = New System.Drawing.Size(217, 82)
        Me.btn_profesores.TabIndex = 1
        Me.btn_profesores.Text = "Profesores"
        Me.btn_profesores.UseVisualStyleBackColor = True
        '
        'btn_alumnos
        '
        Me.btn_alumnos.Image = Global.WindowsApplication1.My.Resources.Resources.alumno
        Me.btn_alumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_alumnos.Location = New System.Drawing.Point(96, 74)
        Me.btn_alumnos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_alumnos.Name = "btn_alumnos"
        Me.btn_alumnos.Size = New System.Drawing.Size(217, 82)
        Me.btn_alumnos.TabIndex = 0
        Me.btn_alumnos.Text = "Alumnos"
        Me.btn_alumnos.UseVisualStyleBackColor = True
        '
        'btn_curso
        '
        Me.btn_curso.Image = Global.WindowsApplication1.My.Resources.Resources.profesor_farsnworth_32
        Me.btn_curso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_curso.Location = New System.Drawing.Point(96, 176)
        Me.btn_curso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_curso.Name = "btn_curso"
        Me.btn_curso.Size = New System.Drawing.Size(217, 82)
        Me.btn_curso.TabIndex = 2
        Me.btn_curso.Text = "Cursos"
        Me.btn_curso.UseVisualStyleBackColor = True
        '
        'btn_materia
        '
        Me.btn_materia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_materia.Location = New System.Drawing.Point(485, 176)
        Me.btn_materia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_materia.Name = "btn_materia"
        Me.btn_materia.Size = New System.Drawing.Size(217, 82)
        Me.btn_materia.TabIndex = 3
        Me.btn_materia.Text = "Materias "
        Me.btn_materia.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(485, 288)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 82)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Notas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 433)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_materia)
        Me.Controls.Add(Me.btn_curso)
        Me.Controls.Add(Me.btn_profesores)
        Me.Controls.Add(Me.btn_alumnos)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmPrincipal"
        Me.Text = "frmPrincipal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_alumnos As Button
    Friend WithEvents btn_profesores As Button
    Friend WithEvents btn_curso As Button
    Friend WithEvents btn_materia As Button
    Friend WithEvents Button1 As Button
End Class
