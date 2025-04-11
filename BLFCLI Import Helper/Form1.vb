Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        If Me.FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            Dim fileInfo As New IO.DirectoryInfo(FolderBrowserDialog1.SelectedPath)
            Dim usermaps As IO.FileInfo() = fileInfo.GetFiles("*", IO.SearchOption.AllDirectories)
            Dim GetFileInfo As IO.FileInfo

            For Each GetFileInfo In usermaps
                ListBox1.Items.Add(GetFileInfo)
            Next
        End If
        Label1.Text = ListBox1.Items.Count
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If CheckBox1.Checked = True Then
            Clipboard.SetText((".\blf_cli.exe title-storage import-variant " + Chr(34) + ".\Blam-Title-Storage\Halo 3\Release\default_hoppers" + Chr(34) + " .\variants\" + My.Settings.subDR.ToString + "\" + ListBox1.GetItemText(ListBox1.SelectedItem) + (" ") + Chr(34) + "Halo 3" + Chr(34) + BuildVer.Text))
        Else
            Clipboard.SetText((".\blf_cli.exe title-storage import-variant " + Chr(34) + ".\Blam-Title-Storage\Halo 3\Release\default_hoppers" + Chr(34) + " .\variants\" + ListBox1.GetItemText(ListBox1.SelectedItem) + (" ") + Chr(34) + "Halo 3" + Chr(34) + BuildVer.Text))
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Clipboard.SetText(".\blf_cli.exe title-storage build " + Chr(34) + ".\Blam-Title-Storage\Halo 3\Release" + Chr(34) + " .\storage\title\tracked\12070 " + Chr(34) + "Halo 3" + Chr(34) + BuildVer.Text)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clipboard.SetText(".\blf_cli.exe title-storage build-config .\storage\title\tracked\12070 " + Chr(34) + ".\Blam-Title-Storage\Halo 3\Release" + Chr(34) + " " + Chr(34) + "Halo 3" + Chr(34) + BuildVer.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim subdir As String
        subdir = Microsoft.VisualBasic.InputBox("Enter the name of your sub directory located in /variants. If you're not using one, uncheck the checkbox.", "", My.Settings.subDR, 600, 400)
        My.Settings.subDR = subdir
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub BuildVer_Click(sender As Object, e As EventArgs) Handles BuildVer.Click
        If BuildVer.Text.Contains("12070") Then
            Dim rslt As New System.Windows.Forms.DialogResult
            rslt = MessageBox.Show("Change the build to Halo 3 ODST?", "BLFCLI Import Helper", MessageBoxButtons.YesNo)
            If rslt = Windows.Forms.DialogResult.Yes Then
                BuildVer.Text = " 13895.09.04.27.2201.atlas_release"
            End If

        ElseIf BuildVer.Text.Contains("13895") Then
            Dim rslt2 As New System.Windows.Forms.DialogResult
            rslt2 = MessageBox.Show("Change the build to Halo 3?", "BLFCLI Import Helper", MessageBoxButtons.YesNo)
            If rslt2 = Windows.Forms.DialogResult.Yes Then
                BuildVer.Text = " 12070.08.09.05.2031.halo3_ship"
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Button2.Enabled = True
        Else
            Button2.Enabled = False
        End If
    End Sub

    'Form animation after clicking More Commands:
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Size = New Size(Me.Width, Me.Height + 1)
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Timer1.Start()
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Size = New Size(307, 481) Then
            Timer1.Enabled = False
            Label2.Visible = False
        End If
    End Sub
End Class
