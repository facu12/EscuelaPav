Public Class AlumnoService
    Private oAlumnoDao As AlumnoDAO
    Public Sub New()
        oAlumnoDao = New AlumnoDAO()
    End Sub

    Public Function listarAlumnos() As List(Of Alumno)
        Return oAlumnoDao.getAlumnos
    End Function

    Public Function registrarAlumno(ByVal oAlumno As Alumno) As Boolean
        Return oAlumnoDao.add(oAlumno)
    End Function

    Public Function actualizarAlumno(ByVal oAlumno As Alumno) As Boolean
        Return oAlumnoDao.update(oAlumno)
    End Function

    Public Function listarAlumnosConFiltros(ByVal apellido As String) As List(Of Alumno)
        Return oAlumnoDao.getByFilters(apellido)
    End Function

    Public Function listarAlumnosTotal(curso As Integer) As List(Of Alumno)
        Return oAlumnoDao.getAlumnosTotal(curso)
    End Function

End Class
