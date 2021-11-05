Module Module_AFTH

    Public Function GetHighAFVNR(keyjr As Integer)
        Dim found As Integer

        found = 0
        Try
            found = (From af In db.AFs Where af.AFJR = keyjr Select af.AFVNR).Max()
        Catch ex As Exception

        End Try
        Return found + 1
    End Function

    Public Function GetHighAFNR(keyjr As Integer)
        Dim found As Integer

        found = 0
        Try
            found = (From af In db.AFs Where af.AFJR = keyjr Select af.AFNR).Max()
        Catch ex As Exception

        End Try
        Return found + 1
    End Function

    Public Function AFNRexist(keyjr As Integer, keyafnr As Integer)
        Dim notfound As Boolean = True
        afrecs = From af In db.AFs
                 Where af.AFJR = keyjr And af.AFNR = keyafnr
                 Select af.AFJR, af.AFNR

        For Each afrec In afrecs
            notfound = False
        Next

        Return notfound
    End Function

End Module
