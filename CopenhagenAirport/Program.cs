using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace CopenhagenAirport
{
    class Program
    {
        static void Main(string[] args)
        {
            //Airport airport1 = new Airport();
            //airport1.IATA = "AMS";
            //airport1.AirportName = "Amsterdam Airport";
            //RegisterAirport(airport1);

            using (CphAirportEntities context = new CphAirportEntities())
            {
                var airports = context.Airports;

                List<Airport> airports1 = airports.ToList();

                for (int i = 0; i < airports1.Count; i++)
                {
                    Airport airport = airports1[i];
                    Console.WriteLine(airport.AirportName);
                    Console.WriteLine(airport.IATA);
                    for (int j = 0; j < airport.FlightRouteOwneds.Count; j++)
                    {
                        //Console.WriteLine();

                    }
                }
            }
            Console.ReadKey();
        }

        static void RegisterAirport(Airport airport)
        {
            using (CphAirportEntities context = new CphAirportEntities())
            {
                context.Airports.Add(airport);
                context.SaveChanges();
            }
        }

    }
}
