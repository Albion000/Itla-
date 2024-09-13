namespace Programa_condicional.preguntas
{
    public class Quest
    {
        public void questions()
        {
            ///variables a declarar
            decimal totalPreguntas = 0;
            decimal CorrectQuest = 0;
            decimal porcentaje = 0;

            ///Solicitar datos
            ///colocar filtro de errores
            try
            {
                Console.Write("Ingresar el numero total de preguntas: ");
                totalPreguntas = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el numero total de respuesta correctas: ");
                CorrectQuest = Convert.ToInt32(Console.ReadLine());

                /// aplicar condicion de verificacion para evitar desajuste...
                if (CorrectQuest > totalPreguntas)
                {
                    Console.WriteLine("El numero de respuesta no debe superar el numero de preguntas");
                    return;
                }

                /// datos de calculo logicos matematica
                porcentaje = (decimal)((CorrectQuest / totalPreguntas) * 100);

                if (porcentaje >= 90)
                {
                    Console.WriteLine("Nivel Maximo");
                }

                else if (porcentaje >= 75)
                {
                    Console.WriteLine("Nivel Intermedio");
                }

                else if (porcentaje >= 50)
                {
                    Console.WriteLine("Bajo Nivel");
                }
                else
                {
                    Console.WriteLine("Fuera del Nivel");
                }
                // Porcentajes
                Console.WriteLine($"Porcentaje de aciertos: {porcentaje:F2}%");





            }

            catch (FormatException)
            {
                Console.WriteLine("Error: Ingresar datos validos.");
            }



        }
    }
}
