Public Class CursoDAO
    Public Function getCursos() As List(Of Curso)
        Dim cursos As New List(Of Curso)
        Dim str As String = "SELECT * FROM Curso order by año_lectivo desc, nivel asc, subnivel asc"

        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(str).Rows
            cursos.Add(map(row))
        Next

        Return cursos
    End Function

    Public Function eliminarCurso(cod As String) As Boolean
        Dim str As String
        str = "DELETE profesorxmateriaxcurso WHERE cod_curso = " + "'" + cod + "'"
        BDHelper.getDBHelper.EjecutarSQL(str)

        str = "DELETE Curso WHERE cod_curso = " + "'" + cod + "'"
        Return BDHelper.getDBHelper.EjecutarSQL(str) = 1
    End Function

    Public Function add(ByVal oCurso As Curso) As Boolean
        Dim str As String
        str = "INSERT INTO Curso VALUES ("
        str += "'" + oCurso.añolectivo.ToString + oCurso.nivel.ToString + oCurso.subnivel.ToString + "',"
        str += "'" + oCurso.añolectivo.ToString + "',"
        str += "'" + oCurso.nivel.ToString + "',"
        str += "'" + oCurso.subnivel.ToString + "')"

        Return (BDHelper.getDBHelper.EjecutarSQL(str) = 1)
    End Function

    Public Function map(row As DataRow) As Curso
        Dim oCurso As New Curso
        With oCurso
            .añolectivo = Convert.ToInt32(row.Item("año_lectivo"))
            .nivel = row.Item("nivel").ToString
            .subnivel = row.Item("subnivel").ToString
        End With
        Return oCurso
    End Function
End Class
