Public Interface IRepository

    Function GetItem(Id As Integer) As PessoaModel
    Function GetAll() As List(Of PessoaModel)
    Sub Add(item As PessoaModel)
    Sub Remove(item As PessoaModel)

End Interface
