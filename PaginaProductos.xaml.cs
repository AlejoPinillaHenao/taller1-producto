using System.Collections.ObjectModel;


namespace Producto;

public partial class PaginaProductos : ContentPage

{
	private ObservableCollection<Clases.Producto> _productos = new();

	public PaginaProductos()
	{
		InitializeComponent();
        collectionProductos.ItemsSource = _productos;


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

        Clases.Producto nuevoProducto = new Clases.Producto(nombreProducto, precioProducto, cantidadProducto);
        _productos.Add(nuevoProducto);

        ActualizarTotal();
        limpiarFormulario();

    }
			

	private void ActualizarTotal()
	{
		decimal total= _productos.Sum(p => p.CalcularTotalConIva());
        labelTotal.Text = $"Total: {total:C}";

    }

	private void limpiarFormulario()
	{
		nombre.Text = string.Empty;
		precio.Text = string.Empty;
		cantidad.Text = string.Empty;

    }

    //Clases.Producto producto = new Clases.Producto(nombreProducto, precioProducto, cantidadProducto);

    /* string mensaje = $"Producto\n{producto.Nombre}\n\n"
		+ $"Precio\n{producto.Precio:C0}\n\n"
		+ $"Cantidad\n{producto.Cantidad}\n\n"
		+ $"Subtotal\n{producto.CalcularSubtotal():C0}\n\n"
		+ $"IVA\n{producto.CalcularIva():C0}\n\n"
		+ $"Total\n{producto.CalcularTotalConIva():C0}";

	await DisplayAlertAsync("Producto agregado", mensaje, "OK");

	nombre.Text = string.Empty;
	precio.Text = string.Empty;
	cantidad.Text = string.Empty;
	nombre.Focus(); */

    
}