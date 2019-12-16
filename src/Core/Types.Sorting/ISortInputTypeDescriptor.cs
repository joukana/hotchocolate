using System;
using System.Linq.Expressions;
using HotChocolate.Language;

namespace HotChocolate.Types.Sorting
{
    public interface ISortInputTypeDescriptor
        : IDescriptor<SortInputTypeDefinition>
        , IFluent
    {

        /// <summary>
        /// Defines the name of the <see cref="SortInputType{T}"/>.
        /// </summary>
        /// <param name="value">The sort type name.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="value"/> is <c>null</c> or
        /// <see cref="string.Empty"/>.
        /// </exception>
        ISortInputTypeDescriptor Name(NameString value);

        /// <summary>
        /// Adds explanatory text of the <see cref="SortInputType{T}"/>
        /// that can be accessd via introspection.
        /// </summary>
        /// <param name="value">The sort type description.</param>
        /// 
        ISortInputTypeDescriptor Description(string value);

        /// <summary>
        /// Defines the sort binding behavior.
        ///
        /// The default binding behavior is set to
        /// <see cref="BindingBehavior.Implicit"/>.
        /// </summary>
        /// <param name="behavior">
        /// The binding behavior.
        ///
        /// Implicit:
        /// The sort type descriptor will try to infer the sortable fields
        /// from the specified <typeparamref name="T"/>.
        ///
        /// Explicit:
        /// All sortable fields have to be specified explicitly by specifying
        /// which field is sortable.
        /// </param>
        ISortInputTypeDescriptor BindFields(
            BindingBehavior behavior);

        /// <summary>
        /// Defines that all sortable fields have to be specified explicitly by specifying
        /// which field is sortable.
        /// </summary>
        ISortInputTypeDescriptor BindFieldsExplicitly();

        /// <summary>
        /// Defines that the sort type descriptor will try to infer the sortable fields
        /// from the specified <typeparamref name="T"/>.
        /// </summary>
        ISortInputTypeDescriptor BindFieldsImplicitly();


        ISortInputTypeDescriptor Directive<TDirective>(
            TDirective directiveInstance)
            where TDirective : class;

        ISortInputTypeDescriptor Directive<TDirective>()
            where TDirective : class, new();

        ISortInputTypeDescriptor Directive(
            NameString name,
            params ArgumentNode[] arguments);

    }
}
