using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            CityMaster am = new CityMaster(3, "PUN", "pune", "Anything", 2, AreaMaster.areaType.city);
            StateMaster am2 = new StateMaster(2, "PUN", "maharashtra", "Anything", 1, AreaMaster.areaType.state);
            CountryMaster am3 = new CountryMaster(1, "PUN", "India", "Anything", 0, AreaMaster.areaType.country);
            DistrictMaster am4 = new DistrictMaster(4, "PUN", "Nagpur", "Anything", 3, AreaMaster.areaType.district);


            am4.GetAreaMasterByDistrict("Nagpur");
            //am.GetAreaMasterByCity("pune");
            //am2.GetAreaMasterByState("maharashtra");
            Console.ReadLine();
        }
    }
}
