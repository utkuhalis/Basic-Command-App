Public Class Form1

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Return
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then

            If TextBox1.Text = "" Then
                MsgBox("Boş Komut Girildi.", MsgBoxStyle.Information, "UYARI")
            Else
                ListBox1.Items.Add("User> " & TextBox1.Text)

                If TextBox1.Text = "System.Clock" Then
                    ListBox1.Items.Add("JARVIS> " & Now)
                End If

                If TextBox1.Text = "System.Clock.Day" Then
                    ListBox1.Items.Add("JARVIS> " & Now.Day)
                End If

                If TextBox1.Text = "System.Clock.Month" Then
                    ListBox1.Items.Add("JARVIS> " & Now.Month)
                End If

                If TextBox1.Text = "System.Clock.Year" Then
                    ListBox1.Items.Add("JARVIS> " & Now.Year)
                End If

                If TextBox1.Text = "System.Clock.Hour" Then
                    ListBox1.Items.Add("JARVIS> " & Now.Hour)
                End If

                If TextBox1.Text = "System.Clock.Minute" Then
                    ListBox1.Items.Add("JARVIS> " & Now.Minute)
                End If

                If TextBox1.Text = "System.Clock.Second" Then
                    ListBox1.Items.Add("JARVIS> " & Now.Second)
                End If

                If TextBox1.Text = "System.Clock.Millisecond" Then
                    ListBox1.Items.Add("JARVIS> " & Now.Millisecond)
                End If

                If TextBox1.Text = "System.CodeScreen.Clear" Then
                    ListBox1.Items.Clear()
                End If

                If TextBox1.Text = "System.CodeScreen.ForeColor.Blue" Then
                    ListBox1.ForeColor = Color.Turquoise
                End If

                If TextBox1.Text = "System.CodeScreen.ForeColor.Red" Then
                    ListBox1.ForeColor = Color.Red
                End If

                If TextBox1.Text = "System.Exit" Then
                    End
                End If

                TextBox1.Clear()

            End If

        End If
    End Sub
End Class
