// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotifyPropertyChanged.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace MediaBrowser.Helper
{
    #region

    #endregion

    /// <summary>
    ///     The notify property changed.
    /// </summary>
    public abstract class NotifyPropertyChanged : INotifyPropertyChanged
    {
        #region Public Events

        /// <summary>
        ///     The property changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Methods

        /// <summary>
        ///     The raise property changed.
        /// </summary>
        /// <param name="propertyExpression">
        ///     The property expression.
        /// </param>
        /// <typeparam name="TProperty">
        /// </typeparam>
        protected void RaisePropertyChanged<TProperty>(Expression<Func<TProperty>> propertyExpression)
        {
            var memberExpression = (MemberExpression)propertyExpression.Body;
            var propertyName = memberExpression.Member.Name;
            RaisePropertyChanged(propertyName);
        }

        /// <summary>
        ///     The raise property changed.
        /// </summary>
        /// <param name="propertyName">
        ///     The property name.
        /// </param>
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}