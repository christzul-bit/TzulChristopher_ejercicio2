//programa con repositorio 2
Console.WriteLine("Ingrese su tipo de rol \n" +
    "1)Estudiante \n" +
    "2)Docente \n" +
    "3)Tecnico IT \n" +
    "4)Visitante_");
int opcion = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la hora para entrar_");
int hora = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el dia de la semana de (1-7)_");
int dia = int.Parse(Console.ReadLine());
Console.WriteLine("Posee el carner vigente? (s/n)_");
string vigencia = Console.ReadLine();
Console.WriteLine("Posee autorizacion por escrita? (s/n)_");
string autorizacion = Console.ReadLine();
Console.WriteLine("Trae USB? (s/n)_");
string usb = Console.ReadLine();

