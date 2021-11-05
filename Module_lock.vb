Module Module_lock

    Public Function isLocked(locktype As String, lockkey As Integer)
        Dim ByWho As String = ""

        ' test locking van type en key (door andere gebruiker)
        ' leeg = beschikbaar (niet gelockt of gelockt door jezelf (kan eigenlijk niet...))
        lockrecs = From lock In db.LOCKs
                   Join user In db.USERS On lock.LUNRQ Equals user.UNRQ
                   Where lock.LPK = lockkey AndAlso lock.LTYPE = locktype And Not lock.LUNRQ = LoginID
                   Select lock.LID, lock.LPK, lock.LTYPE, lock.LUNRQ, user.UNAAM
        For Each rec In lockrecs
            ByWho = rec.UNAAM
        Next
        Return ByWho
    End Function

    Public Function lockrec(locktype As String, lockkey As Integer)
        Dim succes As Boolean = True
        Dim newrec As New LOCK With {
        .LUNRQ = LoginID,
        .LTYPE = locktype,
        .LDT = ChDate,
        .LPK = lockkey,
        .LSPK = ""
        }
        db.LOCKs.InsertOnSubmit(newrec)
        Try
            db.SubmitChanges()
        Catch ex As Exception
            MsgBox("Locking niet gelukt!")
            succes = False
        End Try
        Return succes
    End Function

    Public Function unlockrec(locktype As String, lockkey As Integer)
        Dim succes As Boolean = True
        Try
            delrecs = From LOCK In db.LOCKs
                      Where LOCK.LPK = lockkey AndAlso LOCK.LTYPE = locktype
            For Each deleterec In delrecs
                db.LOCKs.DeleteOnSubmit(deleterec)
                db.SubmitChanges()
            Next
        Catch
            MsgBox("Unlocking niet gelukt!")
            succes = False
        End Try
        Return succes
    End Function

End Module
