//Zadanie 1
Console.WriteLine("Podaj liczbe, dla ktorej chcesz wyswietlic tabliczke mnozenia:");
int number = int.Parse(Console.ReadLine());

// Tworzenie tablicy dla wynikow mnozenia
int[] tabliczkaMnozenia = new int[10];

// Wypelnianie tablicy wynikami mnozenia
for (int i = 0; i < tabliczkaMnozenia.Length; i++)
{
    tabliczkaMnozenia[i] = number * (i + 1);
}

// Wyswietlanie tabliczki mnozenia
Console.WriteLine($"Tabliczka mnozenia dla liczby {number}");
for (int i = 0; i < tabliczkaMnozenia.Length; i++)
{
    Console.WriteLine($"{number} * {i + 1} = {tabliczkaMnozenia[i]}");
}


//Zadanie 2
int suma = 0;
Console.WriteLine("Wpisuj wybrane liczby calkowite (wprowadzenie liczby ujemnej zakonczy dzialanie tego programu):");

while (true)
{
    Console.WriteLine("Wprowadz liczbe:");
    int liczba = int.Parse(Console.ReadLine());

    // Sprawdzenie, czy wprowadzona liczba jest ujemna
    if (liczba < 0)
    {
        break; // Wyjscie z petli, gdy liczba jest ujemna
    }

    suma += liczba; // Dodanie liczby do sumy, jesli nie jest ujemna
}

Console.WriteLine($"Suma wprowadzonych liczb wynosi: {suma}");

//Zadanie 3
Random randomowa = new Random();
int wylosowanaLiczba = randomowa.Next(1, 11); // Losowanie liczby z zakresu 1-10
int odgadnietaLiczba;

Console.WriteLine("Odgadnij liczbe wylosowana przez program z zakresu od 1 do 10.");

do
{
    Console.WriteLine("Podaj swoja liczbe:");
    odgadnietaLiczba = int.Parse(Console.ReadLine());

    if (odgadnietaLiczba < wylosowanaLiczba)
    {
        Console.WriteLine("Liczba jest za mala. Sprobuj ponownie.");
    }
    else if (odgadnietaLiczba > wylosowanaLiczba)
    {
        Console.WriteLine("Liczba jest za duza. Sprobuj ponownie.");
    }
} while (odgadnietaLiczba != wylosowanaLiczba);

Console.WriteLine("Gratulacje! Zgadles liczbe.");


//Zadanie 4
Console.WriteLine("Dla ilu wartosci chcesz obliczyc srednia arytmetyczna?");
int liczbaWartosci = int.Parse(Console.ReadLine());

double[] wartosci = new double[liczbaWartosci];

for (int i = 0; i < liczbaWartosci; i++)
{
    Console.WriteLine($"Podaj wartosc nr {i + 1}:");
    wartosci[i] = double.Parse(Console.ReadLine());
}

double suma = 0;
foreach (double wartosc in wartosci)
{
    suma += wartosc;
}

double srednia = suma / liczbaWartosci;

Console.WriteLine($"Srednia arytmetyczna podanych wartosci wynosi: {srednia}");