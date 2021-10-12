Public Class FormInicio
    Private Sub ButtonJugar_Click(sender As Object, e As EventArgs) Handles ButtonJugar.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.Drip_2, AudioPlayMode.Background)
        End If
        FormDificultades.ShowDialog(owner:=Me)
    End Sub
    Private Sub ButtonOpciones_Click(sender As Object, e As EventArgs) Handles ButtonOpciones.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.Drip_2, AudioPlayMode.Background)
        End If
        FormOpciones.Show()
        Hide()
    End Sub
    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        If SoundOnOff = True Then
            My.Computer.Audio.Play(My.Resources.Drip_2, AudioPlayMode.Background)
        End If
        Application.Exit()
    End Sub
    Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SoundOnOff = True
    End Sub
End Class
