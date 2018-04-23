Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			For i As Integer = 0 To 4
				dataTable1.Rows.Add(New Object() { i, "Text" & i })
			Next i
		End Sub

		Private Sub repositoryItemPopupContainerEdit1_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles repositoryItemPopupContainerEdit1.QueryResultValue
			e.Value = memoEdit1.EditValue
		End Sub

		Private Sub repositoryItemPopupContainerEdit1_QueryPopUp(ByVal sender As Object, ByVal e As CancelEventArgs) Handles repositoryItemPopupContainerEdit1.QueryPopUp
			memoEdit1.EditValue = (TryCast(sender, PopupContainerEdit)).EditValue
		End Sub
	End Class
End Namespace
