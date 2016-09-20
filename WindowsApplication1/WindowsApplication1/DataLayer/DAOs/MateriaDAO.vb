Public Class MateriaDAO
    Public Function getMaterias() As List(Of Materia)
        Dim materias As New List(Of Materia)
        Dim strSQL = "SELECT * from Materia"

        'Con la tabla devuelta por el Helper creamos N OBJETOS materia a partir de los datos de la/s filas de la tabla Materia
        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            materias.Add(map(row))
        Next

        Return materias
    End Function

    Public Function add(ByVal oMateria As Materia) As Boolean
        Dim comandStr As String

        comandStr = "INSERT INTO Materia VALUES ("
        comandStr += "'" + oMateria.codMateria.ToString + "',"
        comandStr += "'" + oMateria.nombre + "',"
        comandStr += "'" + oMateria.UnoCero(oMateria.esContraturno) + "'"
        comandStr += ")"


        Return (BDHelper.getDBHelper().EjecutarSQL(comandStr) = 1)
    End Function

    Public Function update(ByVal oMateria As Materia) As Boolean
        Dim comandStr As String
        comandStr = "UPDATE Materia SET "
        ' comandStr += "cod_materia='" + oMateria.codMateria + "',"
        comandStr += "nombre= '" + oMateria.nombre + "', "
        comandStr += "es_Contraturno= " + oMateria.UnoCero(oMateria.esContraturno)
        comandStr += " WHERE cod_materia=" + oMateria.codMateria.ToString

        Return (BDHelper.getDBHelper().EjecutarSQL(comandStr) = 1)
    End Function

    Public Function getByFilters(ByVal materia As String) As List(Of Materia)
        Dim materias As New List(Of Materia)
        Dim strSQL = "SELECT * FROM dbo.Materia WHERE materia.nombre LIKE '%" + materia + "%'"
        strSQL += " ORDER BY materia.nombre  DESC"

        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            materias.Add(map(row))
        Next

        Return materias
    End Function

    Private Function map(row As DataRow) As Materia
        Dim oMateria As New Materia
        With oMateria
            .codMateria = row.Item("cod_materia").ToString
            .nombre = row.Item("nombre").ToString
            .esContraturno = row.Item("es_Contraturno").ToString
        End With
        Return oMateria
    End Function

    Public Function getMateriasxCurso(cod As String) As DataTable
        Dim str As String
        str = "SELECT b.apellido + ', ' + b.nombre as profesor, c.nombre as materia FROM profesorxmateriaxcurso a "
        str += "JOIN Profesor b ON a.legajo = b.legajo "
        str += "JOIN Materia c ON a.cod_materia = c.cod_materia "
        str += "WHERE cod_curso = "
        str += "'" + cod.ToString + "'"
        Return BDHelper.getDBHelper.ConsultaSQL(str)

    End Function

    Public Function addMateriaenCurso(cod As String, profesor As Integer, materia As Integer) As Boolean
        Dim str As String
        str = "INSERT INTO profesorxmateriaxcurso values ('"
        str += cod + "','" + profesor.ToString + "','" + materia.ToString + "') "

        Return (BDHelper.getDBHelper.EjecutarSQL(str) = 1)

    End Function



End Class


