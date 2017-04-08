<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.buttonEncryptFile = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.buttonDecryptFile = New System.Windows.Forms.Button()
        Me.txtTextoOriginal = New System.Windows.Forms.TextBox()
        Me.txtTextoCriptografado = New System.Windows.Forms.TextBox()
        Me.txtTextoDescriptografado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'buttonEncryptFile
        '
        Me.buttonEncryptFile.Location = New System.Drawing.Point(28, 83)
        Me.buttonEncryptFile.Name = "buttonEncryptFile"
        Me.buttonEncryptFile.Size = New System.Drawing.Size(75, 23)
        Me.buttonEncryptFile.TabIndex = 0
        Me.buttonEncryptFile.Text = "Encrypt File"
        Me.buttonEncryptFile.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        '
        'buttonDecryptFile
        '
        Me.buttonDecryptFile.Location = New System.Drawing.Point(28, 138)
        Me.buttonDecryptFile.Name = "buttonDecryptFile"
        Me.buttonDecryptFile.Size = New System.Drawing.Size(75, 23)
        Me.buttonDecryptFile.TabIndex = 2
        Me.buttonDecryptFile.Text = "Decrypt File"
        Me.buttonDecryptFile.UseVisualStyleBackColor = True
        '
        'txtTextoOriginal
        '
        Me.txtTextoOriginal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTextoOriginal.Location = New System.Drawing.Point(28, 57)
        Me.txtTextoOriginal.Name = "txtTextoOriginal"
        Me.txtTextoOriginal.Size = New System.Drawing.Size(244, 20)
        Me.txtTextoOriginal.TabIndex = 3
        '
        'txtTextoCriptografado
        '
        Me.txtTextoCriptografado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTextoCriptografado.Location = New System.Drawing.Point(28, 112)
        Me.txtTextoCriptografado.Name = "txtTextoCriptografado"
        Me.txtTextoCriptografado.Size = New System.Drawing.Size(244, 20)
        Me.txtTextoCriptografado.TabIndex = 4
        '
        'txtTextoDescriptografado
        '
        Me.txtTextoDescriptografado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTextoDescriptografado.Location = New System.Drawing.Point(28, 167)
        Me.txtTextoDescriptografado.Name = "txtTextoDescriptografado"
        Me.txtTextoDescriptografado.Size = New System.Drawing.Size(244, 20)
        Me.txtTextoDescriptografado.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtTextoDescriptografado)
        Me.Controls.Add(Me.txtTextoCriptografado)
        Me.Controls.Add(Me.txtTextoOriginal)
        Me.Controls.Add(Me.buttonDecryptFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buttonEncryptFile)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonEncryptFile As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents buttonDecryptFile As Button
    Friend WithEvents txtTextoOriginal As TextBox
    Friend WithEvents txtTextoCriptografado As TextBox
    Friend WithEvents txtTextoDescriptografado As TextBox
End Class
