using NJsonSchema;

namespace FormEngine.FormManager
{
    class FormGenerator
    {
        public string GenerateForm<T>()
        {
            var schema = JsonSchema4.FromTypeAsync(typeof(T)).Result;
            var schemaData = schema.ToJson();
            return schemaData;
        }
    }
}
