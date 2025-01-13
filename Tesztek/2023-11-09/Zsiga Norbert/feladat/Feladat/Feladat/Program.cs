int starterValue = 0;
int enderValue = 0;
bool isNumber = false;
int sum = 0;
int numberOfNumbers = 0;
double avarage = 0;
int numberOfOddNumbers = 0;
int copyStarterValue = 0;
bool evenAndCanBeDividedWith7 = false;
string numbersThatCanBeDevidedWith7= "";

do
{
    Console.Write("Kérek egy kezdőértéket: ");
    string input = Console.ReadLine();
    isNumber = int.TryParse(input, out starterValue);
}
while (!isNumber);

do
{
    Console.Write("Kérek egy végértéket, ami nagyobb a kezdőértéknél: ");
    string input = Console.ReadLine();
    isNumber = int.TryParse(input, out enderValue);
}
while (!isNumber || enderValue <= starterValue);

// feladat 1

for (int i = starterValue; i < enderValue; i++)
{
    sum += i;
}

Console.WriteLine($"{starterValue} és {enderValue} között a számok összege: {sum}");

// feladat 2

numberOfNumbers = enderValue - starterValue ;
avarage =(double)( sum)/ (double)(numberOfNumbers);
Console.WriteLine($"A {starterValue} és a {enderValue} közti számok átlaga: {avarage}.");

// feladat 3
if(starterValue % 2 ==0)
{
    copyStarterValue = starterValue + 1;
}
else
{
    copyStarterValue = starterValue;
}

for (int i = copyStarterValue;i < enderValue;i+=2)
{
    numberOfOddNumbers++;

}

Console.WriteLine($"A {starterValue} és a {enderValue} közti páratlan számok száma: {numberOfOddNumbers}.");

// feladat 4

if (starterValue % 3 == 1)
{
    copyStarterValue = starterValue + 2;
}
else if(starterValue % 3 == 2)
{
    copyStarterValue = starterValue + 1;
}
else
{
    copyStarterValue = starterValue;
}

Console.WriteLine($"A {starterValue} és a {enderValue} közti hárommal osztható számok:");
for  (int i = copyStarterValue; i < enderValue;i+=3)
{
    Console.Write($"{i}, ");
}

//feladat 5

if (starterValue % 2 == 1)
{
    copyStarterValue = starterValue + 1;
}
else
{
    copyStarterValue = starterValue;
}

for (int i = copyStarterValue; i < enderValue;i+=2)
{
    if(i % 7 == 0)
    {
        evenAndCanBeDividedWith7 = true;
        numbersThatCanBeDevidedWith7 += i + ";" ;
    }
}

Console.WriteLine();

if(evenAndCanBeDividedWith7)
{
    Console.WriteLine($"A {starterValue} és a {enderValue} közt van héttel osztható páros szám, ezek: {numbersThatCanBeDevidedWith7}");
}
else
{
    Console.WriteLine($"A {starterValue} és a {enderValue} közt nincs héttel osztható páros szám");
}