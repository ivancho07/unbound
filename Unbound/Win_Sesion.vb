Public Class Win_Sesion
    Dim X As Int16 = 0
    Private Sub Win_Sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CircleBorder(Pic_Foto)
        Grid_Detalle.DataSource = Conexion.TablesQuery("SELECT ANIO, MES, FECHA, ENTRADA, SALIDA, OBS_ENT, OBS_SAL, TOTAL FROM VISTA WHERE DNI = 6760315")
        Grid_Detalle.Columns("ENTRADA").DefaultCellStyle.Format = "hh:mm"
        Grid_Detalle.Columns("SALIDA").DefaultCellStyle.Format = "hh:mm"
        Grid_Detalle.Columns("TOTAL").DefaultCellStyle.Format = "hh:mm"
    End Sub

    Public Sub CircleBorder(ByVal Pic As PictureBox)
        Dim Gph As New System.Drawing.Drawing2D.GraphicsPath()
        Gph.AddEllipse(0, 0, Pic.Width - 3, Pic.Height - 3)
        Dim Rg As Region = New Region(Gph)
        Pic.Region = Rg
    End Sub
    Private Sub Pic_Menu_Click(sender As Object, e As EventArgs) Handles Pic_Menu.Click
        If Panel_Iconos.Width < 250 Then
            Pic_Foto.Width = 250
            Pic_Foto.Height = 250
            Panel_Iconos.Width = 250
            CircleBorder(Pic_Foto)
        Else
            Pic_Foto.Width = 50
            Pic_Foto.Height = 50
            Panel_Iconos.Width = 50
            CircleBorder(Pic_Foto)
        End If
    End Sub

    Private Sub Pic_Menu_MouseEnter(sender As Object, e As EventArgs) Handles Pic_Menu.MouseEnter
        Pic_Menu.BackColor = Color.LightGray
        Lab_Saludo.BackColor = Color.LightGray
        Lab_Saludo.ForeColor = Color.DarkBlue
    End Sub
    Private Sub Pic_Menu_MouseLeave(sender As Object, e As EventArgs) Handles Pic_Menu.MouseLeave
        Pic_Menu.BackColor = Color.Transparent
        Lab_Saludo.BackColor = Color.Transparent
        Lab_Saludo.ForeColor = Color.White
    End Sub

    Private Sub Lab_Saludo_Click(sender As Object, e As EventArgs) Handles Lab_Saludo.Click
        Pic_Foto.Width = 50
        Pic_Foto.Height = 50
        Panel_Iconos.Width = 50
        CircleBorder(Pic_Foto)
    End Sub
End Class