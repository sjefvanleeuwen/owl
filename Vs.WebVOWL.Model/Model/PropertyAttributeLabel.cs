namespace Vs.WebVOWL
{
    public partial struct PropertyAttributeLabel
    {
        public FluffyLabel FluffyLabel;
        public string String;

        public static implicit operator PropertyAttributeLabel(FluffyLabel FluffyLabel) => new PropertyAttributeLabel { FluffyLabel = FluffyLabel };
        public static implicit operator PropertyAttributeLabel(string String) => new PropertyAttributeLabel { String = String };
    }
}