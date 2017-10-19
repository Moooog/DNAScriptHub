Public Class KeemstarNews
    Private Sub KeemstarNews_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim webclient As New System.Net.WebClient
            Dim News As String
            News = System.Text.Encoding.ASCII.GetString((
            webclient.DownloadData("https://pastebin.com/raw/Yj82c73Q")))
            FastColoredTextBox1.Text = (News)
        Catch
            FastColoredTextBox1.Text = ("Lost connection?")
        End Try
    End Sub

    Private Sub MaterialCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles MaterialCheckBox1.CheckedChanged
        If MaterialCheckBox1.Checked = True Then
            MaterialCheckBox1.Checked = False
            Try
                Dim webclient As New System.Net.WebClient
                Dim News As String
                News = System.Text.Encoding.ASCII.GetString((
                webclient.DownloadData("https://pastebin.com/raw/Yj82c73Q")))
                FastColoredTextBox1.Text = (News)
            Catch
                FastColoredTextBox1.Text = ("Lost connection?")
            End Try
        End If
        If MaterialCheckBox1.Checked = False Then

        End If
    End Sub
End Class