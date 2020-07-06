<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication7/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication7/Form1.vb))
* [Program.cs](./CS/WindowsFormsApplication7/Program.cs) (VB: [Program.vb](./VB/WindowsFormsApplication7/Program.vb))
<!-- default file list end -->
# How to use the PopupContainerEdit editor in XtraGrid


<p>This is a very basic sample to illustrate how to edit grid cells using the <a href="https://docs.devexpress.com/WindowsForms/612/controls-and-libraries/editors-and-simple-controls/popup-container-editor">PopupContainerEdit editor</a>. First, it's necessary to assign the PopupContainerControl to the PopupControl property and place the editors you need within the PopupContainerControl. Further, it's necessary to handle the QueryPopUp event to fill the editor in the dropdown with a cell value and the QueryResultValue event to post the modified value back to the grid cell.</p>

<br/>


