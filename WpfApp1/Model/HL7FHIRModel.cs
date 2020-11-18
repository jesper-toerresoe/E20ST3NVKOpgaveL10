using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    class HL7FHIRModel
    {
    }




    public class Patient
    {
        public string resourceType { get; set; }
        public string id { get; set; }
        public Meta meta { get; set; }
        public Extension[] extension { get; set; }
        public Identifier[] identifier { get; set; }
        public Name[] name { get; set; }
        public Telecom[] telecom { get; set; }
        public string gender { get; set; }
        public string birthDate { get; set; }
        public _Birthdate _birthDate { get; set; }
        public bool deceasedBoolean { get; set; }
        public Address[] address { get; set; }
        public Contact[] contact { get; set; }
    }

    public class Meta
    {
        public string versionId { get; set; }
        public DateTime lastUpdated { get; set; }
    }

    public class _Birthdate
    {
        public Extension[] extension { get; set; }
    }

    public class Extension
    {
        public string url { get; set; }
        public DateTime valueDateTime { get; set; }
        public Valueaddress valueAddress { get; set; }
    }

    public class Extension1
    {
        public string url { get; set; }
        public Valueaddress valueAddress { get; set; }
    }

    public class Valueaddress
    {
        public string city { get; set; }
    }

    public class Identifier
    {
        public string system { get; set; }
        public string value { get; set; }
    }

    public class Name
    {
        public string use { get; set; }
        public string family { get; set; }
        public string[] given { get; set; }
        public string[] prefix { get; set; }
    }

    public class Telecom
    {
        public string system { get; set; }
        public string value { get; set; }
        public string use { get; set; }
        public int rank { get; set; }
        public Period period { get; set; }
    }

    public class Period
    {
        public string end { get; set; }
    }

    public class Address
    {
        public string[] line { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
    }

    public class Contact
    {
        public Relationship[] relationship { get; set; }
        public Name1 name { get; set; }
        public Telecom1[] telecom { get; set; }
        public string gender { get; set; }
    }

    public class Name1
    {
        public string family { get; set; }
        public string[] given { get; set; }
    }

    public class Relationship
    {
        public Coding[] coding { get; set; }
    }

    public class Coding
    {
        public string system { get; set; }
        public string code { get; set; }
    }

    public class Telecom1
    {
        public string system { get; set; }
        public string value { get; set; }
        public string use { get; set; }
    }



    //public class Rootobject
    //{
    //    public Class1[] Property1 { get; set; }
    //}

    //public class Class1
    //{
    //    public string Name { get; set; }
    //    public DateTime Created { get; set; }
    //    public bool Active { get; set; }
    //    public string[] Nicknames { get; set; }
    //}


}
