


using Third;

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

people.Name = peoplename;
people.Surname = peoplesurname;
people.Hobby = peoplehobby;
people.BirthDate = birthDateText;
people.Gender = true;

people.GetAge(birthDateText);
