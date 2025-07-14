namespace TrainStationEvolved
{

    public class Program
    {

        static void Main(string[] args)
        {

            //Train Types instances creation section

            Type steam = new Type("Steam", 1.0);
            Type diesel = new Type("Diesel", 1.45);
            Type electric = new Type("Electric", 2.0);
            Type maglev = new Type("Maglev", 1.0);
            Type hyperloop = new Type("Hyperloop", 1.0);

            //Train instaces creation section

            Train a1peppercorn = new Train("LNER A1 PEPPERCORN", 9, steam, "");
            Train kraussmaffei = new Train("Krauss-Maffei ML", 6, diesel, "");
            Train prrgg1 = new Train("PRR GG1", 6, electric, "");
            Train shangaimt = new Train("Shangai MT", 5, maglev, "");
            Train h1oop = new Train("H1 OOP", 5, hyperloop, "");

            //Raw Materials instances creation section

            Material wood = new RawMaterial("Wood", "");
            Material coal = new RawMaterial("Coal", "");
            Material ironOre = new RawMaterial("Iron Ore", "");
            Material oilBarrel = new RawMaterial("Oil Barrel", "");

            //Factory Materials instances creation section

            Material steel = new FactoryMaterial("Steel", [ironOre, coal], "");
            Material nails = new FactoryMaterial("Nails", [steel], "");
            Material timber = new FactoryMaterial("Timber", [wood], "");
            Material ironPowder = new FactoryMaterial("Iron Powder", [ironOre], "");
            Material saw = new FactoryMaterial("Saw", [ironPowder, wood, steel], "");

            //All destinations, except custom destination creation section

            Destination destination5mins = new Destination("Farm", 5, ""); //5 minutes journey
            Destination destination10mins = new Destination("Small Village", 10, ""); //10 minutes journey
            Destination destination20mins = new Destination("Inner City", 20, ""); //20 minutes journey
            Destination destination30mins = new Destination("Agricultural Complex", 30, ""); //30 minutes journey
            Destination destination45mins = new Destination("Farm", 45, ""); //45 minutes journey
            Destination destination1hour = new Destination("Factory City", 60, ""); //1 hour journey
            Destination destination2hours = new Destination("Metropolis Center", 2 * 60, ""); //2 hours journey
            Destination destination3hours = new Destination("Farm", 3 * 60, ""); //3 hours journey
            Destination destination4hours = new Destination("Farm", 4 * 60, ""); //4 hours journey
            Destination destination5hours = new Destination("Periferic Station", 5 * 60, ""); //5 hours journey
            Destination destination6hours = new Destination("Farm", 6 * 60, ""); //6 hours journey
            Destination destination8hours = new Destination("Farm", 8 * 60, ""); //8 hours journey
            Destination destination10hours = new Destination("Farm", 10 * 60, ""); //10 hours journey
            Destination destination12hours = new Destination("Farm", 12 * 60, ""); //12 hours journey
            Destination destination16hours = new Destination("Farm", 16 * 60, ""); //16 hours journey
            Destination destination20hours = new Destination("Farm", 20 * 60, ""); //20 hours journey
            Destination destination24hours = new Destination("Farm", 24 * 60, ""); //1 day journey
            Destination destination48hours = new Destination("Farm", 48 * 60, ""); //2 days journey
            Destination destination72hours = new Destination("Farm", 72 * 60, ""); //3 days journey
            Destination destination96hours = new Destination("Farm", 96 * 60, ""); //4 days journey
            Destination destination120hours = new Destination("Farm", 120 * 60, ""); //5 days journey
            Destination destination144hours = new Destination("Farm", 144 * 60, ""); //6 days journey
            Destination destination168hours = new Destination("Farlands", 168 * 60, ""); //one week journey

            a1peppercorn.UseTrain();

            static void SelectTrain(Train train)
            {
                train.UseTrain();
            }

            SelectTrain(a1peppercorn);
        }
    }
}