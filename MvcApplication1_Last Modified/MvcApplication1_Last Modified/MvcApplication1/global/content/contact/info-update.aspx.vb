
Partial Class global_content_contact_info_update
    Inherits BaseUIPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit

        If (User.Identity.IsAuthenticated = False) Then
            'Session Timed Out, redirect to Login
            FormsAuthentication.SignOut()
            Response.Redirect(strFormsAuthRedirect)
        Else
            Dim auth As New UserAuthentication
            auth.RenewCookie()
        End If
    End Sub
End Class
