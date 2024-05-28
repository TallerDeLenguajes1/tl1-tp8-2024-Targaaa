namespace Distribuidora;

public class Tareas{
    private int id;
    private string descripcion;
    private int duracion;

    public Tareas(int id, string descripcion, int duracion)
    {
        this.id = id;
        this.descripcion = descripcion;
        this.duracion = duracion;
    }

    public int Duracion { get => duracion; set => duracion = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Id { get => id; set => id = value; }

    
}