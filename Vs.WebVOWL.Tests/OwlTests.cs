using System;
using System.Collections.Generic;
using System.IO;
using Vs.WebVOWL.Tests.Data;
using Xunit;

namespace Vs.WebVOWL.Tests
{
    public class OwlTests
    {
        [Fact]
        public void CreateClass()
        {
            Welcome model = new Welcome();
            model.Namespace = new List<object>();
            ModelHelpers.CreateSettings(ref model);
            ModelHelpers.CreateHeader(ref model,
                comment: "Virtual Society - Zorgtoeslag",
                title:"Zorgtoeslag",
                author:"Sjef van Leeuwen",version:"0.1",description: "API configuratie voor het berekenen van zorgtoeslag");
            ModelHelpers.CreateClass(ref model, "Zorgtoeslag","Zorgtoeslag");
            ModelHelpers.CreateClassAttribute(ref model, "euro","Euro");
            ModelHelpers.CreateClassAttribute(ref model, "double", "double");
            ModelHelpers.CreateDataType(ref model, "dataTypeProperty1");
            ModelHelpers.CreateDataType(ref model, "dataTypeProperty3");
            ModelHelpers.CreatePropertyAttribute(ref model, "dataTypeProperty1","drempelinkomen","Zorgtoeslag", "euro");
            ModelHelpers.CreatePropertyAttribute(ref model, "dataTypeProperty3", "woonlandfactor", "Zorgtoeslag", "double");


            File.WriteAllText("./create-class.json", model.ToJson());
        }

        [Fact]
        public void ParseHeader()
        {
            JsonModelParser parser = new JsonModelParser(YAMLOpenAPIBewoning.Json);
            parser.ParseHeader();
            Assert.True(parser.Model.Header.Title.Undefined == "Bewoning");
            Assert.True(parser.Model.Header.Description.Undefined == "<body>API voor het ontsluiten van historische gegevens over de bewoning van een adres. <br> De gegevens van de bewoners zijn actueel.Zie de Functionele documentatie voor nadere toelichting.</body>");
            Assert.True(parser.Model.Header.BaseIris[0].ToString() == "http://www.w3.org/2000/01/rdf-schema");
            Assert.True(parser.Model.Header.Iri.ToString() == "https://github.com/VNG-Realisatie/Bevragingen-ingeschreven-personen");
        }

        [Fact]
        public void ParseSchemas()
        {
            JsonModelParser parser = new JsonModelParser(YAMLOpenAPIBewoning.Json);
            parser.ParseSchemas();
        }
    }
}
