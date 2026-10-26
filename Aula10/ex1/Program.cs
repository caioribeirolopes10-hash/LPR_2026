using System;

class retangulo
{
    public double L;
    public double A;

    public double Area()
    {
        double area = (A * L);
        Console.WriteLine("Área: " + area);
        return area;
    }
    public double Perimetro()
    {
        double perimetro = (2 * (A + L));
        Console.WriteLine("Perímetro: " + perimetro);
        return perimetro;

    }
}
