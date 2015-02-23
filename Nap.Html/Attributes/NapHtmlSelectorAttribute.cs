using System;

namespace Nap.Html.Attributes
{
    public class NapHtmlSelectorAttribute : Attribute
    {
        public NapHtmlSelectorAttribute(string selector)
        {
            Selector = selector;
            Binding = NapHtmlBinding.InnerText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NapHtmlSelectorAttribute"/> class.
        /// </summary>
        /// <param name="selector">The selector to find items on the HTML page.</param>
        /// <param name="binding">The binding type to perform on selection.</param>
        public NapHtmlSelectorAttribute(string selector, NapHtmlBinding binding)
        {
            Selector = selector;
            Binding = binding;
        }

        public NapHtmlSelectorAttribute(string selector, string attribute)
        {
            Selector = selector;
            Attribute = attribute;
        }

        internal string Selector { get; private set; }

        internal NapHtmlBinding Binding { get; private set; }

        internal string Attribute { get; private set; }
    }
}
