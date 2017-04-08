
Public Class Form1

    Private Sub buttonEncryptFile_Click(sender As Object, e As EventArgs) Handles buttonEncryptFile.Click
        txtTextoCriptografado.Text = New StringEncryption().Encrypt(txtTextoOriginal.Text)
    End Sub

    Private Sub buttonDecryptFile_Click(sender As Object, e As EventArgs) Handles buttonDecryptFile.Click
        txtTextoDescriptografado.Text = New StringEncryption().Decrypt(txtTextoCriptografado.Text)

        Label1.Text = IIf((txtTextoDescriptografado.Text = txtTextoOriginal.Text), "SÃO IGUAIS", "DIFERENTES")

    End Sub

End Class
