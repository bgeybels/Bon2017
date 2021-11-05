Module Module_dim

    Public TotalsAllowed As Boolean = False

    Public SysDate As Date
    Public ChDate As String = Today.ToString("dd/MM/yyyy")
    Public sysDBUsed As String
    Public filenm As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    'Public filenm As String = "c:\temp"
    Public frompopup As Boolean = False
    Public started As Boolean
    Public updatestock As Boolean = True
    Public updatestockaantal As String
    Public updateOK As String = ""
    Public codfrombon As Boolean = False

    ' excel valls
    Public xlLandscape As Integer = 2
    Public xlContinuous As Integer = 1
    Public xlDouble As Integer = -4119
    Public xlLineStyleNone = -4142
    Public xlThick As Integer = 4
    Public xlThin As Integer = 2
    Public xlMedium As Integer = -4138

    Public xlCenter As Integer = -4108
    Public xlRight As Integer = -4152
    Public xlLeft As Integer = -4131

    Public xlDiagonalDown As Integer = 5
    Public xlDiagonalUp As Integer = 6
    Public xlEdgeBottom As Integer = 9
    Public xlEdgeLeft As Integer = 7
    Public xlEdgeRight As Integer = 10
    Public xlEdgeTop As Integer = 8
    Public xlInsideHorizontal As Integer = 12
    Public xlInsideVertical As Integer = 11

    'datevalues
    Public vardvan As Date = SysDate
    Public vardtot As Date = SysDate

    'GRIDparams
    Public evenbc As Color
    Public boxcolor As Color
    Public boxcolorerror As Color
    Public oddbc As Color
    Public evenfc As Color
    Public oddfc As Color
    Public dgcelcolor As Color
    Public dgcelgratis As Color
    Public dgcelmemo As Color
    Public selectbg As Color
    Public selectfg As Color
    Public transgrid As DataGridView
    Public transgrp As Integer

    'DB
    Public db As New BONDataContext()
    Public bonrecs As IQueryable
    Public bonlrecs As IQueryable
    Public codrecs As IQueryable
    Public codgprecs As IQueryable
    Public klantrecs As IQueryable
    Public perrecs As IQueryable
    Public records As IQueryable
    Public recordsd As IQueryable
    Public check As IQueryable
    Public checkrec As IQueryable
    Public searchrecs As IQueryable
    Public delrecs As IQueryable
    Public factrecs As IQueryable
    Public factlrecs As IQueryable
    Public postcoderecs As IQueryable
    Public recstocsv As IQueryable
    Public bonlstock As IQueryable
    Public prestrecs As IQueryable
    Public ptyperecs As IQueryable
    Public lockrecs As IQueryable
    Public afrrecs As IQueryable
    Public aftrecs As IQueryable
    Public afrecs As IQueryable

    'Keys
    Public keybonjr As Integer
    Public tokeybonjr As Integer
    Public keybonnr As Integer
    Public tokeybonnr As Integer
    Public keybonlvnr As Integer
    Public keyfaktjr As Integer
    Public keyfaktnr As Integer
    Public keyfaktfnr As Integer
    Public keyfaktdc As String
    Public keyfaktl As Integer
    Public keyknrq As Integer
    Public keycnrq As Integer
    Public keycodenrq As Integer
    Public keycgnrq As Integer
    Public keybnrq As Integer
    Public keyklantnrq As Integer
    Public keybtwnrq As Integer
    Public keyanrq As Integer
    Public keypernrq As Integer
    Public keypervnr As Integer
    Public keyoaanmnrq As Integer
    Public keylevnrq As Integer
    Public keydiesnrq As Integer
    Public keyeigenaarnrq As Integer
    Public keyloginnrq As Integer
    Public keyversiegnrq As Integer
    Public keyvnrq As Integer
    Public hkey As Integer
    Public hkey2 As Integer
    Public hkey3 As Integer
    Public hkeystr As String
    Public keybonldjr As Integer
    Public keybonldnr As Integer
    Public keybonldvnr As Integer
    Public keypsid As Integer
    Public keyptid As Integer
    Public keyprid As Integer
    Public keyfeest As Integer
    Public keyafrid As Integer
    Public keyaftid As Integer
    Public keyafjr As Integer
    Public keyafvnr As Integer

    'Dropdowns
    Public SelCGNRQ As Integer = 0

    Public updategrid As Boolean = True
    Public nofilter As Boolean = True

    'grid rows
    Public bonrindex As Integer
    Public bonlrindex As Integer

    'sizing forms
    Public plook As Boolean = True

    'Filters
    Public filterstr As String
    Public filterint As Integer
    Public fltklant As String
    Public filtercode As String = ""

    Public keylp As Integer
    Public TimeVal As String = ""
    Public TimeStr As String = ""
    Public HasFnr As Boolean
    Public hasCnr As Boolean
    Public resetbonlselect As Boolean

    Public stocklogon As Boolean = False

    'Permissions and task
    Public IsNewRecord As Boolean = False 'true voor een nieuw record
    Public IsNewCode As Boolean = False
    Public IsNewKlant As Boolean = False
    Public CopyRecord As Boolean = False 'true = copieer een record = dupliceer de gegevens
    Public LoginUPD As Boolean
    Public LoginDEL As Boolean
    Public LoginNEW As Boolean
    Public LoginNm As String
    Public LoginID As Integer
    Public LoginSysAdmin As Boolean
    Public LoginStockAdmin As Boolean
    Public LoginPersAdmin As Boolean
    Public LoginTotals As Boolean
    Public LoginTotalsSys As Boolean
    Public GetFaktNr As Boolean
End Module
