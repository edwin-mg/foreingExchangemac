using Xamarin.Forms;

namespace foreingExchangemac
{
    public partial class foreingExchangemacPage : ContentPage
    {
        public foreingExchangemacPage()
        {
            InitializeComponent();
            ConvertButton.Clicked += ConvertButton_Clicked;
        }

        void ConvertButton_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(PesosEntry.Text))
            {
                DisplayAlert("Eror","You most enter a value pesos..." , "Accept");
                return;
            }

                decimal pesos = 0;
                if (!decimal.TryParse(PesosEntry.Text, out pesos))

               {
                DisplayAlert("Error", "You must enter a value numeric in pesos...", "Accept");
                return;
               }

            var dollars = pesos / 3003.003M;
            var euros = pesos / 3531.0510M;
            var pounds = pesos / 3007.2372M;

            DollarsEntry.Text = string.Format("{0:C2}", dollars);
            EurosEntry.Text = string.Format("{0:C2}", euros);
            PoundsEntry.Text = string.Format("{0:C2}", pounds);
        }
    }
}
