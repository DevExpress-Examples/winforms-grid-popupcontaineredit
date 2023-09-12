<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128632334/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1082)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Data Grid - How to use the Popup Container Editor

This example demonstrates how to:

* Create and customize a [Popup Container editor](https://docs.devexpress.com/WindowsForms/612/controls-and-libraries/editors-and-simple-controls/popup-container-editor).
* Assign the popup container editor to a grid column to display and edit cell values.
* Handle the [QueryPopUp](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemPopupBase.QueryPopUp) event to pass the cell value to the editor in the dropdown.
  ```csharp
  private void repositoryItemPopupContainerEdit1_QueryPopUp(object sender, CancelEventArgs e) {
      memoEdit1.EditValue = (sender as PopupContainerEdit).EditValue;
  }
  ```
* Handle the [QueryResultValue](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit.QueryResultValue) event to post the modified value back to the grid cell.
  ```csharp
  private void repositoryItemPopupContainerEdit1_QueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e) {
      e.Value = memoEdit1.EditValue;
  }
  ```


## Files to Review

* [Form1.cs](./CS/WindowsFormsApplication7/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication7/Form1.vb))


## Documentation

* [WinForms Popup Container Editor](https://docs.devexpress.com/WindowsForms/612/controls-and-libraries/editors-and-simple-controls/popup-container-editor)
