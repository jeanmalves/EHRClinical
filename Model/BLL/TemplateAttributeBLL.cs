using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.BLL
{
    public static class TemplateAttributeBLL
    {
        public static List<TemplateAttribute> GetAttributeByTemplate(int opt)
        {
            ClinicalEntities db = new ClinicalEntities();

            try
            {
                var attribubtes = db.TemplateAttributes
                                    .Where(at => at.OpTempId == opt)
                                    .ToList();

                return attribubtes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<DataListAttribute> GetDataListAttribute(int attributeId)
        {
            ClinicalEntities db = new ClinicalEntities();

            try
            {
                var list = db.DataListAttributes
                             .Where(data => data.AttributeId == attributeId)
                             .ToList();

                return list;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void AddDataAttribute(Data data)
        {
            try
            {
                ClinicalEntities db = new ClinicalEntities();
                
                db.Data1.Add(data);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
