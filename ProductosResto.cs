public class ProductosResto
{
    int Id;
    string NombreProducto;
    double Precio;

    public ProductosResto(int ID, string nombreprod, double precio){
        this.Id = ID;
        this.NombreProducto = nombreprod;
        this.Precio = precio;

    }

    public int getID(){
        return this.Id;
    }
    
    public string getName(){
    return this.NombreProducto;
    }
    public double getPrice(){
    return this.Precio;
    }

        public override bool Equals(object? obj)
        {
            var p = obj as ProductosResto;
            if (p != null){
                return p.Id == Id;
            }
            return false;
        }











}