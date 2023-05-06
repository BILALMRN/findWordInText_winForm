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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox_phrase3 = New System.Windows.Forms.TextBox()
        Me.TextBox_str = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.labelText = New System.Windows.Forms.Label()
        Me.Button_search = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_phrase1 = New System.Windows.Forms.TextBox()
        Me.TextBox_phrase2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label_count = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(176, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox_phrase3
        '
        Me.TextBox_phrase3.Location = New System.Drawing.Point(176, 145)
        Me.TextBox_phrase3.Name = "TextBox_phrase3"
        Me.TextBox_phrase3.Size = New System.Drawing.Size(201, 20)
        Me.TextBox_phrase3.TabIndex = 0
        '
        'TextBox_str
        '
        Me.TextBox_str.Location = New System.Drawing.Point(257, 201)
        Me.TextBox_str.Name = "TextBox_str"
        Me.TextBox_str.Size = New System.Drawing.Size(120, 20)
        Me.TextBox_str.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(40, 204)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(68, 17)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Phrase 1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(40, 240)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(68, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Phrase 2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(40, 272)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(68, 17)
        Me.CheckBox3.TabIndex = 1
        Me.CheckBox3.Text = "Phrase 3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'labelText
        '
        Me.labelText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelText.Location = New System.Drawing.Point(40, 325)
        Me.labelText.Name = "labelText"
        Me.labelText.Size = New System.Drawing.Size(180, 31)
        Me.labelText.TabIndex = 2
        Me.labelText.Text = "combien de str exist  :  "
        Me.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_search
        '
        Me.Button_search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button_search.Location = New System.Drawing.Point(302, 236)
        Me.Button_search.Name = "Button_search"
        Me.Button_search.Size = New System.Drawing.Size(75, 23)
        Me.Button_search.TabIndex = 3
        Me.Button_search.Text = "Search"
        Me.Button_search.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Phrase 1 : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phrase 2 : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Phrase 3 : "
        '
        'TextBox_phrase1
        '
        Me.TextBox_phrase1.Location = New System.Drawing.Point(176, 57)
        Me.TextBox_phrase1.Name = "TextBox_phrase1"
        Me.TextBox_phrase1.Size = New System.Drawing.Size(201, 20)
        Me.TextBox_phrase1.TabIndex = 0
        '
        'TextBox_phrase2
        '
        Me.TextBox_phrase2.Location = New System.Drawing.Point(176, 99)
        Me.TextBox_phrase2.Name = "TextBox_phrase2"
        Me.TextBox_phrase2.Size = New System.Drawing.Size(201, 20)
        Me.TextBox_phrase2.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(173, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "STR"
        '
        'Label_count
        '
        Me.Label_count.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_count.Location = New System.Drawing.Point(253, 325)
        Me.Label_count.Name = "Label_count"
        Me.Label_count.Size = New System.Drawing.Size(124, 31)
        Me.Label_count.TabIndex = 2
        Me.Label_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 410)
        Me.Controls.Add(Me.Button_search)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label_count)
        Me.Controls.Add(Me.labelText)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox_str)
        Me.Controls.Add(Me.TextBox_phrase2)
        Me.Controls.Add(Me.TextBox_phrase3)
        Me.Controls.Add(Me.TextBox_phrase1)
        Me.Controls.Add(Me.TextBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox_phrase3 As TextBox
    Friend WithEvents TextBox_str As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents labelText As Label
    Friend WithEvents Button_search As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_phrase1 As TextBox
    Friend WithEvents TextBox_phrase2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label_count As Label
End Class
