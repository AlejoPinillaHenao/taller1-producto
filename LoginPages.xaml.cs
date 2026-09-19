namespace Proyecto_inicial;

using Clases;
using Producto;

public partial class LoginPages : ContentPage
{
    public LoginPages()
    {
        InitializeComponent();
    }

    private void btnLogin_Clicked(object sender, EventArgs e)
    {
        var user = usuario.Text;
        var pass = password.Text;
        Clases.Login login = new Clases.Login();

        if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
        {
            DisplayAlert("Error", "Por favor ingrese usuario y contraseña", "OK");
            return;
        }

        if (login.ValidarAcceso(user, pass))
        {
            DisplayAlert("Éxito", "¡Bienvenido!", "OK");
            Application.Current.MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromArgb("#1E90FF"),
                BarTextColor = Colors.White
            };

            usuario.Text = string.Empty;
            password.Text = string.Empty;

        }

        else
        {
            DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }



    }
}