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
using GuitarK2.Dao;
using GuitarK2.PractiseList;
using GuitarK2.Tools.Metronome.Controls;
using GuitarK2.Tools.MidiBand;
using MetronomeWindow = GuitarK2.Tools.Metronome.MetronomeWindow;

namespace GuitarK2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AllPractiseList practiseList;
        public MainWindow()
        {
            InitializeComponent();
            practiseList = new AllPractiseList();
            practiseList.AllScalePracTypes.Add("All");
            cbScalePractise.ItemsSource = practiseList.AllScalePracTypes;
            
            
            
            
            
        }

        private void cbScalePractise_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String selectedItem = cbScalePractise.SelectedValue.ToString();
            if (selectedItem != null)
            {
                if (selectedItem != "All")
                {
                    
                    if (gridScale.Children.Contains(lbGeneralScalePractise))
                        lbGeneralScalePractise.ItemsSource = practiseList.ScalePractiseListPerType[selectedItem];
                    else
                    {
                        StackPanel panel = new StackPanel();
                        gridScale.Children.RemoveRange(1,practiseList.AllScalePracTypes.Count*2);
                        gridScale.Children.Add(lbGeneralScalePractise);
                        lbGeneralScalePractise.ItemsSource = practiseList.ScalePractiseListPerType[selectedItem];
                    }
                }
                else
                {
                    //lbGeneralScalePractise.Visibility = Visibility.Hidden;
                    gridScale.Children.Remove(lbGeneralScalePractise);
                    List<TextBox> pracTypeTbList = new List<TextBox>();
                    List<ListBox> listBoxList = new List<ListBox>();
                    foreach (var scalePracType in practiseList.ScalePractiseListPerType.Keys)
                    {
                        TextBox tb = new TextBox();
                        tb.Text = scalePracType;
                        pracTypeTbList.Add(tb);

                        ListBox _lb = new ListBox();
                        _lb.ItemsSource = practiseList.ScalePractiseListPerType[scalePracType];
                        listBoxList.Add(_lb);
                    }

                    for (int i = 0; i < pracTypeTbList.Count; i++)
                    {
                        gridScale.Children.Add(pracTypeTbList[i]);
                        gridScale.Children.Add(listBoxList[i]);
                    }

                }
            }

        }
        /*to avoid right select on list box */
        private void lbGeneralScalePractise_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseRightButtonDown(e);
        }

        private void btnMidiBand_Click(object sender, RoutedEventArgs e)
        {
            MidiBandWindow midiBand = new MidiBandWindow();
            midiBand.Show();
        }

        private void btnMedia_Click(object sender, RoutedEventArgs e)
        {
            MetronomeWindow win = new MetronomeWindow();
            win.Show();
        }

        private void btnPendulum_Click(object sender, RoutedEventArgs e)
        {
          
          
        }

        

    }
}
