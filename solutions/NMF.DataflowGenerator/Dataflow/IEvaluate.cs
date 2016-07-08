//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace TTC2016.LiveContest.Dataflow
{
    
    
    /// <summary>
    /// The public interface for Evaluate
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Evaluate))]
    [XmlDefaultImplementationTypeAttribute(typeof(Evaluate))]
    public interface IEvaluate : IModelElement, IElement
    {
        
        /// <summary>
        /// The field property
        /// </summary>
        string Field
        {
            get;
            set;
        }
        
        /// <summary>
        /// The expression property
        /// </summary>
        IExpression Expression
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the Field property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> FieldChanged;
        
        /// <summary>
        /// Gets fired when the Expression property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ExpressionChanged;
    }
}
