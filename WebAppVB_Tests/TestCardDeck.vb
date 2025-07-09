Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports WebFormsAlgorithms.BusinessLogic

Namespace WebAppVB_Tests
    <TestClass>
    Public Class TestCardDeck

        <TestMethod()>
        Public Sub TestPair()
            Dim hand = New List(Of String) From {"Ah", "As", "10c", "7d", "6s"}
            Dim result = Service.EvaluatePokerHand(hand)
            Assert.AreEqual("Pair", result)
        End Sub

        <TestMethod()>
        Public Sub TestTwoPair()
            Dim hand = New List(Of String) From {"Kh", "Kc", "3s", "3h", "2d"}
            Dim result = Service.EvaluatePokerHand(hand)
            Assert.AreEqual("Two Pair", result)
        End Sub

        <TestMethod()>
        Public Sub TestThreeOfAKind()
            Dim hand = New List(Of String) From {"Qh", "Qc", "Qs", "5d", "2h"}
            Dim result = Service.EvaluatePokerHand(hand)
            Assert.AreEqual("Three of a Kind", result)
        End Sub

        <TestMethod()>
        Public Sub TestFlush()
            Dim hand = New List(Of String) From {"Kh", "Qh", "6h", "2h", "9h"}
            Dim result = Service.EvaluatePokerHand(hand)
            Assert.AreEqual("Flush", result)
        End Sub

        <TestMethod()>
        Public Sub TestHighCard()
            Dim hand = New List(Of String) From {"2h", "5d", "9s", "Jc", "Kc"}
            Dim result = Service.EvaluatePokerHand(hand)
            Assert.AreEqual("High Card", result)
        End Sub

        <TestMethod()>
        Public Sub TestInvalidHand()
            Dim hand = New List(Of String) From {"Ah", "Kd"}
            Dim result = Service.EvaluatePokerHand(hand)
            Assert.AreEqual("Invalid Hand", result)
        End Sub

    End Class
End Namespace

