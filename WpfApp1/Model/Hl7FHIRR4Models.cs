using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.Model;

namespace WpfApp1.Model
{
    class Hl7FHIRR4Models
    {
    }


    public class Rootobject
    {
        public string resourceType { get; set; }
        public string type { get; set; }
        public Entry[] entry { get; set; }
        public int total { get; set; }
        public Link[] link { get; set; }
        public string id { get; set; }
        public Meta meta { get; set; }
    }

    public class Meta
    {
        public string versionId { get; set; }
        public DateTime lastUpdated { get; set; }
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
        public Name[] name { get; set; }
        public string gender { get; set; }
        public string birthDate { get; set; }
        public string id { get; set; }
        public Meta1 meta { get; set; }
        public Text text { get; set; }
        public Extension[] extension { get; set; }
        public Identifier[] identifier { get; set; }
        public Telecom[] telecom { get; set; }
        public Address[] address { get; set; }
        public Communication[] communication { get; set; }
        public bool active { get; set; }
    }

    public class Meta1
    {
        public string versionId { get; set; }
        public DateTime lastUpdated { get; set; }
        public Tag[] tag { get; set; }
    }

    public class Tag
    {
        public string system { get; set; }
        public string code { get; set; }
    }

    public class Text
    {
        public string status { get; set; }
        public string div { get; set; }
    }

    public class Name
    {
        public string family { get; set; }
        public string[] given { get; set; }
        public string[] prefix { get; set; }
        public string use { get; set; }
    }

    public class Extension
    {
        public string url { get; set; }
        public Valueaddress valueAddress { get; set; }
        public Valuecodeableconcept valueCodeableConcept { get; set; }
    }

    public class Valueaddress
    {
        public string city { get; set; }
        public string country { get; set; }
    }

    public class Valuecodeableconcept
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
        public string system { get; set; }
        public string value { get; set; }
    }

    public class Telecom
    {
        public string system { get; set; }
        public string value { get; set; }
        public string use { get; set; }
    }

    public class Address
    {
        public string[] line { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
    }

    public class Communication
    {
        public Language language { get; set; }
        public bool preferred { get; set; }
    }

    public class Language
    {
        public Coding1[] coding { get; set; }
    }

    public class Coding1
    {
        public string system { get; set; }
        public string code { get; set; }
        public string display { get; set; }
    }

    public class Link
    {
        public string relation { get; set; }
        public string url { get; set; }
    }

}
