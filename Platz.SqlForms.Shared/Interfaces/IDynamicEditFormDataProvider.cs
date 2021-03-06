﻿using Platz.SqlForms.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Platz.SqlForms
{
    public interface IDynamicEditFormDataProvider
    {
        void SetParameters(object[] serviceParameters);

        IEnumerable<DataField> GetFormFields(IDynamicEditForm form);

        object GetItem(IDynamicEditForm form, int id);
        void DeleteItem(IDynamicEditForm form, object item);
        object InsertItem(IDynamicEditForm form, object item);
        object UpdateItem(IDynamicEditForm form, object item);

        System.Collections.IList GetEntityData(IDynamicEditForm form, Type entity);
    }
}
