Module Module_Display
    Public Sub SetGridRows(dgrid As DataGridView)
        dgrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        With dgrid
            .Dock = DockStyle.Fill
            .AlternatingRowsDefaultCellStyle.BackColor = evenbc
            .AlternatingRowsDefaultCellStyle.ForeColor = evenfc
            .RowsDefaultCellStyle.BackColor = oddbc
            .RowsDefaultCellStyle.ForeColor = oddfc
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .ScrollBars = ScrollBars.Vertical
        End With
    End Sub

    Public Sub SetPopupForm(dform As Form)
        dform.FormBorderStyle = FormBorderStyle.FixedDialog
        'dform.StartPosition = FormStartPosition.CenterParent

        dform.MaximizeBox = False
        dform.MinimizeBox = False
        dform.AutoSize = True
        dform.AutoSizeMode = AutoSizeMode.GrowOnly
        dform.ControlBox = False

        Dim TextBoxes = GetAllControls(dform).OfType(Of TextBox)().ToList()
        For Each item As TextBox In TextBoxes
            item.BackColor = boxcolor
        Next
        Dim ComboBoxes = GetAllControls(dform).OfType(Of ComboBox)().ToList()
        For Each item As ComboBox In ComboBoxes
            If Mid(item.Name, 1, 4) = "ICMB" Then
                item.BackColor = boxcolor
            End If
        Next
    End Sub

    Public Function GetAllControls(control As Control) As IEnumerable(Of Control)
        Dim controls = control.Controls.Cast(Of Control)()
        Return controls.SelectMany(Function(ctrl) GetAllControls(ctrl)).Concat(controls)
    End Function
End Module
