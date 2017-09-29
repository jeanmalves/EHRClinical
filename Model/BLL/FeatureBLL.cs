using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BLL
{
    public static class FeatureBLL
    {
        public static List<Feature> GetFeatures()
        {
            ClinicalEntities db = new ClinicalEntities();

            try
            {
                return db.Features.ToList();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public static List<Feature> GetFeaturesByRole(int? Role)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                var features = db.Features
                                 .Where(f => f.DisplayMenu == 1)
                                 .Where(f => f.status == 1)
                                 .Where(f => f.FeatureGroups.Any(g => g.RoleGroupID == Role))   
                                 .ToList();

                return features;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public static Feature GetFeatureById(int? featureId)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                return db.Features.Find(featureId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static bool UpdateFeature(Feature feature, int roleGroupId)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();

                var featureObj = db.Features.Find(feature.Id);

                featureObj.Name = feature.Name;
                featureObj.Description = feature.Description;
                featureObj.DisplayMenu = feature.DisplayMenu;
                featureObj.status = feature.status;
                featureObj.UpdatedAt = DateTime.Now;
                featureObj.UserId = feature.UserId;

                var featureGroup = db.FeatureGroups.FirstOrDefault(f => f.FeatureID == feature.Id);

                featureGroup.RoleGroupID = roleGroupId;

                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
