namespace promedio
{
    public class Promedio
    {
        private double _eva1, _eva2, _eva3, Acti;
        private string nombre;

        public Promedio(double eva1, double eva2, double eva3, string Nombre)
        {
            this._eva1 = eva1;
            this._eva2 = eva2;
            this._eva3 = eva3;
            this.nombre = Nombre;
        }


        public double CALCUNOTA1(double nota1)
        {
            double eva15 = (nota1 * 15) / 100;

            return eva15;
        }

        public double CALCUNOTA2(double nota2)
        {
            double eva15 = (nota2 * 1.20) / 100;

            return eva15;
        }

        public double CALCUNOTA3(double nota3)
        {
            double eva15 = (nota3 * 2.25) / 100;

            return eva15;
        }

        public double CALCU_Acti(double acti)
        {
            double eva15 = (acti * 10) / 100;

            return eva15;
        }

        public double CalcularPromedio(double nota1, double nota2, double nota3)
       {
            double promedio =(nota1 +  nota2 + nota3) / 3.0;

            return promedio;
        }



    }
}