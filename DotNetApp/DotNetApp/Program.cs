// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");


// zad. 1
string name;
string surname;
int age;
string pesel;
string employeeNumber;
char sex;

// zad. 2
char varA = 'a';
char varB = 'b';
char varC = 'c';
Console.WriteLine($"{varC} \r\n{varB} \r\n{varA}");


// zad. 3
double a;
double b;




Console.Write("Proszę podać wysokość boku a prostokąta: ");
bool success = double.TryParse(Console.ReadLine(), out a);

Console.Write("Proszę podać długość boku b prostokąta: ");
bool success2 = double.TryParse(Console.ReadLine(), out b);

if (a > 0 && b > 0)
{
    double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
    Console.WriteLine($"Długość przekątnej prostokąta: {c}");
}
if (success == false)
{
    Console.WriteLine("Podaj poprawne dane dla boku a");

}
if (success2 == false)
{
    Console.WriteLine("Podaj poprawne dane dla boku b");

}



//else if (success == false || success2 == false)
//{
//    Console.WriteLine("Nie można obliczyć przeciwprostokątnej, wprowadź poprawne dane");
//}


//else
// Console.WriteLine("błędnie podane dane"  );






// zad. 4
int varInt = 10;
string text = "Szkoła Dotneta";
double varDouble = 12.5;


// zad. 5


string varSurname;
int varTel;
string email;
double high, weigh;

Console.WriteLine("Podaj imię");
string varName = Console.ReadLine();
Console.WriteLine($"Twoje imię to {varName}");



Console.WriteLine("Podaj nazwisko");

Console.WriteLine("Podaj nr telefonu");




Console.WriteLine("Podaj email");

Console.WriteLine("Podaj wzrost");

Console.WriteLine("Podaj waga");




