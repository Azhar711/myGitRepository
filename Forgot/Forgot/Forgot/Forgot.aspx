<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Forgot.aspx.vb" Inherits="Forgot.Forgot" MasterPageFile="~/Site1.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ID="ctForgot">
    <asp:Panel ID="pnlForget" runat="server">
        <asp:Label ID="lblDOB" runat="server" Text="Member DOB (MM/DD/YYYY)"></asp:Label>
        <br />
        <asp:TextBox ID="txtMemberDOB" runat="server" ValidationGroup="Forget"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="reqMemberDOB" runat="server" ControlToValidate="txtMemberDOB" ErrorMessage="Please enter DOB."
            SetFocusOnError="true" Display="Dynamic" ValidationGroup="Forget"></asp:RequiredFieldValidator>
        <asp:CustomValidator runat="server" ClientValidationFunction="ValidateDate" SetFocusOnError="true" ControlToValidate="txtMemberDOB" Display="Dynamic"
            ErrorMessage="Please enter valid date in the specified format." ValidationGroup="Forget" />
        <br />
        <br />
        <asp:Label ID="lblMemberId" runat="server" Text="Member ID"></asp:Label>
        <br />
        <asp:TextBox ID="txtMemberId" runat="server" ValidationGroup="Forget"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="reqMemberId" runat="server" ControlToValidate="txtMemberId" ErrorMessage="Please enter member id."
            SetFocusOnError="true" Display="Dynamic" ValidationGroup="Forget"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Button ID="btnForgotID" runat="server" Text="Recover My User ID" ValidationGroup="Forget" />
        <br />
        <br />
        <asp:Button ID="btnForgotPassword" runat="server" Text="Recover My Password" ValidationGroup="Forget" />
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
    </asp:Panel>
    <asp:Panel ID="pnlUserID" runat="server" Visible="false">
        Forgot Your ID?
        <br />
        <br />
        Login ID
        <br />
        <br />
        <asp:Label ID="lblDisplayId" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnForgotIdContinue" runat="server" Text="Continue" />
    </asp:Panel>
    <script type="text/javascript">
        function ValidateDate(sender, args) {
            var dateString = document.getElementById(sender.controltovalidate).value;
            var regex = /((0[1-9]|1[0-2])\/((0|1)[0-9]|2[0-9]|3[0-1])\/((19|20)\d\d))$/;
            if (regex.test(dateString)) {
                var parts = dateString.split("/");
                var dt = new Date(parts[1] + "/" + parts[0] + "/" + parts[2]);
                args.IsValid = (dt.getDate() == parts[0] && dt.getMonth() + 1 == parts[1] && dt.getFullYear() == parts[2]);
            } else {
                args.IsValid = false;
            }
        }
    </script>

</asp:Content>
