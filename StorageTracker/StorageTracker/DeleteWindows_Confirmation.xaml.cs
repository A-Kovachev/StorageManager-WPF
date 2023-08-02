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
    /// Interaction logic for DeleteWindows_Confirmation.xaml
    /// </summary>
    public partial class DeleteWindows_Confirmation : Window
    {
        public static DeleteWindows_Confirmation Instance;
        public DeleteWindows_Confirmation()
        {
            InitializeComponent();
            Instance = this;
        }

        public void NoButtonClicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void DelWindow_YesButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = MainWindow.itemsList.Count - 1; i >= 0; i--)
            {
                if(MainWindow.itemsList[i].IsChecked)
                {
                    MainWindow.itemsList.RemoveAt(i);
                }
            }
            this.Close();
        }
    }
}
