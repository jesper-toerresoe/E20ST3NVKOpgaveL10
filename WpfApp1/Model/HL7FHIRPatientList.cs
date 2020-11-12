using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model.List
{
    

    public class HL7FHIRPatientList //Rootobject
    {
        public string resourceType { get; set; }
        public string type { get; set; }
        public Entry[] entry { get; set; }
        public int total { get; set; }
        public Link[] link { get; set; }
        public string id { get; set; }
        public Meta meta { get; set; }
    }

    

    public class Entry
    {
        public string fullUrl { get; set; }
        public Search search { get; set; }
        public Resource resource { get; set; }
    }

    public class Search
    {
        public string mode { get; set; }
    }

    public class Resource
    {
        public string resourceType { get; set; }
        public Text text { get; set; }
        public Identifier[] identifier { get; set; }
        public bool active { get; set; }
        public Name[] name { get; set; }
        public Telecom[] telecom { get; set; }
        public string gender { get; set; }
        public string birthDate { get; set; }
        public bool deceasedBoolean { get; set; }
        public Address[] address { get; set; }
        public bool multipleBirthBoolean { get; set; }
        public Communication[] communication { get; set; }
        public string id { get; set; }
        public Meta meta { get; set; }
        public Extension[] extension { get; set; }
        public _Birthdate _birthDate { get; set; }
        public int multipleBirthInteger { get; set; }
        public Managingorganization managingOrganization { get; set; }
        public Link[] link { get; set; }
        public Contact[] contact { get; set; }
        public Maritalstatus maritalStatus { get; set; }
        public Generalpractitioner[] generalPractitioner { get; set; }
    }

    public class Text
    {
        public string status { get; set; }
        public string div { get; set; }
    }

    public class Meta
    {
        public string versionId { get; set; }
        public DateTime lastUpdated { get; set; }
        public Tag[] tag { get; set; }
        public Security[] security { get; set; }
    }

    public class Tag
    {
        public string system { get; set; }
        public string code { get; set; }
    }

    public class Security
    {
        public string system { get; set; }
        public string code { get; set; }
        public string display { get; set; }
    }

    public class _Birthdate
    {
        public Extension[] extension { get; set; }
    }

    public class Extension
    {
        public string url { get; set; }
        public DateTime valueDateTime { get; set; }
    }

    public class Managingorganization
    {
        public string reference { get; set; }
    }

    public class Maritalstatus
    {
        public Coding[] coding { get; set; }
    }

    public class Coding
    {
        public string system { get; set; }
        public string code { get; set; }
        public string display { get; set; }
    }

    public class Identifier
    {
        public string use { get; set; }
        public string system { get; set; }
        public string value { get; set; }
        public Type type { get; set; }
    }

    public class Type
    {
        public Coding[] coding { get; set; }
        public string text { get; set; }
    }

    //public class Coding1
    //{
    //    public string system { get; set; }
    //    public string code { get; set; }
    //}

    public class Name
    {
        public string use { get; set; }
        public string family { get; set; }
        public string[] given { get; set; }
        public string[] suffix { get; set; }
        public string[] prefix { get; set; }
    }

    public class Telecom
    {
        public string system { get; set; }
        public string value { get; set; }
        public string use { get; set; }
    }

    public class Address
    {
        public string use { get; set; }
        public string[] line { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
        public string country { get; set; }
    }

    public class Communication
    {
        public Language language { get; set; }
        public bool preferred { get; set; }
    }

    public class Language
    {
        public Coding[] coding { get; set; }
        public string text { get; set; }
    }

    //public class Coding2
    //{
    //    public string system { get; set; }
    //    public string code { get; set; }
    //    public string display { get; set; }
    //}

    //public class Extension1
    //{
    //    public string url { get; set; }
    //    public Valueaddress valueAddress { get; set; }
    //    public Valuecodeableconcept valueCodeableConcept { get; set; }
    //    public string valueString { get; set; }
    //}

    public class Valueaddress
    {
        public string city { get; set; }
        public string country { get; set; }
    }

    public class Valuecodeableconcept
    {
        public Coding[] coding { get; set; }
    }

    //public class Coding3
    //{
    //    public string system { get; set; }
    //    public string code { get; set; }
    //    public string display { get; set; }
    //}

    public class Link
    {
        public Other other { get; set; }
        public string type { get; set; }
    }

    public class Other
    {
        public string reference { get; set; }
    }

    public class Contact
    {
        public Relationship[] relationship { get; set; }
        public Name name { get; set; }
        public Telecom[] telecom { get; set; }
    }

    //public class Name1
    //{
    //    public string use { get; set; }
    //    public string family { get; set; }
    //    public string[] given { get; set; }
    //}

    public class Relationship
    {
        public Coding[] coding { get; set; }
    }

    //public class Coding4
    //{
    //    public string system { get; set; }
    //    public string code { get; set; }
    //    public string display { get; set; }
    //}

    //public class Telecom1
    //{
    //    public string system { get; set; }
    //    public string value { get; set; }
    //    public string use { get; set; }
    //}

    public class Generalpractitioner
    {
        public string reference { get; set; }
        public string display { get; set; }
    }

    //public class Link1
    //{
    //    public string relation { get; set; }
    //    public string url { get; set; }
    //}

}
