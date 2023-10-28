internal class Program
{
    private static void Main(string[] args)
    {
Console.Write("Введите количество элементов в массиве: "); 
int count = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(); 
 
int[] values = new int[count]; 
 
for(int i = 0; i < values.Length; i++) { 
    values[i] = i + 100; 
} 
 
for(int i = 0; i < values.Length; i++) { 
    Console.WriteLine($"Значение массива под индексом {i} равно {values[i]}"); 
}
}
    }
