Public Class Survivor
    Inherits User
    Dim dirx
    Dim diry
    Dim rnd
    Public imagen_sobrev As PictureBox



    Public Sub New(ancho As Integer, alto As Integer)

        widthForm = ancho
        heightForm = alto

        imagen_sobrev = New PictureBox()
        imagen_sobrev.Size = New Size(50, 50)
        rnd = New Random()
        imagen_sobrev.Location = New Point(rnd.Next(widthForm - imagen_sobrev.Width), rnd.Next(heightForm - headerHeight - imagen_sobrev.Height))
        imagen_sobrev.Image = Image.FromFile("Resources\sobreviente.png")
        imagen_sobrev.SizeMode = PictureBoxSizeMode.StretchImage
        dirx = 4
        diry = 4


    End Sub

    Public Property direcciony() As Integer
        Get
            ' Gets the property value.
            Return diry
        End Get
        Set(ByVal Value As Integer)
            ' Sets the property value.
            diry = Value
        End Set
    End Property


    Public Property direccionx() As Integer
        Get
            ' Gets the property value.
            Return dirx
        End Get
        Set(ByVal Value As Integer)
            ' Sets the property value.
            dirx = Value
        End Set
    End Property

    Public Function survivorMovimiento(wi As Integer, he As Integer, lancha As PictureBox)
        Dim x, y As Integer
        Dim ancho, alto As Integer

        x = imagen_sobrev.Location.X
        y = imagen_sobrev.Location.Y
        ancho = wi
        alto = he


        Debug.WriteLine(lancha.Bounds)


        If y <= headerHeight Then
            y = headerHeight
            diry = -diry
        End If
        If y >= alto - imagen_sobrev.Height - 30 Then
            y = alto - imagen_sobrev.Height - 30
            diry = -diry
        End If

        If x <= 0 Then
            x = 0
            dirx = -dirx
        End If
        If x >= ancho - imagen_sobrev.Width Then
            x = ancho - imagen_sobrev.Width
            dirx = -dirx
        End If

        imagen_sobrev.Location = New Point(x + dirx, y + diry)


    End Function


End Class
