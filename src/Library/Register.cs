namespace Library; 
using Library;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using TwitterUCU;
public class Register{
        private string userid;
        private string password;
        
        private static List<Passanger>listpassangers;
        private static List<Driver>listdrivers;


        public void RegisterPassenger(string id, string name, string lastname)
        {      
                try
                {
                    Passanger NewPassanger = new Passanger(id,lastname,name);
                    listpassangers.Add(NewPassanger);
                }
                catch (System.Exception error)
                {
                    error.ToString();
                    throw error;
                }
                
            
               
        }
         public void RegisterDriver(string userid, string password,string id, string name, string lastname, Vehicle vehicle)
        {   
            try
            {
                var Twitter = new TwitterImage();
                Console.WriteLine(Twitter.PublishToTwitter("New wonderful driver",@"conductorprofesiomal.PNG"));
                var twitterDirectMessage = new TwitterMessage();
                Console.WriteLine(twitterDirectMessage.SendMessage("¡Hola genio universal!", "1580569603910033409"));
                Driver NewDriver = new Driver(id, lastname, name, vehicle);
                listdrivers.Add(NewDriver);
            }
            catch (System.Exception error)
            {
                
                throw error;
            }
                
        }
            
}