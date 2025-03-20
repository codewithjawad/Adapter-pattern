using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace adaptertask
{
    internal class ConvertxmltoJSON: XML
    {
        XMLCODE xmlvar;
        public ConvertxmltoJSON(XMLCODE xmlvar)
        {
            this.xmlvar = xmlvar;
        }
        public String Convert()
        {
            return xmlvar.XMLCODEFORMAT() +"Converted to JSON CODE";
        }
    }
}
