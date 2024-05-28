using Distribuidora;

static void leerLista(List<Tareas> lista){
        foreach(Tareas tarea in lista){
            Console.WriteLine(tarea.Id);
            Console.WriteLine(tarea.Descripcion);
            Console.WriteLine(tarea.Duracion);

        }
    }
var listaPendiente = new List<Tareas>();
var listaRealizadas = new List<Tareas>();

Tareas TareaA = new Tareas(1,"Primera Tarea", 20);
Tareas TareaB = new Tareas(2,"Segunda Tarea",25);
Tareas TareaC = new Tareas(3,"Tercer Tarea",14);

listaPendiente.Add(TareaA);
listaPendiente.Add(TareaB);
listaPendiente.Add(TareaC);

int num;
int idTarea;
string descri;
do{
    Console.WriteLine("Ingresar 1 para pasar tarea pendiente a realizada");
    Console.WriteLine("Ingresar 2 para buscar una tarea pendiente");
    Console.WriteLine("Ingrese 3 para salir");
    num = Convert.ToInt32(Console.ReadLine());
    switch (num)
    {
        case 1:
            Console.WriteLine("Ingresar el id de la tarea a cambiar");
            idTarea = Convert.ToInt32(Console.ReadLine());
            foreach (Tareas Tarea in listaPendiente)
            {
                if(Tarea.Id == idTarea){
                    listaRealizadas.Add(Tarea);
                    leerLista(listaRealizadas);
                    listaPendiente.RemoveAt(idTarea - 1);
                    leerLista(listaPendiente);

                }
            }
            break;
        case 2: 
            Console.WriteLine("Ingresar la descripcion a buscar");
            descri = Console.ReadLine();
            foreach (Tareas tarea in listaPendiente){
                if(tarea.Descripcion == descri){
                    Console.WriteLine(tarea.Id);
                    Console.WriteLine(tarea.Descripcion);
                    Console.WriteLine(tarea.Duracion);
                }
            }
    }


}while(num != 3);

