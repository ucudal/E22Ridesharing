namespace Library;

public class Vehicle
{
    public int Capacity{get; set;}
    public string Type{get; set;}
    public Driver driver;

    public Vehicle(int capacidad, string tipo, Driver duenio){
        this.Capacity = capacidad;
        this.Type = tipo;
        this.driver = duenio;
    }
}