namespace Library;

public class Driver:User{
    protected override string id{get;set;}
    protected override string lastname{get;set;}
    protected override string name{get;set;}
    protected override double rating{get;set;}
    /* private Vehicle vehicle{get;set;}*/

    public Driver(string id, string lastname, string name/*,Vehicle vehicle  */){
        this.id=id;
        this.lastname=lastname;
        this.name=name;
        this.rating=0;
        /*this.vehicle=vehicle;*/

    }

}