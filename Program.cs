Random random = new Random();
int minRandomNumber = 0;
int maxRandomNumber = 100;
int numbersInArray = 40;
int[] numbers = new int[numbersInArray];
int[] tempNumbers = new int[numbersInArray];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(minRandomNumber, maxRandomNumber);
}

for (int j = 0; j < numbers.Length; j++)
{
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        if (numbers[i] > numbers[i + 1])
        {
            tempNumbers[i] = numbers[i];
            numbers[i] = numbers[i + 1];
            numbers[i + 1] = tempNumbers[i];
        }
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}