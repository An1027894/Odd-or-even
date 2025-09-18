using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
// let the user choose a number
Console.WriteLine("Choose a number");
int x = Convert.ToInt32(Console.ReadLine());

// it will moded by 2 equal 0 to see it even
if (x % 2 == 0){
    // if it does equal even it will tell the user that the naumber is even
    Console.WriteLine("It even!");
}
// if the number is not even then it will run the number through this code blew
//It will moded the number by 1 to see if it squal to 0 if it does then it odd
else if (x % 1 == 0){

    // then it will tell the user the number is even
    Console.WriteLine("It odd!");
}