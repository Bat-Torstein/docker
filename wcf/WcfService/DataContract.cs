using System.Runtime.Serialization;

namespace Shared
{
    [DataContract]
    public class Expression
    {
        [DataMember]
        public int FirstNumber { get; set; }
        [DataMember]
        public int SecondNumber { get; set; }
        [DataMember]
        public Operator Operation { get; set; }
    }

    public enum Operator
    {
        ADD,
        MULTIPLY
    }
}
