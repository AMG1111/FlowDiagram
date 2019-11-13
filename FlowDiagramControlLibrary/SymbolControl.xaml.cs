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

namespace FlowDiagramControlLibrary
{
    
    /// <summary>
    /// Interaction logic for SymbolControl.xaml
    /// </summary>
    public partial class SymbolControl : UserControl
    {
        private string currentSymbol;
        public SymbolControl()
        {
            InitializeComponent();
        }

        public string CurrentSymbol { get => currentSymbol; set => currentSymbol = value; }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentSymbol = ((ComboBoxItem)cboSymbol.SelectedValue).Content.ToString();
        }
    }
}
