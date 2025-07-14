namespace TrainStationEvolved
{

    public class Program
    {

        static void Main(string[] args)
        {
            Train train1 = new Train("LNER A1 PEPPERCORN", 9, "steam", "edede"); //creating the instances so i can test then on complile

            Material wood = new RawMaterial("Wood", "");
            Material coal = new RawMaterial("Coal", "");
            Material ironOre = new RawMaterial("Iron Ore", "");

            Material steel = new FactoryMaterial("Steel", [ ironOre, coal ], "");

            Material nails = new FactoryMaterial("Nails", [steel], "");

            //All destinations, except custon instances creation section

            Destination destination5mins = new Destination("Farm", 5, ""); //5 minutes journey
            Destination destination10mins = new Destination("Farm", 10, ""); //10 minutes journey
            Destination destination20mins = new Destination("Farm", 20, ""); //20 minutes journey
            Destination destination30mins = new Destination("Farm", 30, ""); //30 minutes journey
            Destination destination45mins = new Destination("Farm", 45, ""); //45 minutes journey
            Destination destination1hour = new Destination("Farm", 60, ""); //1 hour journey
            Destination destination2hours = new Destination("Farm", 2*60, ""); //2 hours journey
            Destination destination3hours = new Destination("Farm", 3*60, ""); //3 hours journey
            Destination destination4hours = new Destination("Farm", 4*60, ""); //4 hours journey
            Destination destination5hours = new Destination("Farm", 5*60, ""); //5 hours journey
            Destination destination6hours = new Destination("Farm", 6*60, ""); //6 hours journey
            Destination destination8hours = new Destination("Farm", 8*60, ""); //8 hours journey
            Destination destination10hours = new Destination("Farm", 10*60, ""); //10 hours journey
            Destination destination12hours = new Destination("Farm", 12*60, ""); //12 hours journey
            Destination destination16hours = new Destination("Farm", 16*60, ""); //16 hours journey
            Destination destination20hours = new Destination("Farm", 20*60, ""); //20 hours journey
            Destination destination24hours = new Destination("Farm", 24*60, ""); //1 day journey
            Destination destination48hours = new Destination("Farm", 48*60, ""); //2 days journey
            Destination destination72hours = new Destination("Farm", 72*60, ""); //3 days journey
            Destination destination96hours = new Destination("Farm", 96*60, ""); //4 days journey
            Destination destination120hours = new Destination("Farm", 120*60, ""); //5 days journey
            Destination destination144hours = new Destination("Farm", 144*60, ""); //6 days journey
            Destination destination168hours = new Destination("Farm", 168*60, ""); //one week journey

            train1.UseTrain();
            
        }
    }
}