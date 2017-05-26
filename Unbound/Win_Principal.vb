Public Class Win_Principal
    Dim X As Int16 = 0
    Private Sub Win_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Lab_Menu.BackColor = Color.FromArgb(72, 104, 135)
        'Lab_Inicio.BackColor = Color.FromArgb(0, 159, 60)
        'Lab_Usuario.BackColor = Color.FromArgb(214, 138, 58)
        'Lab_Config.BackColor = Color.FromArgb(110, 110, 110)
        'Lab_Salir.BackColor = Color.FromArgb(239, 156, 0)

    End Sub
    Private Sub Pic_Menu_Click(sender As Object, e As EventArgs) Handles Pic_Menu.Click
        If X = 0 Then
            X = 1
        Else
            X = 0
        End If
        Temporizador.Enabled = True
    End Sub

    Private Sub Temporizador_Tick(sender As Object, e As EventArgs) Handles Temporizador.Tick
        If X = 1 Then
            If Panel_Labels.Width < 150 Then
                Panel_Labels.Width = Panel_Labels.Width + 10
            Else
                Temporizador.Enabled = False
            End If
        Else
            If Panel_Labels.Width > 2 Then
                Panel_Labels.Width = Panel_Labels.Width - 10
            Else
                Temporizador.Enabled = True
            End If
        End If
    End Sub
End Class