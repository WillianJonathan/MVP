Imports MVP

Public Class PessoaModel
    Implements IPessoaModel

#Region "Privadas"

    Private _id As Integer
    Private _codigo As String
    Private _nomeRazaoSocial As String

#End Region

#Region "Públicas"

    Public Property Id As Integer Implements IPessoaModel.Id
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Codigo As String Implements IPessoaModel.Codigo
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property NomeRazaoSocial As String Implements IPessoaModel.NomeRazaoSocial
        Get
            Return _nomeRazaoSocial
        End Get
        Set(value As String)
            _nomeRazaoSocial = value
        End Set
    End Property

#End Region

End Class
