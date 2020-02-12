using System;

namespace Attributes
{
    
    [System.AttributeUsage(System.AttributeTargets.Class |  
                        System.AttributeTargets.Struct,  
                        AllowMultiple = true)  // multiuse attribute  
    ]  
    public class Author : System.Attribute  
    {
        private string name;  
        public double version;  

        public Author(string name)  
        {  
            this.name = name;  
            version = 1.0;  
        }  
    }

    [Serializable()]
    public class MyCustomException : System.Exception
    {
        public MyCustomException() : base() { }
        public MyCustomException(string message) : base(message) { }
        public MyCustomException(string message, System.Exception inner) 
            : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected MyCustomException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    }
}