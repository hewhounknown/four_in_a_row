<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCover
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdResume = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdNew
        '
        Me.cmdNew.BackColor = System.Drawing.Color.Teal
        Me.cmdNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNew.Font = New System.Drawing.Font("Ravie", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.cmdNew.Location = New System.Drawing.Point(21, 161)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(107, 49)
        Me.cmdNew.TabIndex = 0
        Me.cmdNew.Text = "Start"
        Me.cmdNew.UseVisualStyleBackColor = False
        '
        'cmdResume
        '
        Me.cmdResume.BackColor = System.Drawing.Color.Teal
        Me.cmdResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdResume.Font = New System.Drawing.Font("Ravie", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResume.ForeColor = System.Drawing.Color.MediumSpringGreen
        Me.cmdResume.Location = New System.Drawing.Point(283, 161)
        Me.cmdResume.Name = "cmdResume"
        Me.cmdResume.Size = New System.Drawing.Size(107, 49)
        Me.cmdResume.TabIndex = 1
        Me.cmdResume.Text = "Resume"
        Me.cmdResume.UseVisualStyleBackColor = False
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lblWelcome.Font = New System.Drawing.Font("Ravie", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Chartreuse
        Me.lblWelcome.Location = New System.Drawing.Point(44, 50)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(326, 66)
        Me.lblWelcome.TabIndex = 2
        Me.lblWelcome.Text = "Welcome to 4 in a row"
        '
        'frmCover
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(423, 292)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.cmdResume)
        Me.Controls.Add(Me.cmdNew)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmCover"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "4 in a row"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdNew As Button
    Friend WithEvents cmdResume As Button
    Friend WithEvents lblWelcome As Label
End Class
