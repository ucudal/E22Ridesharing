namespace Library;

public class Passanger:User{
      public override string id{get;set;}
      public override string lastname{get;set;}
      public override string name{get;set;}
      public override double rating{get;set;}
    public Passanger(string id, string lastname, string name){
        this.id=id;
        this.lastname=lastname;
        this.name=name;
        this.rating=0;
      }
      public void rate(Driver pasajero, double rate){
        pasajero.rating = rate;
    }
    public void verifyRate(){}
}

