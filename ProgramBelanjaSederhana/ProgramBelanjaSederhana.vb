Public Class Form1
    Private Sub BtnHitung_Click(sender As Object, e As EventArgs) Handles BtnHitung.Click
        Dim Harga, Jumlah As Integer
        Dim THarga, Diskon, TBayar As Double
        Dim Bonus As String

        Harga = Val(TBHargaSatuan.Text)
        Jumlah = Val(TBJumlahBarang.Text)
        THarga = Harga * Jumlah
        TBTotalHarga.Text = THarga

        If THarga >= 500000 Then
            Diskon = 0.2 * THarga
            Bonus = "Tas Pinggang"
        ElseIf THarga >= 200000 Then
            Diskon = 0.15 * THarga
            Bonus = "Payung"
        ElseIf THarga >= 200000 Then
            Diskon = 0.15 * THarga
            Bonus = "Kaos"
        ElseIf THarga >= 200000 Then
            Diskon = 0.15 * THarga
            Bonus = "Pena"
        Else
            Diskon = 0
            Bonus = "Tidak Ada"
        End If

        TBayar = THarga - Diskon

        TBBonus.Text = Bonus
        TBDiskon.Text = Diskon
        TBTotalBayar.Text = TBayar


    End Sub
End Class
