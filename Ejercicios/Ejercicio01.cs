using System.Security.Cryptography.X509Certificates;

namespace Examen1.Ejercicios
{
    public class Ejercicio01//Cotizador de envíos
    {
        public string? ClienteNombre;
        public int ClienteZona;
        public decimal PesoPaquete;
        public int TipoDeServicio;
        public static decimal ValorDeclarado;
        private decimal Total = ValorDeclarado;

        private decimal SubTotal = ValorDeclarado;
       





        public void Ejecutar()
        {
            Console.WriteLine("Ingrese el nombre del cliente:\n");
            ClienteNombre = Console.ReadLine();

            Console.WriteLine("Ingrese la zona del cliente:\n"+
            "1.Local\n 2.Departamental\n 3.Nacional\n");
            do{ClienteZona = Convert.ToInt32(Console.ReadLine());
            if(ClienteZona<1 && ClienteZona>3)
            {
                Console.WriteLine("Opción Invalida Intente de Nuevo");
            }
            }while(ClienteZona<1 && ClienteZona>3);

            do{Console.WriteLine("Ingrese el peso del paquete:\n");
            PesoPaquete = Convert.ToInt32(Console.ReadLine());
            if(PesoPaquete<=0)
                {
                    Console.WriteLine("Opción Invalida Intente de Nuevo");
                }
            }while(PesoPaquete<=0);

            Console.WriteLine("Ingrese el tipo de servicio:\n"+
            "1.Estándar\n 2.Express\n 3.Mismo Día\n");
            do{TipoDeServicio = Convert.ToInt32(Console.ReadLine());
            if(TipoDeServicio<1 && TipoDeServicio>3)
            {
                Console.WriteLine("Opción Invalida Intente de Nuevo");
            }
            }while(TipoDeServicio<1 && TipoDeServicio>3);

            do{Console.WriteLine("Ingrese el valor declarado\n");
            ValorDeclarado = Convert.ToInt32(Console.ReadLine());
            if(ValorDeclarado<=0)
                {
                    Console.WriteLine("Opción Invalida Intente de Nuevo");
                }
            }while(ValorDeclarado<=0);
            
        

       #region Tarifas
        
       
            decimal TotalRecargoPorPeso = 0;
            //Recargo por peso
            if(PesoPaquete<=1)
            {
                TotalRecargoPorPeso = 0;
            }
            else if(PesoPaquete>1 && PesoPaquete<=5)
            { 
                TotalRecargoPorPeso = 40;
            }
            else if(PesoPaquete>5 && PesoPaquete<=10)
            {
                TotalRecargoPorPeso = 80;
            }
            else if(PesoPaquete>=10)
            {
                TotalRecargoPorPeso = 140;
            }
            else
            {}
           
            //Recargo por ClienteZona
            decimal TotalRecargoClienteZona = 0;
            switch(ClienteZona)
            {
                case 1:
                TotalRecargoClienteZona = 60;
                break;
                case 2:
                TotalRecargoClienteZona = 100;
                break;
                case 3:
                TotalRecargoClienteZona = 150;
                break;
            }
      

           
            //Recargo por Tipo de Servicio
            decimal RecargoPorTipoDeServicio = TotalRecargoClienteZona + TotalRecargoPorPeso;
            switch(TipoDeServicio)
            {
                case 1:
                RecargoPorTipoDeServicio = 0;
                break;
                case 2:
                RecargoPorTipoDeServicio = RecargoPorTipoDeServicio + (RecargoPorTipoDeServicio*0.25m);
                break;
                case 3:
                RecargoPorTipoDeServicio = RecargoPorTipoDeServicio + (RecargoPorTipoDeServicio*0.50m);
                break;
            }
        
            
            decimal RecargoPorSeguro = 0;
            //Recargo por Seguro
            if(ValorDeclarado>5000)
            {
                RecargoPorSeguro = RecargoPorSeguro + (ValorDeclarado*0.02m);
            }
            else
            {}
        

           decimal Descuento = 0;
            //Descuento
            if(SubTotal > 700)/*El subtotal va a ser igual a el valor declarado debido 
            a que el ejercicio no pide una selección de mas productos entonces no es necesario mas código*/
            {
                Descuento = Descuento + (Descuento*0.05m);
            }
         

        #endregion

        Total = SubTotal + RecargoPorSeguro + RecargoPorTipoDeServicio + TotalRecargoClienteZona + TotalRecargoPorPeso - Descuento;
        string TipodeEnvio = ValorDeclarado>5000 ? "Envío Asegurado" : "Envio sin seguro";
            //Recibo
        Console.WriteLine("----REGISTRO DE TRANSACCIONES REALIZADAS----\n"
        +$"Recargo por peso: {TotalRecargoPorPeso}\n"
        +$"Recargo por zona: {TotalRecargoClienteZona}\n"
        +$"Recargo por servicio: {RecargoPorTipoDeServicio}\n"
        +$"Recargo por seguro: {RecargoPorSeguro}\n"        
        +$"Descuento: {Descuento}\n"
        +$"Subtotal: {SubTotal}\n"
        +$"Total: {Total}\n"

        +$"Tipo de envío:{TipodeEnvio}\n"
        );

            

            
            
            
            
            
        }

    
    }

}