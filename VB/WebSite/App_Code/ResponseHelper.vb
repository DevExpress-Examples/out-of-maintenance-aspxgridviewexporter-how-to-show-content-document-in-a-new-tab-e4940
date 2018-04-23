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


Public Module ResponseHelper
	<System.Runtime.CompilerServices.Extension> _
	Public Sub Redirect(ByVal response As HttpResponse, ByVal url As String, ByVal target As String, ByVal windowFeatures As String)
		If (String.IsNullOrEmpty(target) OrElse target.Equals("_self", StringComparison.OrdinalIgnoreCase)) AndAlso String.IsNullOrEmpty(windowFeatures) Then
			response.Redirect(url)
		Else
			Dim page As Page = CType(HttpContext.Current.Handler, Page)
			If page Is Nothing Then
				Throw New InvalidOperationException("Cannot redirect to new window outside Page context.")
			End If
			url = page.ResolveClientUrl(url)

			Dim script As String
			If (Not String.IsNullOrEmpty(windowFeatures)) Then
				script = "window.open(""{0}"", ""{1}"", ""{2}"");"
			Else
				script = "window.open(""{0}"", ""{1}"");"
			End If

			script = String.Format(script, url, target, windowFeatures)
			ScriptManager.RegisterStartupScript(page, GetType(Page), "Redirect", script, True)
		End If
	End Sub
End Module