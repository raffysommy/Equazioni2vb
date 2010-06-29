Public Class Form1

    'Scusate ma non commento molto il codice nelle prossime relase sara più commentato
    'Sorry but not much comment the code in the next relase it will most commented
    'This program is devolped under GPLv3 Licence


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim xal2 As Double = TextBox1.Text
        Dim x As Double = TextBox2.Text

        If xal2 = 0 Then
            MsgBox("Attenzione il valore di x^2 è 0")
        Else
            If x = 0 Then
                MsgBox("Attenzione l'equazione è monomia e ha un unica soluzione x=0")
            Else
                Dim soluzione As Double = -x / xal2
                TextBox3.Text = soluzione

            End If


        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim xal2pure As Double = TextBox6.Text
        Dim xpure As Double = TextBox5.Text

        If xal2pure = 0 Then
            MsgBox("Attenzione il valore di x^2 è 0")
        Else

            If xpure = 0 Then
                MsgBox("Attenzione l'equazione è monomia e ha un unica soluzione x=0")

            Else
                Dim solvente As Double = -xpure / xal2pure


                If solvente > 0 Then

                    Label32.Hide()
                    Label33.Hide()
                    Dim soluzionepure = Math.Sqrt(solvente)
                    TextBox7.Text = soluzionepure
                    TextBox4.Text = -soluzionepure



                Else
                    Label32.Show()
                    Label33.Show()
                    Dim soluzionepure = Math.Sqrt(-solvente)
                    TextBox7.Text = soluzionepure
                    TextBox4.Text = -soluzionepure


                End If


            End If

        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim xal2delto As Double = TextBox11.Text
        Dim xdelto As Double = TextBox12.Text
        Dim numdelto As Double = TextBox10.Text
        If xal2delto = 0 Then
            MsgBox("Attenzione il valore di x^2 è 0")
        Else
            If xdelto = 0 Then
                MsgBox("l'equazione è pura")

            ElseIf xdelto = 0 And numdelto = 0 Then
                MsgBox("l'equazione è monomia")
            Else
                If numdelto = 0 Then
                    MsgBox("l'equazione è spuria")
                Else
                    Dim delta As Double = xdelto * xdelto - 4 * xal2delto * numdelto
                    TextBox13.Text = delta
                    If delta < 0 Then
                        If TextBox16.TextLength > 0 Then
                            PictureBox2.Hide()
                            TextBox14.Hide()
                            TextBox15.Hide()
                            Label24.Hide()
                            Label25.Hide()
                            Label26.Hide()
                            Label27.Hide()
                            Label28.Hide()
                            Label29.Hide()
                            PictureBox3.Hide()
                            TextBox17.Hide()
                            TextBox16.Hide()
                            TextBox8.Show()
                            TextBox9.Show()

                        End If
                        Label30.Show()
                        Label31.Show()
                        Dim drad As Double = Math.Sqrt(-delta)
                        Dim x1 As Double = (-xdelto + drad) / 2
                        Dim x2 As Double = (-xdelto - drad) / 2
                        TextBox8.Text = x1
                        TextBox9.Text = x2
                    Else
                        Dim drad As Double = Math.Sqrt(delta)

                        Dim intrad As Double = Math.Truncate(drad)
                        If drad = intrad Then
                            If TextBox16.TextLength > 0 Then
                                PictureBox2.Hide()
                                TextBox14.Hide()
                                TextBox15.Hide()
                                Label24.Hide()
                                Label25.Hide()
                                Label26.Hide()
                                Label27.Hide()
                                Label28.Hide()
                                Label29.Hide()
                                PictureBox3.Hide()
                                TextBox17.Hide()
                                TextBox16.Hide()
                                TextBox8.Show()
                                TextBox9.Show()

                            End If
                            Dim x1 As Double = (-xdelto + drad) / 2
                            Dim x2 As Double = (-xdelto - drad) / 2
                            TextBox8.Text = x1
                            TextBox9.Text = x2
                        Else
                            TextBox8.Hide()
                            TextBox9.Hide()
                            PictureBox2.Show()
                            TextBox14.Show()
                            TextBox15.Show()
                            Label24.Show()
                            Label25.Show()
                            Label26.Show()
                            Label27.Show()
                            Label28.Show()
                            Label29.Show()
                            PictureBox3.Show()
                            TextBox17.Show()
                            TextBox16.Show()

                            TextBox14.Text = -xdelto
                            TextBox15.Text = delta
                            TextBox17.Text = -xdelto
                            TextBox16.Text = delta

                        End If


                    End If

                End If




            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AboutBox1.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SplashScreen1.Close()



    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub

  
   
End Class
