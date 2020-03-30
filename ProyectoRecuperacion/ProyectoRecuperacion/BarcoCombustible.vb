Public Class BarcoCombustible
    'Posee dos limitantes en x
    Inherits User

    Public Sub New(ancho As Integer)
        widthForm = ancho

    End Sub

    Public Function movimientoBuque(ancho As Integer)


        If Me.positionx >= ancho Then
            Me.position_x = 12
        End If




    End Function


End Class
