Imports MySql.Data.MySqlClient
Public Class frmStudent
    Public _id As String
    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Me.Dispose()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using O As New OpenFileDialog With {.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif|Ico | *.ico", .Multiselect = False, .Title = "Select Image"}
            If O.ShowDialog = 1 Then
                picImage.BackgroundImage = Image.FromFile(O.FileName)
                OpenFileDialog1.FileName = O.FileName
            End If
        End Using
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If IS_EMPTY(txtSno) = True Then Return
            If IS_EMPTY(txtName) = True Then Return
            If IS_EMPTY(txtProgram) = True Then Return
            If IS_EMPTY(txtSection) = True Then Return

            If MsgBox("Save record?.", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                With cm
                    .Connection = cn
                    .CommandType = CommandType.Text
                    .CommandText = "insert into tblstudent (studentno,rfid, fullname, address, mobileno, program, section, pic) values(@studentno,@rfid, @fullname, @address, @mobileno, @program, @section, @pic)"

                    Dim mstream As New System.IO.MemoryStream()
                    picImage.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim arrImage() As Byte = mstream.GetBuffer()

                    .Parameters.AddWithValue("@studentno", txtSno.Text)
                    .Parameters.AddWithValue("@rfid", txtTag.Text)
                    .Parameters.AddWithValue("@fullname", txtName.Text)
                    .Parameters.AddWithValue("@address", txtAddress.Text)
                    .Parameters.AddWithValue("@mobileno", txtMobile.Text)
                    .Parameters.AddWithValue("@program", txtProgram.Text)
                    .Parameters.AddWithValue("@section", txtSection.Text)
                    .Parameters.AddWithValue("@pic", arrImage)
                    .ExecuteNonQuery()
                    frmWait.seconds = 1
                    frmWait.ShowDialog()
                    MsgBox("Record successfully saved.", vbInformation)
                End With
                cn.Close()
                Clear()
                frmStudentList.LoadRecords()
                txtTag.Focus()
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Clear()
        txtAddress.Clear()
        txtMobile.Clear()
        txtName.Clear()
        txtSno.Clear()
        txtTag.Clear()
        txtTag.Focus()
        picImage.BackgroundImage = Image.FromFile(Application.StartupPath & "\man1.png")
        btnSave.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If IS_EMPTY(txtTag) = True Then Return
            If IS_EMPTY(txtSno) = True Then Return
            If IS_EMPTY(txtName) = True Then Return
            If IS_EMPTY(txtProgram) = True Then Return
            If IS_EMPTY(txtSection) = True Then Return
            If MsgBox("Update record?", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                With cm
                    .Connection = cn
                    .CommandType = CommandType.Text
                    If OpenFileDialog1.FileName <> "OpenFileDialog1" Then
                        .CommandText = "update tblstudent set studentno=@studentno,rfid=@rfid, fullname=@fullname, address=@address, mobileno=@mobileno, program=@program, section=@section, pic=@pic where id = @id"
                    Else
                        .CommandText = "update tblstudent set studentno=@studentno,rfid=@rfid, fullname=@fullname, address=@address, mobileno=@mobileno, program=@program, section=@section  where id = @id"
                    End If
                    Dim mstream As New System.IO.MemoryStream()
                    picImage.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim arrImage() As Byte = mstream.GetBuffer()

                    .Parameters.AddWithValue("@studentno", txtSno.Text)
                    .Parameters.AddWithValue("@rfid", txtTag.Text)
                    .Parameters.AddWithValue("@fullname", txtName.Text)
                    .Parameters.AddWithValue("@address", txtAddress.Text)
                    .Parameters.AddWithValue("@mobileno", txtMobile.Text)
                    .Parameters.AddWithValue("@program", txtProgram.Text)
                    .Parameters.AddWithValue("@section", txtSection.Text)
                    If OpenFileDialog1.FileName <> "OpenFileDialog1" Then .Parameters.AddWithValue("@pic", arrImage)
                    .Parameters.AddWithValue("@id", _id)
                    .ExecuteNonQuery()
                    frmWait.seconds = 1
                    frmWait.ShowDialog()
                    MsgBox("Record successfully updated.", vbInformation)
                End With
                cn.Close()
                Clear()
                frmStudentList.LoadRecords()
                txtTag.Focus()
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