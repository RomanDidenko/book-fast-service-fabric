﻿using System.Threading.Tasks;

namespace BookFast.Framework
{
    public interface IQuery<in TModel, TResult>
    {
        Task<TResult> ExecuteAsync(TModel model);
    }
}