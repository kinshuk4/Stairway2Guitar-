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
    /// Interaction logic for VolumeControl.xaml
    /// </summary>
    public partial class VolumeControl : UserControl
    {
        public VolumeControl()
        {
            InitializeComponent();
            ToolTipService.SetToolTip(this.VolumeSlider, string.Format("Volume: {0}%", this.VolumeSlider.Value * 100));
        }

        public event RoutedPropertyChangedEventHandler<double> ValueChanged;

        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (VolumeSliderReflection != null)
            {
                this.VolumeSliderReflection.Value = e.NewValue;
            }

            if (VolumeSlider != null)
            {
                ToolTipService.SetToolTip(this.VolumeSlider, string.Format("Volume: {0}%", Math.Ceiling(e.NewValue * 100)));
            }

            if (this.ValueChanged != null)
            {
                this.ValueChanged(this, new RoutedPropertyChangedEventArgs<double>(e.OldValue, e.NewValue));
            }
        }

        private void VolumeSlider_MouseEnter(object sender, MouseEventArgs e)
        {
            this.VolumeSlider.Cursor = Cursors.Hand;
            VisualStateManager.GoToState(this.VolumeSliderReflection, "MouseOver", false);
        }

        private void VolumeSlider_MouseLeave(object sender, MouseEventArgs e)
        {
            this.VolumeSlider.Cursor = Cursors.Arrow;
            VisualStateManager.GoToState(this.VolumeSliderReflection, "Normal", false);
        }
    }
}