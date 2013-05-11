<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.go = New System.Windows.Forms.Button()
        Me.sf = New System.Windows.Forms.TextBox()
        Me.src = New System.Windows.Forms.Button()
        Me.dest = New System.Windows.Forms.Button()
        Me.df = New System.Windows.Forms.TextBox()
        Me.folders = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'go
        '
        Me.go.Enabled = False
        Me.go.Location = New System.Drawing.Point(109, 113)
        Me.go.Name = "go"
        Me.go.Size = New System.Drawing.Size(75, 23)
        Me.go.TabIndex = 0
        Me.go.Text = "Go"
        Me.go.UseVisualStyleBackColor = True
        '
        'sf
        '
        Me.sf.Location = New System.Drawing.Point(13, 13)
        Me.sf.Name = "sf"
        Me.sf.Size = New System.Drawing.Size(210, 19)
        Me.sf.TabIndex = 1
        '
        'src
        '
        Me.src.Location = New System.Drawing.Point(230, 11)
        Me.src.Name = "src"
        Me.src.Size = New System.Drawing.Size(50, 23)
        Me.src.TabIndex = 2
        Me.src.Text = "Src"
        Me.src.UseVisualStyleBackColor = True
        '
        'dest
        '
        Me.dest.Location = New System.Drawing.Point(230, 55)
        Me.dest.Name = "dest"
        Me.dest.Size = New System.Drawing.Size(50, 23)
        Me.dest.TabIndex = 4
        Me.dest.Text = "Dest"
        Me.dest.UseVisualStyleBackColor = True
        '
        'df
        '
        Me.df.BackColor = System.Drawing.Color.White
        Me.df.Location = New System.Drawing.Point(13, 57)
        Me.df.Name = "df"
        Me.df.ReadOnly = True
        Me.df.Size = New System.Drawing.Size(210, 19)
        Me.df.TabIndex = 3
        '
        'folders
        '
        Me.folders.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "to"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(160, 88)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 19)
        Me.NumericUpDown1.TabIndex = 6
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Threads:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "vladkorotnev 2013"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 167)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dest)
        Me.Controls.Add(Me.df)
        Me.Controls.Add(Me.src)
        Me.Controls.Add(Me.sf)
        Me.Controls.Add(Me.go)
        Me.Name = "Form1"
        Me.Text = "ThreadedCopier"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents go As System.Windows.Forms.Button
    Friend WithEvents sf As System.Windows.Forms.TextBox
    Friend WithEvents src As System.Windows.Forms.Button
    Friend WithEvents dest As System.Windows.Forms.Button
    Friend WithEvents df As System.Windows.Forms.TextBox
    Friend WithEvents folders As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
