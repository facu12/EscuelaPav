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

    Public Function getAño() As DataTable
        Dim str As String
        str = "Select distinct año_lectivo as año FROM curso ORDER BY año DESC"
        Return BDHelper.getDBHelper.ConsultaSQL(str)
    End Function

    Public Function getCursosAño(año As Integer) As List(Of Curso)
        Dim str As String
        Dim tabla As New List(Of Curso)
        str = "Select año_lectivo, nivel, subnivel FROM curso WHERE año_lectivo = '"
        str += año.ToString + "' ORDER BY año_lectivo desc, nivel asc, subnivel asc"
        For Each row As DataRow In BDHelper.getDBHelper.ConsultaSQL(str).Rows
            tabla.Add(map(row))
        Next
        Return tabla
    End Function

    Public Function getAlumnosCurso(curso As Integer) As DataTable
        Dim str As String
        str = "SELECT b.legajo, b.apellido + ', ' + b.nombre as nombre FROM AlumnosXCurso a JOIN Alumno b ON a.legajo = b.legajo WHERE cod_curso = '"
        str += curso.ToString + "'"

        Return BDHelper.getDBHelper.ConsultaSQL(str)
    End Function

    Public Function getMateriaCurso(curso As Integer) As DataTable
        Dim str As String
        str = "SELECT b.cod_materia, b.nombre FROM ProfesorXMateriaXCurso a JOIN materia b ON a.cod_materia = b.cod_materia WHERE a.cod_curso = '"
        str += curso.ToString + "'"
        Return BDHelper.getDBHelper.ConsultaSQL(str)
    End Function


End Class
