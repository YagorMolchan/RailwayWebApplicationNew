using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RailwayNew1.Models.Domain.Specifications;

namespace RailwayNew1.Models.DesignPatterns.Proxy.Wagon
{
    public class WagonStoreProxy : IWagon
    {
        List<Domain.Entity.Wagon> wagons;
        WagonStore wagonStore;

        public WagonStoreProxy()
        {
            wagons = new List<Domain.Entity.Wagon>();
        }

        public Domain.Entity.Wagon GetWagon(int number)
        {
            var wagon = new Domain.Entity.Wagon();

            if(wagon==null)
            {
                if(wagonStore==null)
                {
                    wagonStore = new WagonStore();
                }
                wagon = wagonStore.GetWagon(number);

                if(wagon.Id >= 6)
                {
                    wagon.Type = "Сидячий";
                }
                wagons.Add(wagon);                
            }
            return wagon;
        }

        public void Dispose()
        {
            if(wagonStore!=null)
                wagonStore.Dispose();
        }
    }
}
