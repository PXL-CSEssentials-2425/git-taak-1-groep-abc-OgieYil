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
            ColorInfoText.Text = "Groen is de kleur van genezing";
            ColorCodeText.Text = "#008000";  // Groen hex-code
        }

        private void Red_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Red);
            ColorInfoText.Text = " Rood is de kleur van warmte";
            ColorCodeText.Text = "#FF0000";  // Geel hex-code


        }

        private void Yellow_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Yellow);

            ColorInfoText.Text = "Geel is de kleur van levenslust";
            ColorCodeText.Text = "#FFFF00";  // Geel hex-code


        }

        private void Blue_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Blue);

            ColorInfoText.Text = "Blauw is de kleur van intelligentie";
            ColorCodeText.Text = "#0000FF";  // Blauw hex-code

        }

        private void Image_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {

            this.Background = new SolidColorBrush(Colors.LightGray);
            //brengt de 2 Texte terug tot beginstand.
            ColorInfoText.Text = "Klik op een kleur voor meer informatie.";
            ColorCodeText.Text = "Klik op een kleur voor meer informatie.";  
        }


     

    }
}