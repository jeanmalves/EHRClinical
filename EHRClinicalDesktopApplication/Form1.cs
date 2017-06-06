using EHRServerApi;
using Model.DAO;
using OpenEhr.AM.Archetype;
using OpenEhr.Factories;
using OpenEhr.Futures.OperationalTemplate;
using OpenEhr.Paths;
using OpenEhr.RM.Demographic.Impl;
using OpenEhr.RM.Ehr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EHRClinicalDesktopApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openEHRTest();
        }

        public void openEHRTest()
        {
            //User user = new User();
            //user.UserName = "jeanmalves";
            //user.Password = "82959111";

            //EHRServer ehrServer= new EHRServer(user);
            //var token = ehrServer.Login();


            XmlReader xml = XmlReader.Create(@"C:\Users\Public\Documents\My Clinical Models\Sample Set\Templates\Sample Simple Blood pressure.opt");
            OperationalTemplate opt = new OperationalTemplate();
            opt.ReadXml(xml);

            // template
            var template = opt.TemplateId;
            // conceito
            opt.Concept.ToString();
            // idioma
            opt.Language.CodeString.ToString();
            // restrições
            var constraints = opt.Constraints;
            // autor original
            var author = opt.Description.OriginalAuthor;
            // view constraints
            var viewConstraints = opt.View.Constraints;
            // termos
            var terms = opt.Definition.TermDefinitions;

            var anotations = opt.Annotations;
            CArchetypeRoot archetypeRoot = opt.Definition;

            var binding = archetypeRoot.TermBindings;

           /* string pa = "";
            while ( archetypeRoot.Attributes.Count() > 0)
            {
                foreach (var item in archetypeRoot.Attributes)
                {
                    if(item.Children.Count() > 0)
                    {
                        foreach (var children in item.Children)
                        {
                            pa = pa + children.Path;
                        }
                    }
                }
            }

            */

            Path p = new Path("/data[at0001]/events[at0006]/data[at0003]/items[at0004]/value");
            string currentName = p.Value;
            
            XmlReader xml2 = XmlReader.Create(@"C:\Users\Public\Documents\My Clinical Models\Sample Set\Archetypes\entry\observation\"+ archetypeRoot.ArchetypeId + ".xml");
            
            //Archetype ar = new Archetype();
            //var hash = archetypeRoot.TermDefinitions.Item("at0004").Items.Item("text");
            //ar.ReadXml(xml2);
            
           // var t = ar.Ontology.TermDefinition("en", "at0004") ;

            
        }
    }
}
