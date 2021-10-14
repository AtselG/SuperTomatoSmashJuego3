Public Class FormPuzzle1
    Private Sub FormPuzzle1_Load(sender As Object, e As EventArgs) Handles Me.Load
        MaterialRaisedButtonComenzar.Show()
        MaterialRaisedButtonVolver.Hide()
        MaterialRaisedButtonVerificar.Hide()
    End Sub
    Private Sub MaterialRaisedButtonComenzar_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButtonComenzar.Click
        TimerVerification.Start()
        MaterialRaisedButtonComenzar.Hide()
        MaterialRaisedButtonVolver.Show()
        MaterialRaisedButtonVerificar.Show()
        PictureBox1.Image = My.Resources.Blanco1
        PictureBox2.Image = My.Resources.Nivel22
        PictureBox3.Image = My.Resources.Nivel23
        PictureBox4.Image = My.Resources.Nivel28
        PictureBox5.Image = My.Resources.Nivel27
        PictureBox6.Image = My.Resources.Nivel25
        PictureBox7.Image = My.Resources.Nivel26
        PictureBox8.Image = My.Resources.Nivel29
        PictureBox9.Image = My.Resources.Nivel24
        PictureBox1.BackColor = Color.White
        PictureBox2.BackColor = Color.Gray
        PictureBox3.BackColor = Color.Gray
        PictureBox4.BackColor = Color.Gray
        PictureBox5.BackColor = Color.Gray
        PictureBox6.BackColor = Color.Gray
        PictureBox7.BackColor = Color.Gray
        PictureBox8.BackColor = Color.Gray
        PictureBox9.BackColor = Color.Gray
    End Sub
    Private Sub MaterialRaisedButtonVerificar_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButtonVerificar.Click
        If PictureBox1.Image Is My.Resources.Blanco1 And
        PictureBox2.Image Is My.Resources.Nivel22 And
        PictureBox3.Image Is My.Resources.Nivel23 And
        PictureBox4.Image Is My.Resources.Nivel24 And
        PictureBox5.Image Is My.Resources.Nivel25 And
        PictureBox6.Image Is My.Resources.Nivel26 And
        PictureBox7.Image Is My.Resources.Nivel27 And
        PictureBox8.Image Is My.Resources.Nivel28 And
        PictureBox9.Image Is My.Resources.Nivel29 Then
            Dim Result As DialogResult
            Result = MessageBox.Show("¡Felicidades, completaste el rompecabezas! :D", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            If Result = DialogResult.OK Then
                FormInicio.Show()
                Me.Close()
                Close()
            End If
        Else
            Dim Result As DialogResult
            Result = MessageBox.Show("El rompecabezsa está incompleto", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            If Result = DialogResult.OK Then

            End If
        End If
    End Sub
    Private Sub MaterialRaisedButtonVolver_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButtonVolver.Click
        Dim Result As DialogResult
        Result = MessageBox.Show("¿Estás seguro de que quieres volver al menú principal?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If Result = DialogResult.Yes Then
            FormInicio.Show()
            Close()
        ElseIf Result = DialogResult.No Then

        End If
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        If PictureBox8.BackColor = Color.White Then
            PictureBox8.Image = PictureBox9.Image
            PictureBox8.BackColor = Color.Gray
            PictureBox9.Image = My.Resources.Blanco1
            PictureBox9.BackColor = Color.White
        End If
        If PictureBox6.BackColor = Color.White Then
            PictureBox6.Image = PictureBox9.Image
            PictureBox6.BackColor = Color.Gray
            PictureBox9.Image = My.Resources.Blanco1
            PictureBox9.BackColor = Color.White
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        If PictureBox9.BackColor = Color.White Then
            PictureBox9.Image = PictureBox8.Image
            PictureBox9.BackColor = Color.Gray
            PictureBox8.Image = My.Resources.Blanco1
            PictureBox8.BackColor = Color.White
        End If
        If PictureBox7.BackColor = Color.White Then
            PictureBox7.Image = PictureBox8.Image
            PictureBox7.BackColor = Color.Gray
            PictureBox8.Image = My.Resources.Blanco1
            PictureBox8.BackColor = Color.White
        End If
        If PictureBox5.BackColor = Color.White Then
            PictureBox5.Image = PictureBox8.Image
            PictureBox5.BackColor = Color.Gray
            PictureBox8.Image = My.Resources.Blanco1
            PictureBox8.BackColor = Color.White
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        If PictureBox8.BackColor = Color.White Then
            PictureBox8.Image = PictureBox7.Image
            PictureBox8.BackColor = Color.Gray
            PictureBox7.Image = My.Resources.Blanco1
            PictureBox7.BackColor = Color.White
        End If
        If PictureBox4.BackColor = Color.White Then
            PictureBox4.Image = PictureBox7.Image
            PictureBox4.BackColor = Color.Gray
            PictureBox7.Image = My.Resources.Blanco1
            PictureBox7.BackColor = Color.White
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        If PictureBox9.BackColor = Color.White Then
            PictureBox9.Image = PictureBox6.Image
            PictureBox9.BackColor = Color.Gray
            PictureBox6.Image = My.Resources.Blanco1
            PictureBox6.BackColor = Color.White
        End If
        If PictureBox5.BackColor = Color.White Then
            PictureBox5.Image = PictureBox6.Image
            PictureBox5.BackColor = Color.Gray
            PictureBox6.Image = My.Resources.Blanco1
            PictureBox6.BackColor = Color.White
        End If
        If PictureBox3.BackColor = Color.White Then
            PictureBox3.Image = PictureBox6.Image
            PictureBox3.BackColor = Color.Gray
            PictureBox6.Image = My.Resources.Blanco1
            PictureBox6.BackColor = Color.White
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If PictureBox8.BackColor = Color.White Then
            PictureBox8.Image = PictureBox5.Image
            PictureBox8.BackColor = Color.Gray
            PictureBox5.Image = My.Resources.Blanco1
            PictureBox5.BackColor = Color.White
        End If
        If PictureBox6.BackColor = Color.White Then
            PictureBox6.Image = PictureBox5.Image
            PictureBox6.BackColor = Color.Gray
            PictureBox5.Image = My.Resources.Blanco1
            PictureBox5.BackColor = Color.White
        End If
        If PictureBox4.BackColor = Color.White Then
            PictureBox4.Image = PictureBox5.Image
            PictureBox4.BackColor = Color.Gray
            PictureBox5.Image = My.Resources.Blanco1
            PictureBox5.BackColor = Color.White
        End If
        If PictureBox2.BackColor = Color.White Then
            PictureBox2.Image = PictureBox5.Image
            PictureBox2.BackColor = Color.Gray
            PictureBox5.Image = My.Resources.Blanco1
            PictureBox5.BackColor = Color.White
        End If
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If PictureBox7.BackColor = Color.White Then
            PictureBox7.Image = PictureBox4.Image
            PictureBox7.BackColor = Color.Gray
            PictureBox4.Image = My.Resources.Blanco1
            PictureBox4.BackColor = Color.White
        End If
        If PictureBox5.BackColor = Color.White Then
            PictureBox5.Image = PictureBox4.Image
            PictureBox5.BackColor = Color.Gray
            PictureBox4.Image = My.Resources.Blanco1
            PictureBox4.BackColor = Color.White
        End If
        If PictureBox1.BackColor = Color.White Then
            PictureBox1.Image = PictureBox4.Image
            PictureBox1.BackColor = Color.Gray
            PictureBox4.Image = My.Resources.Blanco1
            PictureBox4.BackColor = Color.White
        End If
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If PictureBox6.BackColor = Color.White Then
            PictureBox6.Image = PictureBox3.Image
            PictureBox6.BackColor = Color.Gray
            PictureBox3.Image = My.Resources.Blanco1
            PictureBox3.BackColor = Color.White
        End If
        If PictureBox2.BackColor = Color.White Then
            PictureBox2.Image = PictureBox3.Image
            PictureBox2.BackColor = Color.Gray
            PictureBox3.Image = My.Resources.Blanco1
            PictureBox3.BackColor = Color.White
        End If
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If PictureBox3.BackColor = Color.White Then
            PictureBox3.Image = PictureBox2.Image
            PictureBox3.BackColor = Color.Gray
            PictureBox2.Image = My.Resources.Blanco1
            PictureBox2.BackColor = Color.White
        End If
        If PictureBox5.BackColor = Color.White Then
            PictureBox5.Image = PictureBox2.Image
            PictureBox5.BackColor = Color.Gray
            PictureBox2.Image = My.Resources.Blanco1
            PictureBox2.BackColor = Color.White
        End If
        If PictureBox1.BackColor = Color.White Then
            PictureBox1.Image = PictureBox2.Image
            PictureBox1.BackColor = Color.Gray
            PictureBox2.Image = My.Resources.Blanco1
            PictureBox2.BackColor = Color.White
        End If
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If PictureBox4.BackColor = Color.White Then
            PictureBox4.Image = PictureBox1.Image
            PictureBox4.BackColor = Color.Gray
            PictureBox1.Image = My.Resources.Blanco1
            PictureBox1.BackColor = Color.White
        End If
        If PictureBox2.BackColor = Color.White Then
            PictureBox2.Image = PictureBox1.Image
            PictureBox2.BackColor = Color.Gray
            PictureBox1.Image = My.Resources.Blanco1
            PictureBox1.BackColor = Color.White
        End If
    End Sub
End Class
