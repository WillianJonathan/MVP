Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod>
    Public Sub EncryptDecrypt()
        ' Arrange
        Dim subject = New StringEncryption()
        Dim originalString = "EU IA LHE CHAMAR"

        ' Act
        Dim encryptedString1 = subject.Encrypt(originalString)
        Dim encryptedString2 = subject.Encrypt(originalString)
        Dim decryptedString1 = subject.Decrypt(encryptedString1)
        Dim decryptedString2 = subject.Decrypt(encryptedString2)

        ' Assert
        Assert.AreEqual(originalString, decryptedString1, "Decrypted string should match original string")
        Assert.AreEqual(originalString, decryptedString2, "Decrypted string should match original string")
        Assert.AreNotEqual(originalString, encryptedString1, "Encrypted string should not match original string")
        Assert.AreNotEqual(encryptedString1, encryptedString2, "String should never be encrypted the same twice")
    End Sub

End Class