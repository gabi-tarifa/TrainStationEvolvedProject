using System;

namespace TrainStationEvolved{

    public class Train
    {
        private string Name { get; set; }
        private int Power { get; set; }
        private Type Type { get; set; }
        private string Link { get; set; }
        private bool InUse { get; set; } = false;

        public Train(string name, int power, Type type, string link)
        {
            this.Name = name;
            this.Power = power;
            this.Type = type;
            this.Link = link;
        }

        public void UseTrain()
        {
            if (InUse == false)
            {
                InUse = true;
                return;
            }
            Console.WriteLine("O trem selecionado já está em uso.");
            
        }
    }
}