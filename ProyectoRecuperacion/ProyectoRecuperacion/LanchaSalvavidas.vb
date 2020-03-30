Public Class LanchaSalvavidas
    Inherits User
    Dim dirx
    Dim diry



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





End Class
