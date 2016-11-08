Public Class AsistenciaService
    Dim oAsistencia As New AsistenciaDAO

    Public Function getAño() As DataTable
        Return oAsistencia.getAño
    End Function
    Public Function insertarAsistencias(tabla As DataTable, trim As Integer, fecha As String) As Integer
        Return oAsistencia.insertarAsistencias(tabla, trim, fecha)
    End Function
    Public Function getTrimestres() As DataTable
        Return oAsistencia.getTrimestres()
    End Function

    Public Function existeAsistencia(ByVal curso As String, ByVal trimestre As String) As Boolean
        Return oAsistencia.existeAsistencia(curso, trimestre)
    End Function
    Public Function getAsistencias(ByVal curso As String, ByVal trimestre As String) As DataTable
        Return oAsistencia.getAsistencias(curso, trimestre)
    End Function

    Public Function getAsistenciaTotal(curso As String, trimestre As String) As DataTable
        Return oAsistencia.getAsistenciaTotal(curso, trimestre)
    End Function
    Public Function ActualizarAsistencia(curso As String, trimestre As String, legajo As String, asist As String, fecha As String, justif As String) As Boolean
        Return oAsistencia.actualizarAsistencia(curso, trimestre, legajo, asist, fecha, justif)
    End Function
    Public Function borrarDia(curso As String, trimestre As String, dia As String) As Boolean
        Return oAsistencia.borrarDia(curso, trimestre, dia)
    End Function

End Class
