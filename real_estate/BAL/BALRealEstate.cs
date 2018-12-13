using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class BALRealEstate
    {
        RealEstate prop = new RealEstate();
        RealEstateEntities db = new RealEstateEntities();
        public List<property> getProperty()
        {
            //return prop.getProperty();
            return db.properties.ToList();
        }
        public System.Collections.Generic.List<DAL.getAllProp_Result> getAllProp()
        {
            return db.getAllProp().ToList();
        }

        public List<townRegion> getTown()
        {
            return prop.getTown();
        }
        public List<area> getArea()
        {
            return prop.getArea();
        }
        public List<district> getDistrict()
        {
            return prop.getDistrict();
        }
        public List<realEstateType> getRealEstateType()
        {
            return prop.getRealEstateType();
        }
        public void DeleteCustomer(string id)
        {
            prop.Delete(id);
        }
        public List<project> getProject()
        {
            return prop.getProject();
        }
        public List<area> getAreaByIdTown(int id)
        {
            return prop.getAreaByIdTown(id);
        }
        public List<district> getDistrictByIdArea(int id)
        {
            return prop.getDistrictByIdArea(id);
        }
        //public bool Insert(ref string err, ref string pro, string id_prop, int id_realestate_type, string id_project, int floor, int room, float price, int id_town, int id_area, int id_district, string ten, string status, byte[] avatar)
        //{
        //    return prop.Insert( ref err,ref pro, id_prop,id_realestate_type, id_project, floor, room, price, id_town, id_area, id_district, ten, status, avatar);
        //}
        public bool Update(ref string err, ref string pro, string id_prop, int id_realestate_type, string id_project, int floor, int room, float price, int id_town, int id_area, int id_district, string ten, string status, byte[] avatar)
        {
            return prop.Update(ref err, ref pro,id_prop, id_realestate_type, id_project, floor, room, price, id_town, id_area, id_district, ten, status, avatar);
        }
        public ObjectResult<DAL.property> searchPropertyByPlace(int id_town, int id_area, int id_district)
        {
            return prop.searchPropertyByPlace(id_town, id_area, id_district);
        }

        public bool insertProp(ref string err, ref string pro, int id_realestate_type, string id_project, int floor, int room, float price, int id_town, int id_area, int id_district, string ten, string status, byte[] avatar)
        {
            return prop.InsertProp(ref err, ref pro, id_realestate_type, id_project, floor, room, price, id_town, id_area, id_district, ten, status, avatar);
        }
    }
}       
