<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        MaskedTextBox1 = New MaskedTextBox()
        ComboBox1 = New ComboBox()
        NumericUpDown1 = New NumericUpDown()
        Button1 = New Button()
        Label7 = New Label()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(55, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 25)
        Label1.TabIndex = 0
        Label1.Text = "* Nom Complet"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(55, 180)
        Label2.Name = "Label2"
        Label2.Size = New Size(172, 25)
        Label2.TabIndex = 1
        Label2.Text = "* Adresse e-mail"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(55, 248)
        Label3.Name = "Label3"
        Label3.Size = New Size(233, 25)
        Label3.TabIndex = 2
        Label3.Text = "* Numéro de téléphone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(55, 315)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 25)
        Label4.TabIndex = 3
        Label4.Text = "* Age"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(55, 387)
        Label5.Name = "Label5"
        Label5.Size = New Size(165, 25)
        Label5.TabIndex = 4
        Label5.Text = "* Choix du pays"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(55, 454)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 25)
        Label6.TabIndex = 5
        Label6.Text = "* Mot de passe"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(367, 117)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(206, 27)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(367, 181)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(206, 27)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(367, 455)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(206, 27)
        TextBox3.TabIndex = 8
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Location = New Point(367, 249)
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(206, 27)
        MaskedTextBox1.TabIndex = 9
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(367, 388)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(206, 28)
        ComboBox1.TabIndex = 10
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(368, 317)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(205, 27)
        NumericUpDown1.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.MenuHighlight
        Button1.Location = New Point(350, 523)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 12
        Button1.Text = "Validé"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.Highlight
        Label7.Location = New Point(261, 26)
        Label7.Name = "Label7"
        Label7.Size = New Size(324, 32)
        Label7.TabIndex = 13
        Label7.Text = "Formulare d'inscription"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 603)
        Controls.Add(Label7)
        Controls.Add(Button1)
        Controls.Add(NumericUpDown1)
        Controls.Add(ComboBox1)
        Controls.Add(MaskedTextBox1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label

End Class
