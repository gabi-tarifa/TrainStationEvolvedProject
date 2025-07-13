namespace TrainStationEvolved{
    public class PassengerWagon:Wagon{
    private string Nickname{ get; set; }
        private int Passengers { get; set; }
        private int Mail { get; set; }
        private int Profit { get; set; }
        public PassengerWagon(string nickname, int passengers, int mail, int profit):base(nickname, profit){
            this.Nickname = nickname;
            this.Passengers = passengers;
            this.Mail = mail;
            this.Profit = profit;
        }
    }
}