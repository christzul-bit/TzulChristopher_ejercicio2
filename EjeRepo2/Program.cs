//programa con repositorio 2
using System.ComponentModel.Design;

bool permiso = false;
int nvlPermiso = 0;
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
Console.WriteLine("Posee autorizacion por escrita? (s/n)_");
string autorizacion = Console.ReadLine();
Console.WriteLine("Trae USB? (s/n)_");
string usb = Console.ReadLine();
Console.WriteLine("Viene acompañado de un personal de la Universidad? (s/n)_");
string togheter = Console.ReadLine();
if (hora >= 0 && hora <= 23 && dia >= 1 && dia <= 7 && usb == "s" || usb == "n" && togheter == "s" || togheter == "n" && autorizacion == "s" || autorizacion == "n") {
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Posee el carner vigente? (s/n)_");
            string vigencia = Console.ReadLine();
            if (dia >= 1 && dia <= 5 && hora >= 7 && hora <= 18)
            {
                if(vigencia == "s")
                {
                    if(usb == "s")
                    {
                        if(togheter == "s" && autorizacion == "s")
                        {
                            permiso = true;
                            nvlPermiso = 2;
                        }else
                        {
                            Console.WriteLine("Necesitas acompañamiento y autorizacion para entrar con USB");
                        }
                    }else
                    {
                        permiso = true;
                        nvlPermiso = 2;
                    }
                }else
                {
                    Console.WriteLine("Tienes que validar tu carnet");
                }
            }else
            {
                Console.WriteLine("No puede entrar fuera de horario permitido para estudiantes \n" +
                    "de lunes a viernes y entre 7 a 18 horas.");
            }
            break;
        case 2:
            if(dia >= 1 && dia <= 7 && hora >= 7 && hora <= 18)
            {
                permiso = true;
                nvlPermiso = 3;
            }else
            {
                Console.WriteLine("Los docentes solo pueden entrar en horario permitido \n" +
                    "de lunes a viernes y entre 7 a 18 horas");
            }
            break;
        case 3:
            if (autorizacion == "s")
            {
                permiso = true;
                nvlPermiso = 4;
            }else
            {
                Console.WriteLine("Requiere de autorizasion por escrita");
            }
            break;
        case 4:
            if(dia >= 1 && dia <= 5 && hora >=7 && hora <=18)
            {
                if (autorizacion == "s" && togheter == "s")
                {
                    permiso = true;
                    nvlPermiso = 1;
                }
                else
                {
                    Console.WriteLine("Necesitas de autorizacion y supervision para entrar");
                }
            }
            else
            {
                Console.WriteLine("Los visitantes no pueden entrar fuera de horario escolar \n" +
                    "de lunes a viernes de 7 a 18 horas");
            }
            break;
        default: Console.WriteLine("Opcion invalida"); break;
    }
}else
{
    Console.WriteLine("Uno o mas respuestas invalidas, intente otra vez");
}