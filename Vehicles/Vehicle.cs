using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public enum Energies { none, essence, diesel, GPL, electric }
    public abstract class Vehicle : IComparable
    {
        public string? Name { get; }
        public Energies Energy { get; }
        public decimal Price { get; }

        private string _description;

        public Vehicle(string? name, Energies energy, decimal price)
        {
            Name = name;
            Energy = energy;
            Price = price;
        }

        public virtual string Description
        {
            get { return $"véhicule {Name} {Energy}"; }
        }

        public abstract decimal GetResalePrice(double kilometrage, int startDate);

        public int CompareTo(object? obj)
        {
            if (obj is Vehicle)
            {
                Vehicle v = (Vehicle)obj;
                return Price.CompareTo(v.Price);
            }
            else
            {
                return 2;
            }


        }
    }

    public class Car : Vehicle
    {
        public int NbDoor { get; set; }
        public Car(string? name, Energies energy, decimal price) : base(name, energy, price)
        {
        }

        public override string ToString()
        {
            return $"voiture de nom {Name} avec moteur {Energy} au prix de {Price}";
        }

        public override decimal GetResalePrice(double kilometrage, int startDate)
        {
            int seniority = DateTime.Today.Year - startDate;

            decimal resalePrice = Price * 100000 / ((decimal)kilometrage * seniority);

            return resalePrice;
        }

        public override string Description
        {
            get { return $"voiture {Name} {Energy}"; }
        }
    }

    public class Moto : Vehicle
    {
        public Moto(string? name, Energies energy, decimal price) : base(name, energy, price)
        {
        }


        public override string Description
        {
            get { return $"moto {Name} {Energy}"; }
        }

        public override decimal GetResalePrice(double kilometrage, int startDate)
        {
            int seniority = DateTime.Today.Year - startDate;


            decimal resalePrice = Price * 70000 / ((decimal)kilometrage * seniority);

            return resalePrice;
        }
    }
}
