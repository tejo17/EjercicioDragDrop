Public Class Form1
    Dim posLista As String
    Private Sub SingleR_Click(sender As Object, e As EventArgs) Handles singleRight.Click
        If ListBox1.SelectedItem = Nothing Then
            ErrorProvider1.SetError(ListBox1, "Debes seleccionar un elemento del campo de la izquierda.")
        Else
            ErrorProvider1.SetError(ListBox1, "")
            For Each item As String In ListBox1.SelectedItems
                ListBox2.Items.Add(item)
            Next

            For Each item As String In ListBox1.SelectedItems
                Console.Write(item)

            Next

        End If
    End Sub
    Private Sub SingleL_Click(sender As Object, e As EventArgs) Handles singleLeft.Click

        If ListBox2.SelectedItem = Nothing Then
            ErrorProvider2.SetError(ListBox2, "Debes seleccionar un elemento del campo de la derecha.")
        Else
            ErrorProvider2.SetError(ListBox2, "")
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        End If
    End Sub
    Private Sub AllR_Click(sender As Object, e As EventArgs) Handles allRight.Click
        For i As Integer = 0 To ListBox1.Items.Count - 1
            ListBox1.SetSelected(i, True)
            ListBox2.Items.Add(ListBox1.SelectedItem)
        Next
        ListBox1.Items.Clear()
    End Sub

    Private Sub allL_Click(sender As Object, e As EventArgs) Handles allLeft.Click
        For i As Integer = 0 To ListBox2.Items.Count - 1
            ListBox2.SetSelected(i, True)
            ListBox1.Items.Add(ListBox2.SelectedItem)
        Next
        ListBox2.Items.Clear()
    End Sub
    Private Sub ListBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseMove
        posLista = "izq"
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            ListBox1.DoDragDrop(ListBox1.Text, DragDropEffects.All)
        End If
    End Sub

    Private Sub ListBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles ListBox2.MouseMove
        posLista = "der"
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            ListBox2.DoDragDrop(ListBox2.Text, DragDropEffects.All)
        End If
    End Sub

    Private Sub ListBox2_DragDrop(sender As Object, e As DragEventArgs) Handles ListBox2.DragDrop

        ListBox2.Text = (e.Data.GetData(DataFormats.Text).ToString())
        ListBox2.Items.Add(ListBox1.SelectedItem)
        ListBox1.Items.Remove(ListBox1.SelectedItem)

    End Sub

    Private Sub ListBox1_DragDrop(sender As Object, e As DragEventArgs) Handles ListBox1.DragDrop

        ListBox1.Text = (e.Data.GetData(DataFormats.Text).ToString())
        ListBox1.Items.Add(ListBox2.SelectedItem)
        ListBox2.Items.Remove(ListBox2.SelectedItem)

    End Sub

    Private Sub ListBox2_DragEnter(sender As Object, e As DragEventArgs) Handles ListBox2.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) And posLista.Equals("izq") Then
            e.Effect = DragDropEffects.All
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub ListBox1_DragEnter(sender As Object, e As DragEventArgs) Handles ListBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.Text) And posLista.Equals("der") Then
            e.Effect = DragDropEffects.All
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
End Class
