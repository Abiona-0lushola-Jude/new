Public Class Form1
    Dim PI = 3.14
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btndis_Click(sender As Object, e As EventArgs) Handles btndis.Click
        Dim ab As Double
        Dim de As Double
        ab = Val(txtEB.Text) - Val(txtEA.Text)
        de = Val(txtNB.Text) - Val(txtNA.Text)
        txtans.Text = Math.Sqrt((Math.Pow(ab, 2)) + (Math.Pow(de, 2)))
        MsgBox("Distance: " & txtans.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ab As Double
        Dim de As Double
        Dim pct As Double
        'de= latitude
        'ab= departure
        ab = Val(txtEB.Text) - Val(txtEA.Text)
        de = Val(txtNB.Text) - Val(txtNA.Text)
        'txtans.Text = Math.Atan(txtnum1.Text) * (180 / 3.14159265358979)
        pct = Math.Round((Math.Atan(ab / de) * (180 / 3.14159265358979)), 3)
        If (ab >= 0) AndAlso (de >= 0) Then
            txtans.Text = pct
        ElseIf (ab >= 0) AndAlso (de < 0) Then
            txtans.Text = (180 + pct)
        ElseIf (ab <= 0) AndAlso (de < 0) Then
            txtans.Text = (180 - pct)
        Else
            txtans.Text = (360 + pct)
        End If
        MsgBox("Bearing: " & txtans.Text)

    End Sub

    Private Sub btnext_Click(sender As Object, e As EventArgs) Handles btnext.Click
        btnext.Text = MsgBox("Do you want to exit?", vbYesNo)
        If btnext.Text = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnclr_Click(sender As Object, e As EventArgs) Handles btnclr.Click
        txtEA.Text = ""
        txtEB.Text = ""
        txtNA.Text = ""
        txtNB.Text = ""
        txtans.Text = ""
    End Sub

    Private Sub Btnnxt_Click(sender As Object, e As EventArgs) Handles Btnnxt.Click
        Form2.Show()
    End Sub
End Class