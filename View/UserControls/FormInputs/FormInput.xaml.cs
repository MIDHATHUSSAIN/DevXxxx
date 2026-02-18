using DevX.ViewModel;
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
    /// Interaction logic for FormInput.xaml
    /// </summary>
    public partial class FormInput 
    {
        public static readonly DependencyProperty LabelTextProperty =
        DependencyProperty.Register("LabelText", typeof(string), typeof(FormInput), new PropertyMetadata(string.Empty));
        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }
        public FormInput()
        {
            InitializeComponent();
            
        }
    }
}
