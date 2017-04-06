Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim pessoaView As New PessoaView
        Dim pessoaModel As New PessoaModel
        Dim pessoaRepository As New PessoaRepository

        Dim pessoaPresenter As New PessoaPresenter(pessoaModel, pessoaView, pessoaRepository)

        pessoaView.Show()

    End Sub

End Class