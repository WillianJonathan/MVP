Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class StringEncryption
    Private ReadOnly random As Random
    Private ReadOnly key As Byte()
    Private ReadOnly rm As RijndaelManaged
    Private ReadOnly encoder As UTF8Encoding

    Public Sub New()
        Me.random = New Random()
        Me.rm = New RijndaelManaged()
        Me.encoder = New UTF8Encoding()
        Me.key = Convert.FromBase64String("") 'mínimo 12 caracteres ACEITOS EM BASE 64
    End Sub

    Public Function Encrypt(unencrypted As String) As String
        Dim vector = New Byte(15) {}
        Me.random.NextBytes(vector)
        Dim cryptogram = vector.Concat(Me.Encrypt(Me.encoder.GetBytes(unencrypted), vector))
        Return Convert.ToBase64String( cryptogram.ToArray())
    End Function

    Public Function Decrypt(encrypted As String) As String
        Dim cryptogram = Convert.FromBase64String(encrypted)
        If cryptogram.Length < 17 Then
            Throw New ArgumentException("Not a valid encrypted string", "encrypted")
        End If

        Dim vector = cryptogram.Take(16).ToArray()
        Dim buffer = cryptogram.Skip(16).ToArray()
        Return Me.encoder.GetString(Me.Decrypt(buffer, vector))
    End Function

    Private Function Encrypt(buffer As Byte(), vector As Byte()) As Byte()
        Dim encryptor = Me.rm.CreateEncryptor(Me.key, vector)
        Return Me.Transform(buffer, encryptor)
    End Function

    Private Function Decrypt(buffer As Byte(), vector As Byte()) As Byte()
        Dim decryptor = Me.rm.CreateDecryptor(Me.key, vector)
        Return Me.Transform(buffer, decryptor)
    End Function

    Private Function Transform(buffer As Byte(), transform__1 As ICryptoTransform) As Byte()
        Dim stream = New MemoryStream()
        Using cs = New CryptoStream(stream, transform__1, CryptoStreamMode.Write)
            cs.Write(buffer, 0, buffer.Length)
        End Using

        Return stream.ToArray()
    End Function
End Class