Imports four_in_a_row.frmMain

Public Class frmCover
    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        Me.Hide()
        frmMain.Show()
        frmMain.newGame()

    End Sub

    Private Sub cmdResume_Click(sender As Object, e As EventArgs) Handles cmdResume.Click
        Me.Hide()
        frmMain.Show()
    End Sub

End Class