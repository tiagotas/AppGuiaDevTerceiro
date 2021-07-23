using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppGuiaDevTerceiro
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Detail = new NavigationPage(new NovaPasta1.Inicial());
        }

        private void Button_Clicked_Contato(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage(new NovaPasta1.Contato());
                IsPresented = false;

            } catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Button_Clicked_Inicial(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage(new NovaPasta1.Inicial());
                IsPresented = false;
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Button_Clicked_Bd(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage(new NovaPasta1.BancoDados());
                IsPresented = false;
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Button_Clicked_ProgWeb(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage(new NovaPasta1.ProgramacaoWeb());
                IsPresented = false;
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Button_Clicked_Dd(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage(new NovaPasta1.DesignDigital());
                IsPresented = false;
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Button_Clicked_ProgMobile(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage(new NovaPasta1.ProgramacaoMobile());
                IsPresented = false;
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Button_Clicked_So(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage(new NovaPasta1.SistemasOperacionais());
                IsPresented = false;
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Button_Clicked_Rc(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage(new NovaPasta1.RedesComputadores());
                IsPresented = false;
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

        private void Button_Clicked_Sd(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage(new NovaPasta1.SegurancaDigital());
                IsPresented = false;
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}
