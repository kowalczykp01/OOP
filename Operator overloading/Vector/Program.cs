using System;

struct Vektor
{
    int x;
    int y;
    int z;
    public Vektor(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public override string ToString()
    {
        return "X: " + x + " Y: " + y + " Z: " + z;
    }
    public static Vektor operator +(Vektor w)
    {
        return new Vektor(w.x, w.y, w.z);
    }
    public static Vektor operator -(Vektor w)
    {
        return new Vektor(-w.x, -w.y, -w.z);
    }
    public static Vektor operator *(Vektor w, int n)
    {
        return new Vektor(w.x * n, w.y * n, w.z * n);
    }
    public static Vektor operator /(Vektor w, int n)
    {
        return new Vektor(w.x / n, w.y / n, w.z / n);
    }
    public override bool Equals(object obj)
    {
        if (obj == null)
            return false;
        else if (obj is Vektor)
        {
            if (x == ((Vektor)obj).x && y == ((Vektor)obj).y && z == ((Vektor)obj).z)
                return true;
            else
                return false;
        }
        else
            return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(x, y, z);
    }
    public static bool operator ==(Vektor w, Vektor v)
    {
        if (w.x == v.x && w.y == v.y && w.z == v.z)
            return true;
        else
            return false;
    }
    public static bool operator !=(Vektor w, Vektor v)
    {
        if (w == v)
            return false;
        else
            return true;
    }
    public static double operator ~(Vektor w)
    {
        return (double)Math.Sqrt(Math.Pow(w.x, 2) + Math.Pow(w.y, 2) + Math.Pow(w.z, 2));
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Vektor w1 = new Vektor(1, 2, 3);
        Vektor w2 = new Vektor(1, 2, 5);
        Vektor w3 = new Vektor(1, 2, 3);
        Vektor w4 = new Vektor(2, 4, 6);
        Console.WriteLine(w3 * 2);
        Console.WriteLine();
        Console.WriteLine(w1 == w3);
        Console.WriteLine();
        Console.WriteLine(w1 == w2);
        Console.WriteLine();
        Console.WriteLine(w1 != w3);
        Console.WriteLine();
        Console.WriteLine(~w4);
        Console.WriteLine();
    }
}
