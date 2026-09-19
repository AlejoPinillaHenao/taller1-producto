namespace Producto;

public partial class PaginaProductos : ContentPage
{
	public PaginaProductos()
	{
		InitializeComponent();
	}

	private async void btnAgregar_Clicked(object? sender, EventArgs e)
	{
		string nombreProducto = nombre.Text ?? string.Empty;

		if (string.IsNullOrWhiteSpace(nombreProducto)
			|| !decimal.TryParse(precio.Text, out decimal precioProducto)
			|| !int.TryParse(cantidad.Text, out int cantidadProducto))
		{
			await DisplayAlertAsync("Error", "Ingrese nombre, precio y cantidad válidos", "OK");
			return;
		}

		Clases.Producto producto = new Clases.Producto(nombreProducto, precioProducto, cantidadProducto);

		resultado.Text = producto.ToString();
	}
}