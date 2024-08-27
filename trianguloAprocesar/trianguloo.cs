

namespace trianguloAprocesar
{
  public class trianguloo
   {
        public void procesada()
        {
            int triangulo = 0;
            decimal basee = 0;
            decimal altura = 0;
            int contador = 1;
            decimal area = 0;
            int mayorunidad = 0;
            try
            {
                Console.WriteLine($"ingrese la cantidad de triangulo a procesar");
                triangulo = Convert.ToInt32(Console.ReadLine());

                while (contador <= triangulo)
                {
                    Console.WriteLine($"ingrese la base del traingulo: {contador}");
                    basee = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine($"ingrese la altura del traingulo: {contador}");
                    altura = Convert.ToDecimal(Console.ReadLine());
                    area = (basee / 2) * altura;
                    Console.WriteLine($"esta es la base: {basee} y la altura : {altura} y su area es: {area} ");
                    if (area > 12)
                    {
                        mayorunidad++;
                    }
                    contador++;
                }
                if (area > 12)
                {
                    Console.WriteLine($"triangulo con su area mayor a 12 unidades {mayorunidad}");

                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"error de formatos {ex.Message}");

            }
            catch (Exception e)
            {
                Console.WriteLine($"error {e.Message}");
            }
        }
   }
}
