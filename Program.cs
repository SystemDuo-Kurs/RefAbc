List<string> lista = new();

lista.Add("asd");
lista.Add("qwe");

int broj = 5;
Foo(broj);
Console.WriteLine(broj);

int[] brojevi = { 5 };
Bar(brojevi);
Console.WriteLine(brojevi[0]);

void Bar(int[] niz)
{
    niz[0]++;
}

void Foo(int broj)
{
    broj++;
}