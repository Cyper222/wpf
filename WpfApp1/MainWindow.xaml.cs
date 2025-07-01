using System.Media;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    private string currentImput = "";
    public MainWindow()
    {
        InitializeComponent();
        

    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        var button = sender as Button;
        string value = button.Content.ToString();
        currentImput += value;
        outputText.Text = currentImput;
        SoundPlayer sound = new SoundPlayer("Sound/click.wav");
        sound.Play();
    }

    private void ButtonDelete(object sender, RoutedEventArgs e)
    {
        currentImput = "";
        outputText.Text = "0";
        SoundPlayer sound = new SoundPlayer("Sound/click.wav");
        sound.Play();
    }
    
    private void ButtonDeleteLast(object sender, RoutedEventArgs e)
    {
        if (!string.IsNullOrEmpty(currentImput))
        {
            currentImput = currentImput.Substring(0, currentImput.Length - 1);
            outputText.Text = string.IsNullOrEmpty(currentImput) ? "0" : currentImput;
        }
        SoundPlayer sound = new SoundPlayer("Sound/click.wav");
        sound.Play();
    }

    private void Equals_Clik(object sender, RoutedEventArgs e)
    {
        try
        {
            var result = new System.Data.DataTable().Compute(currentImput, null);
            outputText.Text = result.ToString();
        }
        catch
        {
            outputText.Text = "Error";
            currentImput = "0";

        }
        SoundPlayer sound = new SoundPlayer("Sound/click.wav");
        sound.Play();
    }
}
   

