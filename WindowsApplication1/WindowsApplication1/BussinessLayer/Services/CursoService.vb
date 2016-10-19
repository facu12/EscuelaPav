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

    Public Function eliminarCurso(cod As String) As Boolean
        Return oCurso.eliminarCurso(cod)
    End Function

    Public Function getAño() As DataTable
        Return oCurso.getAño
    End Function

    Public Function listarCursosAño(año As Integer) As List(Of Curso)
        Return oCurso.getCursosAño(año)
    End Function

    Public Function limpiarCurso(cod As Integer) As Boolean
        Return oCurso.limpiarCurso(cod)
    End Function
    Public Function asignarAlumnos(tabla As DataTable)
        Return oCurso.asignarAlumnos(tabla)
    End Function

    Public Function listarAlumnosCurso(curso As Integer) As DataTable
        Return oCurso.getAlumnosCurso(curso)
    End Function

    Public Function listarMateriaCurso(curso As Integer) As DataTable
        Return oCurso.getMateriaCurso(curso)
    End Function

End Class
