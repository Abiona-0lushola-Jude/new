Public Class Form2
    Public tct As New List(Of Double)
    Dim lat1, lat2, lat3, lat4, lat5 As Double
    Dim dep1, dep2, dep3, dep4, dep5 As Double
    Dim EL As Double
    Dim EDP As Double
    Dim len As Double
    Dim fr As Double
    Dim y, t, s, f, x, w, i, k, z, h As Double

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
    End Sub

    Dim txt1, txt2, txt3, txt4, txt5, tnt1, tnt2, tnt3, tnt4, tnt5 As Double
    Dim pep1, pep2, pep3, pep4, pep41, pep5, pep6, pep7, pep8, pep9 As Double
    Dim dad1, dad2, dad3, dad4, dad41, dad5, dad6, dad7, dad8, dad9 As Double
    Dim fed1, fed2, fed3, fed4, fed5 As Double


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fed1 = Math.Round((Val(txtd1.Text) + (Val(txtm1.Text) / 60)) + (Val(txts1.Text) / 3600), 4)
        fed2 = Math.Round((Val(txtd2.Text) + Val(txtm2.Text / 60)) + (Val(txts2.Text / 3600)), 4)
        fed3 = Math.Round((Val(txtd3.Text) + Val(txtm3.Text / 60)) + (Val(txts3.Text / 3600)), 4)
        fed4 = Math.Round((Val(txtd4.Text) + Val(txtm4.Text / 60)) + (Val(txts4.Text / 3600)), 4)
        fed5 = Math.Round((Val(txtd5.Text) + Val(txtm5.Text / 60)) + (Val(txts5.Text / 3600)), 4)
        'Getting Lat and Dep
        lat1 = Math.Round((Val(txtl1.Text) * Math.Cos(fed1 * 3.1415926535897931 / 180)), 2)
        lat2 = Math.Round((Val(txtl2.Text) * Math.Cos(fed2 * 3.1415926535897931 / 180)), 2)
        lat3 = Math.Round((Val(txtl3.Text) * Math.Cos(fed3 * 3.1415926535897931 / 180)), 2)
        lat4 = Math.Round((Val(txtl4.Text) * Math.Cos(fed4 * 3.1415926535897931 / 180)), 2)
        lat5 = Math.Round((Val(txtl5.Text) * Math.Cos(fed5 * 3.1415926535897931 / 180)), 2)
        dep1 = Math.Round((Val(txtl1.Text) * Math.Sin(fed1 * 3.1415926535897931 / 180)), 2)
        dep2 = Math.Round((Val(txtl2.Text) * Math.Sin(fed2 * 3.1415926535897931 / 180)), 2)
        dep3 = Math.Round((Val(txtl3.Text) * Math.Sin(fed3 * 3.1415926535897931 / 180)), 2)
        dep4 = Math.Round((Val(txtl4.Text) * Math.Sin(fed4 * 3.1415926535897931 / 180)), 2)
        dep5 = Math.Round((Val(txtl5.Text) * Math.Sin(fed5 * 3.1415926535897931 / 180)), 2)
        EL = lat1 + lat2 + lat3 + lat4 + lat5
        EDP = dep1 + dep2 + dep3 + dep4 + dep5
        len = Math.Round(Val(txtl1.Text) + Val(txtl2.Text) + Val(txtl3.Text) + Val(txtl4.Text) + Val(txtl5.Text), 2)
        Dim pe() As Double = {lat1, lat2, lat3, lat4, lat5}
        For n1 As Double = 0 To pe.Length - 1
            lat.Items.Add(pe(n1))
        Next
        Dim pe1() As Double = {dep1, dep2, dep3, dep4, dep5}
        For ne1 As Double = 0 To pe1.Length - 1
            dep.Items.Add(pe1(ne1))
        Next
        If (EL = 0 AndAlso EDP = 0) Then
            dad1 = Math.Round(Val(txtNAA.Text), 4) + lat1
            dad2 = lat2 + dad1
            dad3 = lat3 + dad2
            dad4 = lat4 + dad3
            dad41 = lat5 + dad4
            dad5 = Math.Round(Val(txtEAA.Text), 4) + dep1
            dad6 = dep2 + dad5
            dad7 = dep3 + dad6
            dad8 = dep4 + dad7
            dad9 = dep5 + dad8
            Dim z() As Double = {Val(txtNAA.Text), dad1, dad2, dad3, dad4, dad41}
            For num1 As Double = 0 To z.Length - 1
                Northings.Items.Add(z(num1))
            Next
            Dim j() As Double = {Val(txtEAA.Text), dad5, dad6, dad7, dad8, dad9}
            For num2 As Double = 0 To j.Length - 1
                Eastings.Items.Add(j(num2))
            Next
            MsgBox("Error Depature: " & EDP)
        Else
            'Correction for the Lat and Dep
            y = Math.Round(((Val(txtl1.Text) / (len)) * (EL)), 2)
            t = Math.Round(((Val(txtl2.Text) / (len)) * (EL)), 2)
            s = Math.Round(((Val(txtl3.Text) / (len)) * (EL)), 2)
            f = Math.Round(((Val(txtl4.Text) / (len)) * (EL)), 2)
            z = Math.Round(((Val(txtl5.Text) / (len)) * (EL)), 2)
            x = Math.Round(((Val(txtl1.Text) / (len)) * (EDP)), 2)
            w = Math.Round(((Val(txtl2.Text) / (len)) * (EDP)), 2)
            i = Math.Round(((Val(txtl3.Text) / (len)) * (EDP)), 2)
            k = Math.Round(((Val(txtl4.Text) / (len)) * (EDP)), 2)
            h = Math.Round(((Val(txtl5.Text) / (len)) * (EDP)), 2)
            'Adding the correction to the existing Lat and Dep
            txt1 = y + lat1
            txt2 = t + lat2
            txt3 = s + lat3
            txt4 = f + lat4
            txt5 = z + lat5
            'Departures
            tnt1 = x + dep1
            tnt2 = w + dep2
            tnt3 = i + dep3
            tnt4 = k + dep4
            tnt5 = h + dep5
            'Displaying Corrected Latitudes
            Dim qe1() As Double = {txt1, txt2, txt3, txt4, txt5}
            For n2 As Double = 0 To qe1.Length - 1
                corrlat.Items.Add(qe1(n2))
            Next
            'Displaying Departures
            Dim m1() As Double = {tnt1, tnt2, tnt3, tnt4, tnt5}
            For nr As Double = 0 To m1.Length - 1
                corrdep.Items.Add(m1(nr))
            Next
            'Getting Coordinates
            pep1 = Math.Round((Val(txtNAA.Text) + txt1), 2)
            pep2 = txt2 + pep1
            pep3 = txt3 + pep2
            pep4 = txt4 + pep3
            pep41 = txt5 + pep4
            pep5 = Math.Round((Val(txtEAA.Text) + tnt1), 2)
            pep6 = tnt2 + pep5
            pep7 = tnt3 + pep6
            pep8 = tnt4 + pep7
            pep9 = tnt5 + pep8
            'Displaying Coordinates
            Dim q() As Double = {Math.Round(Val(txtNAA.Text), 4), pep1, pep2, pep3, pep4, pep41}
            For num As Double = 0 To q.Length - 1
                Northings.Items.Add(q(num))
            Next
            Dim jh() As Double = {Math.Round(Val(txtEAA.Text), 4), pep5, pep6, pep7, pep8, pep9}
            For num0 As Double = 0 To jh.Length - 1
                Eastings.Items.Add(jh(num0))
            Next
        End If
        'This is for the Area
        txtArea.Text = (((Val(txtNAA.Text) * pep5) + (pep1 * pep6) + (pep2 * pep7) + (pep3 * pep8) + (pep4 * pep9)) - ((Val(txtEAA.Text) * pep1) + (pep5 * pep2) + (pep6 * pep3) + (pep7 * pep4) + (pep8 * pep41))) / 2
        'This is for linear Accuracy
        fr = Math.Sqrt((Math.Pow(EL, 2)) + (Math.Pow(EDP, 2)))
        txtLA.Text = fr / len
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtArea.Text = ""
        txtd1.Text = ""
        txtd2.Text = ""
        txtd3.Text = ""
        txtd4.Text = ""
        txtNAA.Text = ""
        txtEAA.Text = ""
        Eastings.Text = ""
        Northings.Text = ""
        txtl1.Text = ""
        txtl2.Text = ""
        txtl3.Text = ""
        txtl4.Text = ""
        txtLA.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Text = MsgBox("Do you want to exit?", vbYesNo)
        If Button1.Text = vbYes Then
            Application.Exit()
        End If
    End Sub
End Class
