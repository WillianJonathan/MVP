Public Interface IPessoaView

    Event Inserir(sender As Object, e As EventArgs)
    Event Alterar(sender As Object, e As EventArgs)
    Event Excluir(sender As Object, e As EventArgs)
    Event Limpar(sender As Object, e As EventArgs)
    Event RegistroSelecionado(Id As Integer)

    Property Lista As List(Of PessoaModel)
    Property NomeRazaoSocial As String
    Property Codigo As String


End Interface
