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
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.btn_calc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(166, 62)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(125, 27)
        Me.txt1.TabIndex = 0
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(166, 116)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(125, 27)
        Me.txt2.TabIndex = 1
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(166, 176)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(125, 27)
        Me.txt3.TabIndex = 2
        '
        'txt4
        '
        Me.txt4.Enabled = False
        Me.txt4.Location = New System.Drawing.Point(166, 233)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(125, 27)
        Me.txt4.TabIndex = 3
        '
        'btn_calc
        '
        Me.btn_calc.Location = New System.Drawing.Point(166, 308)
        Me.btn_calc.Name = "btn_calc"
        Me.btn_calc.Size = New System.Drawing.Size(125, 29)
        Me.btn_calc.TabIndex = 4
        Me.btn_calc.Text = "Hesapla"
        Me.btn_calc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Öz direnç"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Kesit alanı"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Uzunluk"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Direnç"
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(166, 357)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(125, 29)
        Me.btn_clear.TabIndex = 9
        Me.btn_clear.Text = "Temizle"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 480)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_calc)
        Me.Controls.Add(Me.txt4)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Name = "Form1"
        Me.Text = "Direnç Hesaplayıcı"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents txt4 As TextBox
    Friend WithEvents btn_calc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_clear As Button
End Class
