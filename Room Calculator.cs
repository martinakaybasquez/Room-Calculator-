Console.WriteLine("Welcome to GC's Room Detail Generator!");

Console.WriteLine();

// something that you noticed is that if your value is a double/int/etc it has to remain consistent throughout assigning 
Console.Write("What is the length of your room? ");
double length = double.Parse(Console.ReadLine());

Console.WriteLine();

Console.Write("What is the width of your room? ");
double width = double.Parse(Console.ReadLine());

Console.WriteLine();

Console.Write("What is the height of your room? ");
double height = double.Parse(Console.ReadLine());



Console.WriteLine();

double recArea = length * width;
double squArea = width * height;
double tears = height * length;
double recPerimeter = 2 * (length + width);
double recVolume = length * width * height;
double recSurfaceArea = 2 * (recArea + squArea + tears);
Console.WriteLine($"The perimeter of your room is {recPerimeter}.");
Console.WriteLine($"The volume of your room is {recVolume}.");
Console.WriteLine($"The surface area of your room is {recSurfaceArea}");
Console.WriteLine($"The area of your room is {recArea}. Which makes you a...");
if (recArea <= 250)
{
    Console.WriteLine("You are a peasant and your room is small.");
}
else if (recArea > 250 && recArea < 650)
{
    Console.WriteLine("You are a blue collar individual in medium house.");
}
else if (recArea >= 650)
{
    Console.WriteLine("You are a king and live in a lavish large house.");
}

// Console.WriteLine(recArea);
// Console.WriteLine(recPerimeter);
// Console.WriteLine(recVolume);
// Console.WriteLine(recSurfaceArea);


