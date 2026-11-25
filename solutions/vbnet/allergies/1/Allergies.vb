Public Class Allergies
    Private score As Integer = 0
    Private catalogedAllergies As New Dictionary(Of String, Integer) From {
        {"eggs", 1},
        {"peanuts", 2},
        {"shellfish", 4},
        {"strawberries", 8},
        {"tomatoes", 16},
        {"chocolate", 32},
        {"pollen", 64},
        {"cats", 128}
    }
  
    Public Sub New(score As Integer)
        Me.score = score
    End Sub

    Public Function AllergicTo(allergy As String) As Boolean
        If (score And catalogedAllergies(allergy)) <> 0 Then
            Return True
        End If

        Return False
    End Function

    Public Function List() As IList(Of String)
        Dim compatibleAllergies As New List(Of String)

        For each allergyName As String In catalogedAllergies.keys
            If AllergicTo(allergyName) Then
                compatibleAllergies.add(allergyName)
            End If
        Next

        Return compatibleAllergies
    End Function
End Class
