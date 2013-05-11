Imports Microsoft.VisualBasic.FileIO.FileSystem
Public Class ThreadController
    Dim allFiles As New ArrayList
    Dim allthreads As New ArrayList
    Dim srcP As String
    Dim dstP As String
    Dim maxTC As Integer
    Dim completions As Integer
    Public Property caller As Form1
    Dim s As New System.Diagnostics.Stopwatch
    Dim WithEvents t As New Timer
    Sub beginProcessingFolders(ByVal src As String, ByVal dest As String)
        caller.Hide()
        Me.Show()
        t.Interval = 1000
        t.Enabled = True
        AddHandler t.Tick, AddressOf timeupd
        s.Start()
        maxTC = caller.NumericUpDown1.Value
        state.Text = "Preparing..."
        srcP = src
        dstP = dest
        processFolder(src)
        If Not DirectoryExists(dest) Then
            CreateDirectory(dest)
        Else
            If GetDirectoryInfo(dest).GetFiles.Count > 0 Or GetDirectoryInfo(dest).GetDirectories.Count > 0 Then
                If MsgBox("The folder " + dest.Split("\").Last + " is not empty! The contents may be overwritten! Proceed?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Oops") = MsgBoxResult.No Then
                    caller.Show()
                    Me.Close()
                    Return
                End If
            End If
        End If
        makeThreads()
        Me.state.Text = "Copying"
    End Sub

    Sub makeThreads()
        Application.DoEvents()
        For i = 0 To maxTC
            Me.threads.Items.Add("Thread " + i.ToString)
            state.Text = "Creating thread " + CStr(i)
            Dim t As New CopierThread
            t.beginForDest(dstP, Me, i)
            allthreads.Add(t)

        Next
    End Sub

    Sub processFolder(ByVal dir As String)
        Dim p As New ArrayList
        Dim files As System.IO.FileInfo() = FileIO.FileSystem.GetDirectoryInfo(dir).GetFiles
        Application.DoEvents()
        For Each file As System.IO.FileInfo In files
            allFiles.Add(file.FullName)
        Next

        Dim dirs As System.IO.DirectoryInfo() = FileIO.FileSystem.GetDirectoryInfo(dir).GetDirectories
        Application.DoEvents()
        For Each d As System.IO.DirectoryInfo In dirs
            processFolder(d.FullName)
        Next


    End Sub
    Sub timeupd()
        Me.state.Text = "Elapsed: " + s.Elapsed.Hours.ToString + "hrs " + s.Elapsed.Minutes.ToString + "min " + s.Elapsed.Seconds.ToString + "sec."

    End Sub
    Function anyMoreFiles() As Boolean
       
        If allFiles.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Function giveMeNextFile() As String
        Dim nextFile = allFiles.Item(allFiles.Count - 1).ToString
        allFiles.RemoveAt(allFiles.Count - 1)
        'Log("Handing off " + nextFile)
        Return nextFile
    End Function

    Private Sub ThreadController_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MinimumSize = Me.Size
        Me.MaximumSize = Me.Size
        Me.MaximizeBox = False

    End Sub
    Delegate Sub SetTextCallback(ByVal text As String, ByVal num As Integer)
    Sub PushEvt(ByVal [text] As String, ByVal num As Integer)

        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.threads.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf PushEvt)
            Me.Invoke(d, New Object() {[text], num})
        Else
            Me.threads.Items(num) = "Thread " + CStr(num) + ": " + text
            Log("Thread " + CStr(num) + ": " + text)
            If text = "Completed" Or text = "Stopped" Then
                completions += 1
                If completions >= Me.allthreads.Count Then
                    canceller.Text = "Close"
                    t.Enabled = False
                    s.Stop()
                    Me.state.Text = "Completed in " + s.Elapsed.Hours.ToString + "hrs " + s.Elapsed.Minutes.ToString + "min " + s.Elapsed.Seconds.ToString + "sec."

                End If

            End If
        End If
    End Sub
    Delegate Sub LogCallback(ByVal text As String)
    Sub Log(ByVal [text] As String)

        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.threads.InvokeRequired Then
            Dim d As New LogCallback(AddressOf Log)
            Me.Invoke(d, New Object() {text})
        Else
            Me.logs.Text += "[" + Now.ToString + "] "
            Me.logs.Text += text
            Me.logs.Text += vbCrLf
            If Me.logs.SelectionLength <= 0 Then
                Me.logs.SelectionStart = Len(Me.logs.Text)
                Me.logs.SelectionLength = 0
                Me.logs.ScrollToCaret()
            End If
        End If
    End Sub

    Private Sub canceller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles canceller.Click
        If canceller.Text = "Close" Then
            Me.Close()
            caller.Show()
        Else
            For Each thread As CopierThread In allthreads
                thread.setStopFlag()
            Next
        End If
    End Sub
End Class