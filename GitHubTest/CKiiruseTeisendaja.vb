Public Class CKiiruseTeisendaja
    Implements IKiiruseTeisendaja

    Private Function KmhToMs(kmh As Double) As Double Implements IKiiruseTeisendaja.KmhToMs
        Return kmh / 3.6
    End Function

    Private Function MsToKmh(ms As Double) As Double Implements IKiiruseTeisendaja.MsToKmh
        Return ms * 3.6
    End Function
End Class
