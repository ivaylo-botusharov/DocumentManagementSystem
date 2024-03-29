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
    /// Документ
    /// </summary>
    public partial class Document {

        public Document()
        {
            OnCreated();
        }

        /// <summary>
        /// ID на документ
        /// </summary>
        public virtual long DocumentID { get; set; }

        /// <summary>
        /// Име на файл
        /// </summary>
        public virtual string FileName { get; set; }

        /// <summary>
        /// ID на тип документ
        /// </summary>
        public virtual long DocumentTypeID { get; set; }

        /// <summary>
        /// Kod на тип файл (напр. pdf, jpeg, png)
        /// </summary>
        public virtual string FileTypeCode { get; set; }

        /// <summary>
        /// Коментар
        /// </summary>
        public virtual string Comment { get; set; }

        public virtual Guid Guid { get; set; }

        public virtual DocumentApplication DocumentApplication { get; set; }

        public virtual FileType FileType { get; set; }

        public virtual DocumentType DocumentType { get; set; }

        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion
    }

}
