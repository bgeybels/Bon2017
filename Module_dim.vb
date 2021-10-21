Module Module_dim

    Public SysDate As Date
    Public sysDBUsed As String

    'GRIDparams
    Public evenbc As Color = ColorTranslator.FromHtml(My.Settings.GRIDrowseven)
    Public oddbc As Color = ColorTranslator.FromHtml(My.Settings.GRIDrowsodd)
    Public evenfc As Color = ColorTranslator.FromHtml(My.Settings.GRIDforecoloreven)
    Public oddfc As Color = ColorTranslator.FromHtml(My.Settings.GRIDforecolorodd)
    'DISPLAYparams
    Public boxcolor As Color = ColorTranslator.FromHtml(My.Settings.DISPtextboxbackcolor)
    Public boxcolorerror As Color = ColorTranslator.FromHtml(My.Settings.DISPtextboxerror)
    Public dgcelcolor As Color = ColorTranslator.FromHtml(My.Settings.GRIDcellnotused)

    'DB
    Public db As New BONDataContext()
    Public bonrecs As IQueryable
    Public bonlrecs As IQueryable
    Public codrecs As IQueryable
    Public codgprecs As IQueryable
    Public klantrecs As IQueryable
    Public records As IQueryable
    Public check As IQueryable
    Public checkrec As IQueryable
    Public searchrecs As IQueryable
    Public factrecs As IQueryable
    Public factlrecs As IQueryable

    'Keys
    Public keybonjr As Integer
    Public tokeybonjr As Integer
    Public keybonnr As Integer
    Public tokeybonnr As Integer
    Public keybonlvnr As Integer
    Public keyfaktjr As Integer
    Public keyfaktnr As Integer
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
    Public keyoaanmnrq As Integer
    Public keylevnrq As Integer
    Public keydiesnrq As Integer
    Public keyeigenaarnrq As Integer
    Public keyloginnrq As Integer
    Public hkey As Integer
    Public hkey2 As Integer
    Public hkey3 As Integer
    Public hkeystr As String

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

    Public keylp As Integer
    Public TimeVal As String = ""
    Public TimeStr As String = ""
    Public HasFnr As Boolean
    Public hasCnr As Boolean

    'Permissions and task
    Public IsNewRecord As Boolean = False 'true voor een nieuw record
    Public CopyRecord As Boolean = False 'true = copieer een record = dupliceer de gegevens
    Public LoginUPD As Boolean
    Public LoginDEL As Boolean
    Public LoginNEW As Boolean
    Public LoginNm As String
    Public LoginSysAdmin As Boolean
End Module
