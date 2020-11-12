using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

namespace WindowsFormsApp1.Boundary
{
    class HL7FHIRR4Boundary
    {
        //https://www.hl7.org/fhir/administration-module.html
        //https://www.hl7.org/fhir/patient.html
        Patient pat;// = new Patient();
        Patient cpat;

        Identifier id; // = new Identifier();

        //public HL7FHIRR4Boundary(Patient pat, Identifier id)
        //{
        //    this.pat = pat ?? throw new ArgumentNullException(nameof(pat));
        //    this.id = id ?? throw new ArgumentNullException(nameof(id));
        //}

        //[Obsolete]
        public void HandlePatient()
        {
            var locpat = new Patient();
            locpat.Active = true;
            locpat.ActiveElement = new FhirBoolean(true);

            var id = new Identifier();

            id.System = "http://hl7.org/fhir/sid/us-ssn";
            id.Value = "000-12-3456";

            locpat.Identifier.Add(id);

            var contact = new Patient.ContactComponent();
            contact.Name = new HumanName();
            contact.Name.Family = "Parks";

            // setup other contact details

            locpat.Contact.Add(contact);
            locpat.Gender = AdministrativeGender.Male;

            var deceased_date = new FhirDateTime("2015-04-23");
            locpat.Deceased = deceased_date;
            locpat.Deceased = new FhirBoolean(false);
            locpat.Name.Add(new HumanName().WithGiven("Christopher").WithGiven("C.H.").AndFamily("Parks"));
            HumanName hn = new HumanName();
            hn.Text = "Peter Ole Sørensen";

            var birthplace = new Extension();
            birthplace.Url = "http://hl7.org/fhir/StructureDefinition/birthPlace";
            birthplace.Value = new Address() { City = "Seattle" };
            pat.Extension.Add(birthplace);

            var birthtime = new Extension("http://hl7.org/fhir/StructureDefinition/patient-birthTime",
                                           new FhirDateTime(1983, 4, 23, 7, 44, 10));
            pat.BirthDateElement.Extension.Add(birthtime);
        }

        public void Boundary_HL7FHIR_REST()
        {
            var client = new FhirClient("https://vonk.fire.ly");
            //var k = new Fhir
            //client.PreferredFormat = ResourceFormat.Unknown;
            // client.UseFormatParam = true; //depends on the sever  format in url or in header (default)
            // client.ReturnFullResource = false; //Give minimal response
            client.Timeout = 120000; // The timeout is set in milliseconds, with a default of 100000

            //var location_A = new Uri("https://vonk.fire.ly/Patient/58689c4c-daf4-450b-a1ca-7c1846bb65b5");
            //var pat_A = client.Read<Patient>(location_A);
            // or
            //var pat_A = client.Read<Patient>("Patient/58689c4c-daf4-450b-a1ca-7c1846bb65b5");
            var pat_A = client.Read<Patient>("Patient/b46b6f29-fb93-4929-a760-ee722cb37f94");

            //b46b6f29-fb93-4929-a760-ee722cb37f94

            // Read a specific version of a Patient resource with technical id '32' and version id '4'
            //var location_B = new Uri("http://vonk.fire.ly/Patient/32/_history/4");
            //var pat_B = client.Read<Patient>(location_B);
            // or
            //var pat_B = client.Read<Patient>("Patient/32/_history/4");

            var pat_C = makeAPatient();//Go to makeAPAtient at study the code setting up at HL7 FHIR Patient!
            pat_C.Telecom = pat_A.Telecom;

            //The client.Create call below will throw an exception Hint se error.txt file
            // Your error correcting code 
            // goes here !! Requires some knowlegde about Patient class!
            var created_pat = client.Create(pat_C);

            //After succesfully Create, retrive the patient ID from created_pat, and use the ID to retrieve the patient in Postman/AdvancedRESTClient
            client.Delete(created_pat);//Clean up the test. Check result in Postman/AdvancedRESTClient
        }

        private Patient makeAPatient()
        {
            // example Patient setup, fictional data only
            var pat = new Patient();

            var id = new Identifier();
            id.System = "http://hl7.org/fhir/sid/us-ssn";
            id.Value = "010119-4589";
            pat.Identifier.Add(id);

            var name = new HumanName().WithGiven("Christiane").WithGiven("A.H.").AndFamily("Julemand");
            name.Prefix = new string[] { "Mrs." };
            name.Use = HumanName.NameUse.Official;

            var nickname = new HumanName();
            nickname.Use = HumanName.NameUse.Nickname;
            nickname.GivenElement.Add(new FhirString("Chrissy"));

            pat.Name.Add(name);
            pat.Name.Add(nickname);

            pat.Gender = AdministrativeGender.Female;

            pat.BirthDate = "2019-01-01";

            var birthplace = new Extension();
            birthplace.Url = "http://hl7.org/fhir/StructureDefinition/birthPlace";
            birthplace.Value = new Address() { City = "Aarhus N" };
            pat.Extension.Add(birthplace);

            var birthtime = new Extension("http://hl7.org/fhir/StructureDefinition/patient-birthTime",
                                           new FhirDateTime(2019, 1, 1, 0, 00));
            pat.BirthDateElement.Extension.Add(birthtime);

            var address = new Address()
            {
                Line = new string[] { "Finlandsgade 22" },
                City = "Aarhus N",
                State = "",
                PostalCode = "8200",
                Country = "Denmark"
            };
            pat.Address.Add(address);

            var contact = new Patient.ContactComponent();
            contact.Name = new HumanName();
            contact.Name.Given = new string[] { "Knud" };
            contact.Name.Family = "Julemand";
            contact.Gender = AdministrativeGender.Female;
            contact.Relationship.Add(new CodeableConcept("http://hl7.org/fhir/v2/0131", "N"));
            contact.Telecom.Add(new ContactPoint(ContactPoint.ContactPointSystem.Phone, null, ""));
            pat.Contact.Add(contact);

            pat.Deceased = new FhirBoolean(false);

            return pat;
        }
    }
}
