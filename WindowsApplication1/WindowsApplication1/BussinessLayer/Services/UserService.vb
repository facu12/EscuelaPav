Public Class UserService
    Private oUserDao As UserDAO
    Public Sub New()
        oUserDao = New UserDAO()
    End Sub

    Public Function validarUsuario(ByVal n_user As String, ByVal pass As String) As Boolean
        Return Not IsNothing(oUserDao.getUser(n_user, pass))
    End Function

    Public Function listarUsers() As List(Of User)
        Return oUserDao.getAll
    End Function
End Class
