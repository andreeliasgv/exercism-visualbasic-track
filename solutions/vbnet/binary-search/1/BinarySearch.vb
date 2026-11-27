Public Module BinarySearch
    Public Function Find(ByVal input As Integer(), ByVal value As Integer) As Integer
      Dim initSearchPos As Integer = 0
      Dim endSearchPos As Integer = input.Length - 1

      While initSearchPos <= endSearchPos
         Dim middleArrayPos As Integer = initSearchPos + (endSearchPos - initSearchPos) \ 2

         Select Case value
            Case Is < input(middleArrayPos)
               endSearchPos = middleArrayPos - 1
            Case Is > input(middleArrayPos)
               initSearchPos = middleArrayPos + 1
            Case Else
               Return middleArrayPos
         End Select
      End While

      Return -1
   End Function
End Module
