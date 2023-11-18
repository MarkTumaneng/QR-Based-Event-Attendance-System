Imports MySql.Data.MySqlClient
Module Module1
    Public cn As New MySqlConnection
    Public cm As New MySqlCommand
    Public dr As MySqlDataReader
    Public _user As String
    Public _name As String
    Public _pass As String
    Sub Connection()
        With cn
            .ConnectionString = "server=localhost;user id=root;password=;database=rfidevent;"
        End With
    End Sub

    Public Function IS_EMPTY(ByRef sText As Object) As Boolean
        On Error Resume Next
        If sText.Text = "" Then
            IS_EMPTY = True
            MsgBox("WARNING: REQUIRED MISSING FIELD.", vbExclamation)
            sText.BackColor = Color.LemonChiffon
            sText.SetFocus()
        Else
            IS_EMPTY = False
            sText.BackColor = Color.FromArgb(240, 240, 240)
        End If
        Return IS_EMPTY
    End Function
End Module
