using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface IProperty
    {
        List<property> getProperty();
        List<townRegion> getTown();
        List<area> getArea();
        List<realEstateType> getRealEstateType();
        List<project> getProject();
        List<district> getDistrict();
        List<townRegion> getTownById();
        List<area> getAreaById();   
        List<district> getDistTrictById();
        System.Data.Entity.Core.Objects.ObjectResult<DAL.sp_searchLocationProperty_Result> searchPropertyByPlace(int id_town,int id_area,int id_district);
        
        
        //bool Insert(ref string err, ref string pro,string id_prop, int id_realestate_type,string id_project ,int floor ,int room,float price,int id_town,int id_area,int id_district,string ten, string status, byte[] avatar);
        bool Update(ref string err, ref string pro, string id_prop, int id_realestate_type, string id_project, int floor, int room, float price, int id_town, int id_area, int id_district, string ten, string status, byte[] avatar); 
        void Delete(string id);
    }
}
