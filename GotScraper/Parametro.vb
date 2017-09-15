Public Class Parametro
    Private m_chiave As String
    Private m_valore As String

    Public Property Chiave() As String
        Get
            Return m_chiave
        End Get
        Set(ByVal value As String)
            m_chiave = value
        End Set
    End Property

    Public Property Valore() As String
        Get
            Return m_valore
        End Get
        Set(ByVal value As String)
            m_valore = value
        End Set
    End Property

    Public Sub New(ByVal nomeChiave As String, ByVal valoreChiave As String)

        m_chiave = nomeChiave
        m_valore = valoreChiave

    End Sub

    Public Overrides Function ToString() As String

        Return m_chiave & " = " & m_valore

    End Function
End Class
