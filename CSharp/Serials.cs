using System.Runtime.Serialization; //Datacontract Attributes
using System.Runtime.Serialization.Json;
using System.IO; //memorystream

namespace CSharp
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
    }
    // To serialize the Person object we would so the following:
    public class serializePeople {
        public void serializePerson() {
            Person p = new Person
            {
                Name = "Jack",
                Age = 45
            };

            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Person));
            ser.WriteObject(stream1, p);
            // The memory stream stream1 contains the JSON data:
            // {
            //     "Name": "Jack",
            //     "Age": 45
            // }
            // The below line of code could be used to get the Person object back from the JSON data:
            Person p2 = (Person)ser.ReadObject(stream1);
            
        }
    }
}