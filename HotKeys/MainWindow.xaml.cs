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

namespace HotKeys
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BindHotKey(Key.R, Brushes.Red, button);
            BindHotKey(Key.G, Brushes.Green, button);
            BindHotKey(Key.B, Brushes.Blue, button);
        }

        private void BindHotKey(Key key, Brush brush, Control element, ModifierKeys modifier = ModifierKeys.Control)
        {
            RoutedCommand command = new RoutedCommand();
            command.InputGestures.Add(new KeyGesture(key, modifier));
            CommandBindings.Add(new CommandBinding(
                command, (s, e) => element.Background = brush));
        }
    }
}