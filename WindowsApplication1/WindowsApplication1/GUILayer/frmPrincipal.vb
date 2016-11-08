﻿Public Class frmPrincipal
    Private Sub btn_alumnos_Click(sender As Object, e As EventArgs) Handles btn_alumnos.Click
        Form1.ShowDialog()
    End Sub

    Private Sub btn_profesores_Click(sender As Object, e As EventArgs) Handles btn_profesores.Click
        frmProfesores.ShowDialog()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Levanta el formulario para loggeo de usuario
        'Deshabilitado por el momento para seguir probando
        'frmLogin.ShowDialog()
    End Sub

    Private Sub btn_curso_Click(sender As Object, e As EventArgs) Handles btn_curso.Click
        frmCursos.ShowDialog()

    End Sub

    Private Sub btn_materia_Click(sender As Object, e As EventArgs) Handles btn_materia.Click
        frmMaterias.ShowDialog()
    End Sub

    Private Sub btnNotas_Click(sender As Object, e As EventArgs) Handles btnNotas.Click
        frmNotas.ShowDialog()
    End Sub

    Private Sub btnAsistencia_Click(sender As Object, e As EventArgs) Handles btnAsistencia.Click
        frmAsistencia.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmAsignarAlumno.ShowDialog()
    End Sub

    Private Sub btnReporteNotas_Click(sender As Object, e As EventArgs) Handles btnReporteNotas.Click
        frmReporteNota.ShowDialog()
    End Sub

    Private Sub btnReporteAsist_Click(sender As Object, e As EventArgs) Handles btnReporteAsist.Click
        frmReporteAsistencia.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmEstadisticasNotas.ShowDialog()
    End Sub


End Class