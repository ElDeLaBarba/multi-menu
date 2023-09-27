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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Multi_Menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Button playButton;
        public Button cancelButton;
        public ListBox versionSelector;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void PlayButton_Initialized(object sender, EventArgs e)
        {
            playButton = (Button)sender;
        }

        private void CancelButton_Initialized(object sender, EventArgs e)
        {
            cancelButton = (Button)sender;
        }

        private void ListBox_Initialized(object sender, EventArgs e)
        {
            versionSelector = (ListBox)sender;
        }
    }
}
