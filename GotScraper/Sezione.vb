Public Class Sezione
    Inherits List(Of Parametro)

    Private m_nome As String
    Private m_commento As String

    Public Property Nome() As String
        Get
            Return m_nome
        End Get
        Set(ByVal value As String)
            m_nome = value
        End Set
    End Property

    Public Property Commento() As String
        Get
            Return m_commento
        End Get
        Set(ByVal value As String)
            m_commento = value
        End Set
    End Property

    Public Sub New(ByVal nome As String, Optional ByVal commento As String = "")

        m_nome = nome
        If commento <> "" Then m_commento = commento

    End Sub

    Public Function GetParametroByNome(ByVal nomeParametro As String) As Parametro

        For Each P As Parametro In Me
            If P.Chiave = nomeParametro Then Return P
        Next
        Return Nothing

    End Function
End Class
