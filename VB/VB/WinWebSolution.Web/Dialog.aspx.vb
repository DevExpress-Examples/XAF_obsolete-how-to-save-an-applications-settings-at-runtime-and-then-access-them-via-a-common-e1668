Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.ExpressApp.Web
Imports DevExpress.ExpressApp.Editors
Imports DevExpress.ExpressApp.Web.Templates

Partial Public Class DialogPage
	Inherits BaseXafPage
	Implements ILookupPopupFrameTemplate
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		WebApplication.Instance.CreateControls(Me)
	End Sub
	Protected Overrides Sub OnViewChanged(ByVal view As DevExpress.ExpressApp.View)
        ViewSiteControl = viewSiteControl1
	End Sub
	Public Sub New()
	End Sub
	#Region "ILookupPopupFrameTemplate Members"

    Public Property IsSearchEnabled() As Boolean Implements ILookupPopupFrameTemplate.IsSearchEnabled
        Get
            Return SearchActionContainer.Visible
        End Get
        Set(ByVal value As Boolean)
            SearchActionContainer.Visible = value
        End Set
    End Property

    Public Sub SetStartSearchString(ByVal searchString As String) Implements ILookupPopupFrameTemplate.SetStartSearchString
    End Sub

	#End Region
End Class
