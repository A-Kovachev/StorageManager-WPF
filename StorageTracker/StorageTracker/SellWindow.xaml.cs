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

namespace StorageTracker
{
    /// <summary>
    /// Interaction logic for SellWindow.xaml
    /// </summary>
    public partial class SellWindow : Window
    {
        public static SellWindow Instance;
        public SellWindow()
        {
            InitializeComponent();
            Instance = this;
        }

        public void CancelButtonClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public void EnterButtonClicked(object sender, RoutedEventArgs e)
        {
            int decreasQuantity = 0;
            try
            {
                decreasQuantity = (int.Parse(SellWindow_TextBoxQuantity.Text));

                if (decreasQuantity > 0)
                {
                    foreach (var item in MainWindow.itemsList)
                    {
                        if (item.IsChecked)
                        {
                            item.Quantity -= decreasQuantity;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "");
            }

            this.Close();
        }
    }
}
