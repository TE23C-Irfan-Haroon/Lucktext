string name;

Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor =ConsoleColor.Black;
Console.Clear();

Console.WriteLine("Write your name: ");
name = Console.ReadLine();

// Console.WriteLine("Hello " + name + "!");
Console.WriteLine($"Hello {name}!");

string age;

Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor =ConsoleColor.Red;
Console.Clear();

Console.WriteLine("Write your age: ");
age = Console.ReadLine();

string city;

Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor =ConsoleColor.White;
Console.Clear();

Console.WriteLine("Write the place you live: ");
city = Console.ReadLine();

string sport; 

Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor =ConsoleColor.Red;
Console.Clear();

Console.WriteLine("Write your favourite sports: ");
sport = Console.ReadLine();

string food; 

Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor =ConsoleColor.White;
Console.Clear();

Console.WriteLine("Write your favourite food: ");
food = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor =ConsoleColor.Black;
Console.Clear();


// Console.WriteLine("Hello, my name is " + name + " and i am " + age + " years old. I live in a place called " + city " and i love playing " + sport + ", but because i eat too much " + food + " i can't play it anymore.")
Console.WriteLine($"Hello, my name is {name} and i am {age} years old. I live in a place called {city} and i love playing {sport}, but because i eat too much {food} i got injured and can't play it anymore.");

Console.ReadLine();

