Public Class Form2
    Dim hasil As String = ""
    
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Select Case ComboBox1.Text
                Case "Pyramid"
                    pola(Convert.ToInt32(TextBox1.Text))
                Case "Hollow Pyramid"
                    holowPyramid(Convert.ToInt32(TextBox1.Text))
                Case "Inverted Pyramid"
                    invertedPyramid(Convert.ToInt32(TextBox1.Text))
                Case "Hollow Inverted Pyramid"
                    polaInvertedPyramid(Convert.ToInt32(TextBox1.Text))
                Case Else
                    TextBox2.Text = "Pilih Pola Dulu Bos"
            End Select
        Catch ex As Exception
            TextBox2.Text = "Bintang Bos"
        End Try
    End Sub

    Private Sub pola(batas As Integer)
        Dim batasKolom1 As Integer = batas
        Dim batasKolom2 As Integer = batas
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (kolom < batasKolom1 Or kolom > batasKolom2) Then
                    Me.hasil &= "  "


                Else
                    Me.hasil &= "*"
                End If
            Next
            batasKolom1 -= 1
            batasKolom2 += 1
            Me.hasil &= vbCrLf
        Next
        TextBox2.Text = hasil
        hasil = ""
    End Sub

    Private Sub holowPyramid(batas As Integer)
        Dim batasKolom1 As Integer = batas
        Dim batasKolom2 As Integer = batas
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (baris < batas) Then
                    If (kolom = batasKolom1 Or kolom = batasKolom2) Then
                        Me.hasil &= "*"
                    Else
                        Me.hasil &= "  "
                    End If
                Else
                    Me.hasil &= "*"
                End If
            Next
            batasKolom1 -= 1
            batasKolom2 += 1
            Me.hasil &= vbCrLf
        Next
        TextBox2.Text = hasil
        hasil = ""
    End Sub

    Private Sub invertedPyramid(batas As Integer)
        Dim batasKolom1 As Integer = 0
        Dim batasKolom2 As Integer = batas * 2
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (kolom > batasKolom1 And kolom < batasKolom2) Then
                    Me.hasil &= "*"
                Else
                    Me.hasil &= "  "
                End If
            Next
            Me.hasil &= vbCrLf
            batasKolom1 += 1
            batasKolom2 -= 1
        Next
        TextBox2.Text = hasil
        Me.hasil = ""
    End Sub

    Private Sub polaInvertedPyramid(batas As Integer)
        Dim batasKolom1 As Integer = 1
        Dim batasKolom2 As Integer = batas * 2 - 1
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (baris = 1) Then
                    Me.hasil &= "*"
                Else
                    If (kolom = batasKolom1 Or kolom = batasKolom2) Then
                        Me.hasil &= "*"
                    Else
                        Me.hasil &= "  "
                    End If
                End If
            Next
            batasKolom1 += 1
            batasKolom2 -= 1
            Me.hasil &= vbCrLf
        Next
        TextBox2.Text = hasil
        Me.hasil = ""
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Hollow(p1 As Object)
        Throw New NotImplementedException
    End Sub

    Private Sub Pyramid(p1 As Integer)
        Throw New NotImplementedException
    End Sub

    Private Sub HollowPyramid(p1 As Integer)
        Throw New NotImplementedException
    End Sub

    Private Sub InvertedPhyramid(p1 As Integer)
        Throw New NotImplementedException
    End Sub

    Private Sub HollowInvertedPyramid(p1 As Integer)
        Throw New NotImplementedException
    End Sub

End Class