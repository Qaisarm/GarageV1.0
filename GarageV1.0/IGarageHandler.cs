namespace GarageV1._0
{
    internal interface IGarageHandler
    {
        Garage<Vehicle> CreateGarage(string name, int capacity);
    }
}