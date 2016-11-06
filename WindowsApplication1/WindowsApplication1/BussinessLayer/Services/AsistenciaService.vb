Public Class AsistenciaService
    Private oAsistencia As New AsistenciaDAO

    Public Function getAño() As DataTable
        Return oAsistencia.getAño
    End Function
    Public Function insertarAsistencias(tabla As DataTable, trim As Integer, fecha As String) As Integer
        Return oAsistencia.insertarAsistencias(tabla, trim, fecha)
    End Function
    Public Function getTrimestres() As DataTable

        Return oAsistencia.getTrimestres()
    End Function

    Public Function getDatosFecha(fecha As String)
        Return oAsistencia.getDatosFecha()
    End Function

End Class
