using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RealEstate : IProperty
    {
        RealEstateEntities db = new RealEstateEntities();
        public void Delete(string id)
        {
            property prop = db.properties.Find(id);
            db.properties.Remove(prop);
            db.SaveChanges();
        }

        public List<area> getArea()
        {
            return db.areas.ToList();
        }

        public List<district> getDistrict()
        {
            return db.districts.ToList();
        }

        public List<project> getProject()
        {
            return db.projects.ToList();
        }

        public List<property> getProperty()
        {
            return db.properties.ToList();
        }

        public List<realEstateType> getRealEstateType()
        {
            return db.realEstateTypes.ToList();
        }

        public List<townRegion> getTown()
        {
            return db.townRegions.ToList();
        }
        public List<area> getAreaByIdTown(int id)
        {
            return db.areas.Where(x => x.id_town_region == id).ToList();
        }
        public List<district> getDistrictByIdArea(int id)
        {
            return db.districts.Where(x => x.id_area == id).ToList();
        }

       

        public List<townRegion> getTownById()
        {
            throw new NotImplementedException();
        }

        public List<area> getAreaById()
        {
            throw new NotImplementedException();
        }

        public List<district> getDistTrictById()
        {
            throw new NotImplementedException();
        }

        public bool Update(ref string err, ref string pro, string id_prop, int id_realestate_type, string id_project, int floor, int room, float price, int id_town, int id_area, int id_district, string ten, string status, byte[] avatar)
        {
            bool f = false;
            try
            {

                db.sp_updateProperty(id_prop, id_realestate_type, id_project, floor, room, price, id_town, id_area, id_district, status, ten, avatar);
                db.SaveChanges();
                f = true;

            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        pro += validationError.PropertyName;
                        err += validationError.ErrorMessage;
                    }
                }
            }
            return f;
        }
      
        //public bool Insert(ref string err,ref string pro, string id_prop, int id_realestate_type, string id_project, int floor, int room, float price, int id_town, int id_area, int id_district, string ten, string status, byte[] avatar)
        //{
        //    bool f = false;

        //    try
        //    {
        //        using (RealEstateEntities db = new RealEstateEntities())
        //        {
        //            // db.properties.Add(new property {id_prop=id_prop,id_real_estate_type=id_realestate_type,id_project=id_project,floor=floor,room=room,price=price,id_town_region=id_town,id_area=id_area,id_district=id_district,name=ten,status=status,avatar=avatar });
        //          db.sp_InsertProperty(id_prop,id_realestate_type, id_project, floor, room, price, id_town, id_area, id_district, status, ten, avatar);
                 
        //            db.SaveChanges();
                   
        //            //db.sp_InsertProperty(id_realestate_type, id_project, floor, room, price, id_town, id_area, id_district, status, ten, avatar);
        //            //db.SaveChanges();
        //            f = true;


        //        }
        //    }
        //    catch (DbEntityValidationException ex)
        //    {
        //        foreach (var entityValidationErrors in ex.EntityValidationErrors)
        //        {
        //            foreach (var validationError in entityValidationErrors.ValidationErrors)
        //            {
        //                pro += validationError.PropertyName;
        //                err += validationError.ErrorMessage;
        //            }
        //        }
        //    }
        //    return f;
        //}
        public bool InsertProp(ref string err, ref string pro, int id_realestate_type, string id_project, int floor, int room, float price, int id_town, int id_area, int id_district, string ten, string status, byte[] avatar)
        {   
            bool f = false;

            try
            {
                using (RealEstateEntities db = new RealEstateEntities())
                {
                    // db.properties.Add(new property {id_prop=id_prop,id_real_estate_type=id_realestate_type,id_project=id_project,floor=floor,room=room,price=price,id_town_region=id_town,id_area=id_area,id_district=id_district,name=ten,status=status,avatar=avatar });
                    db.sp_InsertProperty(id_realestate_type, id_project, floor, room, price, id_town, id_area, id_district, status, ten, avatar);

                    db.SaveChanges();

                    //db.sp_InsertProperty(id_realestate_type, id_project, floor, room, price, id_town, id_area, id_district, status, ten, avatar);
                    //db.SaveChanges();
                    f = true;


                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        pro += validationError.PropertyName;
                        err += validationError.ErrorMessage;
                    }
                }
            }
            return f;
        }
        public ObjectResult<DAL.property> searchPropertyByPlace(int id_town, int id_area, int id_district)
        {
            return db.sp_searchLocationProperty(id_town, id_area, id_district);
        }

        ObjectResult<sp_searchLocationProperty_Result> IProperty.searchPropertyByPlace(int id_town, int id_area, int id_district)
        {
            throw new NotImplementedException();
        }
    }
}
