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

		string mensaje = $"Producto: {producto.Nombre}\n"
			+ $"Precio: {producto.Precio:C}\n"
			+ $"Cantidad: {producto.Cantidad}\n"
			+ $"Subtotal: {producto.CalcularSubtotal():C}\n"
			+ $"IVA: {producto.CalcularIva():C}\n"
			+ $"Total: {producto.CalcularTotalConIva():C}";

		await DisplayAlertAsync("Producto agregado", mensaje, "OK");

		nombre.Text = string.Empty;
		precio.Text = string.Empty;
		cantidad.Text = string.Empty;
		nombre.Focus();
	}
}