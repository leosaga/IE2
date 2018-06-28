Public Class GrillaTurnos

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.operacion = "alta"
        Form1.Text = "Nuevo Turno"
        Form1.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.operacion = "modifica"
        Form1.Text = "Modificar Turno"
        Form1.indice = DataGridView1.CurrentRow.Index
        llenarform()
        Form1.Show()

    End Sub

    Private Sub llenarform()
        Form1.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        Form1.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        Form1.TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        Form1.ComboBox1.SelectedItem = DataGridView1.CurrentRow.Cells(3).Value.ToString
        Form1.ComboBox2.SelectedItem = DataGridView1.CurrentRow.Cells(4).Value.ToString
        Form1.ComboBox3.SelectedItem = DataGridView1.CurrentRow.Cells(5).Value.ToString
    End Sub
    Private Sub GrillaTurnos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = lst
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click

        Form1.operacion = "elimina"
        Form1.Text = "Elimina Turno"
        Form1.indice = DataGridView1.CurrentRow.Index
        llenarform()
        Form1.Show()
    End Sub
End Class