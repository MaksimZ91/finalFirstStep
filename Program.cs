Console.Clear();

string[] asd (int count, string[] arr)
{
  string [] array = new string[count];
  int i = 0;
  while (i < count)
  {
    for (int j = 0; j <= arr.Length-1; j++)
    {
      if(arr[j].Length <= 3)
      {
        array[i] = arr[j];
        i++;
      }      
    }    
  } 
  return array;
}

Console.Write("Введите количество строк:  ");
int n = Convert.ToInt32(Console.ReadLine());
string [] array = new string[n];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
  Console.Write("Введите значение строки:  ");
  array[i] = Console.ReadLine(); 
  if (array[i].Length <= 3)
  count++;
}
Console.WriteLine("Исходный массив: [ " + string.Join(", ", array) + " ]");
Console.WriteLine("Результат: [ " + string.Join(", ", asd(count, array)) + " ]");