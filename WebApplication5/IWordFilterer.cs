using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebApplication5
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWordFilter" in both code and config file together.
    [ServiceContract]
    public interface IWordFilterer
    {
        [OperationContract]
        string WordFilterer(string word);
    }
}
