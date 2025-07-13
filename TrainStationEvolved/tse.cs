namespace TrainStationEvolved
{

    public class Program
    {

        static void Main(string[] args)
        {
            Train train1 = new Train("LNER A1 PEPPERCORN", 9, "steam", "edede");

            Material wood = new RawMaterial("Wood", "");
            Material coal = new RawMaterial("Coal", "");
            Material ironOre = new RawMaterial("Iron Ore", "");

            Destination destination5mins = new Destination("Farm", 5, "");

            Material steel = new FactoryMaterial("Steel", [ ironOre, coal ], "");

            Material nails = new FactoryMaterial("Nails", [steel], "");

            train1.UseTrain();
            
        }
    }
}