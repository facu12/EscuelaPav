Public Class AlumnoDAO
    'Permite obtener todos los alumnos
    Public Function getAlumnos() As List(Of Alumno)
        Dim alumnos As New List(Of Alumno)
        Dim strSQL = "SELECT * from Alumno"

        'Con la tabla devuelta por el Helper creamos N OBJETOS Bug a partir de los datos de la/s filas de la tabla Bugs
        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            alumnos.Add(map(row))
        Next

        Return alumnos
    End Function

    Public Function add(ByVal oAlumno As Alumno) As Boolean
        Dim comandStr As String
        comandStr = "INSERT INTO dbo.Alumno VALUES("
        comandStr += "'" + oAlumno.legajo.ToString + "', "
        comandStr += "'" + oAlumno.nombre + "', "
        comandStr += "'" + oAlumno.apellido + "', "
        comandStr += "'" + oAlumno.documento + "', "
        comandStr += "'" + oAlumno.fecha_nac + "', "
        comandStr += "'" + oAlumno.año_ingreso + "', "
        comandStr += "'" + oAlumno.telefono + "', "
        comandStr += "'" + oAlumno.email + "')"

        Return (BDHelper.getDBHelper().EjecutarSQL(comandStr) = 1)
    End Function

    Public Function update(ByVal oAlumno As Alumno) As Boolean
        Dim comandStr As String
        comandStr = "UPDATE Alumno SET "
        'comandStr += "legajo='" + oAlumno.legajo + "', "
        comandStr += "nombre='" + oAlumno.nombre + "', "
        comandStr += "apellido='" + oAlumno.apellido + "', "
        comandStr += "dni='" + oAlumno.documento + "', "
        comandStr += "año_ingreso='" + oAlumno.año_ingreso + "', "
        comandStr += "telefono='" + oAlumno.telefono + "', "
        comandStr += "mail='" + oAlumno.email + "' "
        comandStr += "WHERE legajo=" + oAlumno.legajo.ToString

        Return (BDHelper.getDBHelper().EjecutarSQL(comandStr) = 1)
    End Function

    Public Function getByFilters(ByVal apellido As String) As List(Of Alumno)
        Dim alumno As New List(Of Alumno)
        Dim strSQL = "SELECT * FROM dbo.Alumno WHERE alumno.apellido LIKE '%" + apellido + "%'"
        strSQL += " ORDER BY alumno.apellido DESC"

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
            .documento = row.Item("documento").ToString
            .fecha_nac = row.Item("fecha_nac").ToString
            .año_ingreso = row.Item("año_ingreso").ToString
            .telefono = row.Item("telefono").ToString
            .documento = row.Item("documento").ToString
        End With
        Return oAlumno
    End Function
End Class
