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

    End Class

End Namespace