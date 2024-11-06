namespace cataas
{
    public class Image
    {

    }

    public partial class MainPage : ContentPage
    {
        string cat = "https://cataas.com/cat";
        string gif = "https://cataas.com/cat/gif";
        string monocat = "https://cataas.com/cat?filter=mono";
        string negatecat = "https://cataas.com/cat?filter=negate";
       

        public MainPage()
        {
            InitializeComponent();
             

        }

       

        private void Button_Clicked(object sender, EventArgs e)
        {
            string textcat = "https://cataas.com/cat/says/" + CatText.Text;

            cats.Source = cat;
            catsGif.Source = gif;
            catsMono.Source = monocat;
            catsNegate.Source = negatecat;
            catsText.Source = textcat;

        }
    }

}
