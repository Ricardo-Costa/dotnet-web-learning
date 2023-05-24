namespace MetadataCustomAttributes
{
    [System.AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class FieldNameAttribute : Attribute
    {
        public string Name { get; private set; }

        public FieldNameAttribute(string name)
        {

            if (string.IsNullOrEmpty(name))
                throw new Exception("Attribute name can't be null or empty!");

            this.Name = name.ToLower();
        }
    }
}