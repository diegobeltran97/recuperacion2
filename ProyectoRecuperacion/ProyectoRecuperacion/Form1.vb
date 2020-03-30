Public Class Form1

    'Variables en mayusculas son parte del formulario
    'Variables en minisculo son parte del user Object
    Dim barco_Combustible As New BarcoCombustible(Me.Width)
    Dim lancha_Salvavidas As New LanchaSalvavidas()
    Dim surv As New Survivor(Me.Width, Me.Height)
    Dim tib As New Tiburon(Me.Width, Me.Height)


    Dim pic_Planta As PictureBox


    Dim movimiento = 5

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()


        Controls.Add(surv.imagen_sobrev)
        Controls.Add(tib.imagen_tiburon)




        'tmr_Mover.Start()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lancha_Salvavidas.direccionx = 0
        lancha_Salvavidas.direcciony = 0


    End Sub

    Private Sub GeneralTime_Tick(sender As Object, e As EventArgs) Handles generalTime.Tick
        txt_tiempo.Text = Val(txt_tiempo.Text) + 1
    End Sub


    Private Sub TimerBarcoCombustible_Tick(sender As Object, e As EventArgs) Handles TimerBarcoCombustible.Tick
        barco_Combustible.position_x = Barcobtn.Location.X + movimiento
        barco_Combustible.position_y = Barcobtn.Location.Y
        barco_Combustible.movimientoBuque(Me.Width)
        Barcobtn.Location = New Point(barco_Combustible.positionx, barco_Combustible.positiony)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timer_movLancha.Tick
        lancha_Salvavidas.position_x = lancha_imagen.Location.X
        lancha_Salvavidas.position_y = lancha_imagen.Location.Y

        If lancha_Salvavidas.position_y <= 82 Then
            lancha_Salvavidas.position_y = 82
            lancha_Salvavidas.direcciony = -lancha_Salvavidas.direcciony
        End If
        If lancha_Salvavidas.position_y >= Me.Height - lancha_imagen.Height - 35 Then
            lancha_Salvavidas.position_y = Me.Height - lancha_imagen.Height - 35
            lancha_Salvavidas.direcciony = -lancha_Salvavidas.direcciony
        End If

        If lancha_Salvavidas.position_x <= 0 Then
            lancha_Salvavidas.position_x = 0
            lancha_Salvavidas.direccionx = -lancha_Salvavidas.direccionx
        End If
        If lancha_Salvavidas.position_x >= Me.Width - lancha_imagen.Width Then
            lancha_Salvavidas.position_x = Me.Width - lancha_imagen.Width
            lancha_Salvavidas.direccionx = -lancha_Salvavidas.direccionx
        End If

        lancha_imagen.Location = New Point(lancha_Salvavidas.position_x + lancha_Salvavidas.direccionx, lancha_Salvavidas.position_y + lancha_Salvavidas.direcciony)

    End Sub

    Private Sub Btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        generalTime.Start()
        TimerBarcoCombustible.Start()
        timer_movLancha.Start()
        mov_survivor.Start()
        mov_Tiburon.Start()




    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean


        Select Case keyData
            Case Keys.Up
                lancha_Salvavidas.direcciony -= 1
            Case Keys.Down
                lancha_Salvavidas.direcciony += 1
            Case Keys.Left
                lancha_Salvavidas.direccionx -= 1
            Case Keys.Right
                lancha_Salvavidas.direccionx += 1
        End Select




            Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Mov_survivor_Tick(sender As Object, e As EventArgs) Handles mov_survivor.Tick
        surv.survivorMovimiento(Me.Width, Me.Height, lancha_imagen)
        rule_Salvavidas()
    End Sub

    Function rule_Salvavidas()




        If surv.imagen_sobrev.Bounds.IntersectsWith(lancha_imagen.Bounds) Then
            Dim rnd As New Random()
            surv.imagen_sobrev.Location = New Point(rnd.Next(Me.Width), rnd.Next(Me.Height))
        End If

    End Function

    Function rule_tiburon()




        If surv.imagen_sobrev.Bounds.IntersectsWith(lancha_imagen.Bounds) Then
            Dim rnd As New Random()
            surv.imagen_sobrev.Location = New Point(rnd.Next(Me.Width), rnd.Next(Me.Height))
        End If

    End Function

    Function rule_lancha()




        If surv.imagen_sobrev.Bounds.IntersectsWith(lancha_imagen.Bounds) Then
            Dim rnd As New Random()
            surv.imagen_sobrev.Location = New Point(rnd.Next(Me.Width), rnd.Next(Me.Height))
        End If

    End Function

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Mov_Tiburon_Tick(sender As Object, e As EventArgs) Handles mov_Tiburon.Tick
        tib.tiburon_mov(Me.Width, Me.Height, lancha_imagen)
    End Sub
End Class
