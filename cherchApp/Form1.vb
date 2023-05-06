Imports cherchApp.search
Public Class Form1

    Private Sub Button_search_Click(sender As Object, e As EventArgs) Handles Button_search.Click
        If TextBox_str.Text <> Nothing Then
            Dim str As New search
            If CheckBox1.Checked Then
                str.search_str(TextBox_phrase1.Text, TextBox_str.Text)
            End If
            If CheckBox2.Checked Then
                str.search_str(TextBox_phrase2.Text, TextBox_str.Text)
            End If
            If CheckBox3.Checked Then
                str.search_str(TextBox_phrase3.Text, TextBox_str.Text)
            End If
            Label_count.Text = CType(str.getCount(), String)
        Else
            MsgBox("text box str est vide", MsgBoxStyle.MsgBoxHelp)
        End If
    End Sub
End Class
