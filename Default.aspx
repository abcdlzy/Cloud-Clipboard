<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="cloudcliper.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tbtext" runat="server" Height="185px" TextMode="MultiLine" Width="986px"></asp:TextBox>
            <br />
            <asp:Button ID="btntextsubmit" runat="server" Text="保存文本" OnClick="btntextsubmit_Click" />
&nbsp;
            <asp:Label ID="lbTextSaveMsg" runat="server" Text="Label"></asp:Label>

            <hr/>
            <br />
            <asp:Button ID="btnFileDownload" runat="server" OnClick="btnFileDownload_Click" Text="当前无文件" />
            <br />
            <br />
            <asp:FileUpload ID="fufile" runat="server" />
            <br />
            <asp:Button ID="btnfilesubmit" runat="server" Text="保存文件" OnClick="btnfilesubmit_Click" />
&nbsp;
            <asp:Label ID="lbFileSaveMsg" runat="server" Text="Label"></asp:Label>

            <br />
        </div>
    </form>
</body>
</html>
