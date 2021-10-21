Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btn_calc_Click(sender As Object, e As EventArgs) Handles btn_calc.Click
        Dim kesit, uzunluk, ozdirenc As Double
        kesit = Val(txt2.Text)
        ozdirenc = Val(txt1.Text)
        uzunluk = Val(txt3.Text)
        If kesit <= 0 Or ozdirenc <= 0 Or uzunluk <= 0 Then
            MsgBox("SIFIR GİREMEZSİN!", vbCritical + vbOKOnly)
            Exit Sub
        End If
        Dim sonuc As String
        sonuc = ozdirenc * (uzunluk / kesit)

        txt4.Text = CStr(sonuc)
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt1.Clear() '2nd way txt1.Text=""'
        txt2.Clear()
        txt3.Clear()
        txt4.Clear()
    End Sub
End Class
