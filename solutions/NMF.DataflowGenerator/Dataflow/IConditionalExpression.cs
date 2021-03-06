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
    /// The public interface for ConditionalExpression
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(ConditionalExpression))]
    [XmlDefaultImplementationTypeAttribute(typeof(ConditionalExpression))]
    public interface IConditionalExpression : IModelElement, IExpression
    {
        
        /// <summary>
        /// The conditionExpression property
        /// </summary>
        IExpression ConditionExpression
        {
            get;
            set;
        }
        
        /// <summary>
        /// The thenExpression property
        /// </summary>
        IExpression ThenExpression
        {
            get;
            set;
        }
        
        /// <summary>
        /// The elseExpression property
        /// </summary>
        IExpression ElseExpression
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired when the ConditionExpression property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ConditionExpressionChanged;
        
        /// <summary>
        /// Gets fired when the ThenExpression property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ThenExpressionChanged;
        
        /// <summary>
        /// Gets fired when the ElseExpression property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> ElseExpressionChanged;
    }
}

