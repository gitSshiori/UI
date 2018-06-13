Public Class Display
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles timeNow.Click

    End Sub

    Private Sub Display_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Gray

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.BackColor = Color.Crimson

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class
