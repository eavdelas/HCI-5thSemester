﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FinalExamination
{
    /// <summary>
    /// Interaction logic for TvControls.xaml
    /// </summary>
    public partial class TvControls : Window
    {
        public TvControls()
        {
            InitializeComponent();
        }

        private void TvControlsWindow_Deactivated(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
