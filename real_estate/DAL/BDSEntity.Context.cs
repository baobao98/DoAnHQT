﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RealEstateEntities : DbContext
    {
        public RealEstateEntities()
            : base("name=RealEstateEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<account> accounts { get; set; }
        public virtual DbSet<appointment> appointments { get; set; }
        public virtual DbSet<area> areas { get; set; }
        public virtual DbSet<contact> contacts { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<district> districts { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<realEstateType> realEstateTypes { get; set; }
        public virtual DbSet<townRegion> townRegions { get; set; }
        public virtual DbSet<trannsaction> trannsactions { get; set; }
        public virtual DbSet<typeAccount> typeAccounts { get; set; }
        public virtual DbSet<advertisement> advertisements { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<project> projects { get; set; }
        public virtual DbSet<property> properties { get; set; }
    
        public virtual int sp_DeleteProperty(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DeleteProperty", idParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_InsertProperty(Nullable<int> id_real_estate_type, string id_project, Nullable<int> floor, Nullable<int> room, Nullable<double> price, Nullable<int> id_town_region, Nullable<int> id_area, Nullable<int> id_district, string status, string name, byte[] avatar)
        {
            var id_real_estate_typeParameter = id_real_estate_type.HasValue ?
                new ObjectParameter("id_real_estate_type", id_real_estate_type) :
                new ObjectParameter("id_real_estate_type", typeof(int));
    
            var id_projectParameter = id_project != null ?
                new ObjectParameter("id_project", id_project) :
                new ObjectParameter("id_project", typeof(string));
    
            var floorParameter = floor.HasValue ?
                new ObjectParameter("floor", floor) :
                new ObjectParameter("floor", typeof(int));
    
            var roomParameter = room.HasValue ?
                new ObjectParameter("room", room) :
                new ObjectParameter("room", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(double));
    
            var id_town_regionParameter = id_town_region.HasValue ?
                new ObjectParameter("id_town_region", id_town_region) :
                new ObjectParameter("id_town_region", typeof(int));
    
            var id_areaParameter = id_area.HasValue ?
                new ObjectParameter("id_area", id_area) :
                new ObjectParameter("id_area", typeof(int));
    
            var id_districtParameter = id_district.HasValue ?
                new ObjectParameter("id_district", id_district) :
                new ObjectParameter("id_district", typeof(int));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var avatarParameter = avatar != null ?
                new ObjectParameter("avatar", avatar) :
                new ObjectParameter("avatar", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertProperty", id_real_estate_typeParameter, id_projectParameter, floorParameter, roomParameter, priceParameter, id_town_regionParameter, id_areaParameter, id_districtParameter, statusParameter, nameParameter, avatarParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int sp_alterdiagram1(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram1", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual ObjectResult<sp_InsertProperty1_Result> sp_InsertProperty1(string id_prop, Nullable<int> id_real_estate_type, string id_project, Nullable<int> floor, Nullable<int> room, Nullable<double> price, Nullable<int> id_town_region, Nullable<int> id_area, Nullable<int> id_district, string status, string name, byte[] avatar)
        {
            var id_propParameter = id_prop != null ?
                new ObjectParameter("id_prop", id_prop) :
                new ObjectParameter("id_prop", typeof(string));
    
            var id_real_estate_typeParameter = id_real_estate_type.HasValue ?
                new ObjectParameter("id_real_estate_type", id_real_estate_type) :
                new ObjectParameter("id_real_estate_type", typeof(int));
    
            var id_projectParameter = id_project != null ?
                new ObjectParameter("id_project", id_project) :
                new ObjectParameter("id_project", typeof(string));
    
            var floorParameter = floor.HasValue ?
                new ObjectParameter("floor", floor) :
                new ObjectParameter("floor", typeof(int));
    
            var roomParameter = room.HasValue ?
                new ObjectParameter("room", room) :
                new ObjectParameter("room", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(double));
    
            var id_town_regionParameter = id_town_region.HasValue ?
                new ObjectParameter("id_town_region", id_town_region) :
                new ObjectParameter("id_town_region", typeof(int));
    
            var id_areaParameter = id_area.HasValue ?
                new ObjectParameter("id_area", id_area) :
                new ObjectParameter("id_area", typeof(int));
    
            var id_districtParameter = id_district.HasValue ?
                new ObjectParameter("id_district", id_district) :
                new ObjectParameter("id_district", typeof(int));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var avatarParameter = avatar != null ?
                new ObjectParameter("avatar", avatar) :
                new ObjectParameter("avatar", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_InsertProperty1_Result>("sp_InsertProperty1", id_propParameter, id_real_estate_typeParameter, id_projectParameter, floorParameter, roomParameter, priceParameter, id_town_regionParameter, id_areaParameter, id_districtParameter, statusParameter, nameParameter, avatarParameter);
        }
    
        public virtual int sp_updateProperty(string id_prop, Nullable<int> id_real_estate_type, string id_project, Nullable<int> floor, Nullable<int> room, Nullable<double> price, Nullable<int> id_town_region, Nullable<int> id_area, Nullable<int> id_district, string status, string name, byte[] avatar)
        {
            var id_propParameter = id_prop != null ?
                new ObjectParameter("id_prop", id_prop) :
                new ObjectParameter("id_prop", typeof(string));
    
            var id_real_estate_typeParameter = id_real_estate_type.HasValue ?
                new ObjectParameter("id_real_estate_type", id_real_estate_type) :
                new ObjectParameter("id_real_estate_type", typeof(int));
    
            var id_projectParameter = id_project != null ?
                new ObjectParameter("id_project", id_project) :
                new ObjectParameter("id_project", typeof(string));
    
            var floorParameter = floor.HasValue ?
                new ObjectParameter("floor", floor) :
                new ObjectParameter("floor", typeof(int));
    
            var roomParameter = room.HasValue ?
                new ObjectParameter("room", room) :
                new ObjectParameter("room", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(double));
    
            var id_town_regionParameter = id_town_region.HasValue ?
                new ObjectParameter("id_town_region", id_town_region) :
                new ObjectParameter("id_town_region", typeof(int));
    
            var id_areaParameter = id_area.HasValue ?
                new ObjectParameter("id_area", id_area) :
                new ObjectParameter("id_area", typeof(int));
    
            var id_districtParameter = id_district.HasValue ?
                new ObjectParameter("id_district", id_district) :
                new ObjectParameter("id_district", typeof(int));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var avatarParameter = avatar != null ?
                new ObjectParameter("avatar", avatar) :
                new ObjectParameter("avatar", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_updateProperty", id_propParameter, id_real_estate_typeParameter, id_projectParameter, floorParameter, roomParameter, priceParameter, id_town_regionParameter, id_areaParameter, id_districtParameter, statusParameter, nameParameter, avatarParameter);
        }
    
        public virtual ObjectResult<sp_searchLocationProperty_Result> sp_searchLocationProperty(Nullable<int> id_town, Nullable<int> id_area, Nullable<int> id_district)
        {
            var id_townParameter = id_town.HasValue ?
                new ObjectParameter("id_town", id_town) :
                new ObjectParameter("id_town", typeof(int));
    
            var id_areaParameter = id_area.HasValue ?
                new ObjectParameter("id_area", id_area) :
                new ObjectParameter("id_area", typeof(int));
    
            var id_districtParameter = id_district.HasValue ?
                new ObjectParameter("id_district", id_district) :
                new ObjectParameter("id_district", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_searchLocationProperty_Result>("sp_searchLocationProperty", id_townParameter, id_areaParameter, id_districtParameter);
        }
    
        public virtual int sp_InsertProperty2(string id_prop, Nullable<int> id_real_estate_type, string id_project, Nullable<int> floor, Nullable<int> room, Nullable<double> price, Nullable<int> id_town_region, Nullable<int> id_area, Nullable<int> id_district, string status, string name, byte[] avatar)
        {
            var id_propParameter = id_prop != null ?
                new ObjectParameter("id_prop", id_prop) :
                new ObjectParameter("id_prop", typeof(string));
    
            var id_real_estate_typeParameter = id_real_estate_type.HasValue ?
                new ObjectParameter("id_real_estate_type", id_real_estate_type) :
                new ObjectParameter("id_real_estate_type", typeof(int));
    
            var id_projectParameter = id_project != null ?
                new ObjectParameter("id_project", id_project) :
                new ObjectParameter("id_project", typeof(string));
    
            var floorParameter = floor.HasValue ?
                new ObjectParameter("floor", floor) :
                new ObjectParameter("floor", typeof(int));
    
            var roomParameter = room.HasValue ?
                new ObjectParameter("room", room) :
                new ObjectParameter("room", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(double));
    
            var id_town_regionParameter = id_town_region.HasValue ?
                new ObjectParameter("id_town_region", id_town_region) :
                new ObjectParameter("id_town_region", typeof(int));
    
            var id_areaParameter = id_area.HasValue ?
                new ObjectParameter("id_area", id_area) :
                new ObjectParameter("id_area", typeof(int));
    
            var id_districtParameter = id_district.HasValue ?
                new ObjectParameter("id_district", id_district) :
                new ObjectParameter("id_district", typeof(int));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var avatarParameter = avatar != null ?
                new ObjectParameter("avatar", avatar) :
                new ObjectParameter("avatar", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertProperty2", id_propParameter, id_real_estate_typeParameter, id_projectParameter, floorParameter, roomParameter, priceParameter, id_town_regionParameter, id_areaParameter, id_districtParameter, statusParameter, nameParameter, avatarParameter);
        }
    
        public virtual int sp_InsertProperty3(Nullable<int> id_real_estate_type, string id_project, Nullable<int> floor, Nullable<int> room, Nullable<double> price, Nullable<int> id_town_region, Nullable<int> id_area, Nullable<int> id_district, string status, string name, byte[] avatar)
        {
            var id_real_estate_typeParameter = id_real_estate_type.HasValue ?
                new ObjectParameter("id_real_estate_type", id_real_estate_type) :
                new ObjectParameter("id_real_estate_type", typeof(int));
    
            var id_projectParameter = id_project != null ?
                new ObjectParameter("id_project", id_project) :
                new ObjectParameter("id_project", typeof(string));
    
            var floorParameter = floor.HasValue ?
                new ObjectParameter("floor", floor) :
                new ObjectParameter("floor", typeof(int));
    
            var roomParameter = room.HasValue ?
                new ObjectParameter("room", room) :
                new ObjectParameter("room", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(double));
    
            var id_town_regionParameter = id_town_region.HasValue ?
                new ObjectParameter("id_town_region", id_town_region) :
                new ObjectParameter("id_town_region", typeof(int));
    
            var id_areaParameter = id_area.HasValue ?
                new ObjectParameter("id_area", id_area) :
                new ObjectParameter("id_area", typeof(int));
    
            var id_districtParameter = id_district.HasValue ?
                new ObjectParameter("id_district", id_district) :
                new ObjectParameter("id_district", typeof(int));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var avatarParameter = avatar != null ?
                new ObjectParameter("avatar", avatar) :
                new ObjectParameter("avatar", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertProperty3", id_real_estate_typeParameter, id_projectParameter, floorParameter, roomParameter, priceParameter, id_town_regionParameter, id_areaParameter, id_districtParameter, statusParameter, nameParameter, avatarParameter);
        }
    
        public virtual int sp_InsertProp(Nullable<int> id_real_estate_type, string id_project, Nullable<int> floor, Nullable<int> room, Nullable<double> price, Nullable<int> id_town_region, Nullable<int> id_area, Nullable<int> id_district, string status, string name, byte[] avatar)
        {
            var id_real_estate_typeParameter = id_real_estate_type.HasValue ?
                new ObjectParameter("id_real_estate_type", id_real_estate_type) :
                new ObjectParameter("id_real_estate_type", typeof(int));
    
            var id_projectParameter = id_project != null ?
                new ObjectParameter("id_project", id_project) :
                new ObjectParameter("id_project", typeof(string));
    
            var floorParameter = floor.HasValue ?
                new ObjectParameter("floor", floor) :
                new ObjectParameter("floor", typeof(int));
    
            var roomParameter = room.HasValue ?
                new ObjectParameter("room", room) :
                new ObjectParameter("room", typeof(int));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("price", price) :
                new ObjectParameter("price", typeof(double));
    
            var id_town_regionParameter = id_town_region.HasValue ?
                new ObjectParameter("id_town_region", id_town_region) :
                new ObjectParameter("id_town_region", typeof(int));
    
            var id_areaParameter = id_area.HasValue ?
                new ObjectParameter("id_area", id_area) :
                new ObjectParameter("id_area", typeof(int));
    
            var id_districtParameter = id_district.HasValue ?
                new ObjectParameter("id_district", id_district) :
                new ObjectParameter("id_district", typeof(int));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var avatarParameter = avatar != null ?
                new ObjectParameter("avatar", avatar) :
                new ObjectParameter("avatar", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertProp", id_real_estate_typeParameter, id_projectParameter, floorParameter, roomParameter, priceParameter, id_town_regionParameter, id_areaParameter, id_districtParameter, statusParameter, nameParameter, avatarParameter);
        }
    
        public virtual ObjectResult<getAllProp_Result> getAllProp()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAllProp_Result>("getAllProp");
        }
    }
}
