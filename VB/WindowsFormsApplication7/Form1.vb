Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace WindowsFormsApplication1

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            For i As Integer = 0 To 5 - 1
                dataTable1.Rows.Add(New Object() {i, "Text" & i})
            Next
        End Sub

        Private Sub repositoryItemPopupContainerEdit1_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs)
            e.Value = memoEdit1.EditValue
        End Sub

        Private Sub repositoryItemPopupContainerEdit1_QueryPopUp(ByVal sender As Object, ByVal e As CancelEventArgs)
            memoEdit1.EditValue = TryCast(sender, PopupContainerEdit).EditValue
        End Sub
    End Class
End Namespace
