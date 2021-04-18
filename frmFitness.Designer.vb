<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFitness
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnWeightLoss = New System.Windows.Forms.Button()
        Me.lstWeightLoss = New System.Windows.Forms.ListBox()
        Me.lblAverageLoss = New System.Windows.Forms.Label()
        Me.mnuFitness = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFitness.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(528, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(339, 84)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Fitness Challenge " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Team Weight Loss"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnWeightLoss
        '
        Me.btnWeightLoss.BackColor = System.Drawing.Color.YellowGreen
        Me.btnWeightLoss.Enabled = False
        Me.btnWeightLoss.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeightLoss.Location = New System.Drawing.Point(581, 140)
        Me.btnWeightLoss.Name = "btnWeightLoss"
        Me.btnWeightLoss.Size = New System.Drawing.Size(210, 32)
        Me.btnWeightLoss.TabIndex = 2
        Me.btnWeightLoss.Text = "Enter Weight Loss"
        Me.btnWeightLoss.UseVisualStyleBackColor = False
        '
        'lstWeightLoss
        '
        Me.lstWeightLoss.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstWeightLoss.FormattingEnabled = True
        Me.lstWeightLoss.ItemHeight = 23
        Me.lstWeightLoss.Location = New System.Drawing.Point(659, 190)
        Me.lstWeightLoss.Name = "lstWeightLoss"
        Me.lstWeightLoss.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstWeightLoss.Size = New System.Drawing.Size(50, 188)
        Me.lstWeightLoss.TabIndex = 3
        '
        'lblAverageLoss
        '
        Me.lblAverageLoss.AutoSize = True
        Me.lblAverageLoss.BackColor = System.Drawing.Color.YellowGreen
        Me.lblAverageLoss.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageLoss.Location = New System.Drawing.Point(485, 381)
        Me.lblAverageLoss.Name = "lblAverageLoss"
        Me.lblAverageLoss.Size = New System.Drawing.Size(382, 29)
        Me.lblAverageLoss.TabIndex = 4
        Me.lblAverageLoss.Text = "Average weight loss is XX.X lbs"
        Me.lblAverageLoss.Visible = False
        '
        'mnuFitness
        '
        Me.mnuFitness.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuFitness.Location = New System.Drawing.Point(0, 0)
        Me.mnuFitness.Name = "mnuFitness"
        Me.mnuFitness.Size = New System.Drawing.Size(867, 24)
        Me.mnuFitness.TabIndex = 5
        Me.mnuFitness.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(180, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'frmFitness
        '
        Me.AcceptButton = Me.btnWeightLoss
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Fitness_Challenge.My.Resources.Resources.health
        Me.ClientSize = New System.Drawing.Size(867, 438)
        Me.Controls.Add(Me.lblAverageLoss)
        Me.Controls.Add(Me.lstWeightLoss)
        Me.Controls.Add(Me.btnWeightLoss)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuFitness)
        Me.Name = "frmFitness"
        Me.Text = "Fitness Challenge"
        Me.mnuFitness.ResumeLayout(False)
        Me.mnuFitness.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnWeightLoss As Button
    Friend WithEvents lstWeightLoss As ListBox
    Friend WithEvents lblAverageLoss As Label
    Friend WithEvents mnuFitness As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
