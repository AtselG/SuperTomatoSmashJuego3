Public Class FormInicio
    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Application.Exit()
    End Sub
    Private Sub ButtonJugar_Click(sender As Object, e As EventArgs) Handles ButtonJugar.Click
        FormPuzzle1.Show()
        Close()
    End Sub
End Class
