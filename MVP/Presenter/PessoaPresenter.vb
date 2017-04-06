Imports System.Reflection

Public Class PessoaPresenter

    Public Sub New(pessoaModel As IPessoaModel, pessoaView As IPessoaView, pessoaRepository As IRepository)

        _pessoaModel = pessoaModel
        _pessoaView = pessoaView
        _pessoaRepository = pessoaRepository

        SetViewPropertiesFromModel()

        ControlarEventos()
        CarregarGrid()

    End Sub

    Private _pessoaModel As IPessoaModel
    Private _pessoaRepository As IRepository
    Private _pessoaView As IPessoaView

    Private Sub SetModelPropertiesFromView()

        For Each viewProperty As PropertyInfo In Me._pessoaView.GetType().GetProperties()

            If viewProperty.CanRead Then

                Dim modelProperty As PropertyInfo = _pessoaModel.GetType().GetProperty(viewProperty.Name)

                If modelProperty IsNot Nothing AndAlso modelProperty.PropertyType.Equals(viewProperty.PropertyType) Then

                    Dim valueToAssing As Object = Convert.ChangeType(viewProperty.GetValue(_pessoaView, Nothing), modelProperty.PropertyType)

                    If valueToAssing IsNot Nothing Then

                        modelProperty.SetValue(_pessoaModel, valueToAssing, Nothing)

                    End If

                End If

            End If

        Next

    End Sub

    Private Sub SetViewPropertiesFromModel()

        For Each viewProperty As PropertyInfo In Me._pessoaView.GetType().GetProperties()

            If viewProperty.CanRead Then

                Dim modelProperty As PropertyInfo = _pessoaModel.GetType().GetProperty(viewProperty.Name)

                If modelProperty IsNot Nothing AndAlso modelProperty.PropertyType.Equals(viewProperty.PropertyType) Then

                    Dim modelValue As Object = modelProperty.GetValue(_pessoaModel, Nothing)

                    If modelValue IsNot Nothing Then

                        Dim valueToAssing = Convert.ChangeType(modelValue, viewProperty.PropertyType)

                        If valueToAssing IsNot Nothing Then

                            viewProperty.SetValue(_pessoaView, valueToAssing, Nothing)

                        End If

                    End If

                End If

            End If

        Next

    End Sub

    Sub ControlarEventos()

        AddHandler _pessoaView.RegistroSelecionado, AddressOf RegistroSelecionado
        AddHandler _pessoaView.Inserir, AddressOf Incluir
        AddHandler _pessoaView.Alterar, AddressOf Alterar
        AddHandler _pessoaView.Excluir, AddressOf Excluir
        AddHandler _pessoaView.Limpar, AddressOf Limpar

    End Sub

    Private Sub RegistroSelecionado(Id As Integer)

        Dim pessoa As PessoaModel = _pessoaRepository.GetItem(Id)

        _pessoaModel = pessoa

        SetViewPropertiesFromModel()

    End Sub

    Private Sub Incluir(sender As Object, e As EventArgs)

        SetModelPropertiesFromView()

        _pessoaRepository.Add(New PessoaModel() With {.Id = _pessoaModel.Id,
                                                      .Codigo = _pessoaModel.Codigo,
                                                      .NomeRazaoSocial = _pessoaModel.NomeRazaoSocial})

        Limpar()
        CarregarGrid()

    End Sub

    Private Sub Alterar(sender As Object, e As EventArgs)

        SetModelPropertiesFromView()
        _pessoaRepository.Add(_pessoaModel)

        Limpar()
        CarregarGrid()

    End Sub

    Private Sub Excluir(sender As Object, e As EventArgs)
        SetModelPropertiesFromView()
        _pessoaRepository.Remove(_pessoaModel)

        Limpar()
        CarregarGrid()

    End Sub

    Private Sub Limpar(sender As Object, e As EventArgs)

        Limpar()
        CarregarGrid()

    End Sub

    Private Sub Limpar()

        _pessoaModel.Id = 0
        _pessoaModel.Codigo = ""
        _pessoaModel.NomeRazaoSocial = ""

        SetViewPropertiesFromModel()

    End Sub

    Private Sub CarregarGrid()

        _pessoaView.Lista = _pessoaRepository.GetAll

    End Sub



End Class
