Imports MySql.Data.MySqlClient

Public Class frmStudentList
    Private Sub label2_Click(sender As Object, e As EventArgs) Handles label2.Click
        Me.Dispose()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        With frmStudent
            .txtTag.Focus()
            .btnSave.Enabled = True
            .btnUpdate.Enabled = False
            .ShowDialog()
        End With
    End Sub

    Sub LoadRecords()
        Try
            dataGridView1.Rows.Clear()
            cn.Open()
            cm = New MySqlCommand("select * from tblstudent where studentno like '" & txtSearch.Text & "' or rfid like '" & txtSearch.Text & "' or fullname like '" & txtSearch.Text & "%'", cn)
            dr = cm.ExecuteReader
            While dr.Read
                dataGridView1.Rows.Add(dataGridView1.RowCount + 1, dr.Item("id").ToString, dr.Item("studentno").ToString, dr.Item("rfid").ToString, dr.Item("fullname").ToString, dr.Item("address").ToString, dr.Item("mobileno").ToString, dr.Item("program").ToString, dr.Item("section").ToString)
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
                With frmStudent
                    cn.Open()
                    cm = New MySqlCommand("Select pic from tblstudent where id like '" & dataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                    dr = cm.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        Dim Len1 As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
                        Dim Array1(CInt(Len1)) As Byte
                        dr.GetBytes(0, 0, Array1, 0, CInt(Len1))

                        Dim MemoryStream1 As New System.IO.MemoryStream(Array1)
                        Dim Bitmap1 As New System.Drawing.Bitmap(MemoryStream1)
                        .picImage.BackgroundImage = Bitmap1
                    End If
                    dr.Close()
                    cn.Close()

                    ._id = dataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                    .txtSno.Text = dataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                    .txtTag.Text = dataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                    .txtName.Text = dataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                    .txtAddress.Text = dataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                    .txtMobile.Text = dataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
                    .txtProgram.Text = dataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
                    .txtSection.Text = dataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
                    .btnSave.Enabled = False
                    .btnUpdate.Enabled = True
                    .ShowDialog()
                End With
            ElseIf colName = "colDelete" Then
                If MsgBox("Delete record?", vbYesNo + vbQuestion) = vbYes Then
                    cn.Open()
                    cm = New MySqlCommand("delete from tblstudent where id like '" & dataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                    cm.ExecuteNonQuery()
                    cn.Close()
                    MsgBox("Record successfully deleted.", vbInformation)
                    LoadRecords()
                End If
            End If
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadRecords()
    End Sub
End Class