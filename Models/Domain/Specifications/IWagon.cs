using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RailwayNew1.Models.Domain.Entity;

namespace RailwayNew1.Models.Domain.Specifications
{
    public interface IWagon:IDisposable
    {
        Wagon GetWagon(int number);
    }
}
