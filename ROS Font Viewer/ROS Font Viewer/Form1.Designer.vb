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
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.MaterialSingleLineTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.UnderlineButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.StrikethroughButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.ItalicButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.BoldButton = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SuspendLayout()
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Icon = Nothing
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(14, 229)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(29, 36)
        Me.MaterialFlatButton1.TabIndex = 4
        Me.MaterialFlatButton1.Text = "1"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'MaterialSingleLineTextField1
        '
        Me.MaterialSingleLineTextField1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.MaterialSingleLineTextField1.Depth = 0
        Me.MaterialSingleLineTextField1.Hint = "Size"
        Me.MaterialSingleLineTextField1.Location = New System.Drawing.Point(141, 197)
        Me.MaterialSingleLineTextField1.MaxLength = 5
        Me.MaterialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField1.Name = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField1.SelectedText = ""
        Me.MaterialSingleLineTextField1.SelectionLength = 0
        Me.MaterialSingleLineTextField1.SelectionStart = 0
        Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(46, 23)
        Me.MaterialSingleLineTextField1.TabIndex = 5
        Me.MaterialSingleLineTextField1.TabStop = False
        Me.MaterialSingleLineTextField1.Text = "13"
        Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(14, 190)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 30)
        Me.ComboBox1.TabIndex = 6
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(378, 172)
        Me.RichTextBox1.TabIndex = 11
        Me.RichTextBox1.Text = ""
        '
        'UnderlineButton
        '
        Me.UnderlineButton.AutoSize = True
        Me.UnderlineButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UnderlineButton.Depth = 0
        Me.UnderlineButton.Icon = Global.ROS_Font_Viewer.My.Resources.Resources.underline
        Me.UnderlineButton.Location = New System.Drawing.Point(141, 229)
        Me.UnderlineButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UnderlineButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.UnderlineButton.Name = "UnderlineButton"
        Me.UnderlineButton.Primary = False
        Me.UnderlineButton.Size = New System.Drawing.Size(44, 36)
        Me.UnderlineButton.TabIndex = 10
        Me.UnderlineButton.UseVisualStyleBackColor = True
        '
        'StrikethroughButton
        '
        Me.StrikethroughButton.AutoSize = True
        Me.StrikethroughButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.StrikethroughButton.Depth = 0
        Me.StrikethroughButton.Icon = Global.ROS_Font_Viewer.My.Resources.Resources.strikethrough
        Me.StrikethroughButton.Location = New System.Drawing.Point(193, 229)
        Me.StrikethroughButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.StrikethroughButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.StrikethroughButton.Name = "StrikethroughButton"
        Me.StrikethroughButton.Primary = False
        Me.StrikethroughButton.Size = New System.Drawing.Size(44, 36)
        Me.StrikethroughButton.TabIndex = 9
        Me.StrikethroughButton.UseVisualStyleBackColor = True
        '
        'ItalicButton
        '
        Me.ItalicButton.AutoSize = True
        Me.ItalicButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ItalicButton.Depth = 0
        Me.ItalicButton.Icon = Global.ROS_Font_Viewer.My.Resources.Resources.italic
        Me.ItalicButton.Location = New System.Drawing.Point(91, 229)
        Me.ItalicButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ItalicButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.ItalicButton.Name = "ItalicButton"
        Me.ItalicButton.Primary = False
        Me.ItalicButton.Size = New System.Drawing.Size(44, 36)
        Me.ItalicButton.TabIndex = 8
        Me.ItalicButton.UseVisualStyleBackColor = True
        '
        'BoldButton
        '
        Me.BoldButton.AutoSize = True
        Me.BoldButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BoldButton.Depth = 0
        Me.BoldButton.Icon = Global.ROS_Font_Viewer.My.Resources.Resources.bold
        Me.BoldButton.Location = New System.Drawing.Point(51, 229)
        Me.BoldButton.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BoldButton.MouseState = MaterialSkin.MouseState.HOVER
        Me.BoldButton.Name = "BoldButton"
        Me.BoldButton.Primary = False
        Me.BoldButton.Size = New System.Drawing.Size(44, 36)
        Me.BoldButton.TabIndex = 7
        Me.BoldButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(402, 425)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.UnderlineButton)
        Me.Controls.Add(Me.StrikethroughButton)
        Me.Controls.Add(Me.ItalicButton)
        Me.Controls.Add(Me.BoldButton)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MaterialSingleLineTextField1)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Font = New System.Drawing.Font("Roboto", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ROS Font Viewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BoldButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents ItalicButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents StrikethroughButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents UnderlineButton As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
