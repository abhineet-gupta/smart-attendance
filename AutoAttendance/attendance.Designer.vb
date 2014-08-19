<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class attendance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ScanButton = New System.Windows.Forms.Button()
        Me.LabelClass = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.TextBoxClass = New System.Windows.Forms.TextBox()
        Me.TextBoxInstEm = New System.Windows.Forms.TextBox()
        Me.LabelInstEmail = New System.Windows.Forms.Label()
        Me.LabelIDs = New System.Windows.Forms.Label()
        Me.LabelSIDLabel = New System.Windows.Forms.Label()
        Me.ButtonEmail = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxPW = New System.Windows.Forms.TextBox()
        Me.TextBoxUN = New System.Windows.Forms.TextBox()
        Me.TextBoxServer = New System.Windows.Forms.TextBox()
        Me.LabelServer = New System.Windows.Forms.Label()
        Me.TextBoxFrom = New System.Windows.Forms.TextBox()
        Me.LabelFrom = New System.Windows.Forms.Label()
        Me.CheckBoxSSL = New System.Windows.Forms.CheckBox()
        Me.LabelPort = New System.Windows.Forms.Label()
        Me.ListBoxPort = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ScanButton
        '
        Me.ScanButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScanButton.Location = New System.Drawing.Point(29, 136)
        Me.ScanButton.Name = "ScanButton"
        Me.ScanButton.Size = New System.Drawing.Size(372, 62)
        Me.ScanButton.TabIndex = 4
        Me.ScanButton.Text = "Scan IDs"
        Me.ScanButton.UseVisualStyleBackColor = True
        '
        'LabelClass
        '
        Me.LabelClass.AutoSize = True
        Me.LabelClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClass.Location = New System.Drawing.Point(23, 27)
        Me.LabelClass.Name = "LabelClass"
        Me.LabelClass.Size = New System.Drawing.Size(68, 25)
        Me.LabelClass.TabIndex = 2
        Me.LabelClass.Text = "Class:"
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(229, 527)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(191, 62)
        Me.SaveButton.TabIndex = 12
        Me.SaveButton.Text = "Save as Excel File"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'TextBoxClass
        '
        Me.TextBoxClass.Location = New System.Drawing.Point(210, 31)
        Me.TextBoxClass.Name = "TextBoxClass"
        Me.TextBoxClass.Size = New System.Drawing.Size(191, 22)
        Me.TextBoxClass.TabIndex = 1
        Me.TextBoxClass.Text = "Test"
        '
        'TextBoxInstEm
        '
        Me.TextBoxInstEm.Location = New System.Drawing.Point(210, 73)
        Me.TextBoxInstEm.Name = "TextBoxInstEm"
        Me.TextBoxInstEm.Size = New System.Drawing.Size(191, 22)
        Me.TextBoxInstEm.TabIndex = 2
        Me.TextBoxInstEm.Text = "@usp.ac.fj"
        '
        'LabelInstEmail
        '
        Me.LabelInstEmail.AutoSize = True
        Me.LabelInstEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInstEmail.Location = New System.Drawing.Point(23, 69)
        Me.LabelInstEmail.Name = "LabelInstEmail"
        Me.LabelInstEmail.Size = New System.Drawing.Size(151, 25)
        Me.LabelInstEmail.TabIndex = 5
        Me.LabelInstEmail.Text = "Instructor Email:"
        '
        'LabelIDs
        '
        Me.LabelIDs.AutoSize = True
        Me.LabelIDs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIDs.Location = New System.Drawing.Point(25, 287)
        Me.LabelIDs.Name = "LabelIDs"
        Me.LabelIDs.Size = New System.Drawing.Size(0, 20)
        Me.LabelIDs.TabIndex = 7
        '
        'LabelSIDLabel
        '
        Me.LabelSIDLabel.AutoSize = True
        Me.LabelSIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSIDLabel.Location = New System.Drawing.Point(24, 239)
        Me.LabelSIDLabel.Name = "LabelSIDLabel"
        Me.LabelSIDLabel.Size = New System.Drawing.Size(140, 24)
        Me.LabelSIDLabel.TabIndex = 8
        Me.LabelSIDLabel.Text = "List of Students:"
        '
        'ButtonEmail
        '
        Me.ButtonEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEmail.Location = New System.Drawing.Point(12, 527)
        Me.ButtonEmail.Name = "ButtonEmail"
        Me.ButtonEmail.Size = New System.Drawing.Size(191, 62)
        Me.ButtonEmail.TabIndex = 11
        Me.ButtonEmail.Text = "Email"
        Me.ButtonEmail.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 407)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "UN: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(207, 434)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "PW: "
        '
        'TextBoxPW
        '
        Me.TextBoxPW.Location = New System.Drawing.Point(251, 435)
        Me.TextBoxPW.Name = "TextBoxPW"
        Me.TextBoxPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPW.Size = New System.Drawing.Size(169, 22)
        Me.TextBoxPW.TabIndex = 9
        '
        'TextBoxUN
        '
        Me.TextBoxUN.Location = New System.Drawing.Point(252, 407)
        Me.TextBoxUN.Name = "TextBoxUN"
        Me.TextBoxUN.Size = New System.Drawing.Size(168, 22)
        Me.TextBoxUN.TabIndex = 8
        Me.TextBoxUN.Text = "xxxx@gmail.com"
        '
        'TextBoxServer
        '
        Me.TextBoxServer.Location = New System.Drawing.Point(252, 246)
        Me.TextBoxServer.Name = "TextBoxServer"
        Me.TextBoxServer.Size = New System.Drawing.Size(168, 22)
        Me.TextBoxServer.TabIndex = 5
        Me.TextBoxServer.Text = "smtp.gmail.com"
        '
        'LabelServer
        '
        Me.LabelServer.AutoSize = True
        Me.LabelServer.Location = New System.Drawing.Point(192, 246)
        Me.LabelServer.Name = "LabelServer"
        Me.LabelServer.Size = New System.Drawing.Size(54, 17)
        Me.LabelServer.TabIndex = 17
        Me.LabelServer.Text = "Server:"
        '
        'TextBoxFrom
        '
        Me.TextBoxFrom.Location = New System.Drawing.Point(251, 463)
        Me.TextBoxFrom.Name = "TextBoxFrom"
        Me.TextBoxFrom.Size = New System.Drawing.Size(169, 22)
        Me.TextBoxFrom.TabIndex = 10
        Me.TextBoxFrom.Text = "xxxx@gmail.com"
        '
        'LabelFrom
        '
        Me.LabelFrom.AutoSize = True
        Me.LabelFrom.Location = New System.Drawing.Point(207, 468)
        Me.LabelFrom.Name = "LabelFrom"
        Me.LabelFrom.Size = New System.Drawing.Size(48, 17)
        Me.LabelFrom.TabIndex = 19
        Me.LabelFrom.Text = "From: "
        '
        'CheckBoxSSL
        '
        Me.CheckBoxSSL.AutoSize = True
        Me.CheckBoxSSL.Checked = True
        Me.CheckBoxSSL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxSSL.Location = New System.Drawing.Point(251, 354)
        Me.CheckBoxSSL.Name = "CheckBoxSSL"
        Me.CheckBoxSSL.Size = New System.Drawing.Size(85, 21)
        Me.CheckBoxSSL.TabIndex = 7
        Me.CheckBoxSSL.Text = "Use SSL"
        Me.CheckBoxSSL.UseVisualStyleBackColor = True
        '
        'LabelPort
        '
        Me.LabelPort.AutoSize = True
        Me.LabelPort.Location = New System.Drawing.Point(207, 276)
        Me.LabelPort.Name = "LabelPort"
        Me.LabelPort.Size = New System.Drawing.Size(38, 17)
        Me.LabelPort.TabIndex = 21
        Me.LabelPort.Text = "Port:"
        '
        'ListBoxPort
        '
        Me.ListBoxPort.FormattingEnabled = True
        Me.ListBoxPort.ItemHeight = 16
        Me.ListBoxPort.Items.AddRange(New Object() {"25", "587", "465", "443"})
        Me.ListBoxPort.Location = New System.Drawing.Point(252, 276)
        Me.ListBoxPort.Name = "ListBoxPort"
        Me.ListBoxPort.Size = New System.Drawing.Size(85, 68)
        Me.ListBoxPort.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(28, 297)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 188)
        Me.TextBox1.TabIndex = 22
        '
        'attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 601)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBoxPort)
        Me.Controls.Add(Me.LabelPort)
        Me.Controls.Add(Me.CheckBoxSSL)
        Me.Controls.Add(Me.TextBoxFrom)
        Me.Controls.Add(Me.LabelFrom)
        Me.Controls.Add(Me.TextBoxServer)
        Me.Controls.Add(Me.LabelServer)
        Me.Controls.Add(Me.TextBoxUN)
        Me.Controls.Add(Me.TextBoxPW)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonEmail)
        Me.Controls.Add(Me.LabelSIDLabel)
        Me.Controls.Add(Me.LabelIDs)
        Me.Controls.Add(Me.TextBoxInstEm)
        Me.Controls.Add(Me.LabelInstEmail)
        Me.Controls.Add(Me.TextBoxClass)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.LabelClass)
        Me.Controls.Add(Me.ScanButton)
        Me.Name = "attendance"
        Me.Text = "Student ID Scanner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ScanButton As System.Windows.Forms.Button
    Friend WithEvents LabelClass As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents TextBoxClass As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxInstEm As System.Windows.Forms.TextBox
    Friend WithEvents LabelInstEmail As System.Windows.Forms.Label
    Friend WithEvents LabelIDs As System.Windows.Forms.Label
    Friend WithEvents LabelSIDLabel As System.Windows.Forms.Label
    Friend WithEvents ButtonEmail As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPW As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUN As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxServer As System.Windows.Forms.TextBox
    Friend WithEvents LabelServer As System.Windows.Forms.Label
    Friend WithEvents TextBoxFrom As System.Windows.Forms.TextBox
    Friend WithEvents LabelFrom As System.Windows.Forms.Label
    Friend WithEvents CheckBoxSSL As System.Windows.Forms.CheckBox
    Friend WithEvents LabelPort As System.Windows.Forms.Label
    Friend WithEvents ListBoxPort As System.Windows.Forms.ListBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
