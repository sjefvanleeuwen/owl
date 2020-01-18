using System;
using System.Collections.Generic;
using System.Globalization;

namespace Vs.WebVOWL
{
    public static class ModelHelpers
    {
        public static void CreateSettings(ref Welcome model, long classDistance = 150, long datatypeDistance=150, double zoom = 1, bool paused = false, double translateX = 0, double translateY = 0)
        {
            model.Settings = new Settings
            {
                Global = new Global
                {
                    Paused = paused,
                    Zoom = zoom.ToString(CultureInfo.InvariantCulture),
                    Translation = new List<double>() { translateX, translateY }
                },
                Gravity = new Gravity
                {
                    ClassDistance = classDistance,
                    DatatypeDistance = datatypeDistance
                }
            };
        }

        public static void CreateDataType(ref Welcome model, string id)
        {
            if (model.Property == null)
                model.Property = new List<Class>();
            model.Property.Add(
                new Class()
                {
                    Id = id,
                    Type = "owl:DatatypeProperty",
                });
        }

        public static void CreatePropertyAttribute(ref Welcome model, string propertyReferenceId, string label, string domain, string range)
        {
            if (model.PropertyAttribute == null)
                model.PropertyAttribute = new List<PropertyAttribute>();

            model.PropertyAttribute.Add(
                new PropertyAttribute()
                {
                    Id = propertyReferenceId,
                    BaseIri = new Uri("https://ontologie.virtualsociety.nl/urukagina/zorgtoeslag"),
                    Iri = new Uri("https://ontologie.virtualsociety.nl/urukagina/zorgtoeslag/drempelinkomen"),
                    Label = new PropertyAttributeLabel() { FluffyLabel = new FluffyLabel() { IriBased = label } },
                    Domain = domain,
                    Range = range,
                    Attributes = new List<string>() { "datatype" }
                });
        }

        public static void CreateClassAttribute(ref Welcome model, string id, string label)
        {
            if (model.ClassAttribute == null)
                model.ClassAttribute = new List<ClassAttribute>();

            model.Class.Add(new Class() { Id = id, Type = "rdfs:Datatype" });
            model.ClassAttribute.Add(
                new ClassAttribute()
                {
                    Id = id,
                    Iri = new Uri("http://visualdataweb.org/newOntology/zorgtoeslag"),
                    BaseIri = new Uri("http://visualdataweb.org/newOntology/"),
                    Label = new ClassAttributeLabel() { PurpleLabel = new PurpleLabel() { IriBased = label } },
                    Attributes = new List<string>() { "datatype" }
                });

        }

        public static void CreateClass(ref Welcome model, string id,string label, string iri="", string baseIri="")
        {
            if (model.Class == null)
                model.Class = new List<Class>();
            model.Class.Add(new Class() { Id = id, Type = "owl:Class", });
            if (model.ClassAttribute == null)
                model.ClassAttribute = new List<ClassAttribute>();
            model.ClassAttribute.Add(
                new ClassAttribute()
                {
                    Id = id,
                    Label = new ClassAttributeLabel() { PurpleLabel = new PurpleLabel() { IriBased = label } },
                });
        }

        public static void CreateHeader(ref Welcome model, string comment = "default", string title = "untitled",
            string author = "", string version = "", string description = "", string iri = "https://ontologie.virtualsociety.nl", string baseIri = "http://www.w3.org/2000/01/rdf-schema")
        {
            model.Comment = comment;
            model.Header = new Header
            {
                Languages = new List<string>()
            };
            model.Header.Languages.Add("en");
            model.Header.Title = new Comments
            {
                Undefined = title
            };
            model.Header.Author = new List<string>() { author };
            model.Header.Version = version;
            model.Header.Description = new Comments
            {
                Undefined = description
            };
            model.Header.BaseIris = new List<Uri>
            {
                new Uri(baseIri)
            };
            model.Header.Iri = new Uri(iri);
        }
    }
}
