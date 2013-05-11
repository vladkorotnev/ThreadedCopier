Public Class Form1
    Sub checkAndEnableGo() Handles sf.TextChanged, df.TextChanged
        go.Enabled = (Trim(df.Text) <> "" And Trim(sf.Text) <> "" And My.Computer.FileSystem.DirectoryExists(sf.Text))

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MinimumSize = Me.Size
        Me.MaximumSize = Me.Size
        Me.MaximizeBox = False
        NumericUpDown1.Value = My.Settings.threads
    End Sub

   
    Private Sub src_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles src.Click
        folders.Description = "Select source directory"
        folders.ShowNewFolderButton = False
        If folders.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            sf.Text = folders.SelectedPath
        End If
        checkAndEnableGo()
    End Sub

    Private Sub dest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dest.Click
        folders.Description = "Select destination directory"
        folders.ShowNewFolderButton = True
        If folders.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Dim p As String = folders.SelectedPath
            If Split(p, "\").Last <> Split(sf.Text, "\").Last Then
                p += "\" + Split(sf.Text, "\").Last
            End If
            df.Text = p
        End If
        checkAndEnableGo()
    End Sub

    Private Sub go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles go.Click
        Dim cp As New ThreadController
        cp.caller = Me
        cp.beginProcessingFolders(sf.Text, df.Text)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        My.Settings.threads = NumericUpDown1.Value
        My.Settings.Save()
    End Sub
End Class
