class Program
{
	static void  Main ()
	{
		int numberticket = Convert.ToInt32(Console.ReadLine());
		switch(numberticket)
		{
			case 1: //Zадайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
				{
					int temprezult=0;
					Random random = new Random();
					int[] array = new int[random.Next(5,10)]; 
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = random.Next(100,999);
						if (array[i]%2==0)
						{
							temprezult++;
						}
					}
					Console.WriteLine(temprezult);
				}
				break;
			case 2://Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
				{
					int tempresult = 0;
					Random random = new Random();
					int[] array = new int[random.Next(5, 10)];
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = random.Next();
						if (i%2>0) 
						{
							tempresult += array[i]; 
						}
					}
					Console.WriteLine(tempresult);
				}
				break;
			case 3://Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
				{
					Random random = new Random();
					double[] doublearray = new double[random.Next(5, 10)];
					for (int i =0; i < doublearray.Length; i++)
					{
						doublearray[i] = random.NextDouble();
					}
					double min = doublearray[0];
					double max = doublearray[0];
					for (int i = 0; i < doublearray.Length; i++)
					{
						if (doublearray[i] < min)
						{
							min = doublearray[i];
						}
						if (doublearray[i]>max)
						{
							max = doublearray[i];
						}

					}
					Console.WriteLine($" разницa между максимальным и минимальным элементов массива {(max - min):F2}");
				}
				break;
		}


	}
}