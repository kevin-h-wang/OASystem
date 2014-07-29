﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PersonManage.aspx.cs" Inherits="WHF.OA.WebUI.Views.BasicData.PersonManage" %>

<%@ Register Src="..\..\Controls\Navigator.ascx" TagName="Navigator" TagPrefix="uc1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/adminCss.css" rel="stylesheet" type="text/css" />
</head>
<body style="margin:0">
    <form id="form1" runat="server">
    <table cellpadding="0" cellspacing="0" class="TableMain">
        <tr>
            <td height="12">
                <asp:Label ID="lblTitle" CssClass="LabelMain" runat="server" Text="人员管理"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <table class="TableMain" cellpadding="0" cellspacing="0">
                    <tr>
                        <td align="right" width="160"><asp:Label ID="lblEmpNO" CssClass="LabelTitle" Text="员工账号" runat="server"></asp:Label></td>
                        <td align="left" width="180"><asp:TextBox ID="txtEmpNO" CssClass="TextBoxMain160" runat="server"></asp:TextBox></td>
                        <td width="4"></td>
                        <td align="right" width="160"><asp:Label ID="lblEmpName" CssClass="LabelTitle" Text="员工姓名" runat="server"></asp:Label></td>
                        <td align="left" width="180"><asp:TextBox ID="txtEmpName" runat="server" CssClass="TextBoxMain160"></asp:TextBox></td>
                        <td align="right"><asp:Button ID="btnQuery" runat="server" Text="查询" CssClass="ButtonMain" /></td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td height="80%">
                <div style="height: 93%; width: 100%;border: 2px solid #cccccc;">
                    <asp:GridView CssClass="gridview_list" ID="gvTest" AutoGenerateColumns="false" runat="server"
                        BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3"
                        CellSpacing="1" GridLines="None">
                        <Columns>
                            <asp:BoundField Visible="false" DataField="oid" HeaderText="" />
                            <asp:BoundField DataField="personaccount" HeaderText="员工账号" />
                            <asp:BoundField DataField="personname" HeaderText="员工姓名" />
                            <asp:BoundField DataField="personsex" HeaderText="员工性别" />
                            <asp:BoundField DataField="personofficephone" HeaderText="办公电话" />
                            <asp:BoundField DataField="personmobilephone" HeaderText="移动电话" />
                            <asp:BoundField DataField="personemail" HeaderText="电子邮件" />
                            <asp:BoundField DataField="persondesc" HeaderText="备注信息" />
                        </Columns>
                        <HeaderStyle CssClass="gridview_header" />
                        <RowStyle CssClass="gridview_row" />
                        <AlternatingRowStyle CssClass="altrow" />
                        <SelectedRowStyle CssClass="gridviewRowSelected" />
                    </asp:GridView>
                </div>
                <div style=" height:10px;float: right;">
                    <uc1:Navigator ID="Navigator" runat="server" />
                </div>
            </td>
        </tr>
        <tr>
            <td height="10" align="center">
                <asp:Button ID="btnAdd" runat="server" Text="新增" CssClass="ButtonMain" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
