using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

public class ProfileConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return typeof(Profile).IsAssignableFrom(objectType);
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        JObject jObject = JObject.FromObject(value, serializer);
        jObject.Add("Type", value.GetType().Name);
        jObject.WriteTo(writer);
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        JObject jObject = JObject.Load(reader);
        string type = jObject["Type"]?.ToString();

        Profile profile;
        switch (type)
        {
            case "UserProfile":
                profile = jObject.ToObject<UserProfile>(serializer);
                break;
            default:
                throw new NotSupportedException($"Unknown profile type: {type}");
        }

        return profile;
    }
}
