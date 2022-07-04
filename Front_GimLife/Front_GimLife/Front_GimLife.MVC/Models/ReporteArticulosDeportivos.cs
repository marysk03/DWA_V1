namespace Front_GimLife.MVC.Models
{
    public class ReporteArticulosDeportivos
    {
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public int cantidad { get; set; }
        public int precio_compra { get; set; }
        public int precio_venta { get; set; }
        public int proveedor { get; set; }

    }
}
