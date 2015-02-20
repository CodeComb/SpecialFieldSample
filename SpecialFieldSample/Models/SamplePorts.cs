using System.Collections.Generic;
using CodeComb.Yuuko;
using CodeComb.Yuuko.Schema;

namespace SpecialFieldSample.Models
{
    public class SamplePorts : PortsContext
    {
        public SamplePorts()
        {
            UserSource = new List<User>();
            UserSource.Add(new User { Username="admin", Password = "7c4a8d09ca3762af61e59520943dc26494f8941b" });
        }

        public List<User> UserSource { get; set; }

        [CollectionPort]
        [Binding("UserSource")]
        public List<User> UserCollectionPort { get; set; }

        [DetailPort(DetailPortFunction.Edit)]
        [Binding("UserSource")]
        public User UserPort { get; set; }
    }
}