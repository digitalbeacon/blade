
namespace System
{
    /// <summary>
    /// The system Object which all other types inherit from.
    /// </summary>
    [ScriptObjectLiteral]
    public class Object
    {
        /// <summary>
        /// Gets or sets a field by key.
        /// </summary>
        /// <param name="key">The field name.</param>
        /// <returns>The associated value, or undefined if one has not been assigned.</returns>
        public dynamic this[string key]
        {
            get { return null; }
            set { }
        }

        /// <summary>
        /// Gets a string representation of the object.
        /// </summary>
        /// <returns>A string value.</returns>
        public virtual string toString() { return null; }

        /// <summary>
        /// Gets a string representation of the object, using locale conventions.
        /// </summary>
        /// <returns>A string value.</returns>
        public string toLocaleString() { return null; }

		/// <summary>
		/// Gets the property names of the object as a string array.
		/// </summary>
		/// <returns>The property names of the object as a string array.</returns>
		public static string[] keys(object obj) { return null; }

		/// <summary>
		/// Implicit conversion to bool.
		/// </summary>
		/// <returns>The resulting boolean value.</returns>
		public static implicit operator Boolean(object o) { return true; }

    }
}