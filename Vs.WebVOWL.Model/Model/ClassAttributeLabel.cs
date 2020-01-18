namespace Vs.WebVOWL
{
    public partial struct ClassAttributeLabel
    {
        public PurpleLabel PurpleLabel;
        public string String;

        public static implicit operator ClassAttributeLabel(PurpleLabel PurpleLabel) => new ClassAttributeLabel { PurpleLabel = PurpleLabel };
        public static implicit operator ClassAttributeLabel(string String) => new ClassAttributeLabel { String = String };
    }
}