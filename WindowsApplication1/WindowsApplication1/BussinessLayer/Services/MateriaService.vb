Public Class MateriaService
    Private oMateriaDAO As MateriaDAO
    Public Sub New()
        oMateriaDAO = New MateriaDAO()
    End Sub

    Public Function listarMateria() As List(Of Materia)
        Return oMateriaDAO.getMaterias()

    End Function

    Public Function registrarMateria(ByVal oMateria As Materia) As Boolean
        Return oMateriaDAO.add(oMateria)
    End Function

    Public Function actualizarMateria(ByVal oMateria As Materia) As Boolean
        Return oMateriaDAO.update(oMateria)
    End Function

    Public Function listarMateriaConFiltro(ByVal nombre As String) As List(Of Materia)
        Return oMateriaDAO.getByFilters(nombre)
    End Function
End Class
