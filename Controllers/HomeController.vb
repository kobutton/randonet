Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Title") = "RANDO.NET Home"

        Return View()
    End Function
End Class
