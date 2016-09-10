Public Class UserDAO
    'Permite obtener un usuario a partir de un nombre de usuario y password
    Public Function getUser(ByVal usuario, ByVal pass)
        Dim oUser As User = Nothing
        Dim oTable As DataTable

        'Armamos el query para ejecutar a la base
        Dim strSQL As String = "SELECT * from usuario WHERE usuario = '" + usuario + "' AND pass = '" + pass + "'"
        'Delegamos la ejecución del comando SQL al Helper
        oTable = BDHelper.getDBHelper().ConsultaSQL(strSQL)
        'Con la tabla devuelta por el Helper creamos un OBJETO User a partir de los datos de fila de la tabla Users
        If oTable.Rows.Count > 0 Then
            oUser = New User()
            oUser.nUsuario = oTable.Rows(0).Item("usuario").ToString
            oUser.password = oTable.Rows(0).Item("pass").ToString
            'oUser.idUsuario = Convert.ToInt32(oTable.Rows(0).Item("id_usuario").ToString)

        End If

        Return oUser
    End Function

    'Permite consultar todos los usuarios de la base. Solo crea objetos con ID+NOMBRE
    Public Function getAll() As List(Of User)
        Dim oUser As User
        Dim estados As New List(Of User)
        Dim strSQL = "SELECT * FROM usuario"

        For Each row As DataRow In BDHelper.getDBHelper().ConsultaSQL(strSQL).Rows
            oUser = New User()
            'oUser.idUsuario = Convert.ToInt32((row.Item("id_usuario").ToString))
            oUser.nUsuario = row.Item("usuario").ToString
            estados.Add(oUser)
        Next

        Return estados
    End Function
End Class
