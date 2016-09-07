Public Class ProfesorService
    Private oProfesorDAO As ProfesorDAO
    Public Sub New()
        oProfesorDAO = New ProfesorDAO()
    End Sub

    Public Function listarProfesor() As List(Of Profesor)
        Return oProfesorDAO.getProfesores()
    End Function

    Public Function registrarProfesor(ByVal oProfesor As Profesor) As Boolean
        Return oProfesorDAO.add(oProfesor)
    End Function

    Public Function actualizarProfesor(ByVal oProfesor As Profesor) As Boolean
        Return oProfesorDAO.update(oProfesor)
    End Function

    Public Function listarProfesorConFiltros(ByVal apellido As String) As List(Of Profesor)
        Return oProfesorDAO.getByFilters(apellido)
    End Function
End Class
