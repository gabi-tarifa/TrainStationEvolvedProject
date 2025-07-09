using System.Console;
namespace TrainStationEvolved
{
    public class Train
    {
        private string name;
        private int power;
        private bool inUse = false;
        private string type;
        private string sprite;
    }

    public class Material
    {
        private string name;
        private int quantity;
    }

    public class RawMaterial:Material 
    {
        private string name;
        private int quantity;

    }

    public class FactoryMaterial:Material
    {
        private string name;
        private int quantity;
        private Material materialProduciton;

    }

    public class Wagon
    {
        private string nickname;
        private int profit;
    }
}