<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PessoaView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PessoaView))
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNomeRazaoSocial = New System.Windows.Forms.TextBox()
        Me.dgvPessoas = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnIncluir = New System.Windows.Forms.ToolStripButton()
        Me.btnAlterar = New System.Windows.Forms.ToolStripButton()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.btnLimpar = New System.Windows.Forms.ToolStripButton()
        Me.btnSair = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvPessoas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(93, 63)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(170, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'txtNomeRazaoSocial
        '
        Me.txtNomeRazaoSocial.Location = New System.Drawing.Point(12, 63)
        Me.txtNomeRazaoSocial.Name = "txtNomeRazaoSocial"
        Me.txtNomeRazaoSocial.Size = New System.Drawing.Size(47, 20)
        Me.txtNomeRazaoSocial.TabIndex = 0
        '
        'dgvPessoas
        '
        Me.dgvPessoas.AllowUserToAddRows = False
        Me.dgvPessoas.AllowUserToDeleteRows = False
        Me.dgvPessoas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPessoas.Location = New System.Drawing.Point(12, 89)
        Me.dgvPessoas.Name = "dgvPessoas"
        Me.dgvPessoas.ReadOnly = True
        Me.dgvPessoas.RowHeadersVisible = False
        Me.dgvPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPessoas.Size = New System.Drawing.Size(260, 184)
        Me.dgvPessoas.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnIncluir, Me.btnAlterar, Me.btnExcluir, Me.btnLimpar, Me.btnSair})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(289, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnIncluir
        '
        Me.btnIncluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnIncluir.Image = CType(resources.GetObject("btnIncluir.Image"), System.Drawing.Image)
        Me.btnIncluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(44, 22)
        Me.btnIncluir.Text = "Incluir"
        '
        'btnAlterar
        '
        Me.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(46, 22)
        Me.btnAlterar.Text = "Alterar"
        '
        'btnExcluir
        '
        Me.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(45, 22)
        Me.btnExcluir.Text = "Excluir"
        '
        'btnLimpar
        '
        Me.btnLimpar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnLimpar.Image = CType(resources.GetObject("btnLimpar.Image"), System.Drawing.Image)
        Me.btnLimpar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(48, 22)
        Me.btnLimpar.Text = "Limpar"
        '
        'btnSair
        '
        Me.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(30, 22)
        Me.btnSair.Text = "Sair"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nome"
        '
        'PessoaView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 285)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvPessoas)
        Me.Controls.Add(Me.txtNomeRazaoSocial)
        Me.Controls.Add(Me.txtCodigo)
        Me.Name = "PessoaView"
        Me.Text = "Cadastro de Pessoas"
        CType(Me.dgvPessoas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNomeRazaoSocial As TextBox
    Friend WithEvents dgvPessoas As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnIncluir As ToolStripButton
    Friend WithEvents btnAlterar As ToolStripButton
    Friend WithEvents btnExcluir As ToolStripButton
    Friend WithEvents btnLimpar As ToolStripButton
    Friend WithEvents btnSair As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
