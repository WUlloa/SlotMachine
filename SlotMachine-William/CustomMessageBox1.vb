Public Class CustomMessageBox1
    Dim RulesMessageBox As CustomMessageBox2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WelcomeOKButton.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    
End Class