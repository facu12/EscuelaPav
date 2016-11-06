Public Class NotaService
    Private oNotaDAO As New NotaDAO
    Public Function getTipoNota() As DataTable
        Return oNotaDAO.getTipoNota
    End Function

    Public Function getTrimestres() As DataTable

        Return oNotaDAO.getTrimestres()
    End Function

    Public Function insertarNotas(tabla As DataTable, tnota As Char, trim As Integer, fecha As String, mat As Integer) As Integer
        Return oNotaDAO.insertarNotas(tabla, tnota, trim, fecha, mat)
    End Function

    Public Function getNotas(curso As String, materia As String, trimestre As String) As DataTable
        Return oNotaDAO.getNotas(curso, materia, trimestre)
    End Function

    Public Function existeNota(curso As String, materia As String, trimestre As String) As Boolean
        Return oNotaDAO.existeNota(curso, materia, trimestre)
    End Function

    Public Function existeNotaFinal(curso As String, materia As String, trimestre As String) As Boolean
        Return oNotaDAO.existeNota(curso, materia, trimestre)
    End Function

    Public Function getNotaFinal(curso As String, materia As String, trimestre As String) As DataTable
        Return oNotaDAO.getNotaFinal(curso, materia, trimestre)
    End Function

    Public Function borrarFinal(curso As String, materia As String, trimestre As String) As Boolean
        Return oNotaDAO.borrarFinal(curso, materia, trimestre)
    End Function

    Public Function borrarDia(curso As String, materia As String, trimestre As String, dia As String) As Boolean
        Return oNotaDAO.borrarDia(curso, materia, trimestre, dia)
    End Function

    Public Function actualizarNotaFinal(curso As String, materia As String, trimestre As String, legajo As String, nota As String) As Boolean
        Return oNotaDAO.actualizarNotaFinal(curso, materia, trimestre, legajo, nota)
    End Function

    Public Function actualizarNotaFecha(curso As String, materia As String, trimestre As String, legajo As String, nota As String, dia As String)
        Return oNotaDAO.actualizarNotaFecha(curso, materia, trimestre, legajo, nota, dia)
    End Function

End Class