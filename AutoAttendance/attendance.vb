Imports System.Net.Mail

Public Class attendance
    Public Function ExecuteCommand(ByVal filePath As String, ByVal arguments As String) As String
        Dim p As Process
        p = New Process()
        p.StartInfo.FileName = filePath
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardInput = True
        p.StartInfo.RedirectStandardOutput = True
        p.Start()
        p.WaitForExit()
        Return p.StandardOutput.ReadToEnd()
    End Function

    Public Class CommandExecutor
        Implements IDisposable

        Public Event OutputRead(ByVal output As String)

        Private WithEvents _process As Process

        Public Sub Execute(ByVal filePath As String, ByVal arguments As String)
            If _process IsNot Nothing Then
                Throw New Exception("Already watching process")
            End If
            _process = New Process()
            _process.StartInfo.FileName = filePath
            _process.StartInfo.CreateNoWindow = True
            _process.StartInfo.Arguments = arguments
            _process.StartInfo.UseShellExecute = False
            _process.StartInfo.RedirectStandardInput = True
            _process.StartInfo.RedirectStandardOutput = True
            _process.Start()
            _process.BeginOutputReadLine()
        End Sub

        Private Sub _process_OutputDataReceived(ByVal sender As Object, ByVal e As System.Diagnostics.DataReceivedEventArgs) Handles _process.OutputDataReceived
            If _process.HasExited Then
                _process.Dispose()
                _process = Nothing
            End If
            RaiseEvent OutputRead(e.Data)
        End Sub

        Private disposedValue As Boolean = False
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    If _process IsNot Nothing Then
                        _process.Kill()
                        _process.Dispose()
                        _process = Nothing
                    End If
                End If
            End If
            Me.disposedValue = True
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
    End Class

    Private WithEvents _commandExecutor As New CommandExecutor()

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScanButton.Click
        _commandExecutor.Execute("C:\Program Files (x86)\ZBarw\bin\zbarcam.exe", "--raw")
        'ZBar is the barcode scanner that is required to be installed, change the .exe path above accordingly
    End Sub

    Private Sub _commandExecutor_OutputRead(ByVal output As String) Handles _commandExecutor.OutputRead
        Me.Invoke(New processCommandOutputDelegate(AddressOf processCommandOutput), output)
    End Sub

    Private Delegate Sub processCommandOutputDelegate(ByVal output As String)
    Private Sub processCommandOutput(ByVal output As String)
        TextBox1.Text = TextBox1.Text & output & vbNewLine
    End Sub

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        _commandExecutor.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim outputString As String
        Dim d As System.DateTime
        d = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")

        outputString = TextBoxClass.Text & vbNewLine & d & _
                        vbNewLine & vbNewLine & "STUDENT IDs" & vbNewLine & LabelIDs.Text

        SaveFileDialog1.Filter = "Comma Separated Values (*.csv)|*.csv" 'filetype to Save As
        SaveFileDialog1.FileName = TextBoxClass.Text & " " & "(Smart Classroom)" & " " & Date.Now.ToString("dd-MM-yyyy")
        SaveFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then 'if Save Dialog opens
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, outputString, False)
            'Save data in file specified by user and save with .csv extension
        End If

        MsgBox("File saved successfully.")

    End Sub

    Private Sub ButtonEmail_Click(sender As Object, e As EventArgs) Handles ButtonEmail.Click
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False

            'Smtp_Server.Credentials = New Net.NetworkCredential("xxxx@gmail.com", "password")
            'Smtp_Server.Host = "smtp.gmail.com"
            ''can use the above to set a fixed SMTP server e.g. that of Gmail

            Smtp_Server.Credentials = New Net.NetworkCredential(TextBoxUN.Text, TextBoxPW.Text)
            Smtp_Server.Host = TextBoxServer.Text
            Smtp_Server.Port = ListBoxPort.Text
            Smtp_Server.EnableSsl = CheckBoxSSL.Checked

            e_mail = New MailMessage()

            'e_mail.From = New MailAddress("xxxx@gmail.com")
            e_mail.From = New MailAddress(TextBoxFrom.Text)

            e_mail.To.Add(TextBoxInstEm.Text)
            e_mail.Subject = TextBoxClass.Text & " " & "Attendance - " & Date.Now.ToString("dd-MM-yyyy")
            e_mail.IsBodyHtml = False
            e_mail.Body = TextBoxClass.Text & _
                        vbNewLine & vbNewLine & "STUDENT IDs" & vbNewLine & TextBox1.Text
            Smtp_Server.Send(e_mail)

            MsgBox("Mail Sent")

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Sub
End Class