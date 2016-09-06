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
            oAlumno.legajo = Convert.ToInt32(oTable.Rows(0).Item("legajo").ToString)
            oAlumno.apellido = oTable.Rows(0).Item("apellido").ToString
            oAlumno.nombre = oTable.Rows(0).Item("nombre").ToString
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

    Public Function update(ByVal oAlumno As Alumno) As Boolean
        Dim comandStr As String
        comandStr = "UPDATE Alumnos SET "
        comandStr += "legajo='" + oAlumno.legajo + "', "
        comandStr += "nombre='" + oAlumno.nombre + "', "
        comandStr += "apellido='" + oAlumno.apellido + "', "
        comandStr += "telefono=" + oAlumno.telefono + ", "
        comandStr += "documento=" + oAlumno.documento + " "
        comandStr += "WHERE legajo=" + oAlumno.legajo.ToString

        Return (BDHelper.getDBHelper().EjecutarSQL(comandStr) = 1)
    End Function

    Public Function getByFilters(ByVal apellido As String) As List(Of Alumno)
        Dim alumno As New List(Of Alumno)
        Dim strSQL = "SELECT * FROM dbo.Alumnos WHERE apellido LIKE '% " + apellido + "%'"
        strSQL += " ORDER BY apellido DESC"

        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            alumno.Add(map(row))
        Next

        Return alumno
    End Function

    Private Function map(row As DataRow) As Alumno
        Dim oAlumno As New Alumno
        With oAlumno
            .legajo = Convert.ToInt32(row.Item("legajo").ToString)
            .apellido = row.Item("apellido").ToString
            .nombre = row.Item("nombre").ToString
            .telefono = row.Item("telefono").ToString
            .documento = row.Item("documento").ToString
        End With
        Return oAlumno
    End Function
End Class
