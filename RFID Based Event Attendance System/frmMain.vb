Imports Tulpep.NotificationWindow
Public Class frmMain
    Sub NotifyUser()
        Dim popup = New PopupNotifier
        popup.TitleText = "WELCOME USER"
        popup.ContentText = _name & vbNewLine & Now.ToLongDateString & vbNewLine & Now.ToLongTimeString
        popup.Popup()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize

    End Sub
    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        With frmStudentList
            .TopLevel = False
            Panel2.Controls.Add(frmStudentList)
            .LoadRecords()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With frmEventList
            .TopLevel = False
            Panel2.Controls.Add(frmEventList)
            .LoadRecords()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        With frmLogs
            .TopLevel = False
            Panel2.Controls.Add(frmLogs)
            .LoadEvent()
            ' .LoadRecords()
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Exit()
    End Sub
End Class
