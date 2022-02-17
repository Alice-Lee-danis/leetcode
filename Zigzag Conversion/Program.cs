string a = "ПРРРРРПРРРРРПРРРРРПРРРРРПРРРРРП";
int f = 7;

for(int i = -1; i < a.Length; i++)
{
    Console.WriteLine(a[i] + " " + a[f * 2 - 2] + " " + a[f * 4 - 4]);
}

Console.WriteLine(a[0] + " " + a[f * 2 - 2] + " " + a[f * 4 - 4]);