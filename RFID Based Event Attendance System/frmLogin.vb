Imports MySql.Data.MySqlClient
Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim found As Boolean = False
            If IS_EMPTY(txtUser) = True Then Return
            If IS_EMPTY(txtPass) = True Then Return
            cn.Open()
            cm = New MySqlCommand("select * from tbluser where username = @username and password =@password", cn)
            With cm
                .Parameters.AddWithValue("@username", txtUser.Text)
                .Parameters.AddWithValue("@password", txtPass.Text)
            End With
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                found = True
                _user = dr.Item("username").ToString
                _name = dr.Item("name").ToString
            End If
            dr.Close()
            cn.Close()

            If found = True Then
                With frmMain
                    txtPass.Clear()
                    txtPass.Clear()
                    Me.Hide()
                    .NotifyUser()
                    .ShowDialog()
                End With
            Else
                MsgBox("INVALID USERNAME AND PASSWORD", vbCritical)
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        With frmSelect
            .Show()
        End With
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class