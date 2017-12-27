Public Class Forgot
    Inherits System.Web.UI.Page

    Public ReadOnly Property MemberId() As String
        Get
            Return txtMemberId.Text
        End Get
    End Property
    Public ReadOnly Property MemberDOB() As String
        Get
            Return txtMemberId.Text
        End Get
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnForgotID_Click(sender As Object, e As EventArgs) Handles btnForgotID.Click
        If Page.IsValid And ValidateMember() Then
            pnlForget.Visible = False
            pnlUserID.Visible = True
            lblDisplayId.Text = GetUserId()
        End If
    End Sub

    Private Sub btnForgotPassword_Click(sender As Object, e As EventArgs) Handles btnForgotPassword.Click
        If Page.IsValid And ValidateMember() Then
            Response.Redirect("~/")
        End If
    End Sub

    Private Sub btnForgotIdContinue_Click(sender As Object, e As EventArgs) Handles btnForgotIdContinue.Click
        Response.Redirect("~/Login.aspx")
    End Sub

    Private Function ValidateMember() As Boolean

        'Validate here and return true / false
        Return True
    End Function

    Private Function GetUserId() As String
        'Get User ID from API
        Return "User ID"
    End Function
End Class