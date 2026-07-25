using System;
using System.Net;
using FastEnumUtility;
using FastEnumUtility.Sandbox;


var success = FastEnum.TryParse<Fruits>("Apple", out var fruit);
Console.WriteLine(success);
Console.WriteLine(fruit);


namespace FastEnumUtility.Sandbox
{
    public enum Fruits
    {
        Apple = 1,

#pragma warning disable CA1041
        [Obsolete]
        Banana,
#pragma warning restore CA1041
    }


    [FastEnum<Fruits>]
    public partial class FruitsBooster
    { }


    [global::FastEnumUtility.FastEnum<HttpStatusCode>]
    public partial class HttpStatusCodeBooster
    { }


    [global::FastEnumUtility.FastEnum<LoaderOptimization>]
    public partial class LoaderOptimizationBooster
    { }
}

