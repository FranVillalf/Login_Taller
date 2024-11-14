using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Esta clase deserealiza un json
namespace Login_Taller.Genericos 
{
    public class LeerJson
    {
        public POJO.LoginData Login_data()
        {
            var json = JsonConvert.DeserializeObject<POJO.LoginData>(File.ReadAllText(@"..\ ..\ Data\login.json"));
            return json;
        }
    }
}
