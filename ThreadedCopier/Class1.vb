Public Class CopierThread
    Dim WithEvents t As New System.ComponentModel.BackgroundWorker
    Dim del As ThreadController
    Dim myidx As Integer
    Dim lastTimeThroughput As Integer = 0 'length/time
    Dim filePath As String
    Dim target As String
    Property mustStop As Boolean
    Sub beginForDest(ByVal dest As String, ByVal deleg As ThreadController, ByVal idx As Integer)
        del = deleg
        myidx = idx
        
        target = dest
        doneWork()

    End Sub

   


    Sub work() Handles t.DoWork
        Try
            Dim t As New System.Diagnostics.Stopwatch
            t.Reset()
            t.Start()
            Dim destFN = target
            Dim ssrc = Split(filePath, Split(target, "\").Last + "\")
            destFN += "\" + ssrc.Last
            My.Computer.FileSystem.CopyFile(filePath, destFN, FileIO.UIOption.OnlyErrorDialogs)
            t.Stop()
            lastTimeThroughput = t.Elapsed.TotalSeconds
        Catch ex As Exception
            MsgBox("Thread " + myidx.ToString + " got an exception: " + ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Whooch")
            del.PushEvt("Exception! " + ex.Message, myidx)
        End Try
    End Sub
    Sub setStopFlag()
        del.PushEvt("Stopping after " + Split(filePath, "\").Last, myidx)
        mustStop = True
    End Sub
    Sub doneWork() Handles t.RunWorkerCompleted
        If del.anyMoreFiles And Not mustStop Then
            If lastTimeThroughput <> Nothing And lastTimeThroughput > 0 Then del.PushEvt("Copying " + filePath.Split("\").Last + " took " + lastTimeThroughput.ToString + "sec.", myidx)
            filePath = del.giveMeNextFile
            del.PushEvt("Copying " + Split(filePath, "\").Last, myidx)
            t.RunWorkerAsync()
        Else
            If Not mustStop Then del.PushEvt("Completed", myidx) Else del.PushEvt("Stopped", myidx)
        End If
    End Sub

End Class

Public Interface CopierDelegate
    Function giveMeNextFile() As String
    Function anyMoreFiles() As Boolean
    Sub PushEvt(ByVal [text] As String, ByVal num As Integer)
End Interface