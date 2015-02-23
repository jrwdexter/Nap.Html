using Nap.Html.Attributes;

namespace Nap.Html.Bindings.Base
{
    /// <summary>
    /// Describes a binding that takes a given HTML element in, and binds the data from that element in a chosen way to a property.
    /// </summary>
    internal interface IHtmlBinding
    {
        /// <summary>
        /// Gets the type of binding that this handler operates on.
        /// </summary>
        NapHtmlBinding Binding { get; }

        string GetContent()
    }
}
