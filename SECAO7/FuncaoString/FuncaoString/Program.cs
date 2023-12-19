var original = "abcde FHIJ ABC abc DEFG    ";

string maiusculo = original.ToUpper();
string minusculo = original.ToLower();
string trim = original.Trim();
int n1 = original.IndexOf("bc");
int n2 = original.LastIndexOf("bc");
string recortar = original.Substring(3);
string recortarAte = original.Substring(3, 5);
string replaceChar = original.Replace('a', 'x');
string replaceStr = original.Replace("bc", "opa");
bool isNull = string.IsNullOrEmpty(original);
bool whiteSpace = string.IsNullOrWhiteSpace(original);


Console.WriteLine($"Original: -{original}-");
Console.WriteLine($"ToUpper: -{maiusculo}-");
Console.WriteLine($"ToLower: -{minusculo}-");
Console.WriteLine($"Trim: -{trim}-");
Console.WriteLine($"IndexOf(bc): -{n1}-");
Console.WriteLine($"LastIndexOf(bc): -{n2}-");
Console.WriteLine($"Substring(3): -{recortar}-");
Console.WriteLine($"Substring(3,5): -{recortarAte}-");
Console.WriteLine($"ReplaceChar(a , x): -{replaceChar}-");
Console.WriteLine($"ReplaceStr(bc , opa): -{replaceStr}-");
Console.WriteLine($"IsNull: -{isNull}-");
Console.WriteLine($"IsNullOrWhiteSpace: -{whiteSpace}-");
