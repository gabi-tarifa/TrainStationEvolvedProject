using System.Console;
using TrainStationEvolved;

{
    Train train1 = new Train(name = "LNER A1 PEPPERCORN", 9, "steam", "edede");

    Material wood = new RawMaterial("Wood");
    Material coal = new RawMaterial("Coal");
    Material ironOre = new RawMaterial("Iron Ore");

    Material nails = new FactoryMaterial("Nails");

    train1.UseTrain();

    train1.UseTrain();


    
}