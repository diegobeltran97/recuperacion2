Public Class Tiburon
    Inherits User

    Dim dirx
    Dim diry
    Dim rnd
    Public imagen_tiburon As PictureBox



    Public Sub New(ancho As Integer, alto As Integer)

        widthForm = ancho
        heightForm = alto

        imagen_tiburon = New PictureBox()
        imagen_tiburon.Size = New Size(50, 50)
        rnd = New Random()
        imagen_tiburon.Location = New Point(rnd.Next(widthForm - imagen_tiburon.Width), rnd.Next(heightForm - headerHeight - imagen_tiburon.Height))
        imagen_tiburon.Image = Image.FromFile("Resources\tiburon.jpg")
        imagen_tiburon.SizeMode = PictureBoxSizeMode.StretchImage
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

    Public Function tiburon_mov(wi As Integer, he As Integer, lancha As PictureBox)
        Dim x, y As Integer
        Dim ancho, alto As Integer

        x = imagen_tiburon.Location.X
        y = imagen_tiburon.Location.Y
        ancho = wi
        alto = he


        Debug.WriteLine(lancha.Bounds)


        If y <= headerHeight Then
            y = headerHeight
            diry = -diry
        End If
        If y >= alto - imagen_tiburon.Height - 30 Then
            y = alto - imagen_tiburon.Height - 30
            diry = -diry
        End If

        If x <= 0 Then
            x = 0
            dirx = -dirx
        End If
        If x >= ancho - imagen_tiburon.Width Then
            x = ancho - imagen_tiburon.Width
            dirx = -dirx
        End If

        imagen_tiburon.Location = New Point(x + dirx, y + diry)


    End Function


End Class
