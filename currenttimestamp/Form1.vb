Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ntim As DateTime = Now()
        Dim tmst As String = ntim.Year.ToString("0000")
        tmst &= ntim.Month.ToString("00")
        tmst &= ntim.Day.ToString("00")
        tmst &= ntim.Hour.ToString("00")
        tmst &= ntim.Minute.ToString("00")
        tmst &= ntim.Second.ToString("00")

        Me.TextBox1.Text = tmst

        'クリップボードに文字列をコピーする
        Clipboard.SetText(tmst)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ntim As DateTime = Now()
        Dim tmst As String = dt2unepocht(ntim)
        Me.TextBox2.Text = tmst

        'クリップボードに文字列をコピーする
        Clipboard.SetText(tmst)

    End Sub
End Class
