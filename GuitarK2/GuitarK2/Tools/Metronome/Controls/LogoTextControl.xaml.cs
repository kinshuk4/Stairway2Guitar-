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
using System;
using System.Windows;

using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
namespace GuitarK2.Tools.Metronome.Controls
{
    /// <summary>
    /// Interaction logic for LogoTextControl.xaml
    /// </summary>
    public partial class LogoTextControl : UserControl
    {
        public LogoTextControl()
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
                this.BorderText.Text = value;
            }
        }

        private void NormalText_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.NormalText.Foreground = new System.Windows.Media.SolidColorBrush((Color)((App)Application.Current).Resources["PaperColor"]);
            this.NormalText.Cursor = Cursors.Hand;
        }

        private void NormalText_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.NormalText.Foreground = new SolidColorBrush(Color.FromArgb(255, 136, 136, 136));
            this.NormalText.Cursor = Cursors.Arrow;
        }

        private void NormalText_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
          
        }
    }
}
