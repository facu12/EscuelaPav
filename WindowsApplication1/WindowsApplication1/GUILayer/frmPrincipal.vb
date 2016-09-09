Public Class frmPrincipal
    Private Sub btn_alumnos_Click(sender As Object, e As EventArgs) Handles btn_alumnos.Click
        Form1.ShowDialog()
    End Sub

    Private Sub btn_profesores_Click(sender As Object, e As EventArgs) Handles btn_profesores.Click
        frmProfesores.ShowDialog()
    End Sub
End Class