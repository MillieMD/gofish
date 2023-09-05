public class Card
{
    int value;
    string suit;

    public Card(int i, string s){
        value = i;
        suit = s;
    }

    public string toString(){

        switch(value){
            case (13):
                return "King of " + suit;

            case (12):
                return "Queen of " + suit;
            
            case(11):
                return "Jack of " + suit;

            default:
                return value + " of " + suit;
        }
    }

}