Public Class NotaDAO
    Public Function getTipoNota() As DataTable
        Dim str As String
        str = "SELECT * FROM TipoNota"
        Return BDHelper.getDBHelper.ConsultaSQL(str)
    End Function

    Public Function getTrimestres() As DataTable
        Dim str As String
        str = "SELECT * FROM Trimestre"
        Return BDHelper.getDBHelper.ConsultaSQL(str)
    End Function

    Public Function insertarNotas(tabla As DataTable, tnota As Char, trim As Integer, fecha As String, mat As String) As Integer
        Dim str As String = ""
        For Each row As DataRow In tabla.Rows
            str += "INSERT INTO Nota VALUES ('"
            str += row.Item("col_Curso").ToString + "'"
            str += ", " + row.Item("col_Legajo").ToString
            str += ", '" + mat.ToString + "'"
            str += ", '" + fecha.ToString + "'"
            str += ", '" + tnota.ToString + "'"
            str += ", " + trim.ToString
            str += ", '" + row.Item("col_Nota").ToString + "')"
            str += " ; "
        Next
        Return BDHelper.getDBHelper.EjecutarSQLTransact(str)

    End Function

    Public Function getNotas(curso As String, materia As String, trimestre As String) As DataTable
        Dim str As String = ""
        str += "EXECUTE obtenerNotas "
        str += "'" + curso.ToString + "'"
        str += ",'" + materia.ToString + "'"
        str += ",'" + trimestre.ToString + "'"

        Return BDHelper.getDBHelper.EjecutarProcedure(str)
    End Function

    Public Function existeNota(curso As String, materia As String, trimestre As String) As Boolean
        Dim str As String = ""
        str += "Select * from nota where cod_curso = "
        str += "'" + curso.ToString + "'"
        str += "AND cod_materia = '" + materia.ToString + "'"
        str += "AND trimestre = '" + trimestre.ToString + "'"
        str += "And tipo_nota = 'E'"

        Return BDHelper.getDBHelper.ConsultaSQL(str).Rows.Count > 0
    End Function

    Public Function existeNotaFinal(curso As String, materia As String, trimestre As String) As Boolean
        Dim str As String = ""
        str += "Select * from nota where cod_curso = "
        str += "'" + curso.ToString + "'"
        str += "AND cod_materia = '" + materia.ToString + "'"
        str += "AND trimestre = '" + trimestre.ToString + "'"
        str += "And tipo_nota = 'F'"

        Return BDHelper.getDBHelper.ConsultaSQL(str).Rows.Count > 0
    End Function

    Public Function getNotaFinal(curso As String, materia As String, trimestre As String) As DataTable
        Dim str As String = ""
        str += "SELECT max(nota) as Final, a.legajo, b.apellido + ', ' + b.nombre as Nombre From alumnosxcurso a "
        str += "LEFT Join alumno b On a.legajo = b.legajo "
        str += "Left Join nota c ON a.legajo = c.legajo_alu "
        str += "WHERE a.cod_curso = '" + curso.ToString + "' "
        str += "And c.cod_materia = '" + materia.ToString + "' "
        str += "And c.trimestre = '" + trimestre.ToString + "' "
        str += "And c.tipo_nota = 'F' "
        str += "GROUP BY a.legajo, b.apellido, b.nombre "

        Return BDHelper.getDBHelper.ConsultaSQL(str)
    End Function

    Public Function borrarDia(curso As String, materia As String, trimestre As String, dia As String) As Boolean
        Dim str As String = ""
        str += "DELETE nota "
        str += "WHERE cod_curso = '" + curso.ToString + "' "
        str += "And cod_materia = '" + materia.ToString + "' "
        str += "And trimestre = '" + trimestre.ToString + "' "
        str += "And tipo_nota <> 'F' "
        str += "And fecha = '" + dia.ToString + "' "

        Return BDHelper.getDBHelper.EjecutarSQL(str) > 0
    End Function

    Public Function borrarFinal(curso As String, materia As String, trimestre As String) As Boolean
        Dim str As String = ""
        str += "DELETE nota "
        str += "WHERE cod_curso = '" + curso.ToString + "' "
        str += "And cod_materia = '" + materia.ToString + "' "
        str += "And trimestre = '" + trimestre.ToString + "' "
        str += "And tipo_nota = 'F' "


        Return BDHelper.getDBHelper.EjecutarSQL(str) > 0
    End Function

    Public Function actualizarNotaFecha(curso As String, materia As String, trimestre As String, legajo As String, nota As String, dia As String)
        Dim str As String = ""
        str += "UPDATE nota set nota = '" + nota.ToString + "' "
        str += "WHERE cod_curso = '" + curso.ToString + "' "
        str += "And cod_materia = '" + materia.ToString + "' "
        str += "And trimestre = '" + trimestre.ToString + "' "
        str += "And legajo_alu = '" + legajo.ToString + "' "
        str += "And fecha = '" + dia.ToString + "' "
        str += "And tipo_nota <> 'F' "

        Return BDHelper.getDBHelper.EjecutarSQL(str) > 0
    End Function

    Public Function actualizarNotaFinal(curso As String, materia As String, trimestre As String, legajo As String, nota As String)
        Dim str As String = ""
        str += "UPDATE nota set nota = '" + nota.ToString + "' "
        str += "WHERE cod_curso = '" + curso.ToString + "' "
        str += "And cod_materia = '" + materia.ToString + "' "
        str += "And trimestre = '" + trimestre.ToString + "' "
        str += "And legajo_alu = '" + legajo.ToString + "' "
        str += "And tipo_nota = 'F' "

        Return BDHelper.getDBHelper.EjecutarSQL(str) > 0
    End Function


End Class