using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Strategy
{
    public class MakeItXML : IStrategy
    {
        public string DoThing(TestClass test)
        {
            using (var stringwriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(test.GetType());
                serializer.Serialize(stringwriter, test);
                return stringwriter.ToString();
            }
        }
    }
}
