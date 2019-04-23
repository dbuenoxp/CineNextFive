using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.Common.JSON
{
    public class JsonManager : IJsonManager
    {
        public byte[] CreateBinaryData<T>(T TObject)
        {
            if (TObject == null)
                return null;


            byte[] binaryData;
            JsonSerializer serializer = new JsonSerializer();
            using (MemoryStream ms = new MemoryStream())
            {
                using (BsonWriter bsonWriter = new BsonWriter(ms))
                {
                    serializer.Serialize(bsonWriter, TObject);
                }
                binaryData = ms.ToArray();
            }

            return binaryData;
        }

        public string CreateStringB64FromData<T>(T TObject)
        {
            byte[] binaryData = this.CreateBinaryData(TObject);

            var b64 = Convert.ToBase64String(binaryData);

            //var str = System.Text.Encoding.UTF8.GetString(binaryData);
            //var STR2 = System.Text.Encoding.UTF8.GetBytes(str);
            //var b64_2 = Convert.ToBase64String(STR2);

            return b64;
        }

        public T CreateDataFromBase64String<T>(string stringBase64)
        {
            JsonSerializer serializer = new JsonSerializer();
            stringBase64 = stringBase64.Replace(' ', '+');
            var binaryData = Convert.FromBase64String(stringBase64);

            //var binaryData2 = System.Text.Encoding.UTF8.GetBytes(stringBase64);
            //var demo = System.Text.Encoding.UTF8.GetString(binaryData2);
            //var demo2 = Convert.FromBase64String(demo);

            MemoryStream oMemoryStream = new MemoryStream(binaryData);
            JsonReader oBsonReader = new BsonReader(oMemoryStream);

            var d = serializer.Deserialize<T>(oBsonReader);

            return d;
        }
    }
}
