using System.Console;

namespace TrainStationEvolved;

public class Train
{
    private string Name { get; set; }
    private int Power { get; set; }
    private string Type { get; set; }
    private string Sprite { get; set; }
    private bool InUse { get; set; } = false;

    public Train(string name, int power, string type, string sprite)
    {
        name = this.Name;
        power = this.Power;
        type = this.Type;
        sprite = this.Sprite;
    }

    public void UseTrain()
    {
        try
        {
            if (InUse.get(false))
                InUse.set(true);
        }
        catch
        {
            Console.Writeline("O trem selecionado já está em uso.");
        }
    }

}