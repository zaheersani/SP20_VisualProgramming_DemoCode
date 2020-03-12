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
using System.Windows.Shapes;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for WPFCommonControls.xaml
    /// </summary>
    public partial class WPFCommonControls : Window
    {
        public WPFCommonControls()
        {
            InitializeComponent();
            ItemCollection collection = this.comboBox.Items;
            collection = this.listBox.Items;
            collection = this.listView.Items;
            //foreach (var item in collection)
            //{
            //    if(item is ListBoxItem)
            //        MessageBox.Show(((ListBoxItem)item).Content.ToString());
            //}
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(this.comboBox.SelectedValue.ToString());
        }

        private void DatePicker_CalendarClosed(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this.datePicker.SelectedDate.Value.ToString("dddd dd MMMM"));
        }
    }
}
