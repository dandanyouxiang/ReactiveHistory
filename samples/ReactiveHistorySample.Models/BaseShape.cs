﻿// Copyright (c) Wiesław Šoltés. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace ReactiveHistorySample.Models
{
    public abstract class BaseShape : BaseObject
    {
        public BaseShape(object owner, string name) : base(owner, name)
        {
        }
    }
}
