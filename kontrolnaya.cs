void PrintArray(string[] array)
{
for(int c = 0;c < array.Length; c++)
{
Console.Write(array[c]);
Console.Write(", ");
}
}

string[] Zapros ()
{
Console.WriteLine("Введите значения через запятую в одну строку: ");
string Zapros = Console.ReadLine();
string[] Zapros_array = (Zapros.Split(","));
return Zapros_array;
}


