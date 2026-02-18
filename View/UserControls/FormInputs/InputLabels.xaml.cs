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

namespace DevX.View.UserControls.FormInputs
{
    /// <summary>
    /// Interaction logic for InputLabels.xaml
    /// </summary>
    public partial class InputLabels 
    {
        public static readonly DependencyProperty MLabelTextProperty =
        DependencyProperty.Register("MLabelText", typeof(string), typeof(InputLabels), new PropertyMetadata(string.Empty));
        public string MLabelText
        {
            get { return (string)GetValue(MLabelTextProperty); }
            set { SetValue(MLabelTextProperty, value); }
        }
        public InputLabels()
        {
            InitializeComponent();
        }
    }
}
