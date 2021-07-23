using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.OpenWhatsApp;
using Xamarin.Essentials;

namespace AppGuiaDevTerceiro.NovaPasta1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contato : ContentPage
    {
        public Contato()
        {
            InitializeComponent();
        }

        private void Button_Clicked_Ligar(object sender, EventArgs e)
        {
            try
            {
                Launcher.OpenAsync("tel:+551436223566");                
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Button_Clicked_Email(object sender, EventArgs e)
        {
            try
            {
                Launcher.OpenAsync("mailto:e070acad@etec.sp.gov.br");
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private async void Button_Clicked_WhatsApp(object sender, EventArgs e)
        {
            try
            {
                Chat.Open("+551436223566");
            }
            catch (Exception ex)
            {
                bool abrir_discador = await DisplayAlert("Ops, Não foi possível abrir o WhatsApp", "Abrir o Discadador?", "Sim", "Agora Não");

                if(abrir_discador)
                    await Launcher.OpenAsync("tel:+551436223566");
            }

        }
    }
}