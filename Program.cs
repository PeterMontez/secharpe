using System;

char c = 'a';                   //char tem ' '
string str = "Hello, World!";  //string tem " "

// ctrl + ; comenta/descomenta

bool b1 = true;
bool b2 = false;

float f = 2.5f;
float fi = float.PositiveInfinity;
double d = 2.5;
double di = double.NegativeInfinity;
double d3 = double.PositiveInfinity;
double d1 = double.Epsilon; //menor quantidade positiva que a variavel aceita
double d2 = double.NaN;
decimal m = 5.0m;

byte b = 200;
short s = 10000;
int i = 123456;
long l = 12345678990;

sbyte sb = -100;
ushort us = 10000;
uint ui = 123456;
ulong ul = 12345678990;

object obj = str;
string str2 = (string)obj;

int result = (int)(ui + l);

dynamic dy = 8;
dy = "Hello, World!";

var x = "7";

int[] arr = new int[10];    // novo vetor de tamanho 10
object[] objs = new object[100];
var arr2 = new double[3];

arr[0] = 4;
var arr3 = arr[0..2];

int a = int.MaxValue;
int num = unchecked(a + 1);

int? y = null;

if (y.HasValue)
{
    Console.WriteLine("Siiii");
}

Console.WriteLine(y ?? 7);
Console.WriteLine(y.ToString());

string s3 = null;
string s4 = s3?.Replace('a', 'b') ?? "Erro";

Console.WriteLine(s4);