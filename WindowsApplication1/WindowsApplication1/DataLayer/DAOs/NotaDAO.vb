Public Class NotaDAO
    Public Function getTipoNota() As DataTable
        Dim str As String
        str = "SELECT * FROM TipoNota"
        Return BDHelper.getDBHelper.ConsultaSQL(str)
    End Function

    Public Function getTrimestres() As DataTable
        Dim str As String
        str = "SELECT * FROM Trimestre"
        Return BDHelper.getDBHelper.ConsultaSQL(str)
    End Function

    Public Function insertarNotas(tabla As DataTable, tnota As Char, trim As Integer, fecha As String, mat As Integer) As Integer
        Dim str As String = ""
        For Each row As DataRow In tabla.Rows
            str += "INSERT INTO Nota VALUES ('"
            str += row.Item("col_Curso").ToString + "'"
            str += ", " + row.Item("col_Legajo").ToString
            str += ", " + mat.ToString
            str += ", '" + fecha + "'"
            str += ", '" + tnota.ToString + "'"
            str += ", " + trim.ToString
            str += ", '" + row.Item("col_Nota").ToString + "')"
            str += " ; "
        Next
        Return BDHelper.getDBHelper.EjecutarSQLTransact(str)

    End Function
End Class