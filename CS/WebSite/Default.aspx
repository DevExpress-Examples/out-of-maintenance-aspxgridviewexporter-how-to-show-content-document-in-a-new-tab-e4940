<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxCallback" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxLoadingPanel" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView.Export" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASPxGridViewExporter - How to show a content document in a new tab</title>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxGridView ID="gv" runat="server" AutoGenerateColumns="False" KeyFieldName="CategoryID">
            <Columns>
                <dx:GridViewCommandColumn>
                    <EditButton Visible="true"></EditButton>
                </dx:GridViewCommandColumn>
                <dx:GridViewDataTextColumn FieldName="CategoryID" ReadOnly="True"
                    VisibleIndex="1">
                    <EditFormSettings Visible="False" />
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="CategoryName" VisibleIndex="2">
                </dx:GridViewDataTextColumn>
                <dx:GridViewDataTextColumn FieldName="Description" VisibleIndex="3">
                </dx:GridViewDataTextColumn>
            </Columns>
        </dx:ASPxGridView>
        <dx:ASPxGridViewExporter ID="exporter" runat="server"></dx:ASPxGridViewExporter>
        <dx:ASPxLoadingPanel ID="lp" runat="server" Modal="true" ClientInstanceName="lp">
        </dx:ASPxLoadingPanel>
        <dx:ASPxButton ID="btn" runat="server" Text="Export" OnClick="btn_Click">
            <ClientSideEvents Click="function(s, e) { lp.Show(); e.processOnServer = true; }" />
        </dx:ASPxButton>
    </form>
</body>
</html>
