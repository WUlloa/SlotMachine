Public Class TetraAbility

    Private Sub RestartNoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartNoButton.Click
        DialogResult = Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub RestartYesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestartYesButton.Click
        DialogResult = Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub
End Class