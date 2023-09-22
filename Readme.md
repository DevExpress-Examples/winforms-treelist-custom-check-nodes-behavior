<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128637946/16.1.11%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T590828)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms TreeList - Implement custom behavior to check nodes

This example handles the [TreeList.BeforeCheckNode](https://documentation.devexpress.com/WindowsForms/DevExpress.XtraTreeList.TreeList.BeforeCheckNode.event) event to do the following:

* Set the same check state for all child nodes if the parent node's check state changes. 
* Check the parent node if at least one child node is checked.

![WinForms TreeList - Implement custom behavior to check nodes](https://raw.githubusercontent.com/DevExpress-Examples/how-to-modify-the-default-checking-nodes-behavior-in-the-treelist-control-t590828/16.1.11+/media/44d609b9-3ba7-4696-866e-359f52232a5c.png)

```csharp
private void treeList1_BeforeCheckNode(object sender, CheckNodeEventArgs e) {
    TreeListNode node = e.Node;
    if(node.Checked)
        node.UncheckAll();
    else node.CheckAll();
    while(node.ParentNode != null) {
        node = node.ParentNode;
        node.CheckState = AnyChildIsChecked(node) ? CheckState.Checked : CheckState.Unchecked;
    }
}
```


## Files to Review

* [Main.cs](./CS/Example/Main.cs) (VB: [Main.vb](./VB/Example/Main.vb))
* [TreeListCheckHelper.cs](./CS/Example/TreeListCheckHelper.cs) (VB: [TreeListCheckHelper.vb](./VB/Example/TreeListCheckHelper.vb))
