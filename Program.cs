
Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());

int [] array = GetArray(size);
Console.WriteLine(String.Join(", ", array));


int [] copyarray = GetArray(array);
Console.WriteLine(String.Join(", ", array));

int [] GetArray(int size)
{

int [] array1 = new int [size];

for(int i = 0; i <size;i++)
{
    array1[i] = new Random().Next(100);
}
return array1;

}

int [] CopyArray(int[] array)
{
int[] res = new int [array.Length];

for(int i = 0; i<array.Length;i++)
{
    res[i]=array[i];
}
return res;

}