namespace Nap.Html.Attributes
{
    /// <summary>
    /// Describes an enumeration of the types of bindings that can occur.
    /// </summary>
    public enum NapHtmlBinding
    {
        /// <summary>
        /// Binds the property to the inner text of the element found by the CSS selector.
        /// </summary>
        InnerText,

        /// <summary>
        /// Binds the property to the inner html of the element found by the CSS selector.
        /// </summary>
        InnerHtml,

        /// <summary>
        /// Binds the property to the 'class' attribute of the element found by the CSS selector.
        /// </summary>
        Class,

        /// <summary>
        /// Binds the property to the ID attribute of the element found by the CSS selector.
        /// </summary>
        Id,

        /// <summary>
        /// Binds the property to a given attribute on the element found by the CSS selector (the attribute to bind is stored elsewhere).
        /// </summary>
        Attribute
    }
}