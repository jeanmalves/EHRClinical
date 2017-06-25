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
            ClinicalEntities db = new ClinicalEntities();

            try
            {
                var features = db.Features
                                 .Where(f => f.DisplayMenu == 1)
                                 .Where(f => f.FeatureGroups.Any(g => g.RoleGroupID == Role))   
                                 .ToList();

                return features;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
