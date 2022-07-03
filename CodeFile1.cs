public class Triangulo
{
    private double baseTri;
    private double alturaTri;
    private double ladoTri;

    private string ladoMayor;
    public Triangulo() { }

    public Triangulo(double alturaTri, double baseTri, double ladoTri)
    {
        this.baseTri = baseTri;
        this.alturaTri = alturaTri;
        this.ladoTri = ladoTri;
    }

    public double Area(double alturaTri, double baseTri)
    {
        return ((baseTri * alturaTri)/2);
    }

    public bool EsEquilatero(double alturaTriangulo, double baseTriangulo, double ladoTriangulo)
    {
        if (ladoTriangulo == alturaTriangulo)
        {
            if (ladoTriangulo == baseTriangulo)
            {
                //Console.WriteLine("El triángulo es equilatero");
                return true;
            }
            return false;
        }
        else
        {
            return false;
        }
    }

    public string LadoMayor(double alturaTriangulo, double baseTriangulo, double ladoTriangulo)
    {
        if (ladoTriangulo > baseTriangulo)
        {
            if (ladoTriangulo > alturaTriangulo)
            {
                ladoMayor = "El lado mayor es el Lado del triángulo: " + ladoTriangulo;
                return ladoMayor;
            }
            else
            {
                ladoMayor = "El lado mayor es la altura del triángulo: " + alturaTriangulo;
                return ladoMayor;
            }
        }
        else
        {
            if (baseTriangulo > alturaTriangulo)
            {
                ladoMayor = "El lado mayor es la base del triángulo: " + baseTriangulo;
                return ladoMayor;
            }
            else
            {
                ladoMayor = "El lado mayor es la altura del triángulo: " + alturaTriangulo;
                return ladoMayor;
            }
        }
    }


}