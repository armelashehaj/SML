Imports System.Data.SqlClient
Public Class Problematikat
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\LibrariaDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub ShfaqListe()
        Con.Open()
        Dim query = "select * from TProblematika"
        Dim adaptor As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adaptor = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adaptor)
        Dim ds = New DataSet()
        adaptor.Fill(ds)
        ProblemGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub GetEmerSt()
        Con.Open()
        Dim query = "select * from Student where StId=" & StIdCb.SelectedValue.ToString() & ""
        Dim cmd = New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim lexues As SqlDataReader
        lexues = cmd.ExecuteReader()
        While lexues.Read
            StEmer.Text = "" + lexues(1).ToString()
        End While
        Con.Close()
    End Sub

    Private Sub GetTitullL()
        Con.Open()
        Dim query = "select * from Liber where LId=" & LiberIdCb.SelectedValue.ToString() & ""
        Dim cmd = New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim lexues As SqlDataReader
        lexues = cmd.ExecuteReader()
        While lexues.Read
            TitullL.Text = "" + lexues(1).ToString()
        End While
        Con.Close()
    End Sub

    Private Sub FillSt()
        Con.Open()
        Dim query = "select * from Student"
        Dim cmd As New SqlCommand(query, Con)
        Dim adaptor As New SqlDataAdapter(cmd)
        Dim Tb1 As New DataTable()
        adaptor.Fill(Tb1)
        StIdCb.DataSource = Tb1
        StIdCb.DisplayMember = "StId"
        StIdCb.ValueMember = "StId"
        Con.Close()
    End Sub
    Private Sub FillL()
        Con.Open()
        Dim query = "select * from Liber"
        Dim cmd As New SqlCommand(query, Con)
        Dim adaptor As New SqlDataAdapter(cmd)
        Dim Tb1 As New DataTable()
        adaptor.Fill(Tb1)
        LiberIdCb.DataSource = Tb1
        LiberIdCb.DisplayMember = "LId"
        LiberIdCb.ValueMember = "LId"
        Con.Close()
    End Sub

    Dim nr = 0
    Private Sub NrILibraveTeMarrHua()

        Con.Open()
        Dim query = "select Count(*) from TProblematika where StId=" & StIdCb.SelectedValue.ToString() & ""
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        nr = cmd.ExecuteScalar
        Con.Close()
    End Sub

    Private Sub ruaj_Click(sender As Object, e As EventArgs) Handles ruaj.Click
        NrILibraveTeMarrHua()
        If StEmer.Text = "" Or TitullL.Text = "" Or StIdCb.SelectedIndex = -1 Or LiberIdCb.SelectedIndex = -1 Then
            MsgBox("Nuk ka informacion te Mjaftueshem!")
        ElseIf nr = 5 Then
            MsgBox("Ju nuk mund te huazoni me shume libra !")
        Else
            Try
                Con.Open()
                Dim query As String
                query = "insert into TProblematika values (" & StIdCb.SelectedValue.ToString() & ",'" & StEmer.Text & "'," & LiberIdCb.SelectedValue.ToString() & ",'" & TitullL.Text & "','" & DataProb.Value.Date & "')"

                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()

                MsgBox("Problematika u raportua me sukses!")
                Con.Close()
                ShfaqListe()
                Reset()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub Problematikat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShfaqListe()
        FillSt()
        FillL()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub StIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles StIdCb.SelectionChangeCommitted
        GetEmerSt()
    End Sub

    Private Sub LiberIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles LiberIdCb.SelectionChangeCommitted
        GetTitullL()
    End Sub

    Private Sub Reset()
        TitullL.Text = ""
        StEmer.Text = ""
        StIdCb.SelectedIndex = -1
        LiberIdCb.SelectedIndex = -1
    End Sub

    Private Sub rivendos_Click(sender As Object, e As EventArgs) Handles rivendos.Click
        Reset()
    End Sub

    Private Sub ktheu_Click(sender As Object, e As EventArgs) Handles ktheu.Click
        Dim obj = New fKryesor
        obj.Show()
        Me.Hide()
    End Sub

    Dim celes = 0
    Private Sub ProblemGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ProblemGV.CellMouseClick
        Dim rresht As DataGridViewRow = ProblemGV.Rows(e.RowIndex)
        StIdCb.SelectedValue = rresht.Cells(1).Value.ToString
        StEmer.Text = rresht.Cells(2).Value.ToString
        LiberIdCb.SelectedValue = rresht.Cells(3).Value.ToString
        TitullL.Text = rresht.Cells(4).Value.ToString
        DataProb.Text = rresht.Cells(5).Value.ToString

        If StEmer.Text = "" Then
            celes = 0
        Else
            celes = Convert.ToInt32(rresht.Cells(0).Value.ToString)
        End If

    End Sub

    Private Sub ndrysho_Click(sender As Object, e As EventArgs) Handles ndrysho.Click
        If StEmer.Text = "" Or TitullL.Text = "" Then
            MsgBox("Nuk ka informacion te Mjaftueshem!")
        Else
            Con.Open()
            Dim query As String
            query = "Update TProblematika set StId=" & StIdCb.SelectedValue.ToString() & ",EmerSt = '" & StEmer.Text & "',LId=" & LiberIdCb.SelectedValue.ToString() & ",TitullL='" & TitullL.Text & "',DateProb='" & DataProb.Value.Date & "' where INum=" & celes & ""

            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()

            MsgBox("Problematika u perditesua!")
            Con.Close()
            ShfaqListe()
            Reset()
        End If
    End Sub
End Class