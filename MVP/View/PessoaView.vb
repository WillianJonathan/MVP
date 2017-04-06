Imports MVP

Public Class PessoaView
    Implements IPessoaView

#Region "Construtores"


#End Region

#Region "Propriedades"

    Public Property NomeRazaoSocial As String Implements IPessoaView.NomeRazaoSocial
        Get
            Return txtNomeRazaoSocial.Text.Trim
        End Get
        Set(value As String)
            txtNomeRazaoSocial.Text = value
        End Set
    End Property

    Public Property Codigo As String Implements IPessoaView.Codigo
        Get
            Return txtCodigo.Text.Trim
        End Get
        Set(value As String)
            txtCodigo.Text = value
        End Set
    End Property

    Public Property Lista As List(Of PessoaModel) Implements IPessoaView.Lista
        Get
            Return dgvPessoas.DataSource
        End Get
        Set(value As List(Of PessoaModel))
            dgvPessoas.DataSource = value
        End Set
    End Property

    Public Event Inserir(sender As Object, e As EventArgs) Implements IPessoaView.Inserir
    Public Event Alterar(sender As Object, e As EventArgs) Implements IPessoaView.Alterar
    Public Event Excluir(sender As Object, e As EventArgs) Implements IPessoaView.Excluir
    Public Event Limpar(sender As Object, e As EventArgs) Implements IPessoaView.Limpar
    Public Event RegistroSelecionado(Id As Integer) Implements IPessoaView.RegistroSelecionado


#End Region

#Region "Eventos"

#Region "Primários"

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click

        RaiseEvent Inserir(sender, e)

    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click

        RaiseEvent Alterar(sender, e)

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        RaiseEvent Excluir(sender, e)

    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click

        RaiseEvent Limpar(sender, e)

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Me.Close()

    End Sub

#End Region

#Region "Secundários"

    Private Sub dgvPessoas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPessoas.CellDoubleClick

        If dgvPessoas.CurrentRow IsNot Nothing AndAlso dgvPessoas.Rows.Count > 0 Then

            Dim _id As Integer = Convert.ToInt32(dgvPessoas.CurrentRow.Cells(0).Value)

            RaiseEvent RegistroSelecionado(_id)

        End If

    End Sub

#End Region

#End Region

End Class
