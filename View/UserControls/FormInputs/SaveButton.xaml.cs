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
 
    public partial class SaveButton 
    {
        public static readonly DependencyProperty CommandProperty =
       DependencyProperty.Register("MCommand", typeof(ICommand), typeof(SaveButton), new PropertyMetadata(null));

        public ICommand MCommand
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public static readonly DependencyProperty ButtonContentProperty =
        DependencyProperty.Register("ButtonContent", typeof(string), typeof(SaveButton), new PropertyMetadata(string.Empty));
        public string ButtonContent
        {
            get { return (string)GetValue(ButtonContentProperty); }
            set { SetValue(ButtonContentProperty, value); }
        }
        public SaveButton()
        {
            InitializeComponent();
        }
    }
}
