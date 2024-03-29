﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 20.01.2021 11:57:10
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;

namespace DocumentManager.DAL.Model
{
    /// <summary>
    /// Тип документ
    /// </summary>
    public partial class DocumentType {

        public DocumentType()
        {
            this.Documents = new List<Document>();
            OnCreated();
        }

        /// <summary>
        /// ID на тип документ
        /// </summary>
        public virtual long DocumentTypeID { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Пореден номер
        /// </summary>
        public virtual int? DisplayOrder { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        public virtual string Code { get; set; }

        /// <summary>
        /// Група на вид документ: - входящ - изходящ - вътрешен(напр. кредитно досие)
        /// </summary>
        public virtual string DocumentTypeGroupCode { get; set; }

        public virtual bool? HasTemplate { get; set; }

        public virtual IList<Document> Documents { get; set; }

        public virtual DocumentTypeGroup DocumentTypeGroup { get; set; }

        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion
    }

}
