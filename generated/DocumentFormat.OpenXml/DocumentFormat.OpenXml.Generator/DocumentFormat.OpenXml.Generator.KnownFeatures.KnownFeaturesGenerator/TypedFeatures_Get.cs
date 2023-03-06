﻿// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using System.Threading;

namespace DocumentFormat.OpenXml.Features;

internal partial class TypedFeatures
{
    private global::DocumentFormat.OpenXml.Features.IRootElementFactory? _TypedRootElementFactory;
    private global::DocumentFormat.OpenXml.Features.IOpenXmlNamespaceResolver? _OpenXmlNamespaceResolver;

    public partial T? Get<T>()
    {
        if (typeof(T) == typeof(global::DocumentFormat.OpenXml.Features.IRootElementFactory))
        {
            if (_TypedRootElementFactory is null)
            {
                Interlocked.CompareExchange(ref _TypedRootElementFactory, new global::DocumentFormat.OpenXml.Features.TypedRootElementFactory(), null);
            }

            return (T)_TypedRootElementFactory;
        }

        if (typeof(T) == typeof(global::DocumentFormat.OpenXml.Features.IOpenXmlNamespaceResolver))
        {
            if (_OpenXmlNamespaceResolver is null)
            {
                Interlocked.CompareExchange(ref _OpenXmlNamespaceResolver, new global::DocumentFormat.OpenXml.Features.OpenXmlNamespaceResolver(), null);
            }

            return (T)_OpenXmlNamespaceResolver;
        }

        if (global::DocumentFormat.OpenXml.Features.FeatureCollection.Default is global::DocumentFormat.OpenXml.Features.IFeatureCollection other1 && other1.Get<T>() is T result1)
        {
            return result1;
        }

        return default;
    }
}
