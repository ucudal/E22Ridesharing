namespace Library;

public class Passanger:User{
      protected override string id{get;set;}
      protected override string lastname{get;set;}
      protected override string name{get;set;}
      protected override double rating{get;set;}
    public Passanger(string id, string lastname, string name){
        this.id=id;
        this.lastname=lastname;
        this.name=name;
        this.rating=0;
      }
}