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
            model.Settings = new Settings();
            model.Settings.Global = new Global();
            model.Settings.Global.Paused = false;
            model.Settings.Global.Zoom = "0.68";
            model.Settings.Global.Translation = new List<double>() { 529.3, 33.32 };
            model.Settings.Gravity = new Gravity();
            model.Settings.Gravity.ClassDistance = 200;
            model.Settings.Gravity.DatatypeDistance = 200;
            model.Settings.Global.Paused = false;
            model.Namespace = new List<object>();
            model.Comment = "Virtual Society - Zorgtoeslag";
            model.Header = new Header();
            model.Header.Languages = new List<string>();
            model.Header.Languages.Add("en");
            model.Header.Title = new Comments();
            model.Header.Title.Undefined = "Zorgtoeslag";
            model.Header.Author = new List<string>() { "Sjef van Leeuwen" };
            model.Header.Version = "0.1";
          //  model.Header.Other = new Other();
          //  model.Header.Other.Rights = new List<BackwardCompatibleWith>();
          //  model.Header.Other.Rights.Add(new BackwardCompatibleWith() { Language = Language.Undefined, Identifier = "MIT License" });

            model.Header.Description = new Comments();
            model.Header.Description.Undefined = "API configuratie voor het berekenen van zorgtoeslag";
            model.Header.BaseIris = new List<Uri>();
            model.Header.BaseIris.Add(new Uri("http://www.w3.org/2000/01/rdf-schema"));
           /* model.Header.BaseIris.Add(new Uri("https://ontologie.virtualsociety.nl/urukagina/zorgtoeslag"));*/
            model.Header.Iri = new  Uri("https://ontologie.virtualsociety.nl/newOntology/");
            model.Class = new List<Class>();
            model.Class.Add(new Class() {  Id = "Zorgtoeslag", Type = "owl:Class",  });
            model.ClassAttribute = new List<ClassAttribute>();
            var attributes = new List<string>();
            attributes.Add("datatype");
            model.Class.Add(new Class() { Id = "euro", Type = "rdfs:Datatype" });

            model.ClassAttribute.Add(
                new ClassAttribute()
                {
                    Id = "euro",
                    Iri = new Uri("http://visualdataweb.org/newOntology/zorgtoeslag"),
                    BaseIri = new Uri("http://visualdataweb.org/newOntology/"),
                    Label = new ClassAttributeLabel() { PurpleLabel = new PurpleLabel() { IriBased = "Euro" } },
                    Attributes = attributes
                }) ;


            model.ClassAttribute.Add(
                new ClassAttribute()
                {
                    Id = "Zorgtoeslag",
                    Label = new ClassAttributeLabel() { PurpleLabel = new PurpleLabel() { IriBased = "Zorgtoeslag" } },
                });
            model.PropertyAttribute = new List<PropertyAttribute>();
            model.Property = new List<Class>();
            model.Property.Add(
                new Class() { 
                    Id="dataTypeProperty1",
                    Type= "owl:DatatypeProperty",
                });
            model.PropertyAttribute.Add(
                new PropertyAttribute()
                {
                    Id = "dataTypeProperty1",
                    BaseIri = new Uri("https://ontologie.virtualsociety.nl/urukagina/zorgtoeslag"),
                    Iri = new Uri("https://ontologie.virtualsociety.nl/urukagina/zorgtoeslag/drempelinkomen"),
                    Label = new PropertyAttributeLabel() { FluffyLabel = new FluffyLabel() { IriBased = "drempelinkomen" } },
                    Domain = "Zorgtoeslag",
                    Range = "euro",
                    Attributes = new List<string>() { "datatype" }
                });

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
