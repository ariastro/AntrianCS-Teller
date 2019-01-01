Public Class Form1

    Dim alamat As String = "D:\COLLEGE\Semester 5\VBNET\suara\"

    Private Sub btnCS_Click(sender As Object, e As EventArgs) Handles btnCS.Click
        Dim gett As String = tbCS.Text
        Dim panjang As Integer = gett.Length
        Dim angka As String = Mid(gett, 3, panjang)
        If angka < 10 Then
            tbCS.Text = "CS" & angka + 1
        End If
    End Sub

    Private Sub btnTeller_Click(sender As Object, e As EventArgs) Handles btnTeller.Click
        Dim gett As String = tbTeller.Text
        Dim panjang As Integer = gett.Length
        Dim angka As String = Mid(gett, 2, panjang)
        If angka < 10 Then
            tbTeller.Text = "T" & angka + 1
        End If
    End Sub

    Private Sub btnPlayCS_Click(sender As Object, e As EventArgs) Handles btnPlayCS.Click
        Dim gett As String = tbCS.Text
        Dim panjang As Integer = gett.Length
        Dim angka As String = Mid(gett, 3, panjang)
        My.Computer.Audio.Play(alamat & "in.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(alamat & "antrian.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(alamat & "nomor.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(alamat & "CS.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(alamat & angka & ".wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(alamat & "silahkan menuju ke.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(alamat & "loket.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(alamat & "1.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(alamat & "out.wav", AudioPlayMode.Background)
    End Sub

    Private Sub btnPlayT_Click(sender As Object, e As EventArgs) Handles btnPlayT.Click
        Dim gett As String = tbTeller.Text
        Dim panjang As Integer = gett.Length
        Dim angka As String = Mid(gett, 2, panjang)
        My.Computer.Audio.Play(alamat & "in.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(alamat & "antrian.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(alamat & "nomor.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(alamat & "T.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(alamat & angka & ".wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(alamat & "silahkan menuju ke.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(alamat & "loket.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(alamat & "2.wav", AudioPlayMode.WaitToComplete)
        My.Computer.Audio.Play(alamat & "out.wav", AudioPlayMode.Background)
    End Sub

End Class
