﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Util.Controls.WPFTest
{
    /// <summary>
    /// Page_ListBox.xaml 的交互逻辑
    /// </summary>
    public partial class Page_ListBox : Page
    {
        public Page_ListBox()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.mcom.UnselectAll();
        }
    }
}
