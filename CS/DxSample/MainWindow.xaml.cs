using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace DxSample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            gridControl1.ItemsSource = DataHelper.GetData();
        }
    }
}
