Imports WebFormsAlgorithms.BusinessLogic
Public Class PokerHand
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ClearInputs()
            lblResult.Text = ""
        End If
    End Sub

    Protected Sub btnEvaluate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEvaluate.Click
        Dim cards As New List(Of String)()

        Dim cardInputs As New List(Of TextBox) From {txtCard1, txtCard2, txtCard3, txtCard4, txtCard5}
        Dim allCardsValid As Boolean = True

        For Each txtBox As TextBox In cardInputs
            Dim cardValue As String = txtBox.Text.Trim()
            If String.IsNullOrEmpty(cardValue) Then
                lblResult.Text = "Please fill out your cards."
                lblResult.ForeColor = System.Drawing.Color.OrangeRed
                allCardsValid = False
                Exit For
            ElseIf Not IsValidCardFormat(cardValue) Then
                lblResult.Text = $"Invalid format: '{cardValue}'. You should provide the cards like: 'AS', '10H', 'KC', '5D'."
                lblResult.ForeColor = System.Drawing.Color.OrangeRed
                allCardsValid = False
                Exit For
            End If
            cards.Add(cardValue)
        Next

        If allCardsValid Then
            Dim handResult As String = Service.EvaluatePokerHand(cards)

            lblResult.Text = $"You have a: <span style='font-weight:bold; color:navy;'>{handResult}</span>"
            lblResult.ForeColor = System.Drawing.Color.DarkGreen
        End If
    End Sub

    Private Function IsValidCardFormat(card As String) As Boolean
        If card.Length < 2 Then
            Return False
        End If

        Dim rankPart As String = card.Substring(0, card.Length - 1).ToUpper()
        Dim suitPart As Char = Char.ToUpper(card.Last())

        Select Case suitPart
            Case "S", "H", "D", "C"
            Case Else
                Return False
        End Select

        Select Case rankPart
            Case "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"
                Return True
            Case Else
                Return False
        End Select
    End Function

    Private Sub ClearInputs()
        txtCard1.Text = ""
        txtCard2.Text = ""
        txtCard3.Text = ""
        txtCard4.Text = ""
        txtCard5.Text = ""
    End Sub

End Class
