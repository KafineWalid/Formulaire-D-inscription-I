Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim errormessage As String = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Remplir la ComboBox avec des pays
        ComboBox1.Items.AddRange({"Morocco", "France", "Canada", "États-Unis", "Royaume-Uni", "Allemagne"})
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        NumericUpDown1.Minimum = 18
        NumericUpDown1.Maximum = 99
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            [errormessage] = "Le nom est obligatoire"
            MessageBox.Show(errormessage)
        End If

        ' Validation du mot de passe
        If TextBox3.Text <> TextBox3.Text Then
            errormessage &= "Les mots de passe ne correspondent pas." & vbCrLf
        End If

        ' Affichage des messages d'erreur s'il y en a
        If errormessage <> "" Then
            MessageBox.Show(errormessage, "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Formulaire validé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    ' Fonction pour valider une adresse e-mail
    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim addr As New System.Net.Mail.MailAddress(email)
            Return addr.Address = email
        Catch
            Return False
        End Try
    End Function
    ' Fonction pour valider un numéro de téléphone
    Private Function IsValidPhoneNumber(phoneNumber As String) As Boolean
        ' Supprimer les caractères spéciaux du numéro de téléphone
        Dim cleanedPhoneNumber As String = cleanedPhoneNumber(phoneNumber)

        ' Vérifier si le numéro de téléphone a la longueur appropriée et commence par le bon préfixe
        If cleanedPhoneNumber.Length = 10 AndAlso cleanedPhoneNumber.StartsWith("06") Then
            Return True
        Else
            Return False
        End If

    End Function

End Class