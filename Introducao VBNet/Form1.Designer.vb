<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblAnoNascimento = New System.Windows.Forms.Label()
        Me.txtAnoNascimento = New System.Windows.Forms.TextBox()
        Me.btnCalculaIdade = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.lblCalcularIdade = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(96, 70)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(55, 20)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(100, 104)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(283, 26)
        Me.txtNome.TabIndex = 1
        '
        'lblAnoNascimento
        '
        Me.lblAnoNascimento.AutoSize = True
        Me.lblAnoNascimento.Location = New System.Drawing.Point(96, 168)
        Me.lblAnoNascimento.Name = "lblAnoNascimento"
        Me.lblAnoNascimento.Size = New System.Drawing.Size(152, 20)
        Me.lblAnoNascimento.TabIndex = 2
        Me.lblAnoNascimento.Text = "Ano de Nascimento:"
        '
        'txtAnoNascimento
        '
        Me.txtAnoNascimento.Location = New System.Drawing.Point(100, 208)
        Me.txtAnoNascimento.Name = "txtAnoNascimento"
        Me.txtAnoNascimento.Size = New System.Drawing.Size(93, 26)
        Me.txtAnoNascimento.TabIndex = 3
        '
        'btnCalculaIdade
        '
        Me.btnCalculaIdade.Location = New System.Drawing.Point(100, 281)
        Me.btnCalculaIdade.Name = "btnCalculaIdade"
        Me.btnCalculaIdade.Size = New System.Drawing.Size(148, 29)
        Me.btnCalculaIdade.TabIndex = 4
        Me.btnCalculaIdade.Text = "Calcular &Idade"
        Me.btnCalculaIdade.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(308, 281)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 29)
        Me.btnSair.TabIndex = 5
        Me.btnSair.Text = "&Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'lblCalcularIdade
        '
        Me.lblCalcularIdade.AutoSize = True
        Me.lblCalcularIdade.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalcularIdade.Location = New System.Drawing.Point(94, 9)
        Me.lblCalcularIdade.Name = "lblCalcularIdade"
        Me.lblCalcularIdade.Size = New System.Drawing.Size(387, 36)
        Me.lblCalcularIdade.TabIndex = 6
        Me.lblCalcularIdade.Text = "CALCULADOR DE IDADE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 358)
        Me.Controls.Add(Me.lblCalcularIdade)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnCalculaIdade)
        Me.Controls.Add(Me.txtAnoNascimento)
        Me.Controls.Add(Me.lblAnoNascimento)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblNome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Calcula Idade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNome As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents lblAnoNascimento As Label
    Friend WithEvents txtAnoNascimento As TextBox
    Friend WithEvents btnCalculaIdade As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents lblCalcularIdade As Label
End Class
