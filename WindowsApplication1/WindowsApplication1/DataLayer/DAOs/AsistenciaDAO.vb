Public Class AsistenciaDAO

    Public Function getAño() As DataTable
        Dim str As String
        str = "Select distinct año_lectivo as año FROM curso ORDER BY año DESC"
        Return BDHelper.getDBHelper.ConsultaSQL(str)
    End Function

    Public Function insertarAsistencias(tabla As DataTable, trim As Integer, fecha As String) As Integer
        Dim str As String = ""

        For Each row As DataRow In tabla.Rows
            Dim bool As Integer = getJustificada(Convert.ToString(row.Item("col_justificada")))
            str += "INSERT INTO Asistencia VALUES ('"
            str += row.Item("col_curso").ToString + "'"
            str += ", " + row.Item("col_legajo").ToString
            str += ", '" + fecha + "'"
            str += ", " + trim.ToString
            str += ", '" + row.Item("col_asistencia").ToString + "'"
            str += ", '" + bool.ToString + "')"
            str += " ; "
        Next
        Return BDHelper.getDBHelper.EjecutarSQLTransact(str)

    End Function

    Private Function getJustificada(ByVal valor As String) As Integer
        Dim ban As Integer
        If valor = "SI" Then
            ban = 1
        Else
            ban = 0

        End If
        Return ban
    End Function

    Public Function getTrimestres() As DataTable
        Dim str As String
        str = "SELECT * FROM Trimestre"
        Return BDHelper.getDBHelper.ConsultaSQL(str)
    End Function

    Public Function getDatosFecha(fecha As String) As DataTable
        Dim str As String
        str = "Select * from asistencia where fecha=" & fecha
        Return BDHelper.getDBHelper.ConsultaSQL(str)
    End Function

End Class
