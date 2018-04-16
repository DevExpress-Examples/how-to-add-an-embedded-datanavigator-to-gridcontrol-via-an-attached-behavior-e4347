Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Data
Imports DevExpress.Xpf.Grid

Namespace DxSample
	Friend Class MultiConverter
		Implements IMultiValueConverter
		Public Function Convert(ByVal values() As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IMultiValueConverter.Convert
			Dim grid As GridControl = TryCast(values(0), GridControl)
			Dim rowHandle As Integer = CInt(Fix(values(1)))

			If rowHandle = GridControl.InvalidRowHandle Then
				Return "0 of 0"
			End If

			Dim all As Integer = grid.DataController.VisibleListSourceRowCount
			Dim rowVisibleIndex As Integer = grid.GetRowHandleByListIndex(grid.GetListIndexByRowHandle(rowHandle))

			Return String.Format("{0} of {1}", rowVisibleIndex+1, all)
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetTypes() As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object() Implements IMultiValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function
	End Class
End Namespace
