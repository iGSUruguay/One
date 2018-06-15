﻿using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One.Model.Misc
{
    public class Table
    {
        // Campos de tabla
        protected string _Id;
        protected DateTime _CreationDate;
        protected DateTime _ModificationDate;

        // Campos auxiliares
        protected bool _IsCreationTime;

        // Propiedades de tabla
        [Column(Storage = "_Id", DbType = "NChar(24)", CanBeNull = false, IsPrimaryKey = true)]
        public string Id
        {
            get => _Id;
        }
        [Column(Storage = "_CreationDate", DbType = "datetime", CanBeNull = false)]
        public DateTime CreationDate
        {
            get => _CreationDate;
        }
        [Column(Storage = "_ModificationDate", DbType = "datetime", CanBeNull = true)]
        public DateTime ModificationDate
        {
            get => _ModificationDate;
        }

        // Metodos de manipulación de datos
        protected void Modify(object value, out object field)
        {
            field = value;
            if (!_IsCreationTime) _ModificationDate = DateTime.Now;
        }
    }
}