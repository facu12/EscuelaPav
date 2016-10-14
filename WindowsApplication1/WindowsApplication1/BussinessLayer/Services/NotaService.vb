Public Class NotaService
    Private oNotaDAO As New NotaDAO
    Public Function getTipoNota() As DataTable
        Return oNotaDAO.getTipoNota
    End Function

    Public Function getTrimestres() As DataTable

        Return oNotaDAO.getTrimestres()
    End Function

    Public Function insertarNotas(tabla As DataTable, tnota As Char, trim As Integer, fecha As String, mat As Integer) As Integer
        Return oNotaDAO.insertarNotas(tabla, tnota, trim, fecha, mat)
    End Function
End Class