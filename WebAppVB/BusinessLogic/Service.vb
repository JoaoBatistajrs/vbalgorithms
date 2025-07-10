Namespace BusinessLogic
    Public Class Service

        Public Shared Function IsPalindrome(ByVal number As Integer) As Boolean

            'Approach 1: Using String Manipulation with LINQ

            If number < 0 Then
                Return number * -1
            End If
            Dim numStr As String = number.ToString()
            Dim reversedNumStr As String = New String(numStr.Reverse().ToArray())

            'Approach 2: Using StringBuilder, faster for larger strings and avoids LINQ overhead
            'Dim charArray = numStr.ToCharArray()
            'Array.Reverse(charArray)
            'Dim reversedNumStrFromChar As String = New String(charArray)

            Return numStr.Equals(reversedNumStr)
        End Function

        Public Shared Function EvaluatePokerHand(cards As List(Of String)) As String
            If cards Is Nothing OrElse cards.Count <> 5 Then
                Return "Invalid Hand"
            End If

            Dim ranks = cards.Select(Function(c) GetCardNumericValue(c)).OrderBy(Function(x) x).ToList()
            Dim suits = cards.Select(Function(c) c.Last()).ToList()

            Dim rankGroups = ranks.GroupBy(Function(r) r).Select(Function(g) New With {
                Key .Rank = g.Key,
                Key .Count = g.Count()
            }).OrderByDescending(Function(x) x.Count).ThenByDescending(Function(x) x.Rank).ToList()

            Dim isFlush = suits.Distinct().Count() = 1
            Dim isStraight = IsSequential(ranks)

            Select Case True
                Case isFlush AndAlso isStraight AndAlso ranks.Min() = 10
                    Return "Royal Flush"
                Case isFlush AndAlso isStraight
                    Return "Straight Flush"
                Case rankGroups(0).Count = 4
                    Return "Four of a Kind"
                Case rankGroups(0).Count = 3 AndAlso rankGroups(1).Count = 2
                    Return "Full House"
                Case isFlush
                    Return "Flush"
                Case isStraight
                    Return "Straight"
                Case rankGroups(0).Count = 3
                    Return "Three of a Kind"
                Case rankGroups(0).Count = 2 AndAlso rankGroups(1).Count = 2
                    Return "Two Pair"
                Case rankGroups(0).Count = 2
                    Return "Pair"
                Case Else
                    Return "High Card"
            End Select
        End Function

        Private Shared Function GetCardNumericValue(card As String) As Integer
            Dim value = card.Substring(0, card.Length - 1).ToUpper()
            Select Case value
                Case "A" : Return 14
                Case "K" : Return 13
                Case "Q" : Return 12
                Case "J" : Return 11
                Case "T" : Return 10
                Case Else : Return Integer.Parse(value)
            End Select
        End Function

        Private Shared Function IsSequential(ranks As List(Of Integer)) As Boolean
            If ranks.Zip(ranks.Skip(1), Function(a, b) b - a).All(Function(diff) diff = 1) Then
                Return True
            End If
            Dim aceLow = New List(Of Integer)(ranks)
            If aceLow.Contains(14) Then
                aceLow = aceLow.Select(Function(x) If(x = 14, 1, x)).OrderBy(Function(x) x).ToList()
                Return aceLow.Zip(aceLow.Skip(1), Function(a, b) b - a).All(Function(diff) diff = 1)
            End If
            Return False
        End Function

    End Class

End Namespace