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

    Public Function getProfesoresCombo() As DataTable
        Dim profesores As New List(Of Profesor)
        Dim strSQL = "select legajo, apellido + ', ' + nombre as nombre from Profesor"

        'Con la tabla devuelta por el Helper creamos N OBJETOS Bug a partir de los datos de la/s filas de la tabla Profesores
        Return BDHelper.getDBHelper().ConsultaSQL(strSQL)
    End Function

    Public Function add(ByVal oProfesor As Profesor) As Boolean
        Dim comandStr As String
        comandStr = "INSERT INTO dbo.Profesor VALUES("
        comandStr += "'" + oProfesor.legajo.ToString + "', "
        comandStr += "'" + oProfesor.nombre + "', "
        comandStr += "'" + oProfesor.apellido + "',"
        comandStr += "'" + oProfesor.dni.ToString + "', "
        comandStr += "'" + oProfesor.fecha_nac.ToString + "', "
        comandStr += "'" + oProfesor.año_ingreso.ToString + "', "
        comandStr += "'" + oProfesor.tel.ToString + "', "
        comandStr += "')"

        Return (BDHelper.getDBHelper().EjecutarSQL(comandStr) = 1)
    End Function

    Public Function update(ByVal oProfesor As Profesor) As Boolean
        Dim comandStr As String
        comandStr = "UPDATE Profesor SET "
        'comandStr += "legajo='" + oProfesor.legajo + "', "
        comandStr += "nombre= '" + oProfesor.nombre.ToString + "', "
        comandStr += "apellido= '" + oProfesor.apellido + "', "
        comandStr += "dni='" + oProfesor.dni.ToString + "', "
        comandStr += "fecha_nac= " + oProfesor.fecha_nac.ToString + ", "
        comandStr += "año_ingreso= '" + oProfesor.año_ingreso.ToString + "', "
        comandStr += "tel= '" + oProfesor.tel.ToString + "', "
        comandStr += "WHERE legajo= " + oProfesor.legajo

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
            .dni = Convert.ToInt32(row.Item("dni").ToString)
            .fecha_nac = row.Item("fecha_nac").ToString
            .año_ingreso = Convert.ToInt32(row.Item("año_ingreso").ToString)
            .tel = row.Item("tel").ToString
            .mail = row.Item("mail").ToString
        End With
        Return oProfeso
    End Function
End Class
