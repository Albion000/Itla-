namespace Programa_condicional.MinusPlus
{
    public class MinusPlus
    {
        public void mInusPlus()
        {
            // Declarar variables
            int num1 = 0;
            int num2 = 0;
            decimal Resultado = 0;

            try
            {
                // Solicitud de datos
                Console.Write("Ingresar el primer número: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingresar el segundo número: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                // Lógica de comparación y cálculo
                if (num1 > num2)
                {
                    Resultado = num1 + num2;
                    Console.WriteLine($"El resultado de la suma es: {Resultado:c}");

                    Resultado = num1 - num2;
                    Console.WriteLine($"El resultado de la resta es: {Resultado:c}");
                }
                else
                {
                    Resultado = num1 * num2;
                    Console.WriteLine($"El resultado del producto es: {Resultado:c}");

                    if (num2 != 0)
                    {
                        Resultado = (decimal)num1 / num2;
                        Console.WriteLine($"El resultado de la división es: {Resultado:c}");
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero.");
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Se ha ingresado un valor no numérico. Por favor, ingresa números enteros.");
            }
        }
    }
}

