Public Class Form1
    Private this As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles sinister.Click
        lbloutput.Text = "left"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbloutput.Click
        lbloutput.Text = "left"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles dexter.Click
        lbloutput.Text = "right"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles medium.Click
        lbloutput.Text = "middle"
    End Sub

    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quit.Click
        this.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
