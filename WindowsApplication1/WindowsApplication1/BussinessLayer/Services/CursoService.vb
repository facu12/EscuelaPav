﻿Public Class CursoService
    Private oCurso As New CursoDAO
    Public Sub New()
        oCurso = New CursoDAO()
    End Sub

    Public Function listarCursos() As List(Of Curso)
        Return oCurso.getCursos
    End Function

    Public Function registrarCurso(curso As Curso) As Boolean
        Return oCurso.add(curso)
    End Function

    Public Function eliminarCurso(cod As String) As Boolean
        Return oCurso.eliminarCurso(cod)
    End Function

    Public Function getAño() As DataTable
        Return oCurso.getAño
    End Function

    Public Function listarCursosAño(año As Integer) As List(Of Curso)
        Return oCurso.getCursosAño(año)
    End Function

End Class
