using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class AreaMaster
    {
        static protected List<AreaMaster> areaCollection = new List<AreaMaster>();
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int areaId { get; set; }
        public enum areaType {
                        country,
                        state,
                        city,
                        district
                        };
        public virtual areaType arType { get; set; }
        public AreaMaster()
        {

        }
        public AreaMaster(int id,string code,string name,string description,int areaId,areaType at) 
        {
            this.id = id;
            this.code = code;
            this.name = name;
            this.description = description;
            this.areaId = areaId;
            this.arType = at;
            areaCollection.Add(this);
        }
        public string GetAreaMasterByAreaId(int arId){

                foreach (AreaMaster areatype in areaCollection.Where(area => area.id == arId))
                {

                return areatype.name;
                }
            return null;            
        }
        
    }

    public class CountryMaster : AreaMaster
    {
        public CountryMaster(int id, string code, string name, string description, int areaId, areaType at) :base(id,code,name,description,areaId,at)
        {

        }
        public CountryMaster()
        {

        }
        public void GetAreaMasterByCountry(string country)
        {
            foreach (AreaMaster areatype in areaCollection.Where(area => area.name == country))
            {

                if (string.Equals(country, areatype.name))
                {
                    Console.WriteLine("country: " + areatype.name);

                }

            }
        }


    }

    public class StateMaster : AreaMaster
    {
        public StateMaster():base()
        {

        }
        public StateMaster(int id, string code, string name, string description, int areaId, areaType at) :base(id,code,name,description,areaId,at)
        {

        }
        public void GetAreaMasterByState(string state)
        {
            foreach (AreaMaster areatype in areaCollection.Where(area => area.name == state))
            {

                if (string.Equals(state, areatype.name))
                {
                    Console.WriteLine("State: " + areatype.name);

                    string country = GetAreaMasterByAreaId(areatype.areaId);

                    CountryMaster c1 = new CountryMaster();
                    c1.GetAreaMasterByCountry(country);
                }

            }
               
        }


    }

    public class CityMaster : AreaMaster
    {
       public CityMaster(int id, string code, string name, string description, int areaId, areaType at) :base(id,code,name,description,areaId,at)
        {

        }
        public CityMaster() { }
        public void GetAreaMasterByCity(string city)
        {
            

            foreach (AreaMaster areatype in areaCollection.Where(area=> area.arType == areaType.city))
            {

                
                if (string.Equals(city,areatype.name))
                {
                    Console.WriteLine("City = "+city);
                    string state  = GetAreaMasterByAreaId(areatype.areaId);
                    StateMaster s1 = new StateMaster();
                    s1.GetAreaMasterByState(state);

                 }
                
            }
           
        }
    }

    public class DistrictMaster : AreaMaster
    {
        public DistrictMaster(int id, string code, string name, string description, int areaId, areaType at) : base(id, code, name, description, areaId, at)
        {

        }

        public DistrictMaster()
        {

        }
        public void GetAreaMasterByDistrict(string district)
        {


            foreach (AreaMaster areatype in areaCollection.Where(area => district == area.name))
            {


                if (string.Equals(district, areatype.name))
                {
                    Console.WriteLine("District = "+district);
                    string city = GetAreaMasterByAreaId(areatype.areaId);
                    CityMaster c1 = new CityMaster();
                    c1.GetAreaMasterByCity(city);

                }

            }

        }
    }


}
