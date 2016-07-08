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
    /// The public interface for FeatureCall
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(FeatureCall))]
    [XmlDefaultImplementationTypeAttribute(typeof(FeatureCall))]
    public interface IFeatureCall : IModelElement, IExpression
    {
        
        /// <summary>
        /// The feature property
        /// </summary>
        string Feature
        {
            get;
            set;
        }
        
        /// <summary>
        /// The targetExpression property
        /// </summary>
        IExpression TargetExpression
        {
            get;
            set;
        }
        
        /// <summary>
        /// The parameters property
        /// </summary>
        IListExpression<IExpression> Parameters
        {
            get;
        }
        
        /// <summary>
        /// Gets fired when the Feature property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> FeatureChanged;
        
        /// <summary>
        /// Gets fired when the TargetExpression property changed its value
        /// </summary>
        event EventHandler<ValueChangedEventArgs> TargetExpressionChanged;
    }
}
