﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.time = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_level = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_tiempo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_iniciar = New System.Windows.Forms.Button()
        Me.generalTime = New System.Windows.Forms.Timer(Me.components)
        Me.Barcobtn = New System.Windows.Forms.Button()
        Me.TimerBarcoCombustible = New System.Windows.Forms.Timer(Me.components)
        Me.lancha_imagen = New System.Windows.Forms.PictureBox()
        Me.timer_movLancha = New System.Windows.Forms.Timer(Me.components)
        Me.mov_Tiburon = New System.Windows.Forms.Timer(Me.components)
        Me.mov_survivor = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.lancha_imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.time)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_level)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_tiempo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_iniciar)
        Me.Panel1.Location = New System.Drawing.Point(-6, -4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 82)
        Me.Panel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(447, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "0"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(466, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "/"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(485, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "3"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(392, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Salvados"
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.Location = New System.Drawing.Point(353, 38)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(13, 13)
        Me.time.TabIndex = 6
        Me.time.Text = "1"
        Me.time.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Vidas"
        '
        'txt_level
        '
        Me.txt_level.AutoSize = True
        Me.txt_level.Location = New System.Drawing.Point(266, 38)
        Me.txt_level.Name = "txt_level"
        Me.txt_level.Size = New System.Drawing.Size(13, 13)
        Me.txt_level.TabIndex = 4
        Me.txt_level.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nivel"
        '
        'txt_tiempo
        '
        Me.txt_tiempo.AutoSize = True
        Me.txt_tiempo.Location = New System.Drawing.Point(176, 38)
        Me.txt_tiempo.Name = "txt_tiempo"
        Me.txt_tiempo.Size = New System.Drawing.Size(13, 13)
        Me.txt_tiempo.TabIndex = 2
        Me.txt_tiempo.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tiempo"
        '
        'btn_iniciar
        '
        Me.btn_iniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_iniciar.Location = New System.Drawing.Point(27, 28)
        Me.btn_iniciar.Name = "btn_iniciar"
        Me.btn_iniciar.Size = New System.Drawing.Size(77, 31)
        Me.btn_iniciar.TabIndex = 0
        Me.btn_iniciar.Text = "Iniciar"
        Me.btn_iniciar.UseVisualStyleBackColor = True
        '
        'generalTime
        '
        Me.generalTime.Interval = 1000
        '
        'Barcobtn
        '
        Me.Barcobtn.Location = New System.Drawing.Point(12, 415)
        Me.Barcobtn.Name = "Barcobtn"
        Me.Barcobtn.Size = New System.Drawing.Size(75, 23)
        Me.Barcobtn.TabIndex = 1
        Me.Barcobtn.Text = "Barco"
        Me.Barcobtn.UseVisualStyleBackColor = True
        '
        'TimerBarcoCombustible
        '
        '
        'lancha_imagen
        '
        Me.lancha_imagen.BackColor = System.Drawing.SystemColors.ControlDark
        Me.lancha_imagen.BackgroundImage = CType(resources.GetObject("lancha_imagen.BackgroundImage"), System.Drawing.Image)
        Me.lancha_imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lancha_imagen.Location = New System.Drawing.Point(50, 307)
        Me.lancha_imagen.Name = "lancha_imagen"
        Me.lancha_imagen.Size = New System.Drawing.Size(100, 50)
        Me.lancha_imagen.TabIndex = 4
        Me.lancha_imagen.TabStop = False
        '
        'timer_movLancha
        '
        Me.timer_movLancha.Interval = 200
        '
        'mov_Tiburon
        '
        '
        'mov_survivor
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lancha_imagen)
        Me.Controls.Add(Me.Barcobtn)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "ProyectRecuperacion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.lancha_imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_tiempo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_iniciar As Button
    Friend WithEvents generalTime As Timer
    Friend WithEvents txt_level As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Barcobtn As Button
    Friend WithEvents TimerBarcoCombustible As Timer
    Friend WithEvents lancha_imagen As PictureBox
    Friend WithEvents timer_movLancha As Timer
    Friend WithEvents mov_Tiburon As Timer
    Friend WithEvents mov_survivor As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents time As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class