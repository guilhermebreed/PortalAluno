using PortalAluno.Paginas.AutenticacaoPaginas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PortalAluno
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new PortalAluno.MainPage();
            MainPage = new NavigationPage(new Autenticacao());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
