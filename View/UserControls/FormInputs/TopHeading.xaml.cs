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
    /// Interaction logic for TopHeading.xaml
    /// </summary>
    public partial class TopHeading 
    {
        public static readonly DependencyProperty TopHeadingText = DependencyProperty.Register("TopHeadingTxt", typeof(string), typeof(TopHeading), new PropertyMetadata(string.Empty));

        public string TopHeadingTxt
        {
            get {  return (string)GetValue(TopHeadingText);}
            set { SetValue(TopHeadingText, value); }
       }



        public TopHeading()
        {
            InitializeComponent();
        }
    }
}
