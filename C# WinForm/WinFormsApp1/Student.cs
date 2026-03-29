using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WinFormsApp1
{
    public class Student
    {
        public ObjectId _id { get; set; }
        public string? name { get; set; }
        public string? gender { get; set; }
        public byte age { get; set; }
        public int score { get; set; }

        [BsonElement("grade")]
        public string grade {
            get {
                return score switch
                {
                    >= 90 => "A",
                    >= 80 => "B",
                    >= 70 => "C",
                    >= 60 => "D",
                    >= 50 => "E",
                    _ => "F"
                };
            }
        }
    }
}
