Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim hitung_gaji As Double

        hitung_gaji = (Me.jam_kerja.Text * 15000) + (Me.lembur.Text * 10000) - (Me.tidak_hadir.Text * 100000)
        Me.Label8.Text = hitung_gaji

        Dim uang_makan As Double

        uang_makan = Me.jam_kerja.Text * 10000
        Me.Label9.Text = uang_makan
    End Sub
End Class
