Public Class Form1
    Private Sub btnCalculaIdade_Click(sender As Object, e As EventArgs) Handles btnCalculaIdade.Click
        'Botão que calcula a idade do usuário
        Dim anoAtual = Date.Now.Year()
        Dim anoNascimento = txtAnoNascimento.Text
        MessageBox.Show("Olá, " & txtNome.Text & ". " _
            & "Em " & anoAtual & ", você terá " & (anoAtual - anoNascimento) & " anos." _
                        , "Mensagem ao usuário")
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
End Class
