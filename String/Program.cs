﻿string original = "abcde FGHIJ ABC abc DEFG    ";

//ToUpper muda todos os caracteres da string para maiúsculo
string s1 = original.ToUpper();

//ToUpper muda todos os caracteres da string para minusculo
string s2 = original.ToLower();

//Trim acabada com os espaços em branco da string
string s3 = original.Trim();

int n1 = original.IndexOf("bc");

int n2 = original.LastIndexOf("bc");

string s4 = original.Substring(3);

string s5 = original.Substring(3, 5);

string s6 = original.Replace('a', 'x');

string s7 = original.Replace("abc", "yx");

bool b1 = string.IsNullOrEmpty(original);
bool b2 = string.IsNullOrWhiteSpace(original);


Console.WriteLine("Original: -" + original + "-");
Console.WriteLine("ToUpper: " + s1 + "-");
Console.WriteLine("ToLower: " + s2 + "-");
Console.WriteLine("Trim: " + s3 + "-");
Console.WriteLine("IndexOf('bc): -" + n1);
Console.WriteLine("LastIndexOf('bc): -" + n2);
Console.WriteLine("Substring(3): -" + s4);
Console.WriteLine("Substring(3, 5): -" + s5);
Console.WriteLine("Replace(a,x) -" + s6);
Console.WriteLine("Replace(abc, yx) -" + s7);
Console.WriteLine("IsNullOrEmpty " + b1);
Console.WriteLine("IsNullOrWhiteSpace " + b2);





