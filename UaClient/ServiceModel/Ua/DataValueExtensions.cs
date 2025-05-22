// Copyright (c) Converter Systems LLC. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Linq;

namespace Workstation.ServiceModel.Ua
{
    public static class DataValueExtensions
    {
        /// <summary>
        /// Gets the value of the DataValue.
        /// </summary>
        /// <param name="dataValue">The DataValue.</param>
        /// <returns>The value.</returns>
        public static object? GetValue(this DataValue? dataValue)
        {
            if (dataValue is null)
            {
                throw new ArgumentNullException(nameof(dataValue));
            }
            var value = dataValue.Value;
            return value switch
            {
                ExtensionObject obj => obj.BodyType == BodyType.Encodable ? obj.Body : obj,
                ExtensionObject[] objArray => objArray.Select(e => e.BodyType == BodyType.Encodable ? e.Body : e).ToArray(),
                _ => value
            };
        }

        /// <summary>
        /// Gets the value of the DataValue, or the default value for the type.
        /// </summary>
        /// <typeparam name="T">The expected type.</typeparam>
        /// <param name="dataValue">The DataValue.</param>
        /// <returns>The value, if an instance of the specified Type, otherwise the Type's default value.</returns>
        public static T? GetValueOrDefault<T>(this DataValue? dataValue)
        {
            if (dataValue is null)
            {
                return default;
            }
            var value = dataValue.Value;
            switch (value)
            {
                case ExtensionObject obj:
                    // handle object, custom type
                    var v2 = obj.BodyType == BodyType.Encodable ? obj.Body : obj;
                    if (v2 is T t1)
                    {
                        return t1;
                    }
                    return default!;

                case ExtensionObject[] objArray:
                    // handle object[], custom type[]
                    var v3 = objArray.Select(e => e.BodyType == BodyType.Encodable ? e.Body : e);
                    var elementType = typeof(T).GetElementType();
                    if (elementType == null)
                    {
                        return default!;
                    }
                    try
                    {
                        var v4 = typeof(Enumerable).GetMethod("Cast")!.MakeGenericMethod(elementType).Invoke(null, [v3]);
                        var v5 = typeof(Enumerable).GetMethod("ToArray")!.MakeGenericMethod(elementType).Invoke(null, [v4]);
                        if (v5 is T t2)
                        {
                            return t2;
                        }
                        return default!;
                    }
                    catch (Exception)
                    {
                        return default!;
                    }

                default:
                    // handle built-in type
                    if (value is T t)
                    {
                        return t;
                    }
                    return default!;

            }
        }

        /// <summary>
        /// Gets the value of the DataValue, or the specified default value.
        /// </summary>
        /// <typeparam name="T">The expected type.</typeparam>
        /// <param name="dataValue">A DataValue</param>
        /// <param name="defaultValue">A default value.</param>
        /// <returns>The value, if an instance of the specified Type, otherwise the specified default value.</returns>
        public static T GetValueOrDefault<T>(this DataValue? dataValue, T defaultValue)
        {
            if (dataValue is null)
            {
                return defaultValue;
            }
            var value = dataValue.Value;
            switch (value)
            {
                case ExtensionObject obj:
                    // handle object, custom type
                    var v2 = obj.BodyType == BodyType.Encodable ? obj.Body : obj;
                    if (v2 is T t1)
                    {
                        return t1;
                    }
                    return defaultValue;

                case ExtensionObject[] objArray:
                    // handle object[], custom type[]
                    var v3 = objArray.Select(e => e.BodyType == BodyType.Encodable ? e.Body : e);
                    var elementType = typeof(T).GetElementType();
                    if (elementType == null)
                    {
                        return defaultValue;
                    }
                    try
                    {
                        var v4 = typeof(Enumerable).GetMethod("Cast")!.MakeGenericMethod(elementType).Invoke(null, new object?[] { v3 });
                        var v5 = typeof(Enumerable).GetMethod("ToArray")!.MakeGenericMethod(elementType).Invoke(null, new object?[] { v4 });
                        if (v5 is T t2)
                        {
                            return t2;
                        }
                        return defaultValue;
                    }
                    catch (Exception)
                    {
                        return defaultValue;
                    }

                default:
                    // handle built-in type
                    if (value is T t)
                    {
                        return t;
                    }
                    return defaultValue;

            }
        }
    }
}
