Imports System.Data.SqlClient

Public Class Student
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\LibrariaDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub ShfaqListe()
        Con.Open()
        Dim query = "select * from Student"
        Dim adaptor As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adaptor = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adaptor)
        Dim ds = New DataSet()
        adaptor.Fill(ds)
        StudentGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub Ruaj_Click(sender As Object, e As EventArgs) Handles Ruaj.Click
        If EmerSt.Text = "" Or DepSt.Text = "" Or SemCB.SelectedIndex = -1 Or NrTelSt.Text = "" Then
            MsgBox("Nuk ka informacion te Mjaftueshem!")
        Else
            Con.Open()
            Dim query As String
            query = "insert into Student values ('" & EmerSt.Text & "','" & DepSt.Text & "', " & SemCB.SelectedItem.ToString() & "," & NrTelSt.Text & ")"

            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()

            MsgBox("Libri u ruajt me sukses!")
            Con.Close()
            ShfaqListe()
            Reset()
        End If
    End Sub

    Private Sub Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShfaqListe()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Dim celes = 0
    Private Sub Reset()
        EmerSt.Text = ""
        DepSt.Text = ""
        SemCB.SelectedIndex = 0
        NrTelSt.Text = ""
        celes = 0
    End Sub

    Private Sub Rivendos_Click(sender As Object, e As EventArgs) Handles Rivendos.Click
        Reset()
    End Sub

    Private Sub StudentGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles StudentGV.CellMouseClick
        Dim rresht As DataGridViewRow = StudentGV.Rows(e.RowIndex)
        EmerSt.Text = rresht.Cells(1).Value.ToString
        DepSt.Text = rresht.Cells(2).Value.ToString
        SemCB.SelectedItem = rresht.Cells(3).Value.ToString
        NrTelSt.Text = rresht.Cells(4).Value.ToString

        If EmerSt.Text = "" Then
            celes = 0
        Else
            celes = Convert.ToInt32(rresht.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Fshi_Click(sender As Object, e As EventArgs) Handles Fshi.Click
        If celes = 0 Then
            MsgBox("Nuk ka informacion te Mjaftueshem!")
        Else
            Con.Open()
            Dim query = "delete from Student where StId=" & celes & " "

            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()

            MsgBox("Te dhenat u fshine me sukses!")
            Con.Close()
            ShfaqListe()
            Reset()
        End If
    End Sub

    Private Sub Ndrysho_Click(sender As Object, e As EventArgs) Handles Ndrysho.Click
        If EmerSt.Text = "" Or DepSt.Text = "" Or SemCB.SelectedIndex = -1 Or NrTelSt.Text = "" Then
            MsgBox("Nuk ka informacion te Mjaftueshem!")
        Else
            Con.Open()
            Dim query As String
            query = "Update Student set EmerSt = '" & EmerSt.Text & "',DepSt = '" & DepSt.Text & "', SemSt=" & SemCB.SelectedItem.ToString() & ",NrTelSt = " & NrTelSt.Text & " where StId=" & celes & ""

            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()

            MsgBox("Studenti u perditesua!")
            Con.Close()
            ShfaqListe()
            Reset()
        End If
    End Sub

    Private Sub kthehu_Click(sender As Object, e As EventArgs) Handles kthehu.Click
        Dim obj = New fKryesor
        obj.Show()
        Me.Hide()
    End Sub
End Class