namespace Library;

public abstract class User:IRating{
      public abstract string id{get;set;}
      public abstract string lastname{get;set;}
      public abstract string name{get;set;}
      public abstract double rating{get;set;}
      public void rate(){}
      public void verifyRate(){}


}