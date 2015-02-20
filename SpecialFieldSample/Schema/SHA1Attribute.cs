using System.Web.Security;
using CodeComb.Yuuko.Schema;

namespace CodeComb.Yuuko.Schema
{
    public class SHA1Attribute : SpecialFieldAttribute
    {
        public override object SetFieldValue(object Value, object DataSource, DetailPortFunction Method)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(Value.ToString(), "SHA1");
        }
    }
}