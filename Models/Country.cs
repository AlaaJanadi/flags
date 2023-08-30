
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Flags.Models
{

    public class Country
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [BsonElement("ID")]
        public int TheId { get; set; }
        public Name Name { get; set; }
        public Name Capital { get; set; }
        public string Continent { get; set; }
        public string tld { get; set; }
        public string area { get; set; }
        public string arearank { get; set; }
        public string population { get; set; }
    }


    public class Name
    {
        public string eng { get; set; }
        public string ar { get; set; }
        public string de { get; set; }
        public string fr { get; set; }
        public string tr { get; set; }
        public string es { get; set; }
        public string por { get; set; }
        public string ita { get; set; }
        public string nor { get; set; }
        public string swe { get; set; }
        public string fin { get; set; }
        public string rus { get; set; }
        public string pol { get; set; }
        public string ukr { get; set; }
        public string rum { get; set; }
        public string hun { get; set; }
        public string dut { get; set; }
        public string ces { get; set; }
        public string jpn { get; set; }
        public string cmn { get; set; }
        public string hin { get; set; }
        public string per { get; set; }
        public string urd { get; set; }
        public string may { get; set; }
        public string ind { get; set; }
    }

}
