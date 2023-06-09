using System;


//read two integer values, in this case, the variables a and b. after this, calculate the sum between them and assign it to the variable soma. 
//write the value of this variable.
//input
//the input file contains 2 integer numbers.

//output
//print the message "soma" with all the capital letters, with a blank space before and after the equal signal followed by the corresponding 
//value to the sum of a and b. like all the problems, don't forget to print the end of line, otherwise you will receive "presentation error"

class URI {
    static void Main(string[] args) {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine("SOMA = " + (x + y));
    }
}