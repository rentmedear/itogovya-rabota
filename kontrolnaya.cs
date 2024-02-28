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

string[] Len_array()
{
string[] array = Zapros();
string new_string = String.Empty;
for(int count = 0;count<array.Length;count++)
{
if(array[count].Length <= 3)
{
new_string=new_string+array[count]+",";
}
}
new_string = new_string.Remove(new_string.Length-1);
string[] new_array = new_string.Split(",");
return new_array;
}
PrintArray(Len_array());
