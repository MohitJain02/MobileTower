using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileTower.WebApp.Services
{
    public interface IPriceCalculator
    {
        string CalculatePrice();
    }
}