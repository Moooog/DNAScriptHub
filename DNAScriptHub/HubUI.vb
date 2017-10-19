Imports System.Net
Public Class HubUI
    Private Sub BunifuSwitch2_Click(sender As Object, e As EventArgs) Handles BunifuSwitch2.Click
        If BunifuSwitch2.Value = True Then
            TopMost = True
        End If
        If BunifuSwitch2.Value = False Then
            TopMost = False
        End If
    End Sub

    Private Sub BunifuSwitch1_Click(sender As Object, e As EventArgs) Handles BunifuSwitch1.Click
        If BunifuSwitch1.Value = True Then
            TextBoxScript.ReadOnly = True
        End If
        If BunifuSwitch1.Value = False Then
            TextBoxScript.ReadOnly = False
        End If
    End Sub
    Private Sub BunifuThinButton228_Click(sender As Object, e As EventArgs) Handles BunifuThinButton228.Click
        KeemstarNews.Show()
    End Sub

    Private Sub BunifuThinButton227_Click(sender As Object, e As EventArgs) Handles BunifuThinButton227.Click
        Try
            Dim webclient As New WebClient
            Dim script1 As String
            script1 = System.Text.Encoding.ASCII.GetString((
            webclient.DownloadData("https://pastebin.com/raw/9RMYd5gg")))
            TextBoxScript.Text = (script1)
            ScriptLabel.Text = ("Current Script: Atlas V1")
        Catch
            TextBoxScript.Text = ("Lost connection?")
            ScriptLabel.Text = ("Current Script: Lost connection?")
        End Try
    End Sub

    Private Sub BunifuThinButton226_Click(sender As Object, e As EventArgs) Handles BunifuThinButton226.Click
        Try
            Dim webclient As New WebClient
            Dim script1 As String
            script1 = System.Text.Encoding.ASCII.GetString((
            webclient.DownloadData("https://pastebin.com/raw/sZn2Svys")))
            TextBoxScript.Text = (script1)
            ScriptLabel.Text = ("Current Script: Custom Titan V2")
        Catch
            TextBoxScript.Text = ("Lost connection?")
            ScriptLabel.Text = ("Current Script: Lost connection?")
        End Try
    End Sub

    Private Sub BunifuThinButton225_Click(sender As Object, e As EventArgs) Handles BunifuThinButton225.Click
        Try
            Dim webclient As New WebClient
            Dim script1 As String
            script1 = System.Text.Encoding.ASCII.GetString((
            webclient.DownloadData("https://pastebin.com/raw/3Te8wdge")))
            TextBoxScript.Text = (script1)
            ScriptLabel.Text = ("Current Script: Sode No Konayuki")
        Catch
            TextBoxScript.Text = ("Lost connection?")
            ScriptLabel.Text = ("Current Script: Lost connection?")
        End Try
    End Sub

    Private Sub BunifuThinButton233_Click(sender As Object, e As EventArgs) Handles BunifuThinButton233.Click
        Dim dialog As DialogResult = MetroFramework.MetroMessageBox.Show(Owner, "Are you sure you want to Import a script into the program. This may overwrite the current script.", "DNAScriptHub Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            If (ImportDialog.ShowDialog = DialogResult.OK) Then
                TextBoxScript.Text = My.Computer.FileSystem.ReadAllText(ImportDialog.FileName)
                ScriptLabel.Text = ("Current Script: " & ImportDialog.SafeFileName)
            End If
        End If
        If dialog = DialogResult.No Then
        End If
    End Sub

    Private Sub BunifuThinButton232_Click(sender As Object, e As EventArgs) Handles BunifuThinButton232.Click
        Dim dialog As DialogResult = MetroFramework.MetroMessageBox.Show(Owner, "Are you sure you want to copy this? You may overwrite an existing paste.", "DNAScriptHub Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            Clipboard.SetText(TextBoxScript.Text)
        End If
        If dialog = DialogResult.No Then
        End If
    End Sub

    Private Sub BunifuThinButton231_Click(sender As Object, e As EventArgs) Handles BunifuThinButton231.Click
        Dim dialog As DialogResult = MetroFramework.MetroMessageBox.Show(Owner, "Are you sure you want to Save As? Make sure not to overwrite an important file.", "DNAScriptHub Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            Dim SaveFile As New SaveFileDialog
            SaveFile.FileName = ""
            SaveFile.Filter = "Text File(*.txt)|*.txt|Lua File(*.lua)|*.lua"
            SaveFile.Title = "Save As"
            SaveFile.ShowDialog()
            Try
                Dim Write As New System.IO.StreamWriter(SaveFile.FileName)
                Write.Write(TextBoxScript.Text)
                Write.Close()
            Catch ex As Exception
            End Try
        End If
        If dialog = DialogResult.No Then
        End If
    End Sub

    Private Sub FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult = MetroFramework.MetroMessageBox.Show(Owner, "As you are leaving, would you like to save your work?", "DNAScriptHub Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then
            Dim SaveFile As New SaveFileDialog
            SaveFile.FileName = ""
            SaveFile.Filter = "Text File(*.txt)|*.txt|Lua File(*.lua)|*.lua"
            SaveFile.Title = "Save As"
            SaveFile.ShowDialog()
            Try
                Dim Write As New System.IO.StreamWriter(SaveFile.FileName)
                Write.Write(TextBoxScript.Text)
                Write.Close()
            Catch ex As Exception
            End Try
        End If
        If dialog = DialogResult.No Then
            Dim dialogFormClosing As DialogResult = MetroFramework.MetroMessageBox.Show(Owner, "Are you sure you dont want to save?", "DNAScriptHub Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialogFormClosing = DialogResult.Yes Then
            End If
            If dialogFormClosing = DialogResult.No Then
                Dim SaveFile As New SaveFileDialog
                SaveFile.FileName = ""
                SaveFile.Filter = "Text File(*.txt)|*.txt|Lua File(*.lua)|*.lua"
                SaveFile.Title = "Save As"
                SaveFile.ShowDialog()
                Try
                    Dim Write As New System.IO.StreamWriter(SaveFile.FileName)
                    Write.Write(TextBoxScript.Text)
                    Write.Close()
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub
End Class
