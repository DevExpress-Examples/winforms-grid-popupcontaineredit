<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128632334/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1082)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication7/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication7/Form1.vb))
* [Program.cs](./CS/WindowsFormsApplication7/Program.cs) (VB: [Program.vb](./VB/WindowsFormsApplication7/Program.vb))
<!-- default file list end -->
# How to use the PopupContainerEdit editor in XtraGrid


<p>This is a very basic sample to illustrate how to edit grid cells using the <a href="https://docs.devexpress.com/WindowsForms/612/controls-and-libraries/editors-and-simple-controls/popup-container-editor">PopupContainerEdit editor</a>. First, it's necessary to assign the PopupContainerControl to the PopupControl property and place the editors you need within the PopupContainerControl. Further, it's necessary to handle the QueryPopUp event to fill the editor in the dropdown with a cell value and the QueryResultValue event to post the modified value back to the grid cell.</p>

<br/>


