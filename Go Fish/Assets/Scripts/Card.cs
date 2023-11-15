public class Card
{
    public int number {get;}    
    public string suit {get;}
    
    public Card(int number, string suit){
        this.number = number;
        this.suit = suit;
    }

    public override string ToString(){
        switch(number){
            case(1):
                return "Ace of " + suit;

            case(13):
                return "King of " + suit;

            case(12):
                return "Queen of " + suit;

            case(11):
                return "Jack of " + suit;

            default:
                return number + " of " + suit;
        }

    }

}
