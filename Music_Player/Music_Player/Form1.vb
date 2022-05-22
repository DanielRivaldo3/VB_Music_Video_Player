Public Class Form1

    Private Sub btn_open_Click(sender As Object, e As EventArgs) Handles btn_open.Click
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub btn_play_Click(sender As Object, e As EventArgs) Handles btn_play.Click
        AxWindowsMediaPlayer2.URL = OpenFileDialog1.FileName
        AxWindowsMediaPlayer2.Ctlcontrols.play()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rb_pause.CheckedChanged
        AxWindowsMediaPlayer2.Ctlcontrols.pause()

    End Sub

    Private Sub btn_stop_Click(sender As Object, e As EventArgs) Handles btn_stop.Click
        AxWindowsMediaPlayer2.Ctlcontrols.stop()

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rb_resume.CheckedChanged
        AxWindowsMediaPlayer2.Ctlcontrols.play()
    End Sub

    Private Sub track_bar_volume_Scroll(sender As Object, e As EventArgs) Handles track_bar_volume.Scroll
        AxWindowsMediaPlayer2.settings.volume = track_bar_volume.Value
    End Sub
End Class
