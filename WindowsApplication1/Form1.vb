Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MsgBox("Ortalama Hesaplama Programına Hoşgeldiniz ", )



    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14, d15, d16, d17, top As Integer
        Dim ort, tsaat As Double
        d1 = 2 * TextBox35.Text
        d2 = 2 * TextBox34.Text
        d3 = 2 * TextBox29.Text
        d4 = 4 * TextBox28.Text
        d5 = 1 * TextBox27.Text
        d6 = 1 * TextBox24.Text
        d7 = 3 * TextBox23.Text
        d8 = 2 * TextBox21.Text
        d9 = 4 * TextBox9.Text
        d10 = 2 * TextBox19.Text
        d11 = 2 * TextBox22.Text
        d12 = 4 * TextBox25.Text
        d13 = 2 * TextBox26.Text
        d14 = 2 * TextBox30.Text
        d15 = 2 * TextBox31.Text
        d16 = 2 * TextBox32.Text
        d17 = 2 * TextBox33.Text

        top = d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8 + d9 + d10 + d11 + d12 + d13 + d14 + d15 + d16 + d17
        tsaat = 39
        ort = top / tsaat


        If ort >= 3 Then
            MsgBox("Ortalaman: " & ort & "  Sınıfı Geçtin", MsgBoxStyle.Information, "Tebrikler")

        Else
            MsgBox("Ortalaman: " & ort & "  Sınıf Tekrarı", MsgBoxStyle.Critical, "Kaldın")

        End If





    End Sub
End Class
