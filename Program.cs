using Examen1.Ejercicios;

Console.WriteLine("----Bienvenido a la interfaz del Examen 1 de POO----\n");

Console.WriteLine("Ingrese el numero del ejercicio que desea seleccionar:\n"
+"1.Ejercicio01\n"
+"2.Ejercicio01\n"
+"3.Ejercicio01\n"
+"4.Ejercicio01\n"
+"5.Ejercicio01\n"
);
int op = Convert.ToInt32(Console.ReadLine());
switch(op)
{
    case 1:
    Ejercicio01 ejercicio01 = new Ejercicio01();
    Console.Clear();
    ejercicio01.Ejecutar();

    break;
    case 2:

    break;
    case 3:

    break;
    case 4:

    break;
    case 5:

    break;
    case 6:

    break;
}
