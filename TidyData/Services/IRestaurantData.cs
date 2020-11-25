using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TidyData.Models;

namespace TidyData.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();

    }
}
