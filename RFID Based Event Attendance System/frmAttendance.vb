Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmAttendance
    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetEvent()
        Me.KeyPreview = True
        Clear()
    End Sub

    Private Sub frmAttendance_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim intY As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = intX
        Me.Height = intY - 40
        Me.Left = 0
        Me.Top = 0

        Panel1.Top = (Me.Height - Panel1.Height) / 2
        Panel1.Left = (Me.Width - Panel1.Width) / 2

    End Sub

    Sub UnLoadForm()
        With frmSelect
            .Dispose()
        End With
    End Sub

    Sub GetEvent()
        cn.Open()
        cm = New MySqlCommand("select * from tblevent where status like 'OPEN'", cn)
        dr = cm.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            lblEventID.Text = dr.Item("eventid").ToString
            lblEvent.Text = dr.Item("event").ToString & " - " & lblLType.Text
        End If
        dr.Close()
        cn.Close()
        txtTag.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Now.ToLongDateString
        lblDT.Text = Now.ToLongTimeString
    End Sub

    Sub Clear()
        PictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath & "\man1.png")
        txtTag.Focus()
        txtTag.SelectionStart = 0
        txtTag.SelectionLength = txtTag.Text.Length
    End Sub

    Private Sub frmAttendance_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()
        End If
    End Sub

    Private Sub txtTag_TextChanged(sender As Object, e As EventArgs) Handles txtTag.TextChanged
        If txtTag.TextLength = 11 Then
            getStudentDetails()
            SaveLogHistory()
            txtTag.Focus()
            txtTag.SelectionStart = 0
            txtTag.SelectionLength = txtTag.Text.Length
        End If
    End Sub

    Sub SaveLogHistory()
        Dim sdate As String = Now.ToString("yyyy-MM-dd")
        Dim found As Boolean = False

        '---------------------------------------------------------
        If lblLType.Text = "LOGIN AM" Then
            cn.Open()
            cm = New MySqlCommand("select * from tbllog where studentno = @studentno and eventid = @eventid and sdate = @sdate", cn)
            cm.Parameters.AddWithValue("@studentno", lblID.Text)
            cm.Parameters.AddWithValue("@eventid", lblEventID.Text)
            cm.Parameters.AddWithValue("@sdate", sdate)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then found = True Else found = False
            dr.Close()
            cn.Close()

            If found = True Then
                cn.Open()
                cm = New MySqlCommand("update  tbllog set amin =@amin where eventid = @eventid and studentno = @studentno and sdate = @sdate", cn)
                cm.Parameters.AddWithValue("@amin", Now.ToShortTimeString)
                cm.Parameters.AddWithValue("@eventid", lblEventID.Text)
                cm.Parameters.AddWithValue("@studentno", lblID.Text)
                cm.Parameters.AddWithValue("@sdate", sdate)
                cm.ExecuteNonQuery()
                cn.Close()
            Else
                cn.Open()
                cm = New MySqlCommand("insert into tbllog(eventid, studentno, sdate,amin)values(@eventid, @studentno, @sdate,@amin)", cn)
                cm.Parameters.AddWithValue("@eventid", lblEventID.Text)
                cm.Parameters.AddWithValue("@studentno", lblID.Text)
                cm.Parameters.AddWithValue("@sdate", sdate)
                cm.Parameters.AddWithValue("@amin", Now.ToShortTimeString)
                cm.ExecuteNonQuery()
                cn.Close()
            End If
        ElseIf lblLType.Text = "LOGOUT AM" Then
            cn.Open()
            cm = New MySqlCommand("select * from tbllog where studentno = @studentno and eventid = @eventid and sdate = @sdate", cn)
            cm.Parameters.AddWithValue("@studentno", lblID.Text)
            cm.Parameters.AddWithValue("@eventid", lblEventID.Text)
            cm.Parameters.AddWithValue("@sdate", sdate)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then found = True Else found = False
            dr.Close()
            cn.Close()

            If found = True Then
                cn.Open()
                cm = New MySqlCommand("update  tbllog set amout =@amout where eventid = @eventid and studentno = @studentno and sdate = @sdate", cn)
                cm.Parameters.AddWithValue("@amout", Now.ToShortTimeString)
                cm.Parameters.AddWithValue("@eventid", lblEventID.Text)
                cm.Parameters.AddWithValue("@studentno", lblID.Text)
                cm.Parameters.AddWithValue("@sdate", sdate)
                cm.ExecuteNonQuery()
                cn.Close()
            Else
                cn.Open()
                cm = New MySqlCommand("insert into tbllog(eventid, studentno, sdate,amout)values(@eventid, @studentno, @sdate,@amout)", cn)
                cm.Parameters.AddWithValue("@eventid", lblEventID.Text)
                cm.Parameters.AddWithValue("@studentno", lblID.Text)
                cm.Parameters.AddWithValue("@sdate", sdate)
                cm.Parameters.AddWithValue("@amout", Now.ToShortTimeString)
                cm.ExecuteNonQuery()
                cn.Close()
            End If
        ElseIf lblLType.Text = "LOGIN PM" Then
            cn.Open()
            cm = New MySqlCommand("select * from tbllog where studentno = @studentno and eventid = @eventid and sdate = @sdate", cn)
            cm.Parameters.AddWithValue("@studentno", lblID.Text)
            cm.Parameters.AddWithValue("@eventid", lblEventID.Text)
            cm.Parameters.AddWithValue("@sdate", sdate)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then found = True Else found = False
            dr.Close()
            cn.Close()

            If found = True Then
                cn.Open()
                cm = New MySqlCommand("update  tbllog set pmin =@pmin where eventid = @eventid and studentno = @studentno and sdate = @sdate", cn)
                cm.Parameters.AddWithValue("@pmin", Now.ToShortTimeString)
                cm.Parameters.AddWithValue("@eventid", lblEventID.Text)
                cm.Parameters.AddWithValue("@studentno", lblID.Text)
                cm.Parameters.AddWithValue("@sdate", sdate)
                cm.ExecuteNonQuery()
                cn.Close()
            Else
                cn.Open()
                cm = New MySqlCommand("insert into tbllog(eventid, studentno, sdate,pmin)values(@eventid, @studentno, @sdate,@pmin)", cn)
                cm.Parameters.AddWithValue("@eventid", lblEventID.Text)
                cm.Parameters.AddWithValue("@studentno", lblID.Text)
                cm.Parameters.AddWithValue("@sdate", sdate)
                cm.Parameters.AddWithValue("@pmin", Now.ToShortTimeString)
                cm.ExecuteNonQuery()
                cn.Close()
            End If
        ElseIf lblLType.Text = "LOGOUT PM" Then
            cn.Open()
            cm = New MySqlCommand("select * from tbllog where studentno = @studentno and eventid = @eventid and sdate = @sdate", cn)
            cm.Parameters.AddWithValue("@studentno", lblID.Text)
            cm.Parameters.AddWithValue("@eventid", lblEventID.Text)
            cm.Parameters.AddWithValue("@sdate", sdate)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then found = True Else found = False
            dr.Close()
            cn.Close()

            If found = True Then
                cn.Open()
                cm = New MySqlCommand("update  tbllog set pmout =@pmout where eventid = @eventid and studentno = @studentno and sdate = @sdate", cn)
                cm.Parameters.AddWithValue("@pmout", Now.ToShortTimeString)
                cm.Parameters.AddWithValue("@eventid", lblEventID.Text)
                cm.Parameters.AddWithValue("@studentno", lblID.Text)
                cm.Parameters.AddWithValue("@sdate", sdate)
                cm.ExecuteNonQuery()
                cn.Close()
            Else
                cn.Open()
                cm = New MySqlCommand("insert into tbllog(eventid, studentno, sdate,pmout)values(@eventid, @studentno, @sdate,@pmout)", cn)
                cm.Parameters.AddWithValue("@eventid", lblEventID.Text)
                cm.Parameters.AddWithValue("@studentno", lblID.Text)
                cm.Parameters.AddWithValue("@sdate", sdate)
                cm.Parameters.AddWithValue("@pmout", Now.ToShortTimeString)
                cm.ExecuteNonQuery()
                cn.Close()
            End If
        End If
    End Sub

    Sub getStudentDetails()
        Try
            cn.Open()
            cm = New MySqlCommand("select pic, studentno, fullname, program, section from tblstudent where rfid = @rfid", cn)
            cm.Parameters.AddWithValue("@rfid", txtTag.Text)
            dr = cm.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblID.Text = dr.Item("studentno").ToString
                lblName.Text = dr.Item("fullname").ToString
                lblProgram.Text = dr.Item("program").ToString & " - " & dr.Item("section").ToString
                If lblLType.Text = "LOGIN AM" Or lblLType.Text = "LOGIN PM" Then
                    lblMsg.Text = lblName.Text & " HAS BEEN SUCCESSFULLY LOGIN " & Now.ToLongTimeString
                Else
                    lblMsg.Text = lblName.Text & " HAS BEEN SUCCESSFULLY LOGOUT " & Now.ToLongTimeString
                End If
            End If
                dr.Close()
            cn.Close()

            cn.Open()
            cm = Nothing
            cm = New MySqlCommand("select pic from tblstudent where rfid like @rfid", cn)
            cm.Parameters.AddWithValue("@rfid", txtTag.Text)
            Dim imageData As Byte() = DirectCast(cm.ExecuteScalar(), Byte())
            If Not imageData Is Nothing Then
                Using ms As New MemoryStream(imageData, 0, imageData.Length)
                    ms.Write(imageData, 0, imageData.Length)
                    PictureBox1.BackgroundImage = Image.FromStream(ms, True)
                End Using
            End If
            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        txtTag.Focus()
        txtTag.SelectionStart = 0
        txtTag.SelectionLength = txtTag.Text.Length
    End Sub

    Private Sub frmAttendance_Click(sender As Object, e As EventArgs) Handles Me.Click
        txtTag.Focus()
        txtTag.SelectionStart = 0
        txtTag.SelectionLength = txtTag.Text.Length
    End Sub
End Class