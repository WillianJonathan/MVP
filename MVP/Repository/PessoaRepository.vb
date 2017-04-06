Imports MVP

Public Class PessoaRepository
    Implements IRepository

    Private _lista As New List(Of PessoaModel)

    Public Sub Add(item As PessoaModel) Implements IRepository.Add

        If item.Id = 0 Then
            item.Id = _lista.Count + 1
            _lista.Add(item)
        Else
            _lista(_lista.IndexOf(item)) = item
        End If

    End Sub

    Public Sub Remove(item As PessoaModel) Implements IRepository.Remove

        _lista.Remove(item)

    End Sub

    Public Function GetItem(Id As Integer) As PessoaModel Implements IRepository.GetItem

        Return _lista.Find(Function(x) x.Id = Id)

    End Function

    Public Function GetAll() As List(Of PessoaModel) Implements IRepository.GetAll

        If _lista.Count = 0 Then
            _lista.Add(New PessoaModel() With {.Id = 1, .Codigo = "1", .NomeRazaoSocial = "Joao"})
            _lista.Add(New PessoaModel() With {.Id = 2, .Codigo = "2", .NomeRazaoSocial = "Lucas"})
            _lista.Add(New PessoaModel() With {.Id = 3, .Codigo = "3", .NomeRazaoSocial = "Gustavo"})
            _lista.Add(New PessoaModel() With {.Id = 4, .Codigo = "4", .NomeRazaoSocial = "Paulo"})
        End If

        Return _lista

    End Function
End Class
