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
        Me.plaintexttxt = New System.Windows.Forms.RichTextBox()
        Me.outputtxt = New System.Windows.Forms.RichTextBox()
        Me.shiftkeytxt = New System.Windows.Forms.TextBox()
        Me.encryptbtn = New System.Windows.Forms.Button()
        Me.decryptbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'plaintexttxt
        '
        Me.plaintexttxt.Location = New System.Drawing.Point(52, 97)
        Me.plaintexttxt.Name = "plaintexttxt"
        Me.plaintexttxt.Size = New System.Drawing.Size(260, 204)
        Me.plaintexttxt.TabIndex = 0
        Me.plaintexttxt.Text = ""
        '
        'outputtxt
        '
        Me.outputtxt.Location = New System.Drawing.Point(442, 97)
        Me.outputtxt.Name = "outputtxt"
        Me.outputtxt.Size = New System.Drawing.Size(260, 204)
        Me.outputtxt.TabIndex = 1
        Me.outputtxt.Text = ""
        '
        'shiftkeytxt
        '
        Me.shiftkeytxt.Location = New System.Drawing.Point(335, 189)
        Me.shiftkeytxt.Name = "shiftkeytxt"
        Me.shiftkeytxt.Size = New System.Drawing.Size(91, 20)
        Me.shiftkeytxt.TabIndex = 2
        '
        'encryptbtn
        '
        Me.encryptbtn.Location = New System.Drawing.Point(237, 316)
        Me.encryptbtn.Name = "encryptbtn"
        Me.encryptbtn.Size = New System.Drawing.Size(75, 23)
        Me.encryptbtn.TabIndex = 3
        Me.encryptbtn.Text = "Encrypt"
        Me.encryptbtn.UseVisualStyleBackColor = True
        '
        'decryptbtn
        '
        Me.decryptbtn.Location = New System.Drawing.Point(627, 316)
        Me.decryptbtn.Name = "decryptbtn"
        Me.decryptbtn.Size = New System.Drawing.Size(75, 23)
        Me.decryptbtn.TabIndex = 4
        Me.decryptbtn.Text = "Decrypt"
        Me.decryptbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Plain Text"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(607, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Output Text"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(345, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Shift Key"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(280, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 31)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Caesar Cipher"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 370)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.decryptbtn)
        Me.Controls.Add(Me.encryptbtn)
        Me.Controls.Add(Me.shiftkeytxt)
        Me.Controls.Add(Me.outputtxt)
        Me.Controls.Add(Me.plaintexttxt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents plaintexttxt As RichTextBox
    Friend WithEvents outputtxt As RichTextBox
    Friend WithEvents shiftkeytxt As TextBox
    Friend WithEvents encryptbtn As Button
    Friend WithEvents decryptbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
