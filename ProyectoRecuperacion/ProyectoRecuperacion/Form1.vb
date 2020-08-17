Imports System.Linq.Expressions

Public Class Form1

    'Variables en mayusculas son parte del formulario
    'Variables en minisculo son parte del user Object
    Dim barco_Combustible As New BarcoCombustible(Me.Width)
    Dim lancha_Salvavidas As New LanchaSalvavidas()
    Dim surv As New Survivor(Me.Width, Me.Height)
    Dim tib As New Tiburon(Me.Width, Me.Height)

    Dim v_surv(4) As Survivor
    Dim nivel = 1

    Dim lista_surv As New List(Of Survivor)



    Dim movimiento = 5

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()



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
        rule_lancha()
    End Sub

    Private Sub Btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        generalTime.Start()
        TimerBarcoCombustible.Start()
        timer_movLancha.Start()

        crearSobrevivientes()
        mov_survivor.Start()
        mov_Tiburon.Start()

        Controls.Add(surv.imagen_sobrev)






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
        For Each sobr In lista_surv
            Controls.Add(sobr.survivorMovimiento(Me.Width, Me.Height, lancha_imagen))
        Next
        rule_Salvavidas()
    End Sub

    Function rule_Salvavidas()




        If surv.imagen_sobrev.Bounds.IntersectsWith(tib.imagen_tiburon.Bounds) Then
            Dim rnd As New Random()
            surv.imagen_sobrev.Location = New Point(rnd.Next(Me.Width), rnd.Next(Me.Height))
        End If

        For Each sobr In lista_surv
            If sobr.imagen_sobrev.Bounds.IntersectsWith(tib.imagen_tiburon.Bounds) Then
                Dim rnd As New Random()
                surv.imagen_sobrev.Location = New Point(rnd.Next(Me.Width), rnd.Next(Me.Height))
            End If
        Next



    End Function

    Function rule_tiburon()




        If surv.imagen_sobrev.Bounds.IntersectsWith(lancha_imagen.Bounds) Then
            Dim rnd As New Random()
            surv.imagen_sobrev.Location = New Point(rnd.Next(Me.Width), rnd.Next(Me.Height))
        End If

    End Function

    Function rule_lancha()

        If lancha_imagen.Bounds.IntersectsWith(tib.imagen_tiburon.Bounds) Then
            Dim rnd As New Random()
            lancha_imagen.Location = New Point(67, 378)
            rules_game(2)
        End If


        For Each sobr In lista_surv
            If lancha_imagen.Bounds.IntersectsWith(sobr.imagen_sobrev.Bounds) Then
                Dim rnd As New Random()
                sobr.imagen_sobrev.Location = New Point(rnd.Next(Me.Width), rnd.Next(Me.Height))
                rules_game(1)
            End If

        Next






    End Function

    Function crearSobrevivientes()
        For Each sobreviviente In v_surv
            sobreviviente = New Survivor(Me.Width, Me.Height)
            lista_surv.Add(sobreviviente)
        Next

        For Each sobr In lista_surv
            Controls.Add(sobr.imagen_sobrev)
        Next





    End Function
    Function rules_game(value As Integer)


        Dim Number = value

        Select Case Number
            Case 1  'Incrementa la vida de los salvavidas' 
                number_survivor_saved.Text = Val(number_survivor_saved.Text) + 1

                If number_survivor_saved.Text = "9" Then
                    rules_game(3)
                End If

            Case 2  'Pierda Vidas el bote'. 
                life_boat_txt.Text = Val(life_boat_txt.Text) - 1

            Case 3 'Llego a todas las vidas'

                MessageBox.Show("Ganaste" & vbNewLine &
                       "Universidad Tecnológica de Panamá" & vbNewLine &
                       "Facultad de Ingeniería en Sistemas Computacionales" & vbNewLine &
                       "Licenciatura en Desarrollo de Software" & vbNewLine &
                       "Profesor: Ricardo Chan" & vbNewLine &
                       "Autor: Diego Sastoque" & vbNewLine &
                       "Cédula: 20-14-3061")
            Case 4 'Perdio a todas las vidas'

                MessageBox.Show("Perdiste" & vbNewLine &
                       "Universidad Tecnológica de Panamá" & vbNewLine &
                       "Facultad de Ingeniería en Sistemas Computacionales" & vbNewLine &
                       "Licenciatura en Desarrollo de Software" & vbNewLine &
                       "Profesor: Ricardo Chan" & vbNewLine &
                       "Autor: Diego Sastoque" & vbNewLine &
                       "Cédula: 20-14-3061")


        End Select




    End Function



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Mov_Tiburon_Tick(sender As Object, e As EventArgs) Handles mov_Tiburon.Tick
        tib.tiburon_mov(Me.Width, Me.Height, lancha_imagen)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
