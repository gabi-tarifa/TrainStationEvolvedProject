namespace TrainStationEvolved{
    public class Type{
        private string Name { get; set;}
        private double Profit { get; set;}
    
        public Type(string name, double profit) { 
            this.Name = name;
            this.Profit = profit;
        }
    }
}