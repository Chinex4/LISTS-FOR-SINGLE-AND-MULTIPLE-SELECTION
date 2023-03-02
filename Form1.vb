Public Class Form1
    Dim SelectedItems As String
    Dim Operation As String

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Operation = "Add" Then
            Label4.Text = "Enter " & ComboBox1.Text & " Name"
        Else
            Label4.Text = "Enter Item Number in " & ComboBox1.Text & " List"
        End If
        TextBox1.Text = ""
        TextBox1.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Operation = "Add"
        fraAddItem.Visible = True
        fraButtons.Enabled = False
        Label4.Text = ""
        TextBox1.Text = ""
        TextBox1.Enabled = False
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        fraAddItem.Visible = False
        fraButtons.Enabled = True
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        End
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Operation = "Delete"
        fraAddItem.Visible = True
        fraButtons.Enabled = False
        Label4.Text = ""
        TextBox1.Text = ""
        TextBox1.Enabled = False
    End Sub

    Private Sub okBtn_Click(sender As Object, e As EventArgs) Handles okBtn.Click
        Select Case ComboBox1.SelectedIndex
            Case 0 'Computers
                If Operation = "Delete" Then
                    computerList.Items.RemoveAt(Val(TextBox1.Text))
                Else
                    computerList.Items.Add(TextBox1.Text)
                End If
                computerList.Refresh()
            Case 1 'Accessories 
                If Operation = "Add" Then
                    accessoriesList.Items.Add(TextBox1.Text)
                Else
                    accessoriesList.Items.RemoveAt(Val(TextBox1.Text))
                End If
                accessoriesList.Refresh()
        End Select
        TextBox1.Text = ""
    End Sub

    Private Sub showSelectBtn_Click(sender As Object, e As EventArgs) Handles showSelectBtn.Click
        SelectedItems = "You selected " & computerList.Text & " and " & accessoriesList.Text
        selected.Text = SelectedItems
    End Sub
End Class
