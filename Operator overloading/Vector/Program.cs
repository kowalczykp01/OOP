using System;

struct Wektor
{
    int x;
    int y;
    int z;
    public Wektor(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public override string ToString()
    {
        return "X: " + x + " Y: " + y + " Z: " + z;
    }
    public static Wektor operator +(Wektor w)
    {
        return new Wektor(w.x, w.y, w.z);
    }
    public static Wektor operator -(Wektor w)
    {
        return new Wektor(-w.x, -w.y, -w.z);
    }
    public static Wektor operator *(Wektor w, int n)
    {
        return new Wektor(w.x * n, w.y * n, w.z * n);
    }
    public static Wektor operator /(Wektor w, int n)
    {
        return new Wektor(w.x / n, w.y / n, w.z / n);
    }
    public override bool Equals(object obj)
    {
        if (obj == null)
            return false;
        else if (obj is Wektor)
        {
            if (x == ((Wektor)obj).x && y == ((Wektor)obj).y && z == ((Wektor)obj).z)
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
    public static bool operator ==(Wektor w, Wektor v)
    {
        if (w.x == v.x && w.y == v.y && w.z == v.z)
            return true;
        else
            return false;
    }
    public static bool operator !=(Wektor w, Wektor v)
    {
        if (w == v)
            return false;
        else
            return true;
    }
    public static double operator ~(Wektor w)
    {
        return (double)Math.Sqrt(Math.Pow(w.x, 2) + Math.Pow(w.y, 2) + Math.Pow(w.z, 2));
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Wektor w1 = new Wektor(1, 2, 3);
        Wektor w2 = new Wektor(1, 2, 5);
        Wektor w3 = new Wektor(1, 2, 3);
        Wektor w4 = new Wektor(2, 4, 6);
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
