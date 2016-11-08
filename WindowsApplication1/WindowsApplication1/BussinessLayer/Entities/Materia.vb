Public Class Materia
    Public Property codMateria As String
    Public Property nombre As String
    Public Property esContraturno As String

    'Funcion creada para reemplazar en la grilla el True/False por un Si/No
    Public Function SiNo(x As String) As String
        If (x) Then
            Return "Si"
        Else Return "No"
        End If
    End Function

    'Funcion creada para reemplazar en el checkbox el Si/No de la grilla por un True/False
    Public Function TrueFlase(x As String) As Boolean
        If (x = "Si") Then
            Return True
        Else Return False
        End If
    End Function

    'Funcion creada para reemplazar en el checkbox el Si/No de la grilla por un True/False
    Public Function UnoCero(x As String) As String
        If (x) Then
            Return "1"
        Else Return "0"
        End If
    End Function
End Class
