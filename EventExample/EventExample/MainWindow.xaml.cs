using System.Windows;
using System.Windows.Controls;

namespace EventExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            btnSayHello.Click += GenericButton_OnClick;
            btnCopyOfSayHello.Click += GenericButton_OnClick;
            btnCopyOfACopyOfSayHello.Click += GenericButton_OnClick;
        }

        private void GenericButton_OnClick(object sender, RoutedEventArgs e)
        {
            var message = string.Empty;

            // Cast the Button Type to the sender object
            var btn = (Button)sender;

            switch(btn.Name)
            {
                case "btnSayHello":
                    message = "Hello World";
                    break;
                case "btnCopyOfSayHello":
                    message = "Copy of btnSayHello says: Hello World";
                    break;
                case "btnCopyOfACopyOfSayHello":
                    message = "Copy of A Copay of btnSayHello says: Hello World";
                    break;
            }

            MessageBox.Show(message);
        }
    }
}
