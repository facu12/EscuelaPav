Public Class MateriaService
    Private oMateriaDAO As MateriaDAO
    Public Sub New()
        oMateriaDAO = New MateriaDAO()
    End Sub

    Public Function listarMateria() As List(Of Materia)
        Return oMateriaDAO.getMaterias()
    End Function

    Public Function listarMateriaxCurso(curso As String) As DataTable
        Return oMateriaDAO.getMateriasxCurso(curso)
    End Function

    Public Function registrarMateria(ByVal oMateria As Materia) As Boolean
        Return oMateriaDAO.add(oMateria)
    End Function

    Public Function registrarMateriaenCurso(cod As String, materia As Integer, profesor As Integer)
        Return oMateriaDAO.addMateriaenCurso(cod, profesor, materia)
    End Function

    Public Function actualizarMateria(ByVal oMateria As Materia) As Boolean
        Return oMateriaDAO.update(oMateria)
    End Function

    Public Function listarMateriaConFiltro(ByVal nombre As String) As List(Of Materia)
        Return oMateriaDAO.getByFilters(nombre)
    End Function

    Public Function eliminarMateriasCursos(cod As String, profesor As Integer, materia As Integer) As Boolean
        Return oMateriaDAO.elimnarMateriadeCurso(cod, profesor, materia)
    End Function
End Class
