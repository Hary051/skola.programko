// See https://aka.ms/new-console-template for more information
using System.Collections.Specialized;

Console.WriteLine("Hello, World!");
int x;
x = 2;

int y = 3;
//sázíme stromy
/*tohle
 * je 
 * dobrý
 */

Console.WriteLine(x);
Console.WriteLine(y);

string name= "Haryjos";
Console.WriteLine("ahoj " + name);
Console.WriteLine("ahoj, {0}", name);




double a = 21;
double b = 36;
double z = b/ a;
Console.WriteLine("{0}+{1}={2}", a,b,a+b);
Console.WriteLine("{0}-{1}={2}", a, b, a -b);
Console.WriteLine("{0}*{1}={2}", a, b, a * b);
Console.WriteLine("{0}/{1}={2}", a, b, z);
Console.WriteLine($"{a}/{b} ={a/b}");
//$ Alt gr+ů

//přetypování proměnné
double john = a / b;
Console.WriteLine(john);
int johnint = (int)john;
Console.WriteLine(johnint);

//boolean true or false

bool bull1 = true;
bool bull2 = false;
Console.WriteLine("{0}&&{1}={2}", bull1, bull2,bull1&&bull2);
//& alt gr+c
Console.WriteLine("{0}||{1}={2}", bull1, bull2, bull1 || bull2);
// | shift+vedle levého shiftu
Console.WriteLine("{0}!{1}={2}", bull1, bull2, bull1,!bull2);

bool jetotricetsedum = b == 37;
Console.WriteLine(jetotricetsedum);

//vstup od uživatele
Console.WriteLine("jmeno:");
string jmeno=Console.ReadLine();
Console.WriteLine("Nazdar "+jmeno);

String cislouzivatele=Console.ReadLine();
int cislohotovo;
int.TryParse(cislouzivatele, out cislohotovo);
Console.WriteLine(cislohotovo+30);
bool succes = int.TryParse(cislouzivatele, out cislohotovo);

Console.WriteLine("succes "+succes);