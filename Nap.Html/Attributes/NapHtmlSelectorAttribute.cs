using System;

namespace Nap.Html.Attributes
{
    /// <summary>
    /// Describes an HTML selector attribute, which can be used to decorate properties to hydrate them using HTML documents.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class NapHtmlSelectorAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NapHtmlSelectorAttribute"/> class.
        /// </summary>
        /// <param name="selector">A CSS selector to bind to the property.</param>
        public NapHtmlSelectorAttribute(string selector)
        {
            Selector = selector;
            Binding = NapHtmlBinding.InnerText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NapHtmlSelectorAttribute"/> class.
        /// </summary>
        /// <param name="selector">A CSS selector to bind to the property.</param>
        /// <param name="binding">The binding type to perform on selection.</param>
        public NapHtmlSelectorAttribute(string selector, NapHtmlBinding binding)
        {
            Selector = selector;
            Binding = binding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NapHtmlSelectorAttribute"/> class.
        /// </summary>
        /// <param name="selector">A CSS selector to bind to the property.</param>
        /// <param name="attribute">The attribute name to use to populate the property.</param>
        public NapHtmlSelectorAttribute(string selector, string attribute)
        {
            Selector = selector;
            Binding = NapHtmlBinding.Attribute;
            Attribute = attribute;
        }

        /// <summary>
        /// Gets the CSS selector used to bind information to the given property.
        /// </summary>
        internal string Selector { get; private set; }

        /// <summary>
        /// Gets the type of binding performed (such as <see cref="NapHtmlBinding.InnerText"/> or <see cref="NapHtmlBinding.InnerHtml"/>).
        /// </summary>
        internal NapHtmlBinding Binding { get; private set; }

        /// <summary>
        /// If set, 
        /// </summary>
        internal string Attribute { get; private set; }
    }
}
