using System;
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

namespace GuitarK2.Tools.Metronome.Controls
{
    /// <summary>
    /// Interaction logic for ReflectionTextControl.xaml
    /// </summary>
    public partial class ReflectionTextControl : UserControl
    {
        public ReflectionTextControl()
        {
            InitializeComponent();
        }

        public string Text
        {
            get
            {
                return this.NormalText.Text;
            }

            set
            {
                this.NormalText.Text = value;
                this.ReflectedText.Text = value;
            }
        }
    }
}
