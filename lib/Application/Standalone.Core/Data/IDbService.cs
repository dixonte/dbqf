﻿using dbqf.Configuration;
using dbqf.Criterion;
using System;
using System.Collections.Generic;
using System.Data;

namespace Standalone.Core.Data
{
    public interface IDbService
    {
        DataTable GetResults(ISearchDetails details);
        List<object> GetList(IFieldPath path);
    }

    public interface IDbServiceAsync
    {
        void GetResults(ISearchDetails details, IDbServiceAsyncCallback<DataTable> callback);
        void GetList(IFieldPath path, IDbServiceAsyncCallback<List<object>> callback);
    }

    public delegate void AsyncCallback<T>(IDbServiceAsyncCallback<T> data);
    public interface IDbServiceAsyncCallback<T>
    {
        T Results { get; set; }
        Exception Exception { get; set; } 
        AsyncCallback<T> Callback { get; }
    }
}
