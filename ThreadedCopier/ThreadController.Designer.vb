<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThreadController
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.canceller = New System.Windows.Forms.Button()
        Me.state = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.threads = New System.Windows.Forms.ListBox()
        Me.logs = New System.Windows.Forms.TextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'canceller
        '
        Me.canceller.Location = New System.Drawing.Point(191, 245)
        Me.canceller.Name = "canceller"
        Me.canceller.Size = New System.Drawing.Size(75, 23)
        Me.canceller.TabIndex = 0
        Me.canceller.Text = "Cancel"
        Me.canceller.UseVisualStyleBackColor = True
        '
        'state
        '
        Me.state.AutoSize = True
        Me.state.Location = New System.Drawing.Point(13, 231)
        Me.state.Name = "state"
        Me.state.Size = New System.Drawing.Size(59, 12)
        Me.state.TabIndex = 2
        Me.state.Text = "Preparing..."
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(15, 12)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.threads)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.logs)
        Me.SplitContainer1.Size = New System.Drawing.Size(427, 213)
        Me.SplitContainer1.SplitterDistance = 142
        Me.SplitContainer1.TabIndex = 3
        '
        'threads
        '
        Me.threads.Dock = System.Windows.Forms.DockStyle.Fill
        Me.threads.FormattingEnabled = True
        Me.threads.ItemHeight = 12
        Me.threads.Location = New System.Drawing.Point(0, 0)
        Me.threads.Name = "threads"
        Me.threads.Size = New System.Drawing.Size(142, 213)
        Me.threads.TabIndex = 2
        '
        'logs
        '
        Me.logs.BackColor = System.Drawing.Color.White
        Me.logs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.logs.Location = New System.Drawing.Point(0, 0)
        Me.logs.Multiline = True
        Me.logs.Name = "logs"
        Me.logs.ReadOnly = True
        Me.logs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.logs.Size = New System.Drawing.Size(281, 213)
        Me.logs.TabIndex = 0
        '
        'ThreadController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 280)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.state)
        Me.Controls.Add(Me.canceller)
        Me.Name = "ThreadController"
        Me.Text = "ThreadController"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents canceller As System.Windows.Forms.Button
    Friend WithEvents state As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents threads As System.Windows.Forms.ListBox
    Friend WithEvents logs As System.Windows.Forms.TextBox
End Class
