namespace GarageV1._0
{
    public class Vehicle
    {
        public Vehicle(string regNr, string color, int numberOfWheels,
            string manufacturer, int modelYear)
        {
            RegNr = regNr;
            Color = color;
            NumberOfWheels = numberOfWheels;
            Manufacturer = manufacturer;
            ModelYear = modelYear;
        }

        public string RegNr { get; private set; }
        public string Color { get; private set; }
        public int NumberOfWheels { get; private set; }
        public string Manufacturer { get; private set; }
        public int ModelYear { get; private set; }


    }
}
