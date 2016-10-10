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
End Class
