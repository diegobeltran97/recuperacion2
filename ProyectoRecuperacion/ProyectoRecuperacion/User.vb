Public Class User

    Public positionx As Integer
    Public positiony As Integer
    Public widthForm, heightForm As Integer
    Public headerHeight = 82



    Public Property position_x() As Integer
        Get
            ' Gets the property value.
            Return positionx
        End Get
        Set(ByVal Value As Integer)
            ' Sets the property value.
            positionx = Value
        End Set
    End Property


    Public Property position_y() As Integer
        Get
            ' Gets the property value.
            Return positiony
        End Get
        Set(ByVal Value As Integer)
            ' Sets the property value.
            positiony = Value
        End Set
    End Property

End Class
