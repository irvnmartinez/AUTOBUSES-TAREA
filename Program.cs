using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTOBUSES___TAREA
{
    class Program
    {
        public struct Autobuses
        {
            public string Modelo { get; set; }
            public string Marca { get; set; }
            public int Capacidad { get; set; }
            public int Matricula { get; set; }


        }

        public struct Choferes
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Telefono { get; set; }
            public int NumeroDeEmpleado { get; set; }
        }
        public struct Rutas
        {
            public string CDO { get; set; }
            public string Destino { get; set; }
            public int CDT { get; set; }
            public int NDR { get; set; }
           
        }
        
       public struct AutobusesConChoferAsignado
       {
                public string Modelo { get; set; }
                public string Marca { get; set; }
                public int Capacidad { get; set; }
                public int Matricula { get; set; }

               
       }

       public struct AutobusesConRutaAsignada
       {
                public string Modelo { get; set; }
                public string Marca { get; set; }
                public int Capacidad { get; set; }
                public int Matricula { get; set; }
                public string Origen { get; set; }
                public string Destino { get; set; }
                public int CDT { get; set; }
                public int NDR { get; set; }


       }
        public struct Ventas
        {
            public string cliente { get; set; }
            public int tickets { get; set; }
            public int ruta { get; set; }
            public int CosteTotal { get; set; }
        }
      
        

        private static List<Autobuses> TheAutobuses = new List<Autobuses>();

        private static List<Choferes> TheChoferes = new List<Choferes>();

        private static List<Rutas> TheRutas = new List<Rutas>();

        private static List<AutobusesConChoferAsignado> TheACCA = new List<AutobusesConChoferAsignado>();

        private static List<AutobusesConRutaAsignada> TheACRA = new List<AutobusesConRutaAsignada>();

        private static List<Ventas> TheVentas = new List<Ventas>();

        


        static void Main(string[] args)
        {
            menu();
        }

        static void menu()
        {
            try
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("                           Bienvenido a su sistema de mantenimiento de autobuses,choferes y rutas\n" +
                "\n                                     ~~~~~~~~~~ Mantenimiento de autobuses ~~~~~~~~~~\n" +
                "\n                                             [1] Crear un nuevo autobus\n                                             [2] Editar un autobus\n                                             [3] Listar autobuses\n                                             [4] Listar autobuses con chofer asignado\n                                             [5] Listar autobuses con ruta asignada\n                                             [6] Eliminar un autobus\n" +
                "\n                                     ~~~~~~~~~~ Mantenimiento de choferes ~~~~~~~~~~\n" +
                "\n                                             [7] Agregar un chofer\n                                             [8] Asignar autobus(es) a un chofer\n                                             [9] Listar Choferes\n" +
                "\n                                     ~~~~~~~~~~ Mantenimiento de rutas ~~~~~~~~~~\n" +
                "\n                                             [10] Agregar una ruta\n                                             [11] Asignar una ruta a un autobus\n                                             [12] Listar Rutas\n                                             [13] Eliminar Ruta\n" +
                "\n                                               ~~~~~~~~~~~~~~~~~~~~\n" +  
                "\n                                             [14] Ir al menu de clientes");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CrearAutobus();
                        break;
                    case 2:
                        EditarAutobus();
                        break;
                    case 3:
                        ListarAutobuses();
                        break;
                    case 4:
                        ListarAutobusesConChofer();
                        break;
                    case 5:
                        ListarAutobusesConRuta();
                        break;
                    case 6:
                        EliminarAutobus();
                        break;
                    case 7:
                        AgregarChofer();
                        break;
                    case 8:
                        AsignarAutAChofer();
                        break;                       
                    case 9:
                        ListarChoferes();
                        break;
                    case 10:
                        AgregarRuta();
                        break;
                    case 11:
                        AsignarRutaaAut();
                        break;
                    case 12:
                        ListarRutas();
                        break;
                    case 13:
                        EliminarRuta();
                        break;
                    case 14:
                        MenuDeClientes();
                        break;
                    default:
                        Console.WriteLine("***        Lo sentimos, esta opcion no se encuentra disponible        ***");
                        break;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("\n***        " + error.Message + "        ***");
                Console.ReadKey();
                menu();
            }


        }

        static void CrearAutobus()
        {
            try
            {
                Autobuses Autobus = new Autobuses();

                Console.Clear();
                Console.WriteLine("                                    ~~~~~~~~~~ Creando nuevo autobus ~~~~~~~~~~\n");
                Console.Write("                                           > Ingrese la marca del autobus: ");
                Autobus.Marca = Console.ReadLine();
                Console.Write("\n                                           > Ingrese el modelo del autobus: ");
                Autobus.Modelo = Console.ReadLine();
                Console.Write("\n                                           > Con que capacidad cuenta el autobus: ");
                Autobus.Capacidad = int.Parse(Console.ReadLine());
                Random rnd = new Random();
                int matricula = Convert.ToInt32(rnd.Next(1000000, 7000000));
                Autobus.Matricula = matricula;
                Console.Write("\n                                           > Su matricula generada automaticamente es: " + matricula);
                

                TheAutobuses.Add(Autobus);
                Console.ReadKey();
                menu();
            }
            catch (Exception error)
            {
                Console.WriteLine("\n                                       ***        " + error.Message + "        ***");
                Console.ReadKey();
                menu();
            }
        }

        static void EditarAutobus()
        {
            try
            {
                 Console.Clear();
                 
                 
                 foreach (Autobuses item in TheAutobuses)
                 {
                    
                    Console.WriteLine("Autobus:" +
                    "\n                              Modelo:" + item.Matricula);
                    
                 }

                Console.WriteLine("Bienvenido al sistema de edicion de autobuses, para continuar escriba la matricula del autobus que desea editar");
                int seleccion = Convert.ToInt32(Console.ReadLine());
                Autobuses edit = new Autobuses();
                foreach (Autobuses item in TheAutobuses)
                {


                     if(seleccion == item.Matricula)
                     {
                        Console.Clear();
                        TheAutobuses.Remove(item);
                        Console.WriteLine("                                        ~~~~~~~~~~ Editando autobus ~~~~~~~~~~\n");
                        Console.Write("                                           > Ingrese la nueva marca del autobus: ");
                        edit.Marca = Console.ReadLine();
                        Console.Write("\n                                           > Ingrese la nueva matricula del autobus: ");
                        edit.Matricula = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\n                                          > Ingrese el nuevo modelo del autobus: ");
                        edit.Modelo = Console.ReadLine();
                        Console.Write("\n                                          > Por ultimo, ingrese la capacidad del autobus: ");
                        edit.Capacidad = Convert.ToInt32(Console.ReadLine());
                        TheAutobuses.Add(edit);
                        Console.ReadKey();
                        menu();
                     }
                   
                    
                }
            }
            catch(Exception error)
            {
                Console.WriteLine("\n***        " + error.Message + "        ***");
                Console.ReadKey();
                menu();
            }
        }

        static void ListarAutobuses()
        {
            try
            {
                Console.Clear();
                foreach (Autobuses item in TheAutobuses)
                {
                    
                    Console.WriteLine("Autobus:" +
                    "\n                              Modelo:" + item.Modelo +
                    "\n                              Marca:" + item.Marca +
                    "\n                              Capacidad:" + item.Capacidad +
                    "\n                              Matricula:" + item.Matricula);
                    
                    Console.WriteLine("\n");
                }
                Console.ReadKey();
                menu();
                
            }
            catch(Exception error)
            {
                Console.WriteLine("\n                 ***        " + error.Message + "        ***");
                Console.ReadKey();
                menu();
            }
        }

        static void ListarAutobusesConChofer()
        {
            try
            {
                Console.Clear();
                foreach (AutobusesConChoferAsignado item in TheACCA)
                { 
                    Console.WriteLine("Autobus:" +
                    "\n                              Marca:" + item.Marca +
                    "\n                              Modelo:" + item.Modelo +
                    "\n                              Capacidad:" + item.Capacidad +
                    "\n                              Matricula:" + item.Matricula);

                    Console.WriteLine("\n");
                }
                Console.ReadKey();
                menu();

            }
            catch (Exception error)
            {
                Console.WriteLine("\n                 ***        " + error.Message + "        ***");
                Console.ReadKey();
                menu();
            }
        }

        static void ListarAutobusesConRuta()
        {
            try
            {
                Console.Clear();
                foreach (AutobusesConRutaAsignada item in TheACRA)
                {
                    Console.WriteLine("Autobus:" +
                    "\n                              Marca:" + item.Marca +
                    "\n                              Modelo:" + item.Modelo +
                    "\n                              Capacidad:" + item.Capacidad +
                    "\n                              Matricula:" + item.Matricula +
                    "\n                              Ciudad de origen:" + item.Origen +
                    "\n                              Destino:" + item.Destino +
                    "\n                              Coste de ticket:" + item.CDT);
                    Console.WriteLine("\n");
                }
                Console.ReadKey();
                menu();

            }
            catch (Exception error)
            {
                Console.WriteLine("\n                 ***        " + error.Message + "        ***");
                Console.ReadKey();
                menu();
            }
        }

        static void EliminarAutobus()
        {
            try
            {
                Console.Clear();
                foreach (Autobuses item in TheAutobuses)
                {
                    Console.WriteLine("Autobus:" +
                    "\n                              Matricula:" + item.Matricula);

                }

                Console.WriteLine("Bienvenido al sistema de eliminacion de autobuses, para continuar escriba la matricula del autobus que desea eliminar");
                int seleccion = Convert.ToInt32(Console.ReadLine());              
                foreach (Autobuses m in TheAutobuses)
                {

                    if(seleccion == m.Matricula)
                    {
                        Console.Clear();
                        TheAutobuses.RemoveAll(i => i.Matricula == seleccion);
                        menu();
                    }
                    

                }
            }
            catch(Exception error)
            {
                Console.WriteLine("***        " + error.Message + "        ***");            }
        }

        static void AgregarChofer()
        {
            try
            {
                Console.Clear();
                Choferes chofer = new Choferes();

                Console.WriteLine("                                        ~~~~~~~~~~ Creando Chofer ~~~~~~~~~~\n");
                Console.Write("                                           > Ingrese el nombre del chofer: ");
                chofer.Nombre = Console.ReadLine();
                Console.Write("\n                                           > Ingrese el apellido del chofer: ");
                chofer.Apellido = Console.ReadLine();
                Console.Write("\n                                           > Ingrese el numero telefonico del chofer: ");
                chofer.Telefono = Console.ReadLine();
                Random rnd = new Random();
                int NumEmpleado = Convert.ToInt32(rnd.Next(1000, 7000));
                chofer.NumeroDeEmpleado = NumEmpleado;
                Console.Write("\n                                           > Su numero de empleado generado automaticamente es: " + NumEmpleado);

                TheChoferes.Add(chofer);
                Console.ReadKey();
                menu();
            }
            catch (Exception error)
            {
                Console.WriteLine("\n***        " + error.Message + "        ***");
                Console.ReadKey();
                menu();
            }
        }

        static void ListarChoferes()
        {
            try
            {
                Console.Clear();
                foreach (Choferes item in TheChoferes)
                {
                    Console.WriteLine("Chofer:" +
                    "\n                              Nombre:" + item.Nombre +
                    "\n                              Apellido:" + item.Apellido +
                    "\n                              Telefono:" + item.Telefono +
                    "\n                              Numero de empleado:" + item.NumeroDeEmpleado);

                    Console.WriteLine("\n");
                }
                Console.ReadKey();
                menu();

            }
            catch (Exception error)
            {
                Console.WriteLine("\n                 ***        " + error.Message + "        ***");
                Console.ReadKey();
                menu();
            }
        }

        static void AsignarAutAChofer()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("                                           ~~~~~~~~~~ Asignando un autobus a un chofer ~~~~~~~~~~");

                foreach (Choferes item in TheChoferes)
                {
                    Console.WriteLine("Chofer:" +
                    "\n                                                    Nombre:" + item.Nombre +
                    "\n                                                    Apellido:" + item.Apellido +
                    "\n                                                    Numero de empleado:" + item.NumeroDeEmpleado);
                }
                Console.WriteLine("                       \nIngrese el numero de empleado del chofer que desea seleccionar");
                int seleccion = Convert.ToInt32(Console.ReadLine());
                foreach (Choferes item1 in TheChoferes)
                {
                    if (seleccion == item1.NumeroDeEmpleado)
                    {
                        foreach (Autobuses item2 in TheAutobuses)
                        {
                            Console.WriteLine("                    Autobus:" +
                            "\n                                            Matricula:" + item2.Matricula);

                        }

                        Console.WriteLine("\nIngrese la matricula del autobus al que quiere asignar a este chofer");
                        int seleccion1 = Convert.ToInt32(Console.ReadLine());
                        foreach (Autobuses item3 in TheAutobuses)
                        {
                            if (seleccion1 == item3.Matricula)
                            {

                                AutobusesConChoferAsignado asignando = new AutobusesConChoferAsignado();
                                asignando.Marca = item3.Marca;
                                asignando.Modelo = item3.Modelo;
                                asignando.Capacidad = item3.Capacidad;
                                asignando.Matricula = item3.Matricula;
                                if (TheACCA.Contains(asignando))
                                {
                                    Console.WriteLine("\n* Este autobus ya tiene un chofer asignado, desea volver al inicio de este registro? [si/no] *");
                                    string decision = Console.ReadLine();
                                    if (decision == "si")
                                    {
                                        AsignarAutAChofer();
                                    }
                                    else
                                    {
                                        menu();
                                    }
                                    
                                }
                                else
                                {
                                    TheACCA.Add(asignando);
                                    Console.WriteLine("El chofer ha sido asignado exitosamente");
                                    Console.ReadKey();
                                    menu();
                                }


                            }

                        }

                    }
                }



            }
            catch(Exception error)
            {
                Console.WriteLine("***        " + error.Message + "        ***");
            }

        }              

        static void AgregarRuta()
        {
            try
            {
                Console.Clear();
                Rutas ruta = new Rutas();

                Console.WriteLine("                                        ~~~~~~~~~~ Creando ruta ~~~~~~~~~~\n");
                Console.Write("                                           > Ingrese la ciudad de origen de esta ruta: ");
                ruta.CDO = Console.ReadLine();
                Console.Write("\n                                           > Ingrese el destino de esta ruta: ");
                ruta.Destino = Console.ReadLine();
                Console.Write("\n                                           > Ingrese el costo de ticket para esta ruta: ");
                ruta.CDT = Convert.ToInt32(Console.ReadLine());
                Random rnd = new Random();
                int NumeroDeRuta = Convert.ToInt32(rnd.Next(1, 100));
                ruta.NDR = NumeroDeRuta;
                Console.Write("\n                                           > El numero de esta ruta generado automaticamente es: " + NumeroDeRuta);


                TheRutas.Add(ruta);
                Console.ReadKey();
                menu();
                
            }
            catch(Exception error)
            {
                Console.WriteLine("\n***        " + error.Message + "        ***");
            }
        }

        static void ListarRutas()
        {
            try
            {
                Console.Clear();              
                foreach (Rutas item in TheRutas)
                {
                    Console.WriteLine("Ruta:" +
                    "\n                              Ciudad de origen:" + item.CDO +
                    "\n                              Destino:" + item.Destino +
                    "\n                              Coste de ticket:" + item.CDT +
                    "\n                              Numero de ruta:" + item.NDR);

                    Console.WriteLine("\n");
                }
                Console.ReadKey();
                menu();

            }
            catch (Exception error)
            {
                Console.WriteLine("\n                 ***        " + error.Message + "        ***");
                Console.ReadKey();
                menu();
            }
        }

        static void AsignarRutaaAut()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("                        ~~~~~~~~~~ Asignando ruta a autobus ~~~~~~~~~~");
                
                foreach (Rutas item in TheRutas)
                {

                    Console.WriteLine("Ruta: " +
                    "\n                                                    Ciudad de origen:" + item.CDO +
                    "\n                                                    Destino:" + item.Destino +
                    "\n                                                    Coste de ticket:" + item.CDT +
                    "\n                                                    Numero de ruta:" + item.NDR);
                                                                                      

                }
                Console.WriteLine("                       \nIngrese el numero de la ruta que desea asignar al autobus");
                int seleccion = Convert.ToInt32(Console.ReadLine());
                foreach (Rutas item1 in TheRutas)
                {
                    if (seleccion == item1.NDR)
                    {
                        foreach (AutobusesConChoferAsignado item2 in TheACCA)
                        {
                            Console.WriteLine("                    Autobus:" +
                            "\n                                            Matricula:" + item2.Matricula);

                        }

                        Console.WriteLine("\nIngrese la matricula del autobus al que asignara esta ruta");
                        int seleccion1 = Convert.ToInt32(Console.ReadLine());
                        foreach (AutobusesConChoferAsignado item3 in TheACCA)
                        {
                            if (seleccion1 == item3.Matricula)
                            {

                                AutobusesConRutaAsignada asignando = new AutobusesConRutaAsignada();
                                asignando.Marca = item3.Marca;
                                asignando.Modelo = item3.Modelo;
                                asignando.Capacidad = item3.Capacidad;
                                asignando.Matricula = item3.Matricula;
                                asignando.Origen = item1.CDO;
                                asignando.Destino = item1.Destino;
                                asignando.CDT = item1.CDT;
                                asignando.NDR = item1.NDR;
                                if (TheACRA.Contains(asignando))
                                {
                                    Console.WriteLine("\n* Este autobus ya tiene una ruta asignada, desea volver al inicio de este registro? [si/no] *");
                                    string decision = Console.ReadLine();
                                    if (decision == "si")
                                    {
                                        AsignarAutAChofer();
                                    }
                                    else
                                    {
                                        menu();
                                    }

                                }
                                else
                                {
                                    TheACRA.Add(asignando);
                                    Console.WriteLine("Se ha asignado la ruta exitosamente");
                                    Console.ReadKey();
                                    menu();
                                }


                            }
                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("***        " + error.Message + "        ***");
            }
        }

        static void EliminarRuta()
        {
            try
            {
                Console.Clear();
                foreach (Rutas item in TheRutas)
                {
                    Console.WriteLine("Ruta:" +
                    "\n                              Numero de ruta:" + item.NDR);

                }

                Console.WriteLine("Bienvenido al sistema de eliminacion de rutas, para continuar escriba el numero de la ruta que desea eliminar");
                int seleccion = Convert.ToInt32(Console.ReadLine());
                foreach (Rutas m in TheRutas)
                {

                    if (seleccion == m.NDR)
                    {
                        foreach (AutobusesConRutaAsignada n in TheACRA)
                        {
                            Console.Clear();
                            TheRutas.RemoveAll(i => i.NDR == seleccion);
                            TheACRA.RemoveAll(j => j.NDR == seleccion);
                            menu();
                        }
                    }

                }
            }
            catch (Exception error)
            {
                Console.WriteLine("***        " + error.Message + "        ***");
            }

        }
        
        static void MenuDeClientes()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\n                 Bienvenido, seleccione una opcion a su preferencia\n" +
                "\n                      ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                "\n                             [1] Ver rutas disponibles\n                             [2] Comprar ticket para un autobus\n                             [3] Reservaciones\n                             [4] Volver al menu principal");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        MCRutasDisponibles();
                        break;
                    case 2:
                        MCComprarTickets();
                        break;
                    case 3:
                        MCReservaciones();
                        break;
                    case 4:
                        menu();
                        break;
                }
            }
            catch(Exception error)
            {
                Console.WriteLine("***        " + error.Message + "        ***");
            }
                   


        }

        static void MCRutasDisponibles()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("                      ~~~~~~~~~~Rutas con espacio disponible ~~~~~~~~~~");
                foreach(AutobusesConRutaAsignada item in TheACRA)
                {
                    if (item.Capacidad > 0)
                    {
                     Console.WriteLine("Rutas:" +
                     "\n                              Ciudad de origen:" + item.Origen +
                     "\n                              Destino:" + item.Destino +
                     "\n                              Coste de ticket:" + item.CDT +
                     "\n                              Asientos:" + item.Capacidad +
                     "\n                              Numero de ruta:" + item.NDR);
                    }

                }
                Console.ReadKey();
                MenuDeClientes();
            }
            catch (Exception error)
            {
                Console.WriteLine("***        " + error.Message + "        ***");
            }
        }

        static void MCComprarTickets()
        {
            try
            {
                Console.Clear();
                Ventas value = new Ventas();
                Console.WriteLine("                     ~~~~~~~~~~ Rutas con espacio disponible ~~~~~~~~~~");
                foreach (AutobusesConRutaAsignada item in TheACRA)
                {
                    if (item.Capacidad > 0)
                    {
                        Console.WriteLine("Rutas:" +
                        "\n                              Ciudad de origen:" + item.Origen +
                        "\n                              Destino:" + item.Destino +
                        "\n                              Coste de ticket:" + item.CDT +
                        "\n                              Asientos:" + item.Capacidad +
                        "\n                              Numero de ruta:" + item.NDR);
                    }
                }
                Console.WriteLine("\nIngrese el numero de la ruta que usara");
                value.ruta = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nIngrese su nombre");
                value.cliente = Console.ReadLine();
                AutobusesConRutaAsignada edit = new AutobusesConRutaAsignada();
                foreach(AutobusesConRutaAsignada item1 in TheACRA)
                {
                    if (value.ruta == item1.NDR)
                    {
                        Console.WriteLine("\nCuantos tickets para esta ruta desea comprar?");
                        value.tickets = Convert.ToInt32(Console.ReadLine());
                        edit.Capacidad = item1.Capacidad - value.tickets;
                        edit.CDT = item1.CDT;
                        edit.Destino = item1.Destino;
                        edit.Marca = item1.Marca;
                        edit.Matricula = item1.Matricula;
                        edit.Modelo = item1.Modelo;
                        edit.NDR = item1.NDR;
                        edit.Origen = item1.Origen;
                        value.CosteTotal = value.tickets * item1.CDT;
                        TheACRA.Remove(item1);
                        TheACRA.Add(edit);
                        TheVentas.Add(value);
                        MenuDeClientes();
                    }
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("***        " + error.Message + "        ***");
            }
        }

        static void MCReservaciones()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("            ~~~~~~~~~~ Reservaciones ~~~~~~~~~~");
                foreach (Rutas item in TheRutas)
                {                   
                    Console.WriteLine("Ruta:" +
                    "\n                              Ciudad de origen:" + item.CDO +
                    "\n                              Destino:" + item.Destino +
                    "\n                              Coste de ticket:" + item.CDT +
                    "\n                              Numero de ruta:" + item.NDR);

                    Console.WriteLine("\n");
                }
                Console.WriteLine("Ingrese el numero de la ruta para ver las reservaciones");
                int seleccion = Convert.ToInt32(Console.ReadLine());
                foreach (Rutas item1 in TheRutas)
                {
                    if (seleccion == item1.NDR )
                    {
                        Console.Clear();
                        foreach(Ventas item2 in TheVentas)
                        {
                            if (seleccion == item2.ruta)
                            {
                                Console.WriteLine("Reservacion:" +
                              "\n                              Fecha:" + DateTime.Today +
                              "\n                              Cliente:" + item2.cliente +
                              "\n                              Tickets reservados:" + item2.tickets +                             
                              "\n                              Ruta:" + item2.ruta +
                              "\n                              Coste total:" + item2.CosteTotal);
                                Console.ReadKey();
                                MenuDeClientes();
                            }
                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("***        " + error.Message + "        ***");
            }
        }


    }
}
