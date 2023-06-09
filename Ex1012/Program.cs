using System;
using System.Globalization;


/*
 Make a program that reads three floating point values: A, B and C. Then, calculate and show:
a) the area of the rectangled triangle that has base A and height C.
b) the area of the radius's circle C. (pi = 3.14159)
c) the area of the trapezium which has A and B by base, and C by height.
d) the area of ​​the square that has side B.
e) the area of the rectangle that has sides A and B.

Input
The input file contains three double values with one digit after the decimal point.

Output
The output file must contain 5 lines of data. Each line corresponds to one of the areas described above, always with a corresponding 
message (in Portuguese) and one space between the two points and the value. The value calculated must be presented with 3 digits after 
the decimal point.
 */
class URI {

    static void Main(string[] args) {

        string[] entrada = Console.ReadLine().Split(' ');
        double a = double.Parse(entrada[0], CultureInfo.InvariantCulture);
        double b = double.Parse(entrada[1], CultureInfo.InvariantCulture);
        double c = double.Parse(entrada[2], CultureInfo.InvariantCulture);

        double t = (a * c) / 2;
        double circ = 3.14159 * c * c;
        double trap = ((a + b) / 2) * c;
        double quad = b * b;
        double ret = a * b;

        Console.WriteLine("TRIANGULO: " + t.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + circ.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + trap.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + quad.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + ret.ToString("F3", CultureInfo.InvariantCulture));

    }

}