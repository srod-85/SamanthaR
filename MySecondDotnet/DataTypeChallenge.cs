int i = 2001;
byte b = 100;
short s = -32;
long l = 33333333333333333;
float f = 1.02f;
double dbl = 85.6;
bool res = true;
char c = 'c';

string s1 = "I control test";
string s2 = "25";
int s3;
res = int.TryParse(s2, out s3);
s3 = int.Parse(s2);
if(res) {
    Console.WriteLine("String 2 \"25\" was parsed to integer " + s3);
}
else {
    Console.WriteLine("String 2 could not be parsed to an integer.");
}
Console.WriteLine("String 1 says: " +s1);
Console.WriteLine("\n int i = " + i);
Console.WriteLine("\n byte b = " + b);
Console.WriteLine("\n short s = " + s);
Console.WriteLine("\n long l = " + l);
Console.WriteLine("\n float f = " + f);
Console.WriteLine("\n double dbl = " + dbl);
Console.WriteLine("\n bool res = " + res);
Console.WriteLine("\n char c = " + c);



