Imports MySql.Data.MySqlClient
Public Class frmLogs
    Private Sub label2_Click(sender As Object, e As EventArgs) Handles label2.Click
        Me.Dispose()
    End Sub

    Sub LoadEvent()
        Try
            cboEvent.Items.Clear()
            cn.Open()
            cm = New MySqlCommand("select * from tblevent", cn)
            dr = cm.ExecuteReader
            While dr.Read
                cboEvent.Items.Add(dr.Item("event").ToString)
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub frmLogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Now
    End Sub

    Sub LoadRecords()
        Try
            Dim _totalpenalty As Double = 0.0
            Dim _eventid As String = ""
            Dim _total As Double = 0
            Dim _penalty As Double = 0
            cn.Open()
            cm = New MySqlCommand("select * from tblevent where event Like '" & cboEvent.Text & "'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                _eventid = dr.Item("eventid").ToString
                _penalty = CDbl(dr.Item("penalty").ToString)
            End While
            dr.Close()
            cn.Close()

            Dim sdate1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
            Dim sdate2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")
            dataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("SELECT s.studentno, s.fullname, concat(s.program , ' ' , s.section) as section,  ifnull(l.eventid,'" & lblEventID.Text & "'),l.id, ifnull(l.sdate,'" & sdate1 & "') as sdate, ifnull(l.amin,'---------------') as amin, ifnull(l.amout,'---------------') as amout, ifnull(l.pmin,'---------------') as pmin, ifnull(l.pmout,'---------------') as pmout, if(l.amin = '---------------',1,0) as am_in, if(l.amout = '---------------',1,0) as am_out,if(l.pmin = '---------------',1,0) as pm_in,if(l.pmout = '---------------',1,0) as pm_out, l.total FROM tbllog AS l RIGHT JOIN tblstudent AS s ON s.studentno = l.studentno where ((l.eventid like '" & _eventid & "' and sdate between '" & sdate1 & "' and '" & sdate2 & "' or eventid is null) and fullname like '" & txtSearch.Text & "%') order by sdate, section, fullname", cn)
            dr = cm.ExecuteReader
            While dr.Read
                _total = (CLng(dr.Item("am_in").ToString) + CLng(dr.Item("am_out").ToString) + CLng(dr.Item("pm_in").ToString) + CLng(dr.Item("pm_out").ToString)) * CDbl(lblPenalty.Text)
                _totalpenalty += _total
                dataGridView1.Rows.Add(dataGridView1.RowCount + 1, dr.Item("id").ToString, lblEventID.Text, cboEvent.Text, dr.Item("studentno").ToString, dr.Item("fullname").ToString, dr.Item("section").ToString, Format(CDate(dr.Item("sdate").ToString), "MM-dd-yyyy"), CDbl(lblPenalty.Text), dr.Item("amin").ToString, dr.Item("amout").ToString, dr.Item("pmin").ToString, dr.Item("pmout").ToString, Format(_total, "#,##0.00"))
            End While
            dr.Close()
            cn.Close()
            lblTotal.Text = Format(_totalpenalty, "₱ #,##0.00")
            UpdateData()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub UpdateData()
        Try
            Dim i As Integer = 0
            For i = 0 To dataGridView1.Rows.Count - 1
                cn.Open()
                cm = New MySqlCommand("update tbllog set total = '" & CDbl(dataGridView1.Rows(i).Cells(13).Value.ToString) & "' where id like '" & dataGridView1.Rows(i).Cells(1).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()
                cn.Close()
            Next
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub cboEvent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEvent.SelectedIndexChanged
        Try
            cn.Open()
            cm = New MySqlCommand("select * from tblevent where event = @event", cn)
            cm.Parameters.AddWithValue("@event", cboEvent.Text)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblEventID.Text = dr.Item("eventid").ToString
                lblPenalty.Text = dr.Item("penalty").ToString
            Else
                lblEventID.Text = ""
                lblPenalty.Text = ""
            End If
            dr.Close()
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        cboEvent_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoadRecords()
    End Sub
End Class