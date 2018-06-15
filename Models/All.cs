// Generated by https://quicktype.io

namespace demo1.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class All
    {
        [JsonProperty("help")]
        public string Help { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("result")]
        public Result Result { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("resource_id")]
        public string ResourceId { get; set; }

        [JsonProperty("fields")]
        public Field[] Fields { get; set; }

        [JsonProperty("records")]
        public Record[] Records { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }
    }

    public partial class Field
    {
        [JsonProperty("type")]
        public FieldType Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public partial class Links
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public partial class Record
    {
        [JsonProperty("Ticketinfo")]
        public Ticketinfo Ticketinfo { get; set; }

        [JsonProperty("Zone")]
        public string Zone { get; set; }

        [JsonProperty("Px")]
        public string Px { get; set; }

        [JsonProperty("Py")]
        public string Py { get; set; }

        [JsonProperty("Add")]
        public string Add { get; set; }

        [JsonProperty("Gov")]
        public Gov Gov { get; set; }

        [JsonProperty("Class2")]
        public string Class2 { get; set; }

        [JsonProperty("Class1")]
        public string Class1 { get; set; }

        [JsonProperty("Website")]
        public string Website { get; set; }

        [JsonProperty("Opentime")]
        public string Opentime { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Remarks")]
        public string Remarks { get; set; }

        [JsonProperty("Parkinginfo_py")]
        public ParkinginfoPy ParkinginfoPy { get; set; }

        [JsonProperty("Parkinginfo_px")]
        public ParkinginfoPx ParkinginfoPx { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Level")]
        public string Level { get; set; }

        [JsonProperty("Picture1")]
        public string Picture1 { get; set; }

        [JsonProperty("Toldescribe")]
        public string Toldescribe { get; set; }

        [JsonProperty("Changetime")]
        public System.DateTimeOffset Changetime { get; set; }

        [JsonProperty("Tel")]
        public string Tel { get; set; }

        [JsonProperty("Picdescribe1")]
        public string Picdescribe1 { get; set; }

        [JsonProperty("Travellinginfo")]
        public Travellinginfo Travellinginfo { get; set; }

        [JsonProperty("_id")]
        public long RecordId { get; set; }

        [JsonProperty("Id")]
        public string Id { get; set; }
    }

    public enum FieldType { Int4, Numeric, Text, Timestamp };

    public enum Gov { The397000000A };

    public enum ParkinginfoPx { The0, The12029248, The12068902 };

    public enum ParkinginfoPy { The0, The2261848, The229137 };

    public enum Ticketinfo { DiY手做教學200元人提供用餐服務150人, Empty, 免費參觀, 新台幣50元 };

    public enum Travellinginfo { Empty };

    public partial class All
    {
        public static All FromJson(string json) => JsonConvert.DeserializeObject<All>(json, demo1.Models.Converter.Settings);
    }

    static class FieldTypeExtensions
    {
        public static FieldType? ValueForString(string str)
        {
            switch (str)
            {
                case "int4": return FieldType.Int4;
                case "numeric": return FieldType.Numeric;
                case "text": return FieldType.Text;
                case "timestamp": return FieldType.Timestamp;
                default: return null;
            }
        }

        public static FieldType ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this FieldType value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case FieldType.Int4: serializer.Serialize(writer, "int4"); break;
                case FieldType.Numeric: serializer.Serialize(writer, "numeric"); break;
                case FieldType.Text: serializer.Serialize(writer, "text"); break;
                case FieldType.Timestamp: serializer.Serialize(writer, "timestamp"); break;
            }
        }
    }

    static class GovExtensions
    {
        public static Gov? ValueForString(string str)
        {
            switch (str)
            {
                case "397000000A": return Gov.The397000000A;
                default: return null;
            }
        }

        public static Gov ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Gov value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Gov.The397000000A: serializer.Serialize(writer, "397000000A"); break;
            }
        }
    }

    static class ParkinginfoPxExtensions
    {
        public static ParkinginfoPx? ValueForString(string str)
        {
            switch (str)
            {
                case "0": return ParkinginfoPx.The0;
                case "120.29248": return ParkinginfoPx.The12029248;
                case "120.68902": return ParkinginfoPx.The12068902;
                default: return null;
            }
        }

        public static ParkinginfoPx ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this ParkinginfoPx value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case ParkinginfoPx.The0: serializer.Serialize(writer, "0"); break;
                case ParkinginfoPx.The12029248: serializer.Serialize(writer, "120.29248"); break;
                case ParkinginfoPx.The12068902: serializer.Serialize(writer, "120.68902"); break;
            }
        }
    }

    static class ParkinginfoPyExtensions
    {
        public static ParkinginfoPy? ValueForString(string str)
        {
            switch (str)
            {
                case "0": return ParkinginfoPy.The0;
                case "22.61848": return ParkinginfoPy.The2261848;
                case "22.9137": return ParkinginfoPy.The229137;
                default: return null;
            }
        }

        public static ParkinginfoPy ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this ParkinginfoPy value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case ParkinginfoPy.The0: serializer.Serialize(writer, "0"); break;
                case ParkinginfoPy.The2261848: serializer.Serialize(writer, "22.61848"); break;
                case ParkinginfoPy.The229137: serializer.Serialize(writer, "22.9137"); break;
            }
        }
    }

    static class TicketinfoExtensions
    {
        public static Ticketinfo? ValueForString(string str)
        {
            switch (str)
            {
                case "DIY手做教學 200元/人提供用餐服務 150/人": return Ticketinfo.DiY手做教學200元人提供用餐服務150人;
                case "": return Ticketinfo.Empty;
                case "免費參觀": return Ticketinfo.免費參觀;
                case "新台幣50元": return Ticketinfo.新台幣50元;
                default: return null;
            }
        }

        public static Ticketinfo ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Ticketinfo value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Ticketinfo.DiY手做教學200元人提供用餐服務150人: serializer.Serialize(writer, "DIY手做教學 200元/人提供用餐服務 150/人"); break;
                case Ticketinfo.Empty: serializer.Serialize(writer, ""); break;
                case Ticketinfo.免費參觀: serializer.Serialize(writer, "免費參觀"); break;
                case Ticketinfo.新台幣50元: serializer.Serialize(writer, "新台幣50元"); break;
            }
        }
    }

    static class TravellinginfoExtensions
    {
        public static Travellinginfo? ValueForString(string str)
        {
            switch (str)
            {
                case "": return Travellinginfo.Empty;
                default: return null;
            }
        }

        public static Travellinginfo ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Travellinginfo value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Travellinginfo.Empty: serializer.Serialize(writer, ""); break;
            }
        }
    }

    public static class Serialize
    {
        public static string ToJson(this All self) => JsonConvert.SerializeObject(self, demo1.Models.Converter.Settings);
    }

    internal class Converter: JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FieldType) || t == typeof(Gov) || t == typeof(ParkinginfoPx) || t == typeof(ParkinginfoPy) || t == typeof(Ticketinfo) || t == typeof(Travellinginfo) || t == typeof(FieldType?) || t == typeof(Gov?) || t == typeof(ParkinginfoPx?) || t == typeof(ParkinginfoPy?) || t == typeof(Ticketinfo?) || t == typeof(Travellinginfo?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (t == typeof(FieldType))
                return FieldTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(Gov))
                return GovExtensions.ReadJson(reader, serializer);
            if (t == typeof(ParkinginfoPx))
                return ParkinginfoPxExtensions.ReadJson(reader, serializer);
            if (t == typeof(ParkinginfoPy))
                return ParkinginfoPyExtensions.ReadJson(reader, serializer);
            if (t == typeof(Ticketinfo))
                return TicketinfoExtensions.ReadJson(reader, serializer);
            if (t == typeof(Travellinginfo))
                return TravellinginfoExtensions.ReadJson(reader, serializer);
            if (t == typeof(FieldType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return FieldTypeExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(Gov?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return GovExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(ParkinginfoPx?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return ParkinginfoPxExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(ParkinginfoPy?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return ParkinginfoPyExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(Ticketinfo?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return TicketinfoExtensions.ReadJson(reader, serializer);
            }
            if (t == typeof(Travellinginfo?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return TravellinginfoExtensions.ReadJson(reader, serializer);
            }
            throw new Exception("Unknown type");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var t = value.GetType();
            if (t == typeof(FieldType))
            {
                ((FieldType)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(Gov))
            {
                ((Gov)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(ParkinginfoPx))
            {
                ((ParkinginfoPx)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(ParkinginfoPy))
            {
                ((ParkinginfoPy)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(Ticketinfo))
            {
                ((Ticketinfo)value).WriteJson(writer, serializer);
                return;
            }
            if (t == typeof(Travellinginfo))
            {
                ((Travellinginfo)value).WriteJson(writer, serializer);
                return;
            }
            throw new Exception("Unknown type");
        }

        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = { 
                new Converter(),
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}