Public Class AlumnoDAO
    'Permite obtener todos los alumnos
    Public Function getAlumnos()
        Dim oAlumno As Alumno = Nothing
        Dim oTable As DataTable

        'Armamos el query para ejecutar a la base
        Dim strSQL As String = "SELECT * from dbo.Alumno"
        'Delegamos la ejecución del comando SQL al Helper
        oTable = BDHelper.getDBHelper().ConsultaSQL(strSQL)
        'Con la tabla devuelta por el Helper creamos un OBJETO Alumno a partir de los datos de fila de la tabla Alumnos
        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            oAlumno = New Alumno()
            oAlumno.legajo = oTable.Rows(0).Item("legajo").ToString
            oAlumno.apellido = oTable.Rows(0).Item("apellido").ToString
            oAlumno.nombre = Convert.ToInt32(oTable.Rows(0).Item("nombre").ToString)
            oAlumno.documento = oTable.Rows(0).Item("documento").ToString
            oAlumno.telefono = oTable.Rows(0).Item("telefono").ToString
        Next

        Return oAlumno
    End Function

    Public Function add(ByVal oAlumno As Alumno) As Boolean
        Dim comandStr As String
        comandStr = "INSERT INTO dbo.Alumno VALUES("
        comandStr += "'" + oAlumno.legajo.ToString + "', "
        comandStr += "'" + oAlumno.nombre + "', "
        comandStr += "'" + oAlumno.apellido + "', "
        comandStr += "'" + oAlumno.telefono + "', "
        comandStr += "'" + oAlumno.documento + ")"

        Return (BDHelper.getDBHelper().EjecutarSQL(comandStr) = 1)
    End Function

End Class
