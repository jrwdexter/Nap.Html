using System;

using Nap.Formatters.Base;

namespace Nap.Html
{
    public class NapHtmlFormatter : INapFormatter
    {
        /// <summary>
        /// Converts a serialized HTML document to a C# object.  A new object is created in this process.
        /// </summary>
        /// <typeparam name="T">The type of object that should be created from the serialized value.</typeparam>
        /// <param name="serialized">The serialized data from the page converted to a POCO model.</param>
        /// <returns>
        /// The newly created object of type <typeparamref name="T"/>.
        /// </returns>
        /// <remarks>
        /// All properties that are being hydrated by deserialization must have public setters.
        /// </remarks>
        /// <example>
        /// <code>
        /// &lt;!DOCTYPE html*gt;
        /// &lt;html lang="en"*gt;
        /// &lt;head*gt;
        ///   &lt;meta charset="UTF-8"*gt;
        ///   &lt;title*gt;Document&lt;/title*gt;
        /// &lt;/head*gt;
        /// &lt;body*gt;
        ///   &lt;p id="FirstName"*gt;John&lt;/p*gt;
        ///   &lt;p class="LastName"*gt;Doe&lt;/p*gt;
        ///   &lt;p class="LastName"*gt;Johnson&lt;/p*gt;
        /// &lt;/body*gt;
        /// &lt;/html*gt; 
        /// </code>
        ///             would populate an object like
        /// <code>
        /// public class Person
        ///             {
        ///                 public string FirstName { get; set; }
        ///                 public string LastName { get; set; }
        ///             }
        /// </code>
        /// with <c>{ FirstName = John, LastName = Doe }</c>
        /// </example>
        public T Deserialize<T>(string serialized)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Not a supported functionality - serializing HTML for POST/PUT/other functionalities is not part of the HTTP protocol.
        /// </summary>
        /// <param name="graph">Unused parameter.</param>
        /// <returns><see cref="NotSupportedException"/>.</returns>
        /// <exception cref="NotSupportedException"></exception>
        public string Serialize(object graph)
        {
            throw new NotSupportedException("HTML objects cannot be serialized for POSTing or any other HTTP verb.");
        }

        /// <summary>
        /// Gets the MIME type corresponding to a given implementation of the <see cref="INapFormatter"/> interface.
        /// Returns "text/html".
        /// </summary>
        public string ContentType => "text/html";
    }
}
