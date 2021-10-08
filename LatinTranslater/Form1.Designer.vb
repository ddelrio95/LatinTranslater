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
        Me.sinister = New System.Windows.Forms.Button()
        Me.dexter = New System.Windows.Forms.Button()
        Me.medium = New System.Windows.Forms.Button()
        Me.quit = New System.Windows.Forms.Button()
        Me.lbloutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'sinister
        '
        Me.sinister.Location = New System.Drawing.Point(150, 208)
        Me.sinister.Name = "sinister"
        Me.sinister.Size = New System.Drawing.Size(118, 23)
        Me.sinister.TabIndex = 0
        Me.sinister.Text = "Sinister"
        Me.sinister.UseVisualStyleBackColor = True
        '
        'dexter
        '
        Me.dexter.Location = New System.Drawing.Point(460, 208)
        Me.dexter.Name = "dexter"
        Me.dexter.Size = New System.Drawing.Size(129, 23)
        Me.dexter.TabIndex = 1
        Me.dexter.Text = "Dexter"
        Me.dexter.UseVisualStyleBackColor = True
        '
        'medium
        '
        Me.medium.Location = New System.Drawing.Point(301, 208)
        Me.medium.Name = "medium"
        Me.medium.Size = New System.Drawing.Size(119, 23)
        Me.medium.TabIndex = 2
        Me.medium.Text = "Medium"
        Me.medium.UseVisualStyleBackColor = True
        '
        'quit
        '
        Me.quit.Location = New System.Drawing.Point(306, 298)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(114, 23)
        Me.quit.TabIndex = 3
        Me.quit.Text = "Exit"
        Me.quit.UseVisualStyleBackColor = True
        '
        'lbloutput
        '
        Me.lbloutput.AutoSize = True
        Me.lbloutput.Location = New System.Drawing.Point(306, 140)
        Me.lbloutput.Name = "lbloutput"
        Me.lbloutput.Size = New System.Drawing.Size(0, 15)
        Me.lbloutput.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbloutput)
        Me.Controls.Add(Me.quit)
        Me.Controls.Add(Me.medium)
        Me.Controls.Add(Me.dexter)
        Me.Controls.Add(Me.sinister)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sinister As Button
    Friend WithEvents dexter As Button
    Friend WithEvents medium As Button
    Friend WithEvents quit As Button
    Friend WithEvents lbloutput As Label
End Class
