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

    Public Function existeAsistencia(ByVal curso As String, ByVal trimestre As String) As Boolean
        Dim str As String = ""
        str = "SELECT * FROM Asistencia where cod_curso = "
        str += "'" + curso.ToString + "' "
        str += "AND trimestre = " + trimestre.ToString
        Return BDHelper.getDBHelper.ConsultaSQL(str).Rows.Count > 0
    End Function

    Public Function getAsistencias(ByVal curso As String, ByVal trimestre As String) As DataTable
        Dim str As String = ""
        str = "EXECUTE obtenerAsistencias "
        str += "'" + curso.ToString + "'"
        str += ",'" + trimestre.ToString + "'"

        Return BDHelper.getDBHelper.EjecutarProcedure(str)
    End Function
    Public Function getAsistenciaTotal(curso As String, trimestre As String) As DataTable
        Dim str As String
        str = "select SUM(asistencia) as Total from Asistencia a join Alumno b on a.legajo_alu = b.legajo WHERE cod_curso = '" + curso.ToString + "'"
        str += "AND trimestre = " + trimestre.ToString + " "
        str += "GROUP BY b.apellido"
        Return BDHelper.getDBHelper.ConsultaSQL(str)
    End Function

    Public Function actualizarAsistencia(curso As String, trimestre As String, legajo As String, asist As String, fecha As String, justif As String) As Boolean
        Dim str As String
        str = "UPDATE Asistencia set asistencia = " + asist.ToString + ", "
        str += "es_justificada = " + justif.ToString + " "
        str += "WHERE cod_curso = '" + curso.ToString + "' "
        str += "AND legajo_alu = " + legajo.ToString + " "
        str += "AND fecha = '" + fecha.ToString + "' "
        str += "AND trimestre = " + trimestre.ToString
        Return BDHelper.getDBHelper.EjecutarSQL(str) > 0
    End Function

    Public Function borrarDia(curso As String, trimestre As String, dia As String) As Boolean
        Dim str As String = ""
        str = "DELETE asistencia "
        str += "WHERE cod_curso = '" + curso.ToString + "' "
        str += "AND fecha = '" + dia.ToString + "' "
        str += "AND trimestre = " + trimestre.ToString
        Return BDHelper.getDBHelper.EjecutarSQL(str) > 0
    End Function

End Class
