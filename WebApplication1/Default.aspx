<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>
<!--inherits from Default.aspx.cs-->
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!--runat means run the events associated with it at server side -->
            <asp:Label ID="Label1" runat="server" Text="Demo of ASP.NET Web Page" />
            <asp:Button ID="Button1" runat="server" Text="Click" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
