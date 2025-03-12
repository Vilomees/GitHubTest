<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ekraaniVorm
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
        Me.txtSisend = New System.Windows.Forms.TextBox()
        Me.txtVastus = New System.Windows.Forms.TextBox()
        Me.cmbTeisendus = New System.Windows.Forms.ComboBox()
        Me.lblSisendYhik = New System.Windows.Forms.Label()
        Me.lblVastusYhik = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSisend
        '
        Me.txtSisend.Location = New System.Drawing.Point(191, 103)
        Me.txtSisend.Name = "txtSisend"
        Me.txtSisend.Size = New System.Drawing.Size(121, 26)
        Me.txtSisend.TabIndex = 0
        '
        'txtVastus
        '
        Me.txtVastus.Enabled = False
        Me.txtVastus.Location = New System.Drawing.Point(191, 195)
        Me.txtVastus.Name = "txtVastus"
        Me.txtVastus.Size = New System.Drawing.Size(121, 26)
        Me.txtVastus.TabIndex = 1
        '
        'cmbTeisendus
        '
        Me.cmbTeisendus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTeisendus.Enabled = False
        Me.cmbTeisendus.FormattingEnabled = True
        Me.cmbTeisendus.Location = New System.Drawing.Point(191, 152)
        Me.cmbTeisendus.Name = "cmbTeisendus"
        Me.cmbTeisendus.Size = New System.Drawing.Size(121, 28)
        Me.cmbTeisendus.TabIndex = 2
        '
        'lblSisendYhik
        '
        Me.lblSisendYhik.AutoSize = True
        Me.lblSisendYhik.Location = New System.Drawing.Point(347, 109)
        Me.lblSisendYhik.Name = "lblSisendYhik"
        Me.lblSisendYhik.Size = New System.Drawing.Size(57, 20)
        Me.lblSisendYhik.TabIndex = 3
        Me.lblSisendYhik.Text = "Label1"
        '
        'lblVastusYhik
        '
        Me.lblVastusYhik.AutoSize = True
        Me.lblVastusYhik.Location = New System.Drawing.Point(347, 201)
        Me.lblVastusYhik.Name = "lblVastusYhik"
        Me.lblVastusYhik.Size = New System.Drawing.Size(57, 20)
        Me.lblVastusYhik.TabIndex = 4
        Me.lblVastusYhik.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblVastusYhik)
        Me.Controls.Add(Me.lblSisendYhik)
        Me.Controls.Add(Me.cmbTeisendus)
        Me.Controls.Add(Me.txtVastus)
        Me.Controls.Add(Me.txtSisend)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSisend As TextBox
    Friend WithEvents txtVastus As TextBox
    Friend WithEvents cmbTeisendus As ComboBox
    Friend WithEvents lblSisendYhik As Label
    Friend WithEvents lblVastusYhik As Label
End Class
