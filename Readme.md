<!-- default file list -->
*Files to look at*:

* [DataHelper.cs](./CS/DxSample/DataHelper.cs) (VB: [DataHelper.vb](./VB/DxSample/DataHelper.vb))
* [DataNavigatorBehavior.cs](./CS/DxSample/DataNavigatorBehavior.cs) (VB: [DataNavigatorBehavior.vb](./VB/DxSample/DataNavigatorBehavior.vb))
* [Dictionary.xaml](./CS/DxSample/Dictionary.xaml) (VB: [Dictionary.xaml](./VB/DxSample/Dictionary.xaml))
* [MainWindow.xaml](./CS/DxSample/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/DxSample/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/DxSample/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DxSample/MainWindow.xaml.vb))
* [MultiConverter.cs](./CS/DxSample/MultiConverter.cs) (VB: [MultiConverter.vb](./VB/DxSample/MultiConverter.vb))
<!-- default file list end -->
# How to add an embedded DataNavigator to GridControl via an attached behavior


<p>This example demonstrates how to implement WinForms DataNavigator in WPF via Behavior. For this, it's necessary to re-define the x:Key="{dxgt:TableViewThemeKey ResourceKey=ScrollViewerTemplate}" control template and create the DataNavigator behavior that loads a re-defined template at the moment of attaching.</p>
<p>If you are using themes, you need to re-define a control template for your theme and add it's name to the key - x:Key="{dxgt:TableViewThemeKey ResourceKey=ScrollViewerTemplate, ThemeName=DXStyle}"<br /><br /><strong>Update</strong><br />Starting with v15.1, GridControl provides the embedded DataNavigator out of the box. To learn more about this feature, refer to the <a href="https://documentation.devexpress.com/WPF/CustomDocument114118.aspx">Data Navigator</a> topic in our documentation.</p>

<br/>


