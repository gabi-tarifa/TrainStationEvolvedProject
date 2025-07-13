namespace TrainStationEvolved
{

    public class RawMaterial : Material
    {
        private string Name{ get; set; }
        private int Quantity{ get; set; } = 0;
        private string image {get; set;}

        public RawMaterial(string name, string image) : base(name, image)
        {
            this.Name = name;
            this.image = image;
        }
    }
}
