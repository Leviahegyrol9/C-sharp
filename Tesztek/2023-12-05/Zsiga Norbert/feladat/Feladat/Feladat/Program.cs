using ExtendedConsole;
using ExtendedMath;

double mass = ConsoleExtension.ReadDouble("Kérem a tömegét kg-ban: ", 1);
double lenght = ConsoleExtension.ReadDouble("Kérem a magasságát m-ben: ", 1);

double bmi = MathFunction.BmiCalculator(mass, lenght);

double bmiConverted = (Math.Round(bmi * 100)) / 100;

Console.WriteLine($"A {mass}kg és {lenght}m BMI értéke {bmiConverted}.");

string bmiResult = bmi switch
{
    <18.5 => "sovány",
    <25 => "normál testsúly",
    <30 => "túlsúly",
    _=>"elhízás"
};

Console.WriteLine($"A BMI index alapján Ön {bmiResult}!");