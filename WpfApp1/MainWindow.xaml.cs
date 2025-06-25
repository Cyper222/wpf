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

namespace WpfApp1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        // Button myButton = new Button();
        // myButton.Width = 70;
        // myButton.Height = 300;
        // myButton.Content = "Кнопка";
        // myButton.Foreground = Brushes.Black;
        // myButton.Background = Brushes.Red;
        // myButton.HorizontalAlignment = HorizontalAlignment.Left;
        // myButton.Cursor = Cursors.Hand;
        //
        // grid1.Children.Add(myButton);
        // myButton.Click += Button_Click;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Hello World!");
    }
    
}