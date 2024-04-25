using static System.Console;
class AddRandomArrays
{
    static void Main()
    {
        Random random = new Random();
        List<int[]> arrayOfArrays = new List<int[]>();
        int numOfArrays = random.Next(2, 11);
		

        for(int i =0; i<numOfArrays;i++)
        {
            int sizeOfArray = random.Next(1,11);
            arrayOfArrays.Add(CreateArray(random, sizeOfArray));
        }


        DisplayAndSum(arrayOfArrays);
        WriteLine("There are {0} arrays.", numOfArrays);


    }

    static int[] CreateArray(Random random, int sizeOfArray)
    {
        int[] array = new int[sizeOfArray];
        for(int j = 0; j<sizeOfArray;j++)
        {
            array[j] = random.Next(0,501);
        }
        return array;
    }

    static void DisplayAndSum(List<int[]> arrayOfArrays)
    {
        long totalSum = 0;
        for (int i = 0; i < arrayOfArrays.Count; i++)
        {
            int[] array = arrayOfArrays[i]; 
            WriteLine("Array #{0}:", i+1);
            long arraySum = 0;
            foreach (int number in array)
            {
                Write(number + " ");
                arraySum += number;
            }
            totalSum += arraySum; 
            WriteLine("\nSum of this array: " + arraySum); 
            WriteLine();
        }
        WriteLine("Total sum of all numbers in the arrays: " + totalSum);
    }
}