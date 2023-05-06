Public Class search
    Dim count As Integer = 0

    Public Sub search_str(ByVal phrase As String, ByVal str As String)
        Dim position As Integer = phrase.IndexOf(str, StringComparison.CurrentCultureIgnoreCase) '' StringComparison.CurrentCultureIgnoreCase pour A=a ... z=Z 
        While position <> -1
            count += 1
            position = phrase.IndexOf(str, position + 1, StringComparison.CurrentCultureIgnoreCase)
        End While

    End Sub
    Public Function getCount()
        Return count
    End Function
End Class
