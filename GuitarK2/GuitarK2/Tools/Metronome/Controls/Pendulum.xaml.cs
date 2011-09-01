using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for Pendulum.xaml
    /// </summary>
    public partial class Pendulum : UserControl, INotifyPropertyChanged
    {
        private int tempo;

        public Pendulum()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public int Tempo
        {
            get
            {
                return (int)this.PendulumSlider.Value;
            }
            set
            {
                this.PendulumSlider.Value = value;
            }
        }

        public void SetAngle(double angle)
        {
            this.PendulumRotatateTransofrm.Angle = angle;
        }

        private void PendulumSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs("Tempo"));
            }
        }
    }
}
