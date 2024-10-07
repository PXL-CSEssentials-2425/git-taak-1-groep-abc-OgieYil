using System.Windows;
using System.Windows.Media;

namespace Git_taak1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Green_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Green);
        
        }

        private void Red_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Red);
          

        }

        private void Yellow_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Yellow);

           

        }

        private void Blue_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Blue);

           
        }

        private void Image_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {

            this.Background = new SolidColorBrush(Colors.LightGray);
            //brengt de 2 Texte terug tot beginstand.
           
        }


     

    }
}