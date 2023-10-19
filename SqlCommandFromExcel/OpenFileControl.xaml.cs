using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.Windows;

namespace SqlCommandFromExcel
{
    /// <summary>
    /// Interaction logic for OpenFileControl.xaml
    /// </summary>
    public partial class OpenFileControl : UserControl
    {
        public OpenFileControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx|CSV Files|*.csv|All FIles|*.*";
            bool? result = openFileDialog.ShowDialog();
            if(result == true)
            {
                string filePath = openFileDialog.FileName;
                filePathTextBox.Text = filePath;
            }
        }
    }
}
