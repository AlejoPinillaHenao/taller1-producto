namespace Proyecto_inicial;

using Clases;
using Producto;

public partial class LoginPages : ContentPage
{
    public LoginPages()
    {
        InitializeComponent();
    }

    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
        var user = usuario.Text;
        var pass = password.Text;
        Clases.Login login = new Clases.Login();

        if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
        {
            await DisplayAlertAsync("Error", "Por favor ingrese usuario y contraseña", "OK");
            return;
        }

        if (login.ValidarAcceso(user, pass))
        {
            await DisplayAlertAsync("Éxito", "¡Bienvenido!", "OK");

            var window = Application.Current?.Windows.Count > 0 ? Application.Current.Windows[0] : null;
            if (window is not null)
            {
                window.Page = new NavigationPage(new MainPage())
                {
                    BarBackgroundColor = Color.FromArgb("#1E90FF"),
                    BarTextColor = Colors.White
                };
            }

            usuario.Text = string.Empty;
            password.Text = string.Empty;
        }
        else
        {
            await DisplayAlertAsync("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }
}
