using System.Collections.Generic;
namespace TrainStationEvolved;

public class FactoryMaterial:Material
{
    private string name;
    private List<Material> materialsRequired = new List<Material>();
    private int quantity;

}
