Imports MySql.Data.MySqlClient
Public Class frmEvent
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Me.Dispose()
    End Sub

    Sub Clear()
        GenerateEventID()
        txtEvent.Clear()
        cboStatus.Text = ""
        btnSave.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Sub GenerateEventID()
        Dim rand As New Random
        Dim x As Integer = 0, found As Boolean = False
        Dim genid As String = ""
        For x = 0 To 5
            genid &= rand.Next(0, 9)
        Next
        cn.Open()
        cm = New MySqlCommand("select * from tblevent where eventid like '" & genid & "'", cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            found = True
        Else
            found = False
        End If
        dr.Close()
        cn.Close()
        If found = True Then
            GenerateEventID()
        Else
            txtID.Text = genid
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If IS_EMPTY(txtID) = True Then Return
            If IS_EMPTY(txtEvent) = True Then Return
            If IS_EMPTY(cboStatus) = True Then Return
            If MsgBox("Save new event?", vbYesNo + vbQuestion) = vbYes Then
                If cboStatus.Text = "OPEN" Then
                    cn.Open()
                    cm = New MySqlCommand("update tblevent set status = 'Close'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                End If
                cn.Open()
                cm = New MySqlCommand("insert into tblevent(eventid, event, penalty, status) values(@eventid, @event, @penalty, @status)", cn)
                With cm
                    .Parameters.AddWithValue("@eventid", txtID.Text)
                    .Parameters.AddWithValue("@event", txtEvent.Text)
                    .Parameters.AddWithValue("@penalty", CDbl(txtPenalty.Text))
                    .Parameters.AddWithValue("@status", cboStatus.Text)
                End With
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Event successfully saved.", vbInformation)
                frmEventList.LoadRecords()
                Clear()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub cboRestricted_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub cboStatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboStatus.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If IS_EMPTY(txtID) = True Then Return
            If IS_EMPTY(txtEvent) = True Then Return
            If IS_EMPTY(cboStatus) = True Then Return
            If MsgBox("Update this event?", vbYesNo + vbQuestion) = vbYes Then
                If cboStatus.Text = "OPEN" Then
                    cn.Open()
                    cm = New MySqlCommand("update tblevent set status = 'Close'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                End If
                cn.Open()
                cm = New MySqlCommand("update tblevent set event=@event, penalty=@penalty, status=@status where eventid = @eventid", cn)
                With cm
                    .Parameters.AddWithValue("@event", txtEvent.Text)
                    .Parameters.AddWithValue("@status", cboStatus.Text)
                    .Parameters.AddWithValue("@penalty", CDbl(txtPenalty.Text))
                    .Parameters.AddWithValue("@eventid", txtID.Text)
                End With
                cm.ExecuteNonQuery()
                cn.Close()
                MsgBox("Event successfully updated.", vbInformation)
                frmEventList.LoadRecords()
                Clear()
                Me.Dispose()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Clear()
    End Sub
End Class