<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudent
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudent))
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTag = New System.Windows.Forms.TextBox()
        Me.txtSno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProgram = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSection = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel3
        '
        Me.LinkLabel3.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.LinkLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.BackColor = System.Drawing.Color.White
        Me.LinkLabel3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel3.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.LinkLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.LinkLabel3.Image = CType(resources.GetObject("LinkLabel3.Image"), System.Drawing.Image)
        Me.LinkLabel3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel3.LinkColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.LinkLabel3.Location = New System.Drawing.Point(731, 12)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(81, 21)
        Me.LinkLabel3.TabIndex = 154
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "       CLOSE"
        Me.LinkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(63, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(2, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 24)
        Me.Label1.TabIndex = 155
        Me.Label1.Text = "STUDENT DETAILS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(43, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 21)
        Me.Label2.TabIndex = 156
        Me.Label2.Text = "RFID No"
        '
        'txtTag
        '
        Me.txtTag.BackColor = System.Drawing.Color.White
        Me.txtTag.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTag.Location = New System.Drawing.Point(125, 79)
        Me.txtTag.MaxLength = 10
        Me.txtTag.Name = "txtTag"
        Me.txtTag.Size = New System.Drawing.Size(351, 27)
        Me.txtTag.TabIndex = 157
        '
        'txtSno
        '
        Me.txtSno.BackColor = System.Drawing.Color.White
        Me.txtSno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSno.Location = New System.Drawing.Point(125, 108)
        Me.txtSno.Name = "txtSno"
        Me.txtSno.Size = New System.Drawing.Size(351, 27)
        Me.txtSno.TabIndex = 159
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(43, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 21)
        Me.Label3.TabIndex = 158
        Me.Label3.Text = "Student No"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Location = New System.Drawing.Point(125, 137)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(351, 27)
        Me.txtName.TabIndex = 161
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(43, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 21)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "Name"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Location = New System.Drawing.Point(125, 166)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(351, 52)
        Me.txtAddress.TabIndex = 163
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(43, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 21)
        Me.Label5.TabIndex = 162
        Me.Label5.Text = "Address"
        '
        'txtMobile
        '
        Me.txtMobile.BackColor = System.Drawing.Color.White
        Me.txtMobile.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMobile.Location = New System.Drawing.Point(125, 224)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(351, 27)
        Me.txtMobile.TabIndex = 165
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(43, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 21)
        Me.Label6.TabIndex = 164
        Me.Label6.Text = "Mobile No"
        '
        'txtProgram
        '
        Me.txtProgram.BackColor = System.Drawing.Color.White
        Me.txtProgram.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProgram.Location = New System.Drawing.Point(125, 253)
        Me.txtProgram.Name = "txtProgram"
        Me.txtProgram.Size = New System.Drawing.Size(351, 27)
        Me.txtProgram.TabIndex = 167
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(43, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 21)
        Me.Label7.TabIndex = 166
        Me.Label7.Text = "Program"
        '
        'txtSection
        '
        Me.txtSection.BackColor = System.Drawing.Color.White
        Me.txtSection.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSection.Location = New System.Drawing.Point(125, 282)
        Me.txtSection.Name = "txtSection"
        Me.txtSection.Size = New System.Drawing.Size(351, 27)
        Me.txtSection.TabIndex = 169
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(43, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 21)
        Me.Label8.TabIndex = 168
        Me.Label8.Text = "Section"
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.FlatAppearance.BorderSize = 0
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Location = New System.Drawing.Point(515, 311)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(226, 28)
        Me.btnBrowse.TabIndex = 171
        Me.btnBrowse.Text = "Browse Image"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'picImage
        '
        Me.picImage.BackgroundImage = CType(resources.GetObject("picImage.BackgroundImage"), System.Drawing.Image)
        Me.picImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picImage.Location = New System.Drawing.Point(515, 79)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(226, 226)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 170
        Me.picImage.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(125, 311)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(71, 28)
        Me.btnSave.TabIndex = 172
        Me.btnSave.Text = "Save"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(197, 311)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(71, 28)
        Me.btnUpdate.TabIndex = 173
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(269, 311)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(71, 28)
        Me.btnCancel.TabIndex = 174
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 372)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.picImage)
        Me.Controls.Add(Me.txtSection)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtProgram)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTag)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmStudent"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Style = MetroFramework.MetroColorStyle.Purple
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTag As TextBox
    Friend WithEvents txtSno As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtProgram As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSection As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBrowse As Button
    Friend WithEvents picImage As PictureBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
