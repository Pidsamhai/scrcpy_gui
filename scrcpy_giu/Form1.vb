Public Class Form1

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim Process As New Process()
    Dim Process_Info As New ProcessStartInfo()
    Dim path As String = "scrcpy-win64"

    Private Sub Top_pa_Paint(sender As Object, e As PaintEventArgs) Handles top_pa.Paint

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
        kill_process()
        Me.Close()
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        VersionLabel.Text = "Alpha Build 0.2 04/08/2019"
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
        Dim str As String() = adb("/c adb shell getprop ro.product.model & adb shell getprop ro.build.version.sdk").Split(vbLf)
        If (str(0) <> Nothing) Then
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
                If (Not m_USB.Checked And Not m_Wireless.Checked) Then
                    msg = "Please Select Mode"
                    MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                If (cmbBitrate.SelectedIndex > -1) Then
                    msg += "-b " + cmbBitrate.Text.TrimEnd("B")
                End If
                'MessageBox.Show(msg)
                If (m_USB.Checked) Then
                    adb("/c adb usb")
                    adb("/c adb kill-server")
                ElseIf (m_Wireless.Checked) Then
                    adb("/c adb kill-server")
                    Dim ip As String = getIP()
                    adb("/c adb tcpip 5555")
                    MessageBox.Show(adb("/c adb connect " & ip & ":5555") + vbCrLf + "Please Unplug USB then press OK", "Please Unplug USB", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
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

                grpbHome.Enabled = False
                lblStat.Text = "Connect " + str(0)
                btnConnect.Text = "Disconnect"
                btnConnect.BackColor = Color.FromArgb(255, 128, 128)
                btnConnect.ForeColor = Color.FromArgb(255, 0, 0)
                btnConnect.FlatAppearance.BorderColor = Color.FromArgb(255, 0, 0)

            Else
                btnConnect.Text = "Connect"
                btnConnect.BackColor = Color.FromArgb(128, 255, 128)
                btnConnect.ForeColor = Color.FromArgb(0, 192, 0)
                btnConnect.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0)
                grpbHome.Enabled = True
                kill_process()
                lblStat.Text = ""
            End If

        Else
            MessageBox.Show("No Devices Connected !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Function Kill_process()
        Process.Close()
        For Each p As Process In Process.GetProcesses
            If p.ProcessName = "scrcpy" Or p.ProcessName = "adb" Then
                Try
                    p.Kill()
                Catch ex As Exception
                    Continue For
                End Try
            End If
        Next
    End Function


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
        Dim a As String
        For Each i In ip_dummy
            a += "->" + i + vbCrLf
        Next
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
        kill_process()
        Me.Close()
    End Sub

    Private Sub BtnKill_Click(sender As Object, e As EventArgs) Handles btnKill.Click
        kill_process()
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
End Class
