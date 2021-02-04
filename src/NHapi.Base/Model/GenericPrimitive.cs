namespace NHapi.Base.Model
{
    /// <summary> An unspecified Primitive datatype that imposes no constraints on its string
    /// value.  This is used to store Varies data, when the data type is unknown.  It is also
    /// used to store unrecognized message constituents.
    /// </summary>
    /// <author>  Bryan Tripp.
    /// </author>
    public class GenericPrimitive : AbstractPrimitive, IPrimitive
    {
        private string valueRenamed = null;

        /// <summary> Creates a new instance of GenericPrimitive. </summary>
        public GenericPrimitive(IMessage message)
            : base(message)
        {
        }

        /// <summary> Returns a String representation of the value of this field.</summary>
        /// <summary> Sets the value of this field if the given value is legal in the context of the
        /// implementing class.
        /// </summary>
        /// <throws>  DataTypeException if the given value is not valid in this context. </throws>
        public override string Value
        {
            get { return valueRenamed; }

            set { valueRenamed = value; }
        }

        /// <summary>Returns the name of the type (used in XML encoding and profile checking).  </summary>
        public override string TypeName
        {
            get { return "UNKNOWN"; }
        }

        /// <summary>
        /// Gets the version.
        /// </summary>
        public virtual string Version
        {
            get { return null; }
        }
    }
}