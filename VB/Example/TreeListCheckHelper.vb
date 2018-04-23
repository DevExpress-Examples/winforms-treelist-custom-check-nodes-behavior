Imports Microsoft.VisualBasic
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports System
Imports System.Linq
Imports System.Windows.Forms

Namespace Example
	Friend Class TreeListCheckHelper
		Public Sub New(ByVal treeList As TreeList)
			treeList.OptionsSelection.MultiSelect = True
			treeList.OptionsView.ShowCheckBoxes = True
			treeList.OptionsBehavior.AllowIndeterminateCheckState = False
			AddHandler treeList.BeforeCheckNode, AddressOf treeList1_BeforeCheckNode
		End Sub

		Private Function AnyChildIsChecked(ByVal node As TreeListNode) As Boolean
			For Each childNode As TreeListNode In node.Nodes
				If childNode.CheckState = CheckState.Checked Then
					Return True
				End If
			Next childNode
			Return False
		End Function
		Private Sub treeList1_BeforeCheckNode(ByVal sender As Object, ByVal e As CheckNodeEventArgs)
			Dim node As TreeListNode = e.Node
			If node.Checked Then
				node.UncheckAll()
			Else
				node.CheckAll()
			End If
			Do While node.ParentNode IsNot Nothing
				node = node.ParentNode
				node.CheckState = If(AnyChildIsChecked(node), CheckState.Checked, CheckState.Unchecked)
			Loop
		End Sub
	End Class
End Namespace