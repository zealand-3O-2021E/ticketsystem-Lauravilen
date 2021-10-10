using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class Costumer
    {
        /// <summary>
        /// List of trips over the bridges
        /// </summary>
        public List<Vehicle> Trips { get; set; }

        /// <summary>
        /// Represents a costumer and their history of trips over Storebaeltsbroen and Oresundsbroen
        /// </summary>
        public Costumer()
        {
            Trips = new List<Vehicle>();
        }

        /// <summary>
        /// Represents a costumer and their history of trips over Storebaeltsbroen and Oresundsbroen, instantiated with a List of Vehicles as an argument
        /// </summary>
        public Costumer(List<Vehicle> trips)
        {
            Trips = trips;
        }

        /// <summary>
        /// Method to add new trips to the costumer's list
        /// </summary>
        /// <param name="vehicle"></param>
        public void AddTripToList(Vehicle vehicle)
        {
            Trips.Add(vehicle);
        }
    }
}
