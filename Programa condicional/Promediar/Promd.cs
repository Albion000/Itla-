namespace Programa_condicional.Promediar
{
    public class Promd
    {

        public void Promediar()
        {
            ///Variables
            int calf1 = 0;
            int calf2 = 0;
            int calf3 = 0;
            decimal Result = 0;
            int aprobado = 70;
            int division = 3;
            /// colocamos el verificador de errores.
             // Verificador de errores.
            try
            {
                // Solicitud de datos.
                Console.Write("Ingresar la primera calificación: ");
                calf1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar la segunda calificación: ");
                calf2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar la tercera calificación: ");
                calf3 = Convert.ToInt32(Console.ReadLine());

                // Operación de logica matematica para el programa.
                Result = (calf1 + calf2 + calf3) / division;

                // logica de aprobacion.
                if (Result >= aprobado)
                {
                    Console.WriteLine($"Usted ha sido aprobado: {Result:c}");
                }
                else
                {
                    Console.WriteLine($"Usted no ha sido aprobado: {Result:c}");
                }
            }  ///Explicacion del valor incorrecto.
            catch (FormatException)
            {
                Console.WriteLine("Error: Se ha ingresado un valor no numérico. Por favor, ingrese números enteros.");
            }
        }
    }
}
