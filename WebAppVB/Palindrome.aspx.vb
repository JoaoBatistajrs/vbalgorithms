Imports WebFormsAlgorithms.BusinessLogic

Public Class Palindrome
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
        End If
    End Sub

    Protected Sub btnCheckPalindrome_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheckPalindrome.Click
        Dim inputNumber As Integer
        If Integer.TryParse(txtNumber.Text, inputNumber) Then
            If Service.IsPalindrome(inputNumber) Then
                lblResult.Text = $"The Number {inputNumber} is a **Palindrome**!"
                lblResult.ForeColor = System.Drawing.Color.Green
            Else
                lblResult.Text = $"The Number {inputNumber} **IS NOT** a Palindromeo."
                lblResult.ForeColor = System.Drawing.Color.Red
            End If
        Else
            lblResult.Text = "Please inform a valid integer number."
            lblResult.ForeColor = System.Drawing.Color.OrangeRed
        End If
    End Sub

End Class