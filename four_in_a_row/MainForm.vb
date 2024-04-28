Imports System.IO
Imports System.Xml.Serialization

Public Class frmMain
    Dim DashBoard(6, 6) As token
    Dim col As Integer = 6
    Dim row As Integer = 6
    Dim player As Integer = 0
    Dim btn As Integer
    Dim num1 As Integer
    Dim num2 As Integer
    Dim num3 As Integer
    Dim num4 As Integer
    Dim num5 As Integer
    Dim num6 As Integer
    Dim num7 As Integer
    Dim pTurn As String
    Dim clor As Color
    Dim killGame As Boolean = False
    Dim dia As DialogResult

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createBoard()
    End Sub

    'draw dashBoard
    Private Sub createBoard()
        For x = 0 To col
            For y = 0 To row
                DashBoard(x, y) = New token()
                With DashBoard(x, y)
                    .Size = New Size(58, 61)
                    .Location = New Point(x * 55, y * 50)
                    .BorderStyle = BorderStyle.FixedSingle
                    .BackColor = Color.DarkSlateGray
                End With
                pnlBoard.Controls.Add(DashBoard(x, y))
            Next
        Next
    End Sub

    Public Function setColor(x As Integer, clr As Color)
        For y = row To 0 Step -1
            If (DashBoard(x, y).Used = False) Then
                DashBoard(x, y).Used = True
                DashBoard(x, y).BackColor = clr
                ' DashBoard(x, y).Tag = lblOutput.Text

                Return True
            End If
        Next
    End Function

    ' for palyer switching
    Sub switchPlayer()
        If (player = 0) Then
            setColor(btn, Color.Aqua)
            clor = Color.Aqua
            player = 1
            pTurn = "Player 1"
            lblClr.BackColor = clor
        ElseIf (player = 1) Then
            setColor(btn, Color.Magenta)
            clor = Color.Magenta
            player = 0
            pTurn = "Player 2"
            lblClr.BackColor = clor
        End If
    End Sub

    ' when column is full, stop it
    Public Function stopCol(c As Integer, click As Button)
        If c = 7 Then
            click.Enabled = False
        End If
    End Function

    ' check win state
    Private Sub chkMatch()
        'for horizontal
        For x = 0 To 3
            For y = 0 To 6
                If DashBoard(x, y).BackColor = clor And DashBoard(x + 1, y).BackColor = clor And DashBoard(x + 2, y).BackColor = clor And DashBoard(x + 3, y).BackColor = clor Then
                    MsgBox(pTurn & " Win!")
                    killGame = True
                    Exit For
                End If
            Next
        Next

        'for vartical
        If (killGame = False) Then
            For x = 0 To 6
                For y = 0 To 3
                    If DashBoard(x, y).BackColor = clor And DashBoard(x, y + 1).BackColor = clor And DashBoard(x, y + 2).BackColor = clor And DashBoard(x, y + 3).BackColor = clor Then
                        MsgBox(pTurn & " Win!")
                        killGame = True
                    End If
                Next
            Next
        End If

        'for Diagonal(/)
        If (killGame = False) Then
            For x = 0 To 3
                For y = 3 To 6
                    If DashBoard(x, y).BackColor = clor And DashBoard(x + 1, y - 1).BackColor = clor And DashBoard(x + 2, y - 2).BackColor = clor And DashBoard(x + 3, y - 3).BackColor = clor Then
                        MsgBox(pTurn & " Wins!")
                        killGame = True
                        Exit For
                    End If
                Next
            Next
        End If

        'for Diagonal(\)
        If (killGame = False) Then
            For x = 0 To 3
                For y = 0 To 3
                    If DashBoard(x, y).BackColor = clor And DashBoard(x + 1, y + 1).BackColor = clor And DashBoard(x + 2, y + 2).BackColor = clor And DashBoard(x + 3, y + 3).BackColor = clor Then
                        MsgBox(pTurn & " Wins!")
                        killGame = True
                        Exit For
                    End If
                Next
            Next
        End If

        ' for draw
        If (killGame = False And num1 = 7 And num2 = 7 And num3 = 7 And num4 = 7 And num5 = 7 And num6 = 7 And num7 = 7) Then
            MsgBox("Draw! Try again...")
            Call newGame()
        End If

        ' kill the Game
        If (killGame = True) Then
            Call newGame()
            dia = MsgBox("Press Ok for exit.., Do you want to restart or exit.", MessageBoxButtons.OKCancel)
            If dia = DialogResult.OK Then
                Application.Exit()
            Else
                frmCover.Show()
                ' frmCover.lblWelcome.Text = ""
                Me.Hide()
            End If
        End If

    End Sub

    Sub newGame()
        reloadBtn()
        pnlBoard.Controls.Clear()
        createBoard()
        killGame = False
        lblOutput.Text = " "
        player = 0
        lblClr.BackColor = gpInfo.BackColor
    End Sub

    Sub reloadBtn()
        cmd1.Enabled = True
        num1 = 0
        cmd2.Enabled = True
        num2 = 0
        cmd3.Enabled = True
        num3 = 0
        cmd4.Enabled = True
        num4 = 0
        cmd5.Enabled = True
        num5 = 0
        cmd6.Enabled = True
        num6 = 0
        cmd7.Enabled = True
        num7 = 0
    End Sub

    Private Sub cmd1_Click(sender As Object, e As EventArgs) Handles cmd1.Click
        btn = 0
        switchPlayer()
        num1 += 1
        stopCol(num1, cmd1)
        lblOutput.Text = pTurn
        chkMatch()
    End Sub

    Private Sub cmd2_Click(sender As Object, e As EventArgs) Handles cmd2.Click
        btn = 1
        switchPlayer()
        num2 += 1
        stopCol(num2, cmd2)
        lblOutput.Text = pTurn
        chkMatch()
    End Sub

    Private Sub cmd3_Click(sender As Object, e As EventArgs) Handles cmd3.Click
        btn = 2
        switchPlayer()
        num3 += 1
        stopCol(num3, cmd3)
        lblOutput.Text = pTurn
        chkMatch()
    End Sub

    Private Sub cmd4_Click(sender As Object, e As EventArgs) Handles cmd4.Click
        btn = 3
        switchPlayer()
        num4 += 1
        stopCol(num4, cmd4)
        lblOutput.Text = pTurn
        chkMatch()
    End Sub

    Private Sub cmd5_Click(sender As Object, e As EventArgs) Handles cmd5.Click
        btn = 4
        switchPlayer()
        num5 += 1
        stopCol(num5, cmd5)
        lblOutput.Text = pTurn
        chkMatch()
    End Sub

    Private Sub cmd6_Click(sender As Object, e As EventArgs) Handles cmd6.Click
        btn = 5
        switchPlayer()
        num6 += 1
        stopCol(num6, cmd6)
        lblOutput.Text = pTurn
        chkMatch()
    End Sub

    Private Sub cmd7_Click(sender As Object, e As EventArgs) Handles cmd7.Click
        btn = 6
        switchPlayer()
        num7 += 1
        stopCol(num7, cmd7)
        lblOutput.Text = pTurn
        chkMatch()
    End Sub

    'for save info as text file
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim mywriter As StreamWriter

        mywriter = File.CreateText(" Round.txt ")
        mywriter.WriteLine(pTurn)
        mywriter.WriteLine(pnlBoard)
        mywriter.WriteLine(pnlClick)
        mywriter.WriteLine(Me)
        mywriter.Close()
        MsgBox(" Current content will be store to a text file. ")

        frmCover.Show()
        Me.Hide()
    End Sub

    'for restart
    Private Sub cmdRestart_Click(sender As Object, e As EventArgs) Handles cmdRestart.Click
        Call newGame()
    End Sub
End Class