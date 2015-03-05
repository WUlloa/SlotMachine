Public Class CustomMessageBox2


    Private Sub RulesOKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RulesOKButton.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close() 'Close Box
    End Sub


End Class