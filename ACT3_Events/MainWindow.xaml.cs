using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace ACT3_Events
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] Numbers = new int[3];
        DispatcherTimer timer = new DispatcherTimer();
        Math math = new Math();
        string type = null;
        public MainWindow()
        {
            InitializeComponent();
            //TextCompositionEventHandler PreviewTextInput;
            A.PreviewTextInput += new TextCompositionEventHandler(VTI);
            B.PreviewTextInput += new TextCompositionEventHandler(VTI);
            C.PreviewTextInput += new TextCompositionEventHandler(VTI);

            calc.MouseEnter += new MouseEventHandler(srvVBtn);
            calc.MouseLeave += new MouseEventHandler(stopSrvVBtn);


        }

        private void Calculer(object sender, MouseButtonEventArgs e)
        {
             math.trimone(int.Parse(A.Text), int.Parse(B.Text), int.Parse(C.Text), out type);
             PageResultat secondpage = new PageResultat();
             secondpage.txtResultat.Text = type;
             Visibility = Visibility.Hidden;
        }

        private void VTI(object sender, TextCompositionEventArgs e)
        {
            if (e.Text != "," && !EstEntier(e.Text))
            {
                e.Handled = true;
            }
            if (((TextBox)sender).Text.IndexOf(e.Text) > -1)
            {
                e.Handled = true;
            }
            else
            {


            }
        }

        private bool EstEntier(string userText)
        {
            return int.TryParse(userText, out _);
        }

        private void srvVBtn(object sender, EventArgs e)
        {
            virtualBtn.Visibility = Visibility.Visible;
            virtualBtn.Background = Brushes.Red;
        }

        private void stopSrvVBtn(object sender, EventArgs e)
        {
            virtualBtn.Visibility = Visibility.Hidden;
        }

    }
}
