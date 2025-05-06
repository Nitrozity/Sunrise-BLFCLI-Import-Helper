Imports System.IO
Imports System.Text
Imports System.ComponentModel
Imports System.Collections.ObjectModel
Imports System.Management.Automation
Imports System.Management.Automation.Runspaces

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbx_skipafterveto.SelectedIndex = cmbx_skipafterveto.FindStringExact(My.Settings.tf_skipAfterVeto)
        cmbx_optional.SelectedIndex = cmbx_optional.FindStringExact(My.Settings.tf_optional)
        gvFileName.Text = My.Settings.gvFileName
        entryWeight.Value = My.Settings.entryWeight
        minPlayerCount.Value = My.Settings.minPlayerCount
        cmbx_skipafterveto.Text = My.Settings.tf_skipAfterVeto
        cmbx_optional.Text = My.Settings.tf_optional
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If rememberSettings.Checked = True Then
            My.Settings.gvFileName = gvFileName.Text
            My.Settings.entryWeight = entryWeight.Text
            My.Settings.minPlayerCount = minPlayerCount.Text
            My.Settings.tf_skipAfterVeto = cmbx_skipafterveto.Text
            My.Settings.tf_optional = cmbx_optional.Text
            My.Settings.Save()
            My.Settings.Reload()
        End If
    End Sub
    Private Sub LoadUsermaps_Click(sender As Object, e As EventArgs) Handles LoadUsermaps.Click

        Dim dlgResult As DialogResult

        If dlgResult = Windows.Forms.DialogResult.Cancel Then Exit Sub

        ListBox1.Items.Clear()
        DataGridView1.Rows.Clear()
        CSV_Textbox.Clear()
        CSV_Textbox.Text = "map_variant_file_name,game_variant_file_name,weight,minimum_player_count,skip_after_veto,optional" + Environment.NewLine

        If Me.FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then


            Dim fileInfo As New IO.DirectoryInfo(FolderBrowserDialog1.SelectedPath)
            Dim usermaps As IO.FileInfo() = fileInfo.GetFiles("*", IO.SearchOption.AllDirectories)
            Dim GetFileInfo As IO.FileInfo

            For Each GetFileInfo In usermaps
                ListBox1.Items.Add(GetFileInfo)
            Next
        End If

        Label1.Text = ListBox1.Items.Count
        importMapsDGV()

        If chk_CreateCSV.Checked = True Then
            importMapsCSV()
            System.IO.File.WriteAllText("game_set.csv", CSV_Textbox.Text)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If chk_SubDR.Checked = True Then
            Clipboard.SetText((".\blf_cli.exe title-storage import-variant " + Chr(34) + ".\Blam-Title-Storage\Halo 3\Release\default_hoppers" + Chr(34) + " .\variants\" + My.Settings.subDR.ToString + "\" + ListBox1.GetItemText(ListBox1.SelectedItem) + (" ") + Chr(34) + "Halo 3" + Chr(34) + BuildVer.Text))
        Else
            Clipboard.SetText((".\blf_cli.exe title-storage import-variant " + Chr(34) + ".\Blam-Title-Storage\Halo 3\Release\default_hoppers" + Chr(34) + " .\variants\" + ListBox1.GetItemText(ListBox1.SelectedItem) + (" ") + Chr(34) + "Halo 3" + Chr(34) + BuildVer.Text))
        End If
    End Sub
    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        Clipboard.SetText(".\blf_cli.exe title-storage build " + Chr(34) + ".\Blam-Title-Storage\Halo 3\Release" + Chr(34) + " .\storage\title\tracked\12070 " + Chr(34) + "Halo 3" + Chr(34) + BuildVer.Text)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Clipboard.SetText(".\blf_cli.exe title-storage build-config .\storage\title\tracked\12070 " + Chr(34) + ".\Blam-Title-Storage\Halo 3\Release" + Chr(34) + " " + Chr(34) + "Halo 3" + Chr(34) + BuildVer.Text)
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_SubDR.CheckedChanged

        If chk_SubDR.Checked = True Then
            Dim subdir As String
            subdir = Microsoft.VisualBasic.InputBox("Enter the name of your sub directory located in /variants. If you're not using one, uncheck the checkbox.", "", My.Settings.subDR, 600, 400)
            My.Settings.subDR = subdir
            My.Settings.Save()
            My.Settings.Reload()
        End If
    End Sub
    Private Function ByteArrayToHexString(ByVal byteArray As Byte()) As String
        Dim hex As New System.Text.StringBuilder(byteArray.Length * 2)
        For Each b As Byte In byteArray
            hex.AppendFormat("{0:x2}", b)
        Next
        hex.Replace("017c", "Narrows")
        hex.Replace("012c", "Construct")
        hex.Replace("0186", "The Pit")
        hex.Replace("0136", "High Ground")
        hex.Replace("0140", "Guardian")
        hex.Replace("014a", "Isolation")
        hex.Replace("0154", "Valhalla")
        hex.Replace("015e", "Epitaph")
        hex.Replace("0190", "Sandtrap")
        hex.Replace("0168", "Snowbound")
        hex.Replace("001e", "Last Resort")
        hex.Replace("0244", "Rat's Nest")
        hex.Replace("019a", "Standoff")
        hex.Replace("0258", "Cold Storage")
        hex.Replace("01ea", "Assembly")
        hex.Replace("01b8", "Longshore")
        hex.Replace("02e4", "Citadel")
        hex.Replace("024e", "Ghost Town")
        hex.Replace("0208", "Blackout")
        hex.Replace("02d0", "Heretic")
        hex.Replace("02da", "Sandbox")
        hex.Replace("01d6", "Avalanche")
        hex.Replace("01f4", "Orbital")
        hex.Replace("01e0", "Foundry")
        Return hex.ToString()
    End Function

    Private Sub importMapsCSV()
        Dim loadMaps(63) As Byte

        For Each file In Directory.GetFiles(FolderBrowserDialog1.SelectedPath).Where(Function(fn) fn.ToLower.Contains(“usermap”))

            Dim fileOpen As IO.FileStream = IO.File.Open(file, IO.FileMode.Open)
            fileOpen.Seek(&H411, IO.SeekOrigin.Begin)
            fileOpen.Read(loadMaps, 0, 64)
            fileOpen.Close()

            For i As Integer = 0 To 63
                CSV_Textbox.Text = CSV_Textbox.Text.ToLower + Chr(loadMaps(i))
            Next
            CSV_Textbox.Text = CSV_Textbox.Text.Replace(" (map variant)", "")
            CSV_Textbox.Text = CSV_Textbox.Text.Replace(" ", "_")
            CSV_Textbox.Text = CSV_Textbox.Text & "," & gvFileName.Text & "," & entryWeight.Value.ToString & "," & minPlayerCount.Value.ToString & "," & cmbx_skipafterveto.Text & "," & cmbx_optional.Text
            CSV_Textbox.Text = CSV_Textbox.Text & Environment.NewLine
        Next

    End Sub

    Private Function BytesToString(bytes() As Byte) As String
        Return String.Concat(Array.ConvertAll(bytes, Function(b) If(b <> 0, CStr(Chr(b)), "")))
    End Function

    Private Sub importMapsDGV()
        Dim loadMem(63) As Byte
        Dim loadAuth(15) As Byte
        Dim byteArray(1) As Byte

        For Each fileInPath In Directory.GetFiles(FolderBrowserDialog1.SelectedPath).Where(Function(fn) fn.ToLower.Contains(“usermap”))

            Dim fileOpen As IO.FileStream = IO.File.Open(fileInPath, IO.FileMode.Open)
            fileOpen.Seek(&H411, IO.SeekOrigin.Begin)
            fileOpen.Read(loadMem, 0, 63)
            fileOpen.Close()
            Dim offset As Integer = 53538
            Do

                Using fs As New FileStream(fileInPath, FileMode.Open, FileAccess.Read)
                    fs.Seek(offset, SeekOrigin.Begin)
                    fs.Read(byteArray, 0, byteArray.Length)
                End Using

                If ByteArrayToHexString(byteArray) = "0000" AndAlso offset = 53538 Then
                    offset = 57634
                Else
                    Exit Do
                End If
            Loop

            Dim offset2 As Integer = 53744
            Do
                Using fs2 As New FileStream(fileInPath, FileMode.Open, FileAccess.Read)
                    fs2.Seek(offset2, SeekOrigin.Begin)
                    fs2.Read(loadAuth, 0, loadAuth.Length)
                End Using
                Exit Do
            Loop
            Me.DataGridView1.Rows.Add(BytesToString(loadMem).Replace("(Map Variant)", ""), ByteArrayToHexString(byteArray), BytesToString(loadAuth), fileInPath)
        Next
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles copyBuild.Click
        Clipboard.SetText(".\blf_cli.exe title-storage build " + Chr(34) + ".\Blam-Title-Storage\Halo 3\Release" + Chr(34) + " .\storage\title\tracked\" + BuildDir.Text + Chr(34) + "Halo 3" + Chr(34) + BuildVer.Text)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles copyBuildConfig.Click
        Clipboard.SetText(".\blf_cli.exe title-storage build-config .\storage\title\tracked\" + BuildDir.Text + Chr(34) + ".\Blam-Title-Storage\Halo 3\Release" + Chr(34) + " " + Chr(34) + "Halo 3" + Chr(34) + BuildVer.Text)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles btnH3.CheckedChanged
        BuildVer.Text = " 12070.08.09.05.2031.halo3_ship"
        BuildDir.Text = "12070 "
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles btnH3ODST.CheckedChanged
        BuildVer.Text = " 13895.09.04.27.2201.atlas_release"
        BuildDir.Text = "13895 "
    End Sub
End Class