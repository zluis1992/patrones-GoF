using Patrones_GoF.Clases_apoyo;
using Patrones_GoF.Patrones;
using System;

namespace Patrones_GoF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
    $$$$$$$\            $$\                                                              $$$$$$\            $$$$$$$$\ 
    $$  __$$\           $$ |                                                            $$  __$$\           $$  _____|
    $$ |  $$ |$$$$$$\ $$$$$$\    $$$$$$\   $$$$$$\  $$$$$$$\   $$$$$$\   $$$$$$$\       $$ /  \__| $$$$$$\  $$ |      
    $$$$$$$  |\____$$\\_$$  _|  $$  __$$\ $$  __$$\ $$  __$$\ $$  __$$\ $$  _____|      $$ |$$$$\ $$  __$$\ $$$$$\    
    $$  ____/ $$$$$$$ | $$ |    $$ |  \__|$$ /  $$ |$$ |  $$ |$$$$$$$$ |\$$$$$$\        $$ |\_$$ |$$ /  $$ |$$  __|   
    $$ |     $$  __$$ | $$ |$$\ $$ |      $$ |  $$ |$$ |  $$ |$$   ____| \____$$\       $$ |  $$ |$$ |  $$ |$$ |      
    $$ |     \$$$$$$$ | \$$$$  |$$ |      \$$$$$$  |$$ |  $$ |\$$$$$$$\ $$$$$$$  |      \$$$$$$  |\$$$$$$  |$$ |      
    \__|      \_______|  \____/ \__|       \______/ \__|  \__| \_______|\_______/        \______/  \______/ \__|      
                                                                                                                  
                                                                                                                  
                                                                                                                  
    ");
            Console.WriteLine("1. Singleton");
            Console.WriteLine("2. Prototype");
            Console.WriteLine("3. Factory Method");
            Console.WriteLine("4. Strategy");
            Console.WriteLine("Escoge un patrón para continuar...");
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.WriteLine($"Patrón singleton o de única instancia, trata de manejar el valor de las propiedades de un objeto establecidas 1 sola vez durante la sesión," +
                                      $"es decir que la primera vez cuando el objeto sea NULL es cuando se establecerá el valor, el resto de veces solo se devolverá el mismo valor que tiene.");
                    Console.WriteLine($"Primera instancia, propiedad mensaje del objeto esta null, entonces le establece un valor, puede ser estático, obtenido de una función o " +
                                      $"cualquier otra cosa, en el ejemplo queda con este valor: {Singleton.Instance.mensaje}");
                    Console.WriteLine($"NOTA: se le puede cambiar el valor a la propiedad normalmente.");
                    Singleton.Instance.mensaje = "nuevo valor";
                    Console.WriteLine($"Cambiamos el valor de la propiedad a: {Singleton.Instance.mensaje}");
                    Console.WriteLine($"Ejemplo de uso diario:");
                    Console.WriteLine("private string urlOrigen");
                    Console.WriteLine("{");
                    Console.WriteLine("    get { return Session['urlOrigen' + localGuid] != null ? (string)Session['urlOrigen' + localGuid] : ''; }");
                    Console.WriteLine("    set { Session['urlOrigen' + localGuid] = value; }");
                    Console.WriteLine("}");
                    break;
                case "2":
                    Console.WriteLine(@"Patrón prototype o prototipo, se trata de clonar objetos, haciendo que si se modifica el objeto original la copia no se afecte " + Environment.NewLine + " no se debe confundir con asignar un objeto a otro (B=A) porque si se modifica el valor A automáticamente cambia B");
                    Console.WriteLine(@"Creamos un objeto A con los siguientes valores Nombre ='Perro grande', Patas = 4, Color = Blanco, Raza = Beagle");
                    Prototype oPrototypeA = new Prototype();
                    oPrototypeA.animal = new Clases_apoyo.Animal { Nombre = "Perro grande", Patas = 4 };
                    oPrototypeA.animal.Rasgos = new Detalles();
                    oPrototypeA.animal.Rasgos.Color = "Blanca";
                    oPrototypeA.animal.Rasgos.Raza = "Beagle";
                    Console.WriteLine("Clonamos el objeto A en un objeto B");

                    Prototype oPrototypeB = new Prototype();
                    oPrototypeB.animal = oPrototypeA.animal.Clone() as Animal;

                    Console.WriteLine("Cambiamos el valor de Nombre en A a 'Perro pequeño' y la Raza por Labrador");
                    oPrototypeA.animal.Nombre = "Perro pequeño";
                    oPrototypeA.animal.Rasgos.Raza = "Labrador";
                    Console.WriteLine($"Validamos que los valores de B no cambiar, Nombre en B= {oPrototypeB.animal.Nombre} y Nombre en A = {oPrototypeA.animal.Nombre}, Raza en B= {oPrototypeB.animal.Rasgos.Raza} y en A= {oPrototypeA.animal.Rasgos.Raza}");
                    Console.WriteLine("");
                    Console.WriteLine(@"Ejemplo de uso diario: " + Environment.NewLine +
                                        " var afiliadoTmp = datosConsulta.afiliado.Clone();");
                    break;
                case "3":
                    Console.WriteLine(@"Patrón factory method, este se trata de tener una 'fabrica' de objetos, que seria una clase que se encarga de crear distintos objetos los cuales " +
                                       "comparten el mismo contrato pero su lógica interna es distinta, " +
                                       "como por ejemplo un método que cree 1 usuario en distintas bases de datos que comparten la misma estructura de tablas pero en diferentes motores.");
                    Console.WriteLine();
                    Console.WriteLine("Ejemplo: Creamos un objeto de la clase Factory y con el metoodo Creador lo usamos para crear el objeto del tipo que re queramos, solo llamando al método de Factory" +
                                      ", y pasando le el tipo del objeto a crear y el método se encarga del resto.");
                    BebidaEmbriagante oFactory = Factory.Creador(Factory.VINO_TINTO);
                    Console.WriteLine($"Usamos el método de Creador para crear un objeto VINO_TINTO y obtener el valor del método CuantoMeEmbriagaPorHora = {oFactory.CuantoMeEmbriagaPorHora()}");
                    oFactory = Factory.Creador(Factory.CERVEZA);
                    Console.WriteLine($"Usamos el método de Creador para crear un objeto CERVEZA y obtener el valor del método CuantoMeEmbriagaPorHora = {oFactory.CuantoMeEmbriagaPorHora()}");
                    Console.WriteLine();
                    Console.WriteLine(@"CONCLUSION: con el patrón Factory como desarrolladores podemos tener una lógica escalable que puede ser estandarizada compartiendo el mismo contrato entre " +
                                       "los nuevos miembros de la fabrica y solo preocuparnos por la lógica puntual de cada uno");
                    break;
                case "4":
                    Console.WriteLine(@"Patrón strategy, trata de manejar el comportamiento de un objeto en tiempo de ejecución, en otras palabras es poder determinar el tipo de un objeto al momento de " +
                                        "llamar el método de manera dinámica sin necesidad de tener que declararlo de manera 'tradicional' podría decirse, dando como ventaja poder tener una interfaz que controle ademas del " +
                                        "contrato también el tipo de los objetos.");
                    Console.WriteLine($"Ejemplo: Tenemos una clase que se encarga de crear un objeto de 2 tipos distintos, dependiendo al comportamiento que nosotros le pasemos," +
                                        "clase: EstrategiasDelBorrachoContexto, la cual tiene un método Conquistar que recibe la opción con la cual se establecerá el tipo de objeto a Crear para el ejemplo seria" +
                                        "tipo = EstrategiaOjitos y EstrategiaInvitarCerveza, los cuales son 2 clases distintas pero que comparten contrato con la misma interfaz" +
                                        "IBorracho." +
                                        "1er llamado, creamos un objeto 'oBorracho' de tipo EstrategiasDelBorrachoContexto pasando le al contexto el parámetro Comportamiento.HacerOjitos, el objeto retorna un objeto tipo EstrategiaOjitos con: ");
                    EstrategiasDelBorrachoContexto oBorracho = new EstrategiasDelBorrachoContexto();
                    oBorracho.Conquistar(EstrategiasDelBorrachoContexto.Comportamiento.HacerOjitos);
                    Console.WriteLine($"2do llamado, con el mismo objeto 'oBorracho' vamos a cambiar el tipo de objeto en tiempo de ejecución, solamente tenemos que llamar al contexto y pasar le el parámetro 'Comportamiento.InvitarCerveza'" +
                                        $"y el contexto nos retornara un objeto de tipo EstrategiaInvitarCerveza con:");
                    oBorracho.Conquistar(EstrategiasDelBorrachoContexto.Comportamiento.InvitarCerveza);
                    Console.WriteLine($"CONCLUSION: el patrón Strategy nos brinda una facilidad de escalabilidad y dinamismo a nuestros objetos y este puede combinarse con otras técnicas " +
                                      $"como reflexión dando como resultado un control centralizado de objetos de distintos tipos sin perder el control de dicha creación en diferentes partes del proyecto.");
                    break;
                default:
                    Console.WriteLine("Digitaste una opción invalida.");
                    break;
            }
        }
    }
}
