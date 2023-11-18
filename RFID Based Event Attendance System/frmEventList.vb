Imports MySql.Data.MySqlClient
Public Class frmEventList
    Private Sub label2_Click(sender As Object, e As EventArgs) Handles label2.Click
        Me.Dispose()
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        With frmEvent
            .GenerateEventID()
            .btnSave.Enabled = True
            .btnUpdate.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Sub LoadRecords()
        Try
            dataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("Select * from tblevent", cn)
            dr = cm.ExecuteReader
            While dr.Read
                dataGridView1.Rows.Add(dataGridView1.RowCount + 1, dr.Item("eventid").ToString, dr.Item("event").ToString, Format(CDbl(dr.Item("penalty").ToString), "#,##0.00"), dr.Item("status").ToString)
            End While
            dr.Close()
            cn.Close()
            dataGridView1.ClearSelection()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub dataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridView1.CellContentClick
        Try
            Dim colName As String = dataGridView1.Columns(e.ColumnIndex).Name
            If colName = "colEdit" Then
                cn.Open()
                cm = New MySqlCommand("select * from tblevent where eventid like '" & dataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                dr = cm.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    With frmEvent
                        .txtID.Text = dr.Item("eventid").ToString
                        .txtEvent.Text = dr.Item("event").ToString
                        .txtPenalty.Text = dr.Item("penalty").ToString
                        .cboStatus.Text = dr.Item("status").ToString
                        .btnSave.Enabled = False
                        .btnUpdate.Enabled = True
                        dr.Close()
                        cn.Close()
                        .ShowDialog()
                    End With
                Else
                    dr.Close()
                    cn.Close()
                End If
            ElseIf colName = "colDelete" Then
                If MsgBox("Delete event?", vbYesNo + vbQuestion) = vbYes Then
                    cn.Open()
                    cm = New MySqlCommand("delete from tblevent where eventid like '" & dataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Event successfully deleted.", vbInformation)
                    LoadRecords()
                End If
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class