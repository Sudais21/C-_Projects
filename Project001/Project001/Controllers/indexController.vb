Imports System.Web.Mvc

Namespace Controllers
    Public Class indexController
        Inherits Controller

        ' GET: index
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace