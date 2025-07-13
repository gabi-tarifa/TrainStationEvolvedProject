
namespace TrainStationEvolved
{
    public class Material
    {
        private string name { get; set; }
        private int quantity { get; set; } = 0;
        private string image { get; set; }

        public Material(string name, string image)
        {
            this.name = name;
            this.image = image;
        }
    }
}