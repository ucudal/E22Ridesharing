namespace Library;

public class Driver:User{
    public override string id{get;set;}
    public override string lastname{get;set;}
    public override string name{get;set;}
    public override double rating{get;set;}
    private Vehicle vehicle{get;set;}

    public Driver(string id, string lastname, string name, Vehicle vehicle){
        this.id=id;
        this.lastname=lastname;
        this.name=name;
        this.rating=0;
        this.vehicle=vehicle;
    }

    public void rate(Passanger pasajero, double rate){
        pasajero.rating = rate;

    }
    public void verifyRate(){}

}