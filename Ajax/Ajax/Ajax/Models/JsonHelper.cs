using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Ajax.Models
{
    public class JsonHelper
    {
        public List<Student> GetStudent(string Json)
        {
            var js = new JavaScriptSerializer();

           
            List<Student> ojb = (List<Student>)js.Deserialize(Json, typeof(Student));

            return ojb;
        }

        public JObject ReadJSONData(string jsonFilename)
        {
            try
            {
                JObject jObject;
                // Read JSON directly from a file  
                using (StreamReader file = System.IO.File.OpenText(jsonFilename))
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    jObject = (JObject)JToken.ReadFrom(reader);
                }
                return jObject;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occurred : " + ex.Message);
                return null;
            }
        }
    }
}