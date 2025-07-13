namespace TrainStationEvolved{
    public class Destination{
        private string Name { get; set;}
        private int TimeTravelMinutes { get; set;}
        private string Image { get; set;}

        public Destination(string name, int timeTravelMinutes, string image) {
            this.Name = name;
            this.TimeTravelMinutes = timeTravelMinutes;
            this.Image = image;
        }
    }
}