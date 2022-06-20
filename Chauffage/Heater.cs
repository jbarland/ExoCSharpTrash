using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chauffage
{
    public abstract class Heater
    {
        public int MaxPower { get; set; }
        public double EnergyEfficiency { get; set; }
        public TimeSpan MaintenanceInterval { get; set; }
        public DateTime NextMaintenanceDate { get; set; }
        public int CurrentMode { get; set; }
        public virtual double Intensity { get; set; }

        public abstract double CalcConsumption(TimeSpan interval);
 

        public virtual void CalcMaintenanceDate(DateTime date)
        {

        }

    }

    public class Mode
    {
        public int id { get; set; }
        public string? label { get; set; }
    }

    public abstract class CombustionHeater : Heater
    {
        public Combustible? HeaterCombustible { get; set; }

    }


    public class Combustible
    {
        public string? Code { get; set; }
        public string? Label { get; set; }
        public Units Unit { get; set; }
        public Categories Category { get; set; }
        public decimal VolumicMass { get; set; }
        public decimal HeatCapacity { get; set; }

    }

    public enum Units { L, m3, kg, stere }

    public enum Categories { wood, fuel, gas, pellets }

    public class Pipe
    {
        public double Diameter { get; set; }
        public int Length { get; set; }
    }


    public class WoodStove : CombustionHeater
    {
        public override double CalcConsumption(TimeSpan interval)
        {
            double comsuption = 0;
            return comsuption;

        }
    }

    public class ElectricHeater : Heater
    {
        public override double CalcConsumption(TimeSpan interval)
        {
            double comsuption = 0;
            return comsuption;

        }

    }






}
