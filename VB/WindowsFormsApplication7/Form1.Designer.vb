Namespace WindowsFormsApplication1

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.dataSet1 = New System.Data.DataSet()
            Me.dataTable1 = New System.Data.DataTable()
            Me.dataColumn1 = New System.Data.DataColumn()
            Me.dataColumn2 = New System.Data.DataColumn()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
            Me.popupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataSet1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dataTable1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemPopupContainerEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.popupContainerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupContainerControl1.SuspendLayout()
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataMember = "Table1"
            Me.gridControl1.DataSource = Me.dataSet1
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemPopupContainerEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(487, 358)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' dataSet1
            ' 
            Me.dataSet1.DataSetName = "NewDataSet"
            Me.dataSet1.Tables.AddRange(New System.Data.DataTable() {Me.dataTable1})
            ' 
            ' dataTable1
            ' 
            Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.dataColumn1, Me.dataColumn2})
            Me.dataTable1.TableName = "Table1"
            ' 
            ' dataColumn1
            ' 
            Me.dataColumn1.ColumnName = "Column1"
            ' 
            ' dataColumn2
            ' 
            Me.dataColumn2.ColumnName = "Column2"
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colColumn1, Me.colColumn2})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' colColumn1
            ' 
            Me.colColumn1.Caption = "Column1"
            Me.colColumn1.FieldName = "Column1"
            Me.colColumn1.Name = "colColumn1"
            Me.colColumn1.Visible = True
            Me.colColumn1.VisibleIndex = 0
            ' 
            ' colColumn2
            ' 
            Me.colColumn2.Caption = "Column2"
            Me.colColumn2.ColumnEdit = Me.repositoryItemPopupContainerEdit1
            Me.colColumn2.FieldName = "Column2"
            Me.colColumn2.Name = "colColumn2"
            Me.colColumn2.Visible = True
            Me.colColumn2.VisibleIndex = 1
            ' 
            ' repositoryItemPopupContainerEdit1
            ' 
            Me.repositoryItemPopupContainerEdit1.AutoHeight = False
            Me.repositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1"
            Me.repositoryItemPopupContainerEdit1.PopupControl = Me.popupContainerControl1
            AddHandler Me.repositoryItemPopupContainerEdit1.QueryResultValue, New DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(AddressOf Me.repositoryItemPopupContainerEdit1_QueryResultValue)
            AddHandler Me.repositoryItemPopupContainerEdit1.QueryPopUp, New System.ComponentModel.CancelEventHandler(AddressOf Me.repositoryItemPopupContainerEdit1_QueryPopUp)
            ' 
            ' popupContainerControl1
            ' 
            Me.popupContainerControl1.Controls.Add(Me.memoEdit1)
            Me.popupContainerControl1.Location = New System.Drawing.Point(275, 105)
            Me.popupContainerControl1.Name = "popupContainerControl1"
            Me.popupContainerControl1.Size = New System.Drawing.Size(200, 100)
            Me.popupContainerControl1.TabIndex = 1
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.memoEdit1.Location = New System.Drawing.Point(0, 0)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Size = New System.Drawing.Size(200, 100)
            Me.memoEdit1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(487, 358)
            Me.Controls.Add(Me.popupContainerControl1)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataSet1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dataTable1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemPopupContainerEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.popupContainerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupContainerControl1.ResumeLayout(False)
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private dataSet1 As System.Data.DataSet

        Private dataTable1 As System.Data.DataTable

        Private dataColumn1 As System.Data.DataColumn

        Private dataColumn2 As System.Data.DataColumn

        Private colColumn1 As DevExpress.XtraGrid.Columns.GridColumn

        Private colColumn2 As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemPopupContainerEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit

        Private popupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl

        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
    End Class
End Namespace
