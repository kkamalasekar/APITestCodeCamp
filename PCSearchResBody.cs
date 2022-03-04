using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AusPostTest
{
    class PCSearchResBody
    {
    public Localities localities { get; set; }
}

public class Localities
{
    public Locality locality { get; set; }
}

public class Locality
{
    public string category { get; set; }
    public int id { get; set; }
    public float latitude { get; set; }
    public string location { get; set; }
    public float longitude { get; set; }
    public int postcode { get; set; }
    public string state { get; set; }
}

}
