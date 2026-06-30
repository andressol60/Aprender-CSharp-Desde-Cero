namespace _06.POO_ClasesYObjetos
{
    public class Operaciones_matematicas
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public Operaciones_matematicas()
        {

        }

        public Operaciones_matematicas(int num1, int num2)
        {
            Numero1 = num1;
            Numero2 = num2;
        }

        public int suma()
        {
            return Numero1 + Numero2;
        }

        public int resta()
        {
            return Numero1 - Numero2;
        }

        public int multiplicacion()
        {
            return Numero1 * Numero2;
        }

        public double division()
        {
            return (Numero1 / Numero2);
        }
    }
}
