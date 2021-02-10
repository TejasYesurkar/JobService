Public Class chargeAmt
    Public rowindx
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        JobRepaire.chrge = txtamt.Text
        ' MsgBox(rowindx)

        Dim StringToCheck As String = txtamt.Text

        For i = 0 To StringToCheck.Length - 1

            If Char.IsLetter(StringToCheck.Chars(i)) Then
                MsgBox("Please Enter Number").ToString()
                Exit Sub
            End If
        Next


        JobRepaire.DataGridView1.Rows(rowindx).Cells(5).Value = txtamt.Text

        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        JobRepaire.chrge = txtamt.Text

        Me.Close()
    End Sub

    Private Sub chargeAmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtamt.Text = 0

    End Sub
End Class