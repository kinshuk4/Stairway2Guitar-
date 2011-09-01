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
using System.Windows.Shapes;
using SilverlightMetronome.Constants;

namespace GuitarK2.Tools.Metronome
{
    /// <summary>
    /// Interaction logic for MetronomeWindow.xaml
    /// </summary>
    public partial class MetronomeWindow : Window
    {
        public MetronomeWindow()
        {
            InitializeComponent();
            this.SetTempoLabels(this.MyMetronome.MetronomeTempo);
        }
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            this.MyMetronome.StartMetronome();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            this.MyMetronome.StopMetronome();
        }

        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.MyMetronome.SetMetronomeVolume(e.NewValue);
        }

        private void MyMetronome_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Tempo")
            {
                this.SetTempoLabels(this.MyMetronome.MetronomeTempo);
            }
        }

        private void SetTempoLabels(int tempo)
        {
            this.BeatsPerMinuteLabel.Text = tempo.ToString();

            if (tempo < BeatsPerMinute.Larghetto)
            {
                this.TempoNameLabel.Text = TempoNames.Largo;
            }
            else if (tempo >= BeatsPerMinute.Larghetto && tempo < BeatsPerMinute.Adaggio)
            {
                this.TempoNameLabel.Text = TempoNames.Larghetto;
            }
            else if (tempo >= BeatsPerMinute.Adaggio && tempo < BeatsPerMinute.Andante)
            {
                this.TempoNameLabel.Text = TempoNames.Adaggio;
            }
            else if (tempo >= BeatsPerMinute.Andante && tempo < BeatsPerMinute.Moderate)
            {
                this.TempoNameLabel.Text = TempoNames.Andante;
            }
            else if (tempo >= BeatsPerMinute.Moderate && tempo < BeatsPerMinute.Alegro)
            {
                this.TempoNameLabel.Text = TempoNames.Moderate;
            }
            else if (tempo >= BeatsPerMinute.Alegro && tempo < BeatsPerMinute.Presto)
            {
                this.TempoNameLabel.Text = TempoNames.Alegro;
            }
            else if (tempo >= BeatsPerMinute.Presto && tempo < BeatsPerMinute.Prestissimo)
            {
                this.TempoNameLabel.Text = TempoNames.Presto;
            }
            else if (tempo >= BeatsPerMinute.Prestissimo)
            {
                this.TempoNameLabel.Text = TempoNames.Prestissimo;
            }
        }

        private void PlayButton_ButtonClicked(object sender, EventArgs e)
        {
            this.StopButton.Visibility = Visibility.Visible;
            this.PlayButton.Visibility = Visibility.Collapsed;
            this.MyMetronome.StartMetronome();
        }

        private void StopButton_ButtonClicked(object sender, EventArgs e)
        {
            this.PlayButton.Visibility = Visibility.Visible;
            this.StopButton.Visibility = Visibility.Collapsed;
            this.MyMetronome.StopMetronome();
        }

        //private void MyMetronome_MetronomeReady( object sender, EventArgs e )
        //{
        //    this.MyMetronome.Visibility = Visibility.Visible;
        //}

        private void VolumeControl_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.MyMetronome.SetMetronomeVolume(e.NewValue);
        }

        private void MyMetronome_MetronomeFailed(object sender, EventArgs e)
        {
            this.ErrorMessage.Visibility = Visibility.Visible;
            this.ErrorMessage.Text = "Sound file failed loading!";
        }

        private void btnIncreaseTempo_Click(object sender, RoutedEventArgs e)
        {
            this.MyMetronome.MetronomeTempo =int.Parse( txbxTempo.Text);
        }
    }
}
