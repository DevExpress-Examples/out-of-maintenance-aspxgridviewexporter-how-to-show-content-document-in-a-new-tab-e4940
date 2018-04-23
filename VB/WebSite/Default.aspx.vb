Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxGridView
Imports System.IO

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Private Shared fileName As String = "myFile.pdf"
	Private Shared folder As String = HttpContext.Current.Server.MapPath("~/PDF")
	Private Shared fullPath As String = Path.Combine(folder, "myFile.pdf")

	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		gv.DataSource = Enumerable.Range(0, 9).Select(Function(i) New With {Key .CategoryID = i, Key .CategoryName = "CategoryName" & i, Key .Description = "Description" & i})
		gv.DataBind()
	End Sub

	Protected Sub btn_Click(ByVal sender As Object, ByVal e As EventArgs)
		Using fileStream As FileStream = File.Create(fullPath)
			exporter.WritePdf(fileStream)
		End Using

		Dim url As String = String.Format("Default2.aspx?Name={0}", fileName)
		Response.Redirect(url, "_blank", "")
	End Sub
End Class