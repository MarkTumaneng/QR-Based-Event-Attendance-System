Public Class frmWait
    Public seconds As Byte = 0
    Dim counter As Integer = 0
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try
            counter = counter + 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer2.Enabled = False
        Me.Dispose()
    End Sub

    Private Sub frmWait_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = seconds * 1000
        Timer2.Interval = 1000
        counter = 1

        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub
End Class