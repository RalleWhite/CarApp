Console.WriteLine("Indtast Bilmærke:");

string brand = Console.ReadLine();

Console.WriteLine("Indtast Bilmodel:");

string model = Console.ReadLine();

Console.WriteLine("Indtast Årgang:");

int year = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Indtast Geartype (A eller M:)");

char gearType = Console.ReadLine()[0];

Console.Write("Indtast nuværende kilometerstand: ");

double nuvaerendeKilometer = Convert.ToDouble(Console.ReadLine());

Console.Write("Indtast antal kilometer kørt på denne tur: ");

double koerteKilometer = Convert.ToDouble(Console.ReadLine());

Console.Write("Indtast bilens brændstofforbrug (km per liter): ");

double forbrug = Convert.ToDouble(Console.ReadLine());

Console.Write("Indtast benzinprisen per liter (DKK): ");

double benzinPris = Convert.ToDouble(Console.ReadLine());



double nyKilometerstand = nuvaerendeKilometer + koerteKilometer;

double literNødvendig = koerteKilometer / forbrug;

double totalPris = literNødvendig * benzinPris;



Console.WriteLine($"Ny kilometerstand: {nyKilometerstand:F2} km");

Console.WriteLine($"Du skal bruge {literNødvendig:F2} liter benzin.");

Console.WriteLine($"Den samlede brændstofpris bliver {totalPris:F2} DKK.");

Console.WriteLine("\n\nBilmærke:" + brand);

Console.WriteLine("\n\nBilmodel:" + model);

Console.WriteLine("\n\nÅrgang:" + year);

Console.WriteLine("\n\nGeartype:" + gearType);





Console.WriteLine("\n Fars drømmebil er en " + brand + " " + model + " fra " + year + "  som har  " + gearType + " geartype");

Console.ReadLine(); /* Wait for user input to exit program */