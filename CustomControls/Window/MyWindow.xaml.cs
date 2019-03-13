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
using System.Windows.Markup;

namespace MyCustomControls
{
    [ContentProperty("_Content")]
    public partial class MyWindow : UserControl
    {
        public MyWindow()
        {
            InitializeComponent();
        }

        public string _Header
        {
            get { return this.txtHeader.Text; }
            set { this.txtHeader.Text = value; }
        }

       

        protected override void OnContentChanged(object oldContent, object newContent)
        {
            if (oldContent != null)
                throw new NotSupportedException("You can not. Input content again..");
        }
    }
    
}
