using OpenEhr.AM.Archetype;
using OpenEhr.Factories;
using OpenEhr.Futures.OperationalTemplate;
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
           /* MyOpenEHR myEHR = new MyOpenEHR();
            Person person = new Person("1233456456");
            MyPerson person2 = new MyPerson();
            OperationalTemplate opt = new OperationalTemplate();
            */
            Archetype aq = new Archetype();
            
            XmlReader xml = XmlReader.Create(@"C:\Users\jeam\Documents\TCC\openEHR-EHR-OBSERVATION.respiration.v1.xml");
            xml.Read();
           aq.ReadXml(xml);
        }
    }
}
