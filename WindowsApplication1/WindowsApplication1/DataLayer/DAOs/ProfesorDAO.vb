Public Class ProfesorDAO

    'Permite obtener todos los profesores
    Public Function getProfesores() As List(Of Profesor)
        Dim profesores As New List(Of Profesor)
        Dim strSQL = "SELECT * FROM Profesor"

        'Con la tabla devuelta por el Helper creamos N OBJETOS Bug a partir de los datos de la/s filas de la tabla Profesores
        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            profesores.Add(map(row))
        Next

        Return profesores
    End Function

    Public Function add(ByVal oAlumno As Profesor) As Boolean
        Dim comandStr As String
        comandStr = "INSERT INTO dbo.Profesor VALUES("
        comandStr += "'" + oAlumno.legajo.ToString + "', "
        comandStr += "'" + oAlumno.nombre + "', "
        comandStr += "'" + oAlumno.apellido + "')"

        Return (BDHelper.getDBHelper().EjecutarSQL(comandStr) = 1)
    End Function

    Public Function update(ByVal oProfesor As Profesor) As Boolean
        Dim comandStr As String
        comandStr = "UPDATE Profesor SET "
        'comandStr += "legajo='" + oProfesor.legajo + "', "
        comandStr += "nombre='" + oProfesor.nombre + "', "
        comandStr += "apellido='" + oProfesor.apellido + "' "
        comandStr += "WHERE legajo=" + oProfesor.legajo.ToString

        Return (BDHelper.getDBHelper().EjecutarSQL(comandStr) = 1)
    End Function

    Public Function getByFilters(ByVal apellido As String) As List(Of Profesor)
        Dim profeso As New List(Of Profesor)
        Dim strSQL = "SELECT * FROM dbo.Profesor WHERE profesor.apellido LIKE '%" + apellido + "%'"
        strSQL += " ORDER BY profesor.apellido DESC"

        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            profeso.Add(map(row))
        Next

        Return profeso
    End Function

    Private Function map(row As DataRow) As Profesor
        Dim oProfeso As New Profesor
        With oProfeso
            .legajo = Convert.ToInt32(row.Item("legajo").ToString)
            .apellido = row.Item("apellido").ToString
            .nombre = row.Item("nombre").ToString
        End With
        Return oProfeso
    End Function
End Class
