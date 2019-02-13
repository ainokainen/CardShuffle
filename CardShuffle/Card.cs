namespace CardShuffle
{
    //Create deck of cards
    public class Card
    {
        public enum Suites
        {
            H= 0 , D , C , S
        }
        public int Value
        {
            get;set;
        }
        public Suites Suite
        {
            get; set;
        }
        public string StringValue
        {
            get
            {
                string name = string.Empty;
                switch (Value)
                { 
                    case (14):
                        name= "A";
                        break;
                    case (13):
                        name= "K";
                        break;
                    case (12):
                        name= "Q";
                        break;
                    case (11):
                        name= "J";
                        break;
                    default:
                        name = Value.ToString();
                        break;
                }
                return name;
            }
        }
        //Create name of the card
        public string Name
        {
            get
            {
                return StringValue + Suite.ToString();
            }
        }
        public Card (int Value, Suites Suite)
        {
            this.Value = Value;
            this.Suite = Suite;
        }
        public Card()
        {

        }

    }
}