Public Class AlumnoService
    Private oAlumnoDao As AlumnoDAO
    Public Sub New()
        oAlumnoDao = New AlumnoDAO()
    End Sub

    Public Function listarAlumnos() As List(Of Alumno)
        Return oAlumnoDao.getAlumnos
    End Function
End Class
