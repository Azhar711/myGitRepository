
Partial Class global_content_terms_of_use
    Inherits BaseUIPage

    Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit

        If (User.Identity.IsAuthenticated = False) Then
            Page.MasterPageFile = "~/master/userauth.master"
        Else
            Dim auth As New UserAuthentication
            auth.RenewCookie()
            Page.MasterPageFile = "~/master/header.master"
        End If

    End Sub
End Class
