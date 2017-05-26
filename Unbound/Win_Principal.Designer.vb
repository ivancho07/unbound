<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Win_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel_Top = New System.Windows.Forms.Panel()
        Me.Panel_Down = New System.Windows.Forms.Panel()
        Me.Panel_Labels = New System.Windows.Forms.TableLayoutPanel()
        Me.Lab_Menu = New System.Windows.Forms.Label()
        Me.Lab_Usuario = New System.Windows.Forms.Label()
        Me.Lab_Salir = New System.Windows.Forms.Label()
        Me.Lab_Inicio = New System.Windows.Forms.Label()
        Me.Lab_Config = New System.Windows.Forms.Label()
        Me.Panel_Iconos = New System.Windows.Forms.TableLayoutPanel()
        Me.Pic_Close = New System.Windows.Forms.PictureBox()
        Me.Pic_Config = New System.Windows.Forms.PictureBox()
        Me.Pic_Home = New System.Windows.Forms.PictureBox()
        Me.Pic_Menu = New System.Windows.Forms.PictureBox()
        Me.Pic_Login = New System.Windows.Forms.PictureBox()
        Me.Temporizador = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Labels.SuspendLayout()
        Me.Panel_Iconos.SuspendLayout()
        CType(Me.Pic_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Config, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Menu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Top
        '
        Me.Panel_Top.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Top.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Top.Name = "Panel_Top"
        Me.Panel_Top.Size = New System.Drawing.Size(814, 28)
        Me.Panel_Top.TabIndex = 1
        '
        'Panel_Down
        '
        Me.Panel_Down.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel_Down.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Down.Location = New System.Drawing.Point(0, 475)
        Me.Panel_Down.Name = "Panel_Down"
        Me.Panel_Down.Size = New System.Drawing.Size(814, 28)
        Me.Panel_Down.TabIndex = 2
        '
        'Panel_Labels
        '
        Me.Panel_Labels.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel_Labels.ColumnCount = 1
        Me.Panel_Labels.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel_Labels.Controls.Add(Me.Lab_Menu, 0, 0)
        Me.Panel_Labels.Controls.Add(Me.Lab_Usuario, 0, 2)
        Me.Panel_Labels.Controls.Add(Me.Lab_Salir, 0, 4)
        Me.Panel_Labels.Controls.Add(Me.Lab_Inicio, 0, 1)
        Me.Panel_Labels.Controls.Add(Me.Lab_Config, 0, 3)
        Me.Panel_Labels.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Labels.Location = New System.Drawing.Point(50, 28)
        Me.Panel_Labels.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Labels.Name = "Panel_Labels"
        Me.Panel_Labels.RowCount = 6
        Me.Panel_Labels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.Panel_Labels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.Panel_Labels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.Panel_Labels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.Panel_Labels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.Panel_Labels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel_Labels.Size = New System.Drawing.Size(1, 447)
        Me.Panel_Labels.TabIndex = 6
        '
        'Lab_Menu
        '
        Me.Lab_Menu.AutoSize = True
        Me.Lab_Menu.BackColor = System.Drawing.SystemColors.Highlight
        Me.Lab_Menu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lab_Menu.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Lab_Menu.ForeColor = System.Drawing.Color.White
        Me.Lab_Menu.Location = New System.Drawing.Point(0, 0)
        Me.Lab_Menu.Margin = New System.Windows.Forms.Padding(0)
        Me.Lab_Menu.Name = "Lab_Menu"
        Me.Lab_Menu.Size = New System.Drawing.Size(1, 50)
        Me.Lab_Menu.TabIndex = 0
        Me.Lab_Menu.Text = "Menú"
        Me.Lab_Menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lab_Usuario
        '
        Me.Lab_Usuario.AutoSize = True
        Me.Lab_Usuario.BackColor = System.Drawing.SystemColors.Highlight
        Me.Lab_Usuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lab_Usuario.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Lab_Usuario.ForeColor = System.Drawing.Color.White
        Me.Lab_Usuario.Location = New System.Drawing.Point(0, 100)
        Me.Lab_Usuario.Margin = New System.Windows.Forms.Padding(0)
        Me.Lab_Usuario.Name = "Lab_Usuario"
        Me.Lab_Usuario.Size = New System.Drawing.Size(1, 50)
        Me.Lab_Usuario.TabIndex = 0
        Me.Lab_Usuario.Text = "Usuarios"
        Me.Lab_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lab_Salir
        '
        Me.Lab_Salir.AutoSize = True
        Me.Lab_Salir.BackColor = System.Drawing.SystemColors.Highlight
        Me.Lab_Salir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lab_Salir.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Lab_Salir.ForeColor = System.Drawing.Color.White
        Me.Lab_Salir.Location = New System.Drawing.Point(0, 200)
        Me.Lab_Salir.Margin = New System.Windows.Forms.Padding(0)
        Me.Lab_Salir.Name = "Lab_Salir"
        Me.Lab_Salir.Size = New System.Drawing.Size(1, 50)
        Me.Lab_Salir.TabIndex = 0
        Me.Lab_Salir.Text = "Salir"
        Me.Lab_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lab_Inicio
        '
        Me.Lab_Inicio.AutoSize = True
        Me.Lab_Inicio.BackColor = System.Drawing.SystemColors.Highlight
        Me.Lab_Inicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lab_Inicio.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Lab_Inicio.ForeColor = System.Drawing.Color.White
        Me.Lab_Inicio.Location = New System.Drawing.Point(0, 50)
        Me.Lab_Inicio.Margin = New System.Windows.Forms.Padding(0)
        Me.Lab_Inicio.Name = "Lab_Inicio"
        Me.Lab_Inicio.Size = New System.Drawing.Size(1, 50)
        Me.Lab_Inicio.TabIndex = 0
        Me.Lab_Inicio.Text = "Inicio"
        Me.Lab_Inicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lab_Config
        '
        Me.Lab_Config.AutoSize = True
        Me.Lab_Config.BackColor = System.Drawing.SystemColors.Highlight
        Me.Lab_Config.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lab_Config.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.Lab_Config.ForeColor = System.Drawing.Color.White
        Me.Lab_Config.Location = New System.Drawing.Point(0, 150)
        Me.Lab_Config.Margin = New System.Windows.Forms.Padding(0)
        Me.Lab_Config.Name = "Lab_Config"
        Me.Lab_Config.Size = New System.Drawing.Size(1, 50)
        Me.Lab_Config.TabIndex = 0
        Me.Lab_Config.Text = "Configuración"
        Me.Lab_Config.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel_Iconos
        '
        Me.Panel_Iconos.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel_Iconos.ColumnCount = 1
        Me.Panel_Iconos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel_Iconos.Controls.Add(Me.Pic_Close, 0, 4)
        Me.Panel_Iconos.Controls.Add(Me.Pic_Config, 0, 3)
        Me.Panel_Iconos.Controls.Add(Me.Pic_Home, 0, 1)
        Me.Panel_Iconos.Controls.Add(Me.Pic_Menu, 0, 0)
        Me.Panel_Iconos.Controls.Add(Me.Pic_Login, 0, 2)
        Me.Panel_Iconos.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Iconos.Location = New System.Drawing.Point(0, 28)
        Me.Panel_Iconos.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel_Iconos.Name = "Panel_Iconos"
        Me.Panel_Iconos.RowCount = 6
        Me.Panel_Iconos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.Panel_Iconos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.Panel_Iconos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.Panel_Iconos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.Panel_Iconos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.Panel_Iconos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel_Iconos.Size = New System.Drawing.Size(50, 447)
        Me.Panel_Iconos.TabIndex = 5
        '
        'Pic_Close
        '
        Me.Pic_Close.Location = New System.Drawing.Point(0, 200)
        Me.Pic_Close.Margin = New System.Windows.Forms.Padding(0)
        Me.Pic_Close.Name = "Pic_Close"
        Me.Pic_Close.Padding = New System.Windows.Forms.Padding(10)
        Me.Pic_Close.Size = New System.Drawing.Size(50, 50)
        Me.Pic_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Close.TabIndex = 4
        Me.Pic_Close.TabStop = False
        '
        'Pic_Config
        '
        Me.Pic_Config.Location = New System.Drawing.Point(0, 150)
        Me.Pic_Config.Margin = New System.Windows.Forms.Padding(0)
        Me.Pic_Config.Name = "Pic_Config"
        Me.Pic_Config.Padding = New System.Windows.Forms.Padding(10)
        Me.Pic_Config.Size = New System.Drawing.Size(50, 50)
        Me.Pic_Config.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Config.TabIndex = 5
        Me.Pic_Config.TabStop = False
        '
        'Pic_Home
        '
        Me.Pic_Home.Location = New System.Drawing.Point(0, 50)
        Me.Pic_Home.Margin = New System.Windows.Forms.Padding(0)
        Me.Pic_Home.Name = "Pic_Home"
        Me.Pic_Home.Padding = New System.Windows.Forms.Padding(10)
        Me.Pic_Home.Size = New System.Drawing.Size(50, 50)
        Me.Pic_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Home.TabIndex = 6
        Me.Pic_Home.TabStop = False
        '
        'Pic_Menu
        '
        Me.Pic_Menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pic_Menu.Location = New System.Drawing.Point(0, 0)
        Me.Pic_Menu.Margin = New System.Windows.Forms.Padding(0)
        Me.Pic_Menu.Name = "Pic_Menu"
        Me.Pic_Menu.Padding = New System.Windows.Forms.Padding(10)
        Me.Pic_Menu.Size = New System.Drawing.Size(50, 50)
        Me.Pic_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Menu.TabIndex = 3
        Me.Pic_Menu.TabStop = False
        '
        'Pic_Login
        '
        Me.Pic_Login.Location = New System.Drawing.Point(0, 100)
        Me.Pic_Login.Margin = New System.Windows.Forms.Padding(0)
        Me.Pic_Login.Name = "Pic_Login"
        Me.Pic_Login.Padding = New System.Windows.Forms.Padding(10)
        Me.Pic_Login.Size = New System.Drawing.Size(50, 50)
        Me.Pic_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Login.TabIndex = 4
        Me.Pic_Login.TabStop = False
        '
        'Temporizador
        '
        Me.Temporizador.Interval = 1
        '
        'Win_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 503)
        Me.Controls.Add(Me.Panel_Labels)
        Me.Controls.Add(Me.Panel_Iconos)
        Me.Controls.Add(Me.Panel_Down)
        Me.Controls.Add(Me.Panel_Top)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Win_Principal"
        Me.Text = "Win_Principal"
        Me.Panel_Labels.ResumeLayout(False)
        Me.Panel_Labels.PerformLayout()
        Me.Panel_Iconos.ResumeLayout(False)
        CType(Me.Pic_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Config, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Menu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Top As Panel
    Friend WithEvents Panel_Down As Panel
    Friend WithEvents Panel_Labels As TableLayoutPanel
    Friend WithEvents Lab_Menu As Label
    Friend WithEvents Lab_Usuario As Label
    Friend WithEvents Lab_Salir As Label
    Friend WithEvents Lab_Inicio As Label
    Friend WithEvents Lab_Config As Label
    Friend WithEvents Panel_Iconos As TableLayoutPanel
    Friend WithEvents Pic_Close As PictureBox
    Friend WithEvents Pic_Config As PictureBox
    Friend WithEvents Pic_Home As PictureBox
    Friend WithEvents Pic_Menu As PictureBox
    Friend WithEvents Pic_Login As PictureBox
    Friend WithEvents Temporizador As Timer
End Class
