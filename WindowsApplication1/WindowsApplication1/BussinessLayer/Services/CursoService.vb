Public Class CursoService
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

End Class
