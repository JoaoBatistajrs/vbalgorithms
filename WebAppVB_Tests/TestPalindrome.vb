Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports WebFormsAlgorithms.BusinessLogic

<TestClass()>
Public Class TestPalindrome

    <TestMethod()>
    Public Sub IsPalindrome_ShouldReturnTrue_ForPalindromeNumbers()
        ' Arrange
        Dim number1 As Integer = 121
        Dim number2 As Integer = 1221
        Dim number3 As Integer = 5005

        ' Act & Assert
        Assert.IsTrue(Service.IsPalindrome(number1), "121 It is a Palindrome.")
        Assert.IsTrue(Service.IsPalindrome(number2), "1221 It is a Palindrome.")
        Assert.IsTrue(Service.IsPalindrome(number3), "5005 It is a Palindrome.")
    End Sub

    <TestMethod()>
    Public Sub IsPalindrome_ShouldHandleSingleDigitNumbers()
        ' Arrange
        Dim number1 As Integer = 1
        Dim number2 As Integer = 9

        ' Act & Assert
        Assert.IsTrue(Service.IsPalindrome(number1), "1 It is a Palindrome.")
        Assert.IsTrue(Service.IsPalindrome(number2), "9 It is a Palindrome.")
    End Sub

    <TestMethod()>
    Public Sub IsPalindrome_ShouldReturnFalse_ForNonPalindromeNumbers()
        ' Arrange
        Dim number1 As Integer = 123
        Dim number2 As Integer = 1234
        Dim number3 As Integer = 10

        ' Act & Assert
        Assert.IsFalse(Service.IsPalindrome(number1), "123 It is not a Palindrome.")
        Assert.IsFalse(Service.IsPalindrome(number2), "1234 It is not a Palindrome.")
        Assert.IsFalse(Service.IsPalindrome(number3), "10 It is not a Palindrome.")
    End Sub

    <TestMethod()>
    Public Sub IsPalindrome_ShouldHandleNegativeNumbers()
        ' Arrange
        Dim number1 As Integer = -1
        Dim number2 As Integer = -121

        ' Act & Assert
        Assert.IsTrue(Service.IsPalindrome(number1), "-1 It is a Palindrome.")
        Assert.IsTrue(Service.IsPalindrome(number2), "-121 It is a Palindrome.")
    End Sub

End Class