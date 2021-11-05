Module Module_PREST

    Public Function GetSELPrestFigures(data As DataGridView)
        Dim found As String = ""
        Dim telbonl As Integer = 0
        Dim telbonltot As Integer = 0
        Dim tothour As Decimal = 0
        Try
            For Each row As DataGridViewRow In data.Rows
                telbonl += 1

                If row.Cells("Totaal").Value = True Then
                    telbonltot += 1
                    tothour += row.Cells("Aantal").Value
                End If


            Next
        Catch ex As Exception

        End Try

        found += telbonl & " records in filter-selectie."
        found += Environment.NewLine
        found += telbonltot & " totaal-records in filter-selectie."
        found += Environment.NewLine
        found += Str(tothour)
        Return "Y#" & found
    End Function

End Module
