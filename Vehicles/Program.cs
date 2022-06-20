using Vehicles;
using System.Text.Json;

/*
Car myCar = new Car("Clio", Energies.diesel, 4100m);

myCar.NbDoor = 5;


Console.WriteLine(myCar.ToString());
Console.WriteLine(JsonSerializer.Serialize(myCar));
Console.WriteLine(myCar.Description);

Vehicle myMoto = new Moto("Harley", Energies.essence, 4100m);
Console.WriteLine(myMoto.Description);

Console.WriteLine("\n\n");


Vehicle[] arrayVehicle = { myCar, myMoto };

for (int i = 0; i < arrayVehicle.Length; i++)
{
    Console.WriteLine(arrayVehicle[i].Description);
    if (arrayVehicle[i] is Car)
    {
        Car aCar = (Car)arrayVehicle[i];
        Console.WriteLine(aCar.NbDoor);
    }
}
//OU avec un foreach
foreach (Vehicle vehicle in arrayVehicle)
{
    Console.WriteLine(vehicle.Description);
    if (vehicle is Car)
    {
        Car aCar = (Car)vehicle;
        Console.WriteLine(aCar.NbDoor);
    }
}

Console.WriteLine(Math.Round(myCar.GetResalePrice(22000, 1998), 2));


IComparable icar = myCar;
IComparable imoto = myMoto;

Console.WriteLine(icar.CompareTo(imoto));

if (icar is Car)
{
    Car aVehicle = (Car)icar;
    Console.WriteLine(aVehicle.Description);
}
*/

Car myCar1 = new Car("Mégane", Energies.diesel, 22000m);
Car myCar2 = new Car("Sandero", Energies.GPL, 15000m);
Moto myMoto1 = new Moto("Intruder", Energies.essence, 13000m);
Moto myMoto2 = new Moto("Energica", Energies.electric, 25000m);

Dictionary<string, Vehicle> list1 = new Dictionary<string, Vehicle>();
list1[myCar1.Name] = myCar1;
list1[myCar2.Name] = myCar2;
list1[myMoto1.Name] = myMoto1;
list1[myMoto2.Name] = myMoto2;

foreach (var vehicle in list1)
{
    Console.WriteLine($"nom : {vehicle.Key} - Prix : {vehicle.Value.Price}");
}
//==> Affichage par ordre d'ajout

Console.WriteLine();

//SortedList<string, Vehicle> list2 = new SortedList<string, Vehicle>();
//list2 = list2.Concat(list1); Non fonctionnel car pas le même type (dictionnary et sortedList)
//list2[myCar1.Name] = myCar1;
//list2[myCar2.Name] = myCar2;
//list2[myMoto1.Name] = myMoto1;
//list2[myMoto2.Name] = myMoto2;
 //OU
SortedList<string, Vehicle> list2 = new SortedList<string, Vehicle>
{ { myCar1.Name, myCar1 },
  { myCar2.Name, myCar2 },
  { myMoto1.Name, myMoto1 },
  { myMoto2.Name, myMoto2 }
};

foreach (var vehicle2 in list2)
{
    Console.WriteLine($"nom : {vehicle2.Key} - Prix : {vehicle2.Value.Price}");
}
// ==> tri par key
Console.WriteLine();

//List<Vehicle> list3 = new List<Vehicle>();
//list3.Add(myCar1);
//list3.Add(myCar2);
//list3.Add(myMoto1);
//list3.Add(myMoto2);

//OU
List<Vehicle> list3 = new List<Vehicle> { myCar1, myCar2, myMoto1, myMoto2 };


list3.Sort();
foreach (var vehicle in list3)
{
    Console.WriteLine($"nom : {vehicle.Name} - Prix : {vehicle.Price}");
}
// ==> tri par Prix car on a redefini la methode CompareTo

Console.WriteLine();

var comprerEnergy = new CompareVehicles();

list3.Sort(comprerEnergy);
// ==> sort par defaut utilise compareTo mais peut prendre en paramètre un IComparer (que l'on peut surcharger comme ici)

foreach (var vehicle in list3)
{
    Console.WriteLine($"nom : {vehicle.Name} - Energie : {vehicle.Energy}");
}

Console.WriteLine();

string[] arrayBrands = { "Clio", "Mégane", "Golf", "Intruder", "Polo" };

foreach (string brand in arrayBrands)
{
    if (list2.TryGetValue(brand, out Vehicle vehicle))
    {
        Console.WriteLine($"nom : {vehicle.Name} - Prix : {vehicle.Price}");
    }
}