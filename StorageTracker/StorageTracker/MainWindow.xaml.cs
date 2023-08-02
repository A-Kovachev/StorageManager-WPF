using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.IO;

namespace StorageTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ObservableCollection<Item> itemsList { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            itemsList = new ObservableCollection<Item>();  
            UploadItemsDataFromTxtFileToList();
            dataGrid.ItemsSource = itemsList;
        }

        public void OpenAddWindow(object sender, RoutedEventArgs e)
        {
                var addWindow = Window.GetWindow(new AddWindow());
                addWindow.Closing += (s, ex) => addButton.IsEnabled = true;
                addWindow.Show();
                addButton.IsEnabled = false;
        }
        public void DeleteCheckedRows(object sender, RoutedEventArgs e)
        {
                var delwindow = Window.GetWindow(new DeleteWindows_Confirmation());
                delwindow.Closing += (s, ex) => delButton.IsEnabled = true;
                delwindow.Show();
                delButton.IsEnabled = false;
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            // Checkbox is checked
            CheckBox checkBoc = (CheckBox)sender;
            Item item = (Item)checkBoc.DataContext;

            item.IsChecked = true;
        }
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            // Checkbox is unchecked
            CheckBox checkBoc = (CheckBox)sender;
            Item item = (Item)checkBoc.DataContext;

            item.IsChecked = false;
        }
        public void OpenSellWindow(object sender, RoutedEventArgs e)
        {
            SellWindow sellWindow = new SellWindow();
            sellWindow.Show();
        }
        public void SelectAllItems(object sender, RoutedEventArgs e)
        {
            foreach(var item in itemsList)
            {
                item.IsChecked = true;
            }
        }
        public void DeselectAllItems(object sender, RoutedEventArgs e)
        {
            foreach (var item in itemsList)
            {
                item.IsChecked = false;
            }
        }
        public void UploadItemsDataFromTxtFileToList()
        {
            string[] linesInFile = File.ReadAllLines(@"C:\Users\DESKTOP\Desktop\OZI\StorageTracker\StorageTracker\ItemsDataSaveFile.txt");
            if(linesInFile.Length > 0)
            {
                for (int i = 0; i < linesInFile.Length; i++)
                {
                    string[] itemsProperties = linesInFile[0].Split("\t");
                    string name = itemsProperties[0];
                    int quantity = int.Parse(itemsProperties[1]);
                    double price = double.Parse(itemsProperties[2]);

                    itemsList.Add(new Item(name, quantity, price));
                }   
            }
        }
        public void SaveDataGridItemsToTextFile()
        {
            string filePath = @"C:\Users\DESKTOP\Desktop\OZI\StorageTracker\StorageTracker\ItemsDataSaveFile.txt";
            File.WriteAllText(filePath, string.Empty);

            StringBuilder sb = new StringBuilder();
            foreach(var item in itemsList)
            {
                string name = item.Name;
                string quantity = item.Quantity.ToString();
                string price = item.PricePerUnit.ToString();

                sb.Append(name);
                sb.Append('\t');
                sb.Append(quantity);
                sb.Append('\t');
                sb.Append(price);
                sb.AppendLine();
            }
            File.WriteAllText(filePath, sb.ToString());
        }
        private void Window_Closing(object sender, CancelEventArgs e)
        {
            SaveDataGridItemsToTextFile();
        }
        private void searchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchTerm = searchBox.Text;

            if (!string.IsNullOrEmpty(searchTerm))
            {
                List<Item> filteredData = new List<Item>();
                foreach (var item in itemsList)
                {
                    if (item.Name.Contains(searchTerm))
                    {
                        filteredData.Add(item);
                    }
                }
                dataGrid.ItemsSource = filteredData;
            }
            else
            {
                dataGrid.ItemsSource = itemsList;
            }
        }
    }
}
