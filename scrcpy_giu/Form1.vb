Imports System.ComponentModel
Public Class Form1

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim Process As New Process()
    Dim Process_Info As New ProcessStartInfo()
    Dim pFFMPEG As New Process()
    Dim pFFMPEG_Info As New ProcessStartInfo()
    Dim p1() As Process
    Dim path As String = AppDomain.CurrentDomain.BaseDirectory + "scrcpy-win64"
    Dim path_ffmpeg As String = AppDomain.CurrentDomain.BaseDirectory + "bin"
    Dim lversion As String = "Alpha Build 0.3 04/09/2019"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True
    End Sub

    Private Sub Top_pa_MouseMove(sender As Object, e As MouseEventArgs) Handles top_pa.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Top_pa_MouseUp(sender As Object, e As MouseEventArgs) Handles top_pa.MouseUp
        drag = False
    End Sub

    Private Sub Top_pa_MouseDown(sender As Object, e As MouseEventArgs) Handles top_pa.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Kill_process()
        If BackgroundWorker1.WorkerSupportsCancellation = True Then
            BackgroundWorker1.CancelAsync()
        End If
        Me.Close()
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Sub btn_to_disable()
        btnConnect.Text = "Disconnect"
        btnConnect.BackColor = Color.FromArgb(255, 128, 128)
        btnConnect.ForeColor = Color.FromArgb(255, 0, 0)
        btnConnect.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0)
    End Sub
    Sub btn_to_enable()
        lblStat.Text = "Connect " + Str(0)
        btnConnect.Text = "Disconnect"
        btnConnect.BackColor = Color.FromArgb(255, 128, 128)
        btnConnect.ForeColor = Color.FromArgb(255, 0, 0)
        btnConnect.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If BackgroundWorker1.IsBusy <> True Then
            BackgroundWorker1.RunWorkerAsync()
        End If

        VersionLabel.Text = lversion
        cmbBitrate.SelectedIndex = 0
        m_USB.Checked = False
        dgvShortCuts.Columns(0).Width = 388 / 1.4
        dgvShortCuts.Columns(1).Width = 388 / 2
        dgvShortCuts.RowTemplate.Height = 30
        Dim row As String() = New String() {"Switch fullscreen mode", "Ctrl+f"}
        dgvShortCuts.Rows.Add(row)
        row = New String() {"Resize window to 1:1 (pixel-perfect)", "Ctrl+g"}
        dgvShortCuts.Rows.Add(row)
        row = New String() {"Resize window to remove black borders", "Ctrl+x | Double-click¹"}
        dgvShortCuts.Rows.Add(row)
        row = New String() {"Click on HOME", "Ctrl+h | Middle-click¹"}
        dgvShortCuts.Rows.Add(row)
        row = New String() {"Click on BACK", "Ctrl+g"}
        dgvShortCuts.Rows.Add(row)
        row = New String() {"Click on APP_SWITCH", "Ctrl+b | Right-click²"}
        dgvShortCuts.Rows.Add(row)
        row = New String() {"Click on MENU", "Ctrl+s"}
        dgvShortCuts.Rows.Add(row)
        row = New String() {"Click on VOLUME_UP", "Ctrl+↑ (up)"}
        dgvShortCuts.Rows.Add(row)
        row = New String() {"Click on VOLUME_DOWN", "Ctrl+↓ (down)"}
        dgvShortCuts.Rows.Add(row)
        row = New String() {"Click on POWER", "Ctrl+p"}
        dgvShortCuts.Rows.Add(row)
        row = New String() {"Power on", "Right-click²"}
        dgvShortCuts.Rows.Add(row)
        row = New String() {"Turn device screen off (keep mirroring)", "Ctrl+o"}
        dgvShortCuts.Rows.Add(row)
        row = New String() {"Expand notification panel", "Ctrl+n"}
        dgvShortCuts.Rows.Add(row)
        row = New String() {"Collapse notification panel", "Ctrl+Shift+n"}
        dgvShortCuts.Rows.Add(row)
        row = New String() {"Copy device clipboard to computer", "Ctrl+c"}
        dgvShortCuts.Rows.Add(row)
        row = New String() {"Paste computer clipboard to device", "Ctrl+v"}
        dgvShortCuts.Rows.Add(row)
        row = New String() {"Copy computer clipboard to device", "Ctrl+Shift+v"}
        dgvShortCuts.Rows.Add(row)
        row = New String() {"Enable/disable FPS counter (on stdout)", "Ctrl+i"}
        dgvShortCuts.Rows.Add(row)

    End Sub

    Private Sub BtnConnect_Click_1(sender As Object, e As EventArgs) Handles btnConnect.Click
        If (Not m_USB.Checked And Not m_Wireless.Checked) Then
            MessageBox.Show("Please Select Mode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim str As String() = Adb("/c adb shell getprop ro.product.model & adb shell getprop ro.build.version.sdk").Split(vbLf)
        Dim devicename As String = str(0)
        Dim apilevel As Integer = Convert.ToInt32(str(1))
        If (devicename <> Nothing And apilevel >= 25) Then
            If (btnConnect.Text = "Connect") Then
                Dim msg As String = "/c scrcpy "
                If (chkScreen_Off.Checked) Then
                    msg += "-S "
                End If
                If (chkOntop.Checked) Then
                    msg += "-T "
                End If
                If (chkCrop.Checked) Then
                    If (cmbCrop.SelectedIndex > -1) Then
                        Dim res As String() = cmbCrop.Text.Split("x")
                        msg += "-c " + res(0) + ":" + res(1) + ":0:0" + " "
                    Else
                        MessageBox.Show("Please select Crop resolution", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

                End If

                If (cmbBitrate.SelectedIndex > -1) Then
                    msg += "-b " + cmbBitrate.Text.TrimEnd("B")
                End If
                'MessageBox.Show(msg)
                If (m_USB.Checked) Then
                    Adb("/c adb usb")
                    Adb("/c adb kill-server")
                ElseIf (m_Wireless.Checked) Then
                    Adb("/c adb kill-server")
                    Dim ip As String = GetIP()
                    Adb("/c adb tcpip 5555")
                    MessageBox.Show(Adb("/c adb connect " & ip & ":5555") + vbCrLf + "Please Unplug USB then press OK", "Please Unplug USB", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                Start_Process(msg)

                grpbHome.Enabled = False
                lblStat.Text = "Connect " + devicename
                btn_to_disable()

            Else
                btn_to_enable()
                grpbHome.Enabled = True
                lblStat.Text = ""
                Kill_process()

            End If

        Else
            MessageBox.Show("No Devices Connected !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub Kill_process()
        For Each p As Process In Process.GetProcesses
            If p.ProcessName = "scrcpy" Or p.ProcessName = "adb" Or p.ProcessName = "ffmpeg" Then
                Try
                    p.Kill()
                Catch ex As Exception
                    Continue For
                End Try
            End If
        Next
    End Sub

    Sub Start_Process(ByVal msg As String)
        Process_Info.FileName = "cmd.exe"
        Process_Info.Arguments = msg
        Process_Info.WorkingDirectory = path
        Process_Info.CreateNoWindow = True
        Process_Info.UseShellExecute = False
        Process_Info.RedirectStandardOutput = True
        Process_Info.RedirectStandardError = True
        Process.EnableRaisingEvents = True
        Process.StartInfo = Process_Info
        Process.Start()
    End Sub


    Function Adb(ByVal Arguments As String) As String
        Try

            Process_Info.FileName = "cmd.exe"
            Process_Info.Arguments = Arguments
            Process_Info.WorkingDirectory = path
            Process_Info.CreateNoWindow = True
            Process_Info.UseShellExecute = False
            Process_Info.RedirectStandardOutput = True
            Process_Info.RedirectStandardError = True

            Process.EnableRaisingEvents = True
            Process.StartInfo = Process_Info
            Process.Start()

            Dim Process_ErrorOutput As String = Process.StandardOutput.ReadToEnd()
            Dim Process_StandardOutput As String = Process.StandardOutput.ReadToEnd()

            If Process_ErrorOutput IsNot Nothing Then Return Process_ErrorOutput
            If Process_StandardOutput IsNot Nothing Then Return Process_StandardOutput

        Catch ex As Exception
            Return ex.Message
        End Try
        Return "OK"

    End Function

    Function GetIP()
        Dim msg As String() = Adb("/c adb shell ip route").Split(vbLf)
        Dim ip_dummy As String() = msg(0).Split(" ")
        Dim ip As String = ip_dummy(ip_dummy.Length - 2)
        'Dim a As String = ""
        'For Each i In ip_dummy
        '    a += "->" + i + vbCrLf
        'Next
        'MessageBox.Show(ip)
        'Dim ip As String = ip_dummy(8)
        Return ip
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("https://github.com/Pidsamhai")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("https://facebook.com/meng.anantasak")
    End Sub

    Private Sub ChkCrop_CheckedChanged(sender As Object, e As EventArgs) Handles chkCrop.CheckedChanged

    End Sub

    Private Sub ChkCrop_CheckStateChanged(sender As Object, e As EventArgs) Handles chkCrop.CheckStateChanged
        If (chkCrop.Checked) Then
            cmbCrop.Enabled = True
        ElseIf (Not chkCrop.Checked) Then
            cmbCrop.Enabled = False
        End If
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.Hide()
        Scrcpy.Visible = True
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles Scrcpy.DoubleClick
        Me.Show()
        Scrcpy.Visible = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Kill_process()
        Me.Close()
    End Sub

    Private Sub BtnKill_Click(sender As Object, e As EventArgs) Handles btnKill.Click
        Kill_process()
    End Sub

    Private Sub Lblsource_Click(sender As Object, e As EventArgs) Handles Lblsource.Click
        Process.Start("https://github.com/Genymobile/scrcpy")
    End Sub

    Private Sub Lblmygit_Click(sender As Object, e As EventArgs) Handles Lblmygit.Click
        Process.Start("https://github.com/Pidsamhai")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("https://github.com/Pidsamhai")
    End Sub

    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs) Handles MaterialLabel1.Click
        Process.Start("https://facebook.com/meng.anantasak")
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim w As BackgroundWorker = CType(sender, BackgroundWorker)
        While True
            If w.CancellationPending = True Then
                e.Cancel = True
                Exit While
            Else
                p1 = Process.GetProcessesByName("scrcpy")

                If p1.Count > 0 Then
                    w.ReportProgress(1, "Running")
                Else
                    w.ReportProgress(1, "Not Running")
                End If
            End If
            System.Threading.Thread.Sleep(1000)
        End While
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        If e.UserState = "Running" Then
            btnConnect.Text = "Disconnect"
            btnConnect.BackColor = Color.FromArgb(255, 128, 128)
            btnConnect.ForeColor = Color.FromArgb(255, 0, 0)
            btnConnect.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0)
        ElseIf e.UserState = "Not Running" Then
            btnConnect.Text = "Connect"
            btnConnect.BackColor = Color.FromArgb(128, 255, 128)
            btnConnect.ForeColor = Color.FromArgb(0, 192, 0)
            btnConnect.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0)
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRec.Click
        pFFMPEG = New Process()
        pFFMPEG_Info = New ProcessStartInfo()
        If (btnRec.Text = "Record") Then
            Dim p2 As Process
            Dim wtname, salt_date, args, file_type As String
            file_type = ".mkv"
            Dim dic As String = AppDomain.CurrentDomain.BaseDirectory
            Debug.WriteLine(dic)
            salt_date = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")
            Debug.WriteLine(salt_date)
            For Each p2 In Process.GetProcessesByName("scrcpy")
                'Debug.WriteLine(p2.MainWindowTitle.ToString)
                wtname = p2.MainWindowTitle.ToString
            Next
            If wtname Is Nothing Then
                Debug.WriteLine("Emty")
                Exit Sub
            End If
            args = "/c ffmpeg -f gdigrab -framerate 25 -i title=""" & wtname & """" + " " + """" & dic + "record\" + wtname.Replace(" ", "") + salt_date + file_type & """"

            Debug.WriteLine(args)
            pFFMPEG_Info.FileName = "cmd.exe"
            pFFMPEG_Info.Arguments = args
            pFFMPEG_Info.WorkingDirectory = path_ffmpeg
            pFFMPEG_Info.CreateNoWindow = True
            pFFMPEG_Info.UseShellExecute = False
            pFFMPEG_Info.RedirectStandardInput = True
            pFFMPEG_Info.RedirectStandardOutput = False
            pFFMPEG_Info.RedirectStandardError = False

            pFFMPEG.EnableRaisingEvents = False
            pFFMPEG.StartInfo = pFFMPEG_Info
            pFFMPEG.Start()
            btnRec.Text = "Stop"
        ElseIf btnRec.Text = "Stop" Then
            Dim pProcess() As Process = Process.GetProcesses
            For Each p As Process In pProcess
                If p.ProcessName = "ffmpeg" Then
                    p.WaitForExit(1000)
                    If Not p.HasExited Then
                        'The process did not close itself so force it to close.
                        p.Kill()
                    End If
                    'Dispose the Process object, which is different to closing the running process.
                    p.Close()
                End If
            Next
            btnRec.Text = "Record"
        End If
    End Sub

End Class
