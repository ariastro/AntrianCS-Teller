<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCS = New System.Windows.Forms.Button()
        Me.btnTeller = New System.Windows.Forms.Button()
        Me.tbCS = New System.Windows.Forms.TextBox()
        Me.tbTeller = New System.Windows.Forms.TextBox()
        Me.btnPlayT = New System.Windows.Forms.Button()
        Me.btnPlayCS = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCS
        '
        Me.btnCS.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCS.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCS.Location = New System.Drawing.Point(45, 31)
        Me.btnCS.Name = "btnCS"
        Me.btnCS.Size = New System.Drawing.Size(75, 32)
        Me.btnCS.TabIndex = 0
        Me.btnCS.Text = "CS"
        Me.btnCS.UseVisualStyleBackColor = False
        '
        'btnTeller
        '
        Me.btnTeller.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnTeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTeller.ForeColor = System.Drawing.Color.MintCream
        Me.btnTeller.Location = New System.Drawing.Point(45, 108)
        Me.btnTeller.Name = "btnTeller"
        Me.btnTeller.Size = New System.Drawing.Size(75, 33)
        Me.btnTeller.TabIndex = 1
        Me.btnTeller.Text = "Teller"
        Me.btnTeller.UseVisualStyleBackColor = False
        '
        'tbCS
        '
        Me.tbCS.Location = New System.Drawing.Point(191, 38)
        Me.tbCS.Name = "tbCS"
        Me.tbCS.Size = New System.Drawing.Size(100, 20)
        Me.tbCS.TabIndex = 2
        Me.tbCS.Text = "CS0"
        '
        'tbTeller
        '
        Me.tbTeller.Location = New System.Drawing.Point(191, 115)
        Me.tbTeller.Name = "tbTeller"
        Me.tbTeller.Size = New System.Drawing.Size(100, 20)
        Me.tbTeller.TabIndex = 3
        Me.tbTeller.Text = "T0"
        '
        'btnPlayT
        '
        Me.btnPlayT.BackColor = System.Drawing.Color.Coral
        Me.btnPlayT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlayT.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPlayT.Location = New System.Drawing.Point(350, 108)
        Me.btnPlayT.Name = "btnPlayT"
        Me.btnPlayT.Size = New System.Drawing.Size(75, 33)
        Me.btnPlayT.TabIndex = 4
        Me.btnPlayT.Text = "Play"
        Me.btnPlayT.UseVisualStyleBackColor = False
        '
        'btnPlayCS
        '
        Me.btnPlayCS.BackColor = System.Drawing.Color.Coral
        Me.btnPlayCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPlayCS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPlayCS.Location = New System.Drawing.Point(350, 31)
        Me.btnPlayCS.Name = "btnPlayCS"
        Me.btnPlayCS.Size = New System.Drawing.Size(75, 32)
        Me.btnPlayCS.TabIndex = 5
        Me.btnPlayCS.Text = "Play"
        Me.btnPlayCS.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 189)
        Me.Controls.Add(Me.btnPlayCS)
        Me.Controls.Add(Me.btnPlayT)
        Me.Controls.Add(Me.tbTeller)
        Me.Controls.Add(Me.tbCS)
        Me.Controls.Add(Me.btnTeller)
        Me.Controls.Add(Me.btnCS)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCS As System.Windows.Forms.Button
    Friend WithEvents btnTeller As System.Windows.Forms.Button
    Friend WithEvents tbCS As System.Windows.Forms.TextBox
    Friend WithEvents tbTeller As System.Windows.Forms.TextBox
    Friend WithEvents btnPlayT As System.Windows.Forms.Button
    Friend WithEvents btnPlayCS As System.Windows.Forms.Button

End Class
