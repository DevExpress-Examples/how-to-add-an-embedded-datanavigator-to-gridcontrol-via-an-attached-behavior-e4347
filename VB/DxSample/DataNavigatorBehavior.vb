Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Interactivity
Imports DevExpress.Xpf.Grid
Imports System.Windows
Imports DevExpress.Xpf.Core.Commands

Namespace DxSample
	Friend Class DataNavigatorBehavior
		Inherits Behavior(Of TableView)
		Public Shared ReadOnly AddNewRowCommandProperty As DependencyProperty = DependencyProperty.RegisterAttached("AddNewRowCommand", GetType(DelegateCommand(Of Object)), GetType(DataNavigatorBehavior), Nothing)

		Public Shared Function GetAddNewRowCommand(ByVal target As TableView) As DelegateCommand(Of Object)
			Return CType(target.GetValue(AddNewRowCommandProperty), DelegateCommand(Of Object))
		End Function

		Public Shared Sub SetAddNewRowCommand(ByVal target As TableView, ByVal value As DelegateCommand(Of Object))
			target.SetValue(AddNewRowCommandProperty, value)
		End Sub

		Protected Overrides Sub OnAttached()
			MyBase.OnAttached()
			Dim view As TableView = TryCast(Me.AssociatedObject, TableView)
			view.Resources.MergedDictionaries.Add(New ResourceDictionary() With {.Source = New Uri("Dictionary.xaml", UriKind.Relative)})
			view.SetValue(DataNavigatorBehavior.AddNewRowCommandProperty, New DelegateCommand(Of Object)(AddressOf AddNewRow))
		End Sub

		Private Sub AddNewRow(ByVal arg As Object)
			TryCast(Me.AssociatedObject, TableView).AddNewRow()
		End Sub
	End Class
End Namespace
