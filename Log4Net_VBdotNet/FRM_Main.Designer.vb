<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Main
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_LogDEBUG = New System.Windows.Forms.Button()
        Me.BTN_LogERR = New System.Windows.Forms.Button()
        Me.BTN_LogWARNING = New System.Windows.Forms.Button()
        Me.BTN_LogINFO = New System.Windows.Forms.Button()
        Me.BTN_LogFromTXTBox = New System.Windows.Forms.Button()
        Me.TXT_Logger = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_Logger = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.Controls.Add(Me.BTN_LogDEBUG)
        Me.Panel1.Controls.Add(Me.BTN_LogERR)
        Me.Panel1.Controls.Add(Me.BTN_LogWARNING)
        Me.Panel1.Controls.Add(Me.BTN_LogINFO)
        Me.Panel1.Controls.Add(Me.BTN_LogFromTXTBox)
        Me.Panel1.Controls.Add(Me.TXT_Logger)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BTN_Logger)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(339, 455)
        Me.Panel1.TabIndex = 0
        '
        'BTN_LogDEBUG
        '
        Me.BTN_LogDEBUG.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_LogDEBUG.ForeColor = System.Drawing.Color.Black
        Me.BTN_LogDEBUG.Location = New System.Drawing.Point(74, 365)
        Me.BTN_LogDEBUG.Name = "BTN_LogDEBUG"
        Me.BTN_LogDEBUG.Size = New System.Drawing.Size(183, 44)
        Me.BTN_LogDEBUG.TabIndex = 7
        Me.BTN_LogDEBUG.Text = "SAMPLE DEBUG LOG"
        Me.BTN_LogDEBUG.UseVisualStyleBackColor = True
        '
        'BTN_LogERR
        '
        Me.BTN_LogERR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_LogERR.ForeColor = System.Drawing.Color.Black
        Me.BTN_LogERR.Location = New System.Drawing.Point(74, 315)
        Me.BTN_LogERR.Name = "BTN_LogERR"
        Me.BTN_LogERR.Size = New System.Drawing.Size(183, 44)
        Me.BTN_LogERR.TabIndex = 6
        Me.BTN_LogERR.Text = "SAMPLE ERROR LOG"
        Me.BTN_LogERR.UseVisualStyleBackColor = True
        '
        'BTN_LogWARNING
        '
        Me.BTN_LogWARNING.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_LogWARNING.ForeColor = System.Drawing.Color.Black
        Me.BTN_LogWARNING.Location = New System.Drawing.Point(74, 265)
        Me.BTN_LogWARNING.Name = "BTN_LogWARNING"
        Me.BTN_LogWARNING.Size = New System.Drawing.Size(183, 44)
        Me.BTN_LogWARNING.TabIndex = 5
        Me.BTN_LogWARNING.Text = "SAMPLE WARNING LOG"
        Me.BTN_LogWARNING.UseVisualStyleBackColor = True
        '
        'BTN_LogINFO
        '
        Me.BTN_LogINFO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_LogINFO.ForeColor = System.Drawing.Color.Black
        Me.BTN_LogINFO.Location = New System.Drawing.Point(74, 215)
        Me.BTN_LogINFO.Name = "BTN_LogINFO"
        Me.BTN_LogINFO.Size = New System.Drawing.Size(183, 44)
        Me.BTN_LogINFO.TabIndex = 4
        Me.BTN_LogINFO.Text = "SAMPLE INFORMATION LOG"
        Me.BTN_LogINFO.UseVisualStyleBackColor = True
        '
        'BTN_LogFromTXTBox
        '
        Me.BTN_LogFromTXTBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_LogFromTXTBox.Enabled = False
        Me.BTN_LogFromTXTBox.ForeColor = System.Drawing.Color.Black
        Me.BTN_LogFromTXTBox.Location = New System.Drawing.Point(74, 77)
        Me.BTN_LogFromTXTBox.Name = "BTN_LogFromTXTBox"
        Me.BTN_LogFromTXTBox.Size = New System.Drawing.Size(183, 47)
        Me.BTN_LogFromTXTBox.TabIndex = 3
        Me.BTN_LogFromTXTBox.Text = "LOG FROM TXTBOX"
        Me.BTN_LogFromTXTBox.UseVisualStyleBackColor = True
        '
        'TXT_Logger
        '
        Me.TXT_Logger.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TXT_Logger.Location = New System.Drawing.Point(74, 51)
        Me.TXT_Logger.Name = "TXT_Logger"
        Me.TXT_Logger.Size = New System.Drawing.Size(183, 20)
        Me.TXT_Logger.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Type your Log here:"
        '
        'BTN_Logger
        '
        Me.BTN_Logger.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTN_Logger.ForeColor = System.Drawing.Color.Black
        Me.BTN_Logger.Location = New System.Drawing.Point(74, 165)
        Me.BTN_Logger.Name = "BTN_Logger"
        Me.BTN_Logger.Size = New System.Drawing.Size(183, 44)
        Me.BTN_Logger.TabIndex = 0
        Me.BTN_Logger.Text = "HELLO WORLD LOG"
        Me.BTN_Logger.UseVisualStyleBackColor = True
        '
        'FRM_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 455)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.Name = "FRM_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log4Net | VB.net Logging"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_LogFromTXTBox As Button
    Friend WithEvents TXT_Logger As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_Logger As Button
    Friend WithEvents BTN_LogDEBUG As Button
    Friend WithEvents BTN_LogERR As Button
    Friend WithEvents BTN_LogWARNING As Button
    Friend WithEvents BTN_LogINFO As Button
End Class
