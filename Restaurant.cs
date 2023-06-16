public class Restaurant
{
    List<ProductosResto> ListaProductos;

    public Restaurant()
    {
        this.ListaProductos = new List<ProductosResto>();
    }

    public void addProduct(ProductosResto ProductoNuevo)
    {
        this.ListaProductos.Add(ProductoNuevo);
    }

    public void removeProduct(ProductosResto Producto)
    {
        this.ListaProductos.Remove(Producto);
    }

    public double CalcularCuenta(){

        int CantidadConsumida = 0;
        int IDProductoConsumido = -1;
        double suma = 0;
        double propina = 0.1;

        Console.WriteLine("Lista Productos:");
        foreach (var i in ListaProductos) {
            Console.WriteLine("ID: {0} Nombre: {1} Precio: {2}$",i.getID(), i.getName(), i.getPrice());

        
        }

        string Resp = "s";
        
        while (Resp != "n")
        {            
            Console.WriteLine("Elegir ID de producto consumido:");
            IDProductoConsumido  = int.Parse(Console.ReadLine());
            Console.WriteLine("Poner cantidad consumida:");
            CantidadConsumida  = int.Parse(Console.ReadLine());
            Console.WriteLine("Quiere seguir cargando productos? s para si - n para no");
            ProductosResto product = ListaProductos.FirstOrDefault(x=>x.getID() == IDProductoConsumido);
            suma += product.getPrice() * CantidadConsumida;
            Resp  = Console.ReadLine();
        }
         

        return suma + suma * propina;


    }











}