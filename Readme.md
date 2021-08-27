<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128637946/16.1.11%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T590828)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Customer.cs](./CS/Example/Customer.cs) (VB: [Customer.vb](./VB/Example/Customer.vb))
* [Main.cs](./CS/Example/Main.cs) (VB: [Main.vb](./VB/Example/Main.vb))
* [Program.cs](./CS/Example/Program.cs) (VB: [Program.vb](./VB/Example/Program.vb))
* [TreeListCheckHelper.cs](./CS/Example/TreeListCheckHelper.cs) (VB: [TreeListCheckHelper.vb](./VB/Example/TreeListCheckHelper.vb))
<!-- default file list end -->
# How to modify the default checking nodes behavior in the TreeList control


<p>This example demonstrates how to modify the default checking nodes behavior in the <strong>TreeList</strong> control. The main idea is to handle the <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeList.BeforeCheckNode.event">TreeList.BeforeCheckNode</a> event, which occurs before a node's check state is changed.<br><br>The <strong>TreeListCheckHelper</strong> class allows the following scenarios

* If a parent node has changed its check state, each child node will have the same state; 
* If at least one child node is checked, the parent node will be also checked.  <br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-modify-the-default-checking-nodes-behavior-in-the-treelist-control-t590828/16.1.11+/media/44d609b9-3ba7-4696-866e-359f52232a5c.png"></p>

<br/>


