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
        comandStr += "' " + oMateria.descripcion + "'"
        comandStr += ")"


        Return (BDHelper.getDBHelper().EjecutarSQL(comandStr) = 1)
    End Function

    Public Function update(ByVal oMateria As Materia) As Boolean
        Dim comandStr As String
        comandStr = "UPDATE Materia SET "
        ' comandStr += "cod_materia='" + oMateria.codMateria + "',"
        comandStr += "nombre='" + oMateria.nombre + "', "
        comandStr += "descripcion='" + oMateria.descripcion + "' "
        comandStr += "WHERE cod_materia=" + oMateria.codMateria.ToString

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
            .descripcion = row.Item("descripcion").ToString

        End With
        Return oMateria
    End Function


End Class


