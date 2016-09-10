Public Class frmLogin
    Private Sub btn_ingresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ingresar.Click
        Dim oUserService As New UserService

        If String.IsNullOrEmpty(txt_contraseña.Text) Or String.IsNullOrEmpty(txt_usuario.Text) Then
            MsgBox("Usuario y Password son requeridos", vbCritical, "Aviso")
            Exit Sub
        End If

        If oUserService.validarUsuario(txt_usuario.Text, txt_contraseña.Text) Then
            Me.Close()
        Else
            lbl_mensaje.ForeColor = Color.Red
            lbl_mensaje.Text = "Usuario o clave incorrectos"
        End If
    End Sub

    Private Sub btn_cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        End
    End Sub
End Class