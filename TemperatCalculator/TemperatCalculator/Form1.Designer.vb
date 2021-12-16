<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.TextBoxC = New System.Windows.Forms.TextBox()
        Me.TextBoxF = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonConvet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxC
        '
        Me.TextBoxC.Location = New System.Drawing.Point(84, 43)
        Me.TextBoxC.Name = "TextBoxC"
        Me.TextBoxC.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxC.TabIndex = 0
        '
        'TextBoxF
        '
        Me.TextBoxF.Location = New System.Drawing.Point(84, 87)
        Me.TextBoxF.Name = "TextBoxF"
        Me.TextBoxF.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxF.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "C"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "F"
        '
        'ButtonConvet
        '
        Me.ButtonConvet.Location = New System.Drawing.Point(301, 47)
        Me.ButtonConvet.Name = "ButtonConvet"
        Me.ButtonConvet.Size = New System.Drawing.Size(75, 23)
        Me.ButtonConvet.TabIndex = 4
        Me.ButtonConvet.Text = "Convet"
        Me.ButtonConvet.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonConvet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxF)
        Me.Controls.Add(Me.TextBoxC)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxC As TextBox
    Friend WithEvents TextBoxF As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonConvet As Button
End Class
