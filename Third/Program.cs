


using Third;

Product Phone = new(150, 90, 120);

Console.WriteLine("h");




Console.WriteLine();
Console.WriteLine("===============================================");
Console.WriteLine();

Person people = new Person();

Console.WriteLine("Kāds ir Jūsu vārds");
string peoplename = Console.ReadLine();

Console.WriteLine("Kāds ir Jūsu uzvārds");
string peoplesurname = Console.ReadLine();

Console.WriteLine("Kāds ir Jūsu hobijs");
string peoplehobby = Console.ReadLine();

Console.WriteLine("Kādi ir Jūsu dzimšanas datumi dd.mm.yyyy?");
string birthDateText = Console.ReadLine();
people.BirthDate = DateTime.Parse(birthDateText);

people.Name = "peoplename";
people.Surname = "peoplesurname";
people.Hobby = "peoplehobby";
people.Gender = true;

int v = people.GetAge(DateTime.Now);


Console.WriteLine();
Console.WriteLine("===============================================");
Console.WriteLine();

Car auto = new Car();
auto.Brand = "Opel";
auto.NumberPlate = "BG1010";
auto.Speed = "140";
var autoName = auto.Brand;
Console.WriteLine($"Car Brand name:{autoName}");
