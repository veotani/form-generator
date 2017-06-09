using Newtonsoft.Json;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
using System.Threading.Tasks;

namespace Form.FormManager
{


    public class FormGenerator
    {
        public string GenerateFormByType<T>()
        {
            JSchemaGenerator generator = new JSchemaGenerator()
            {
                DefaultRequired = Required.DisallowNull
            };
            var schema = @generator.Generate(typeof(T)).ToString();
            schema = "{\"schema\":" + schema;
            schema = schema + "," + GetOnSumbitCode();
            return schema;            
        }
        public string GetOnSumbitCode()
        {
            string OnSumbit = @"
                onSubmit: function(errors, values) {
                    console.log(JSON.stringify(values, null, 2))
                }
            }";
            return OnSumbit;
        }
    }


}