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
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public static AddWindow instance;
        public AddWindow()
        {
            InitializeComponent();
            instance = this;
        }

        public void CancelButtonIsClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        public void AddButtonClicked(object sender, RoutedEventArgs e)
        {
            try
            {
                string newItemName = AddWindow_ProductBox.Text;
                foreach (var item in MainWindow.itemsList)
                {
                    if (item.Name == newItemName)
                    {
                        HandleError();
                        return;
                    }
                }
                Item newItem = new Item(AddWindow_ProductBox.Text, int.Parse(AddWindow_QuantityBox.Text), double.Parse(AddWindow_PriceBox.Text));
                MainWindow.itemsList.Add(newItem);

            }
            catch
            {
                HandleError();
            }

            AddWindow_ProductBox.Text = "";
            AddWindow_QuantityBox.Text = "";
            AddWindow_PriceBox.Text = "";
        }
        private void HandleError()
        {
            MessageBox.Show("Item credentials are incorrect or the item alredy exists.");
        }

    }
}
