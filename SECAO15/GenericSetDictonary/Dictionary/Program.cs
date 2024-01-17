using System.Collections.Generic;

Dictionary<string, string> cookies = new Dictionary<string, string>();
cookies["user"] = "maria";
cookies["email"] = "maria@gmail.com";
cookies["phone"] = "99712234";
cookies["phone"] = "93737388";
Console.WriteLine(cookies["email"]);
Console.WriteLine(cookies["phone"]);

cookies.Remove("email");

if (cookies.ContainsKey("email"))
{
    Console.WriteLine(cookies["email"]);
}
else
{
    Console.WriteLine("There is no 'email' key");
}

Console.WriteLine("size: " + cookies.Count);

Console.WriteLine("ALL COOKIES:");
foreach(KeyValuePair<string, string> kvp in cookies)
{
    Console.WriteLine(kvp.Key + ": " + kvp.Value);
}
