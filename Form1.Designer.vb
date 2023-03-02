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
        Me.fraButtons = New System.Windows.Forms.GroupBox()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.showSelectBtn = New System.Windows.Forms.Button()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.computerList = New System.Windows.Forms.ListBox()
        Me.accessoriesList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.selected = New System.Windows.Forms.Label()
        Me.fraAddItem = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.okBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.fraButtons.SuspendLayout()
        Me.fraAddItem.SuspendLayout()
        Me.SuspendLayout()
        '
        'fraButtons
        '
        Me.fraButtons.Controls.Add(Me.closeBtn)
        Me.fraButtons.Controls.Add(Me.showSelectBtn)
        Me.fraButtons.Controls.Add(Me.deleteBtn)
        Me.fraButtons.Controls.Add(Me.addBtn)
        Me.fraButtons.Location = New System.Drawing.Point(12, 407)
        Me.fraButtons.Name = "fraButtons"
        Me.fraButtons.Size = New System.Drawing.Size(657, 73)
        Me.fraButtons.TabIndex = 0
        Me.fraButtons.TabStop = False
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(6, 19)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(112, 43)
        Me.addBtn.TabIndex = 0
        Me.addBtn.Text = "&Add New Item"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'deleteBtn
        '
        Me.deleteBtn.Location = New System.Drawing.Point(186, 19)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(112, 43)
        Me.deleteBtn.TabIndex = 1
        Me.deleteBtn.Text = "&Delete Item"
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'showSelectBtn
        '
        Me.showSelectBtn.Location = New System.Drawing.Point(365, 19)
        Me.showSelectBtn.Name = "showSelectBtn"
        Me.showSelectBtn.Size = New System.Drawing.Size(112, 43)
        Me.showSelectBtn.TabIndex = 2
        Me.showSelectBtn.Text = "&Show Selection"
        Me.showSelectBtn.UseVisualStyleBackColor = True
        '
        'closeBtn
        '
        Me.closeBtn.Location = New System.Drawing.Point(539, 19)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(112, 43)
        Me.closeBtn.TabIndex = 3
        Me.closeBtn.Text = "&Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'computerList
        '
        Me.computerList.FormattingEnabled = True
        Me.computerList.Items.AddRange(New Object() {"Laptop 486", "Desktop PI", "NoteBook PIII"})
        Me.computerList.Location = New System.Drawing.Point(12, 81)
        Me.computerList.Name = "computerList"
        Me.computerList.Size = New System.Drawing.Size(321, 199)
        Me.computerList.TabIndex = 1
        '
        'accessoriesList
        '
        Me.accessoriesList.FormattingEnabled = True
        Me.accessoriesList.Items.AddRange(New Object() {"Deskjet Printer", "Hard Disk Drive", "Printer Cable", "Data Switch"})
        Me.accessoriesList.Location = New System.Drawing.Point(348, 81)
        Me.accessoriesList.Name = "accessoriesList"
        Me.accessoriesList.Size = New System.Drawing.Size(321, 199)
        Me.accessoriesList.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Computers"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Accessories"
        '
        'selected
        '
        Me.selected.AutoSize = True
        Me.selected.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selected.ForeColor = System.Drawing.Color.Blue
        Me.selected.Location = New System.Drawing.Point(6, 334)
        Me.selected.Name = "selected"
        Me.selected.Size = New System.Drawing.Size(0, 33)
        Me.selected.TabIndex = 5
        '
        'fraAddItem
        '
        Me.fraAddItem.Controls.Add(Me.cancelBtn)
        Me.fraAddItem.Controls.Add(Me.okBtn)
        Me.fraAddItem.Controls.Add(Me.TextBox1)
        Me.fraAddItem.Controls.Add(Me.Label4)
        Me.fraAddItem.Controls.Add(Me.ComboBox1)
        Me.fraAddItem.Location = New System.Drawing.Point(162, 118)
        Me.fraAddItem.Name = "fraAddItem"
        Me.fraAddItem.Size = New System.Drawing.Size(360, 249)
        Me.fraAddItem.TabIndex = 6
        Me.fraAddItem.TabStop = False
        Me.fraAddItem.Text = "Adding New Items to the List"
        Me.fraAddItem.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Computers", "Accessories"})
        Me.ComboBox1.Location = New System.Drawing.Point(9, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(345, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "Select Item Type "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Label4"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 149)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(345, 35)
        Me.TextBox1.TabIndex = 2
        '
        'okBtn
        '
        Me.okBtn.Location = New System.Drawing.Point(68, 203)
        Me.okBtn.Name = "okBtn"
        Me.okBtn.Size = New System.Drawing.Size(103, 31)
        Me.okBtn.TabIndex = 3
        Me.okBtn.Text = "OK"
        Me.okBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(177, 203)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(103, 31)
        Me.cancelBtn.TabIndex = 4
        Me.cancelBtn.Text = "CANCEL"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 492)
        Me.Controls.Add(Me.fraAddItem)
        Me.Controls.Add(Me.selected)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.accessoriesList)
        Me.Controls.Add(Me.computerList)
        Me.Controls.Add(Me.fraButtons)
        Me.Name = "Form1"
        Me.Text = "Computer and Accessories Sales Shop"
        Me.fraButtons.ResumeLayout(False)
        Me.fraAddItem.ResumeLayout(False)
        Me.fraAddItem.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fraButtons As GroupBox
    Friend WithEvents closeBtn As Button
    Friend WithEvents showSelectBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents addBtn As Button
    Friend WithEvents computerList As ListBox
    Friend WithEvents accessoriesList As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents selected As Label
    Friend WithEvents fraAddItem As GroupBox
    Friend WithEvents cancelBtn As Button
    Friend WithEvents okBtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
