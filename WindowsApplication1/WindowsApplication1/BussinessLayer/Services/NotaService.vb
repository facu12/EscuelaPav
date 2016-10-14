Public Class NotaService
    Private oNotaDAO As New NotaDAO
    Public Function getTipoNota() As DataTable
        Return oNotaDAO.getTipoNota
    End Function

    Public Function getTrimestres() As DataTable
        Dim str As String
        str = "SELECT * FROM Trimestre"
        Return BDHelper.getDBHelper.ConsultaSQL(str)
    End Function

    Public Function insertarNotas(tabla As DataTable, tnota As Char, trim As Integer, fecha As String, mat As Integer) As Integer
        Return oNotaDAO.insertarNotas(tabla, tnota, trim, fecha, mat)
    End Function
End Class