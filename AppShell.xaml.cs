namespace Producto
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(PaginaProductos), typeof(PaginaProductos));
        }
    }
}
