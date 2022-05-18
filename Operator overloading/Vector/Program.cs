using System;

struct Vector
{
    int x;
    int y;
    int z;
    public Vector(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public override string ToString()
    {
        return "X: " + x + " Y: " + y + " Z: " + z;
    }
    public static Vector operator +(Vector w)
    {
        return new Vector(w.x, w.y, w.z);
    }
    public static Vector operator -(Vector w)
    {
        return new Vector(-w.x, -w.y, -w.z);
    }
    public static Vector operator *(Vector w, int n)
    {
        return new Vector(w.x * n, w.y * n, w.z * n);
    }
    public static Vector operator /(Vector w, int n)
    {
        return new Vector(w.x / n, w.y / n, w.z / n);
    }
    public override bool Equals(object obj)
    {
        if (obj == null)
            return false;
        else if (obj is Vector)
        {
            if (x == ((Vector)obj).x && y == ((Vector)obj).y && z == ((Vector)obj).z)
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
    public static bool operator ==(Vector w, Vector v)
    {
        if (w.x == v.x && w.y == v.y && w.z == v.z)
            return true;
        else
            return false;
    }
    public static bool operator !=(Vector w, Vector v)
    {
        if (w == v)
            return false;
        else
            return true;
    }
    public static double operator ~(Vector w)
    {
        return (double)Math.Sqrt(Math.Pow(w.x, 2) + Math.Pow(w.y, 2) + Math.Pow(w.z, 2));
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Vector w1 = new Vector(1, 2, 3);
        Vector w2 = new Vector(1, 2, 5);
        Vector w3 = new Vector(1, 2, 3);
        Vector w4 = new Vector(2, 4, 6);
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
