using PortalAlunoApplication.Application;
using PortalAlunoModel.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PortalAluno.Paginas.AutenticacaoPaginas
{
    public partial class Autenticacao : ContentPage
    {
        public Autenticacao()
        {
            InitializeComponent();
        }

        private async void BtnAutenticar(object sender, EventArgs args)
        {
            Usuario usuario = new Usuario();
            AutenticarApplication autApp = new AutenticarApplication();

            usuario = autApp.Autenticar(txtUsuario.Text, txtSenha.Text);

            if(usuario.Autenticado == "S")
            {
                await Navigation.PushAsync(new Master());
            }
            else
            {
                await DisplayAlert("Alert", usuario.Mensagem, "OK");
            }

        }
    }
}
