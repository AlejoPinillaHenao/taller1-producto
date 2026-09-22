namespace Producto;

public partial class LoginPages : ContentPage
{
    public LoginPages()
    {
        InitializeComponent();
    }

    private async void btnLogin_Clicked(object? sender, EventArgs e)
    {
        var user = usuario.Text;
        var pass = password.Text;
        Clases.Login login = new Clases.Login();

        if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
        {
            await DisplayAlert("Error", "Por favor ingrese usuario y contraseña", "OK");
            return;
        }

        if (login.ValidarAcceso(user, pass))
        {
            await DisplayAlert("Éxito", "¡Bienvenido!", "OK");

            usuario.Text = string.Empty;
            password.Text = string.Empty;

            await Shell.Current.GoToAsync(nameof(PaginaProductos));
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }
}