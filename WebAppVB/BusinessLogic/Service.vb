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

            Dim ranks = cards.Select(Function(c) GetCardRank(c)).ToList()
            Dim suits = cards.Select(Function(c) c.Last()).ToList()

            Dim rankGroups = ranks.GroupBy(Function(r) r).Select(Function(g) New With {
                Key .Rank = g.Key,
                Key .Count = g.Count()
            }).OrderByDescending(Function(x) x.Count).ToList()

            Dim isFlush = suits.Distinct().Count() = 1

            Select Case True
                Case isFlush
                    Return "Flush"
                Case rankGroups(0).Count = 3 AndAlso rankGroups.Count = 3
                    Return "Three of a Kind"
                Case rankGroups(0).Count = 2 AndAlso rankGroups(1).Count = 2
                    Return "Two Pair"
                Case rankGroups(0).Count = 2
                    Return "Pair"
                Case Else
                    Return "High Card"
            End Select
        End Function

        Private Shared Function GetCardRank(card As String) As String
            Dim value = card.Substring(0, card.Length - 1).ToUpper()
            Select Case value
                Case "A"
                    Return "14"
                Case "K"
                    Return "13"
                Case "Q"
                    Return "12"
                Case "J"
                    Return "11"
                Case Else
                    Return value
            End Select
        End Function

    End Class

End Namespace