Imports System.Data.OleDb
Module Conexion
    Public cnx As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Control.mdb; Jet OLEDB:Database Password=siliconvalley")
    Dim cmb As OleDbCommandBuilder
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Public ds As DataSet = New DataSet()

    Public Sub Abre()
        Try
            cnx.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub Cierra()
        Try
            cnx.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Function TablesQuery(ByVal sql As String) As DataTable
        Dim dt As New DataTable()
        Try
            ds.Tables.Clear()
            da = New OleDbDataAdapter(sql, cnx)
            cmb = New OleDbCommandBuilder(da)
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return dt
    End Function
    Public Function Ejecucion(ByVal q As String) As Integer
        Dim i As Integer = 0
        Try
            cnx.Open()
            Using cmd As New OleDbCommand(q, cnx)
                i = cmd.ExecuteNonQuery
                If (i > 0) Then
                    i = 1
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnx.Close()
        End Try
        Return i
    End Function

    Public Sub CargaFoto(ByRef num As String, ByRef pb As PictureBox)
        Try
            Conexion.Abre()
            Dim arrImage() As Byte
            Dim myMS As New IO.MemoryStream
            Dim da As New OleDbDataAdapter("SELECT FOTO FROM EMPLEADO WHERE CI=" & num, cnx)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                If Not IsDBNull(dt.Rows(0).Item(0)) Then
                    arrImage = dt.Rows(0).Item(0)
                    For Each ar As Byte In arrImage
                        myMS.WriteByte(ar)
                    Next
                    pb.Image = System.Drawing.Image.FromStream(myMS)
                Else
                    pb.Image = Image.FromFile(Application.StartupPath & "\Icono.png")
                End If
                pb.Enabled = False
            Else
                MsgBox("¡Registro no encontrado!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conexion.Cierra()
        End Try
    End Sub
    'Public Sub SavePhoto(ByVal n As Integer)
    '    Try
    '        cnx.Open()
    '        Dim arrImage() As Byte
    '        Dim strImage As String
    '        Dim myMs As New IO.MemoryStream
    '        If Not IsNothing(WinSession.PicMe.Image) Then
    '            EditEmployed.Foto.Image.Save(myMs, WinSession.PicMe.Image.RawFormat)
    '            arrImage = myMs.GetBuffer
    '            strImage = "?"
    '        Else
    '            arrImage = Nothing
    '            strImage = "NULL"
    '        End If
    '        Dim cmd As New OleDbCommand
    '        cmd.Connection = cnx
    '        cmd.CommandText = "UPDATE EMPLEADO SET FOTO=" & strImage & " WHERE CI=" & n
    '        If strImage = "?" Then
    '            cmd.Parameters.Add(strImage, OleDbType.Binary).Value = arrImage
    '        End If
    '        cmd.ExecuteNonQuery()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        cnx.Close()
    '    End Try
    'End Sub
End Module
