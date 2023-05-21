using System.Diagnostics;

namespace LAB2728;

public class Expression
{
    private double a, b, c, d;

    public Expression()
    {
        
    }
    public Expression(double a, double b, double c, double d)
    {
        if (4 * b - c <= 0)
        {
            throw new Exception($"\nВід'ємне значення логарифма!\n(4 * {b} - {c}) <= 0");
        }

        if (b + c / d - 1 == 0)
        {
            throw new Exception($"\nДілення на ноль!\n({b} + {c} / {d} - 1) = 0");
        }

        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
    }

    public double GetResult()
    {
        return (Math.Log10(4 * b - c) * a) /( b + c / d - 1);
    }
}