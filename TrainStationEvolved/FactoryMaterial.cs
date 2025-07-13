using System.Collections.Generic;
namespace TrainStationEvolved
{
    public class FactoryMaterial : Material
    {
        private string  Name { get; set;}
        private List<Material> materialsRequired = new List<Material>();
        private int Quantity { get; set; } = 0;
        private string Image { get; set; }

        public FactoryMaterial(string name, List<Material> materials, string image) : base(name, image)
        {
            Name = name;
            materialsRequired.AddRange(materials);
            Image = image;
        }
    }
}