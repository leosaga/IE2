Public Class Turnos

    Dim id_ As Integer
    Dim fecha_ As Date
    Dim docente_, vocal1_, vocal2_, asignatura_ As String


    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property
    Public Property fecha() As Date
        Get
            Return fecha_
        End Get
        Set(ByVal value As Date)
            fecha_ = value
        End Set
    End Property


    Public Property asignatura() As String
        Get
            Return asignatura_
        End Get
        Set(ByVal value As String)
            asignatura_ = value
        End Set
    End Property

    Public Property docente() As String
        Get
            Return docente_
        End Get
        Set(ByVal value As String)
            docente_ = value
        End Set
    End Property
    Public Property vocal1() As String
        Get
            Return vocal1_
        End Get
        Set(ByVal value As String)
            vocal1_ = value
        End Set
    End Property

    Public Property vocal2() As String
        Get
            Return vocal2_
        End Get
        Set(ByVal value As String)
            vocal2_ = value
        End Set
    End Property
End Class
