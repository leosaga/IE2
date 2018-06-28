Public Class Form1
    Dim pos As Integer
    Dim operacion_ As String

    Dim fecha As Date

    Dim miturno As New Turnos

    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property
    Dim indice_ As Byte
    Public Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)
            indice_ = value
        End Set
    End Property

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = ComboBox2.SelectedItem Or ComboBox1.SelectedItem = ComboBox3.SelectedItem Or ComboBox2.SelectedItem = ComboBox3.SelectedItem Then
            MsgBox(" combos iguales")
        End If
        If TextBox1.Text = "" Then
            MsgBox("Ingrese un ID")
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MsgBox("Ingrese una Fecha")
            Exit Sub
        End If
        If TextBox3.Text = "" Then
            MsgBox("Ingrese una Asignatura")
            Exit Sub
        End If


        If ComboBox1.SelectedItem = "" Then
            MsgBox("Ingrese un Profesor")
            Exit Sub
        End If
        If ComboBox2.SelectedItem = "" Then
            MsgBox("Ingrese un Profesor")
            Exit Sub
        End If
        If ComboBox3.SelectedItem = "" Then
            MsgBox("Ingrese un Profesor")
            Exit Sub
        End If
        miturno.id = CInt(TextBox1.Text)
        miturno.fecha = CDate(TextBox2.Text)
        miturno.asignatura = TextBox3.Text
        miturno.docente = ComboBox1.SelectedItem
        miturno.vocal1 = ComboBox2.SelectedItem
        miturno.vocal2 = ComboBox3.SelectedItem
        Select Case operacion_
            Case "alta"
                lst.Add(miturno)
            Case "elimina"
                lst.RemoveAt(indice_)
            Case "modifica"
                lst.Item(indice_) = miturno

                GrillaTurnos.DataGridView1.Refresh()
        End Select
        Me.Close()

    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then

            e.Handled = True
       
            Exit Sub
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        'Dim fecha As Date
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "/" Then

            e.Handled = True
            'sale sin procesar
            Exit Sub

        End If
        'TextBox1.SelectionStart (obtiene la posicion del cursor)

        Dim pos As Integer = TextBox2.SelectionStart

        ' si la tecla pulsada es / y la posicion del cursor es distinta de 2y la posicion del cursor es distinto de 5 entonces habilitar handled y salir
        If e.KeyChar = "/" And pos <> 2 And pos <> 5 Then
            e.Handled = True
            Exit Sub
        End If
        'si la tecla pulsada es un numero y pos es 2 o 5 entonces habilitar handled y salir
        If Char.IsNumber(e.KeyChar) And (pos = 2 Or pos = 5) Then
            e.Handled = True
            Exit Sub
        End If

        'If CDate(TextBox2.Text) > DateTime.Now Then
        'Exit Sub
        'End If


    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
        
    End Sub




    






    'Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    For Each item As String In ComboBox1.SelectedItem
    '        ComboBox2.Items.Add(item)
    '        ComboBox3.Items.Add(item)
    '    Next
    'End Sub

    
   




End Class
