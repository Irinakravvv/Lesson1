Console.WriteLine("Введите число");

string input = Console.ReadLine(); // Ввод

int number = int.Parse (input); //Число

// if ( int.TryParse(input))

int square = number * number; // квадрат

Console.WriteLine($"Число в квадрате равно {square}");
