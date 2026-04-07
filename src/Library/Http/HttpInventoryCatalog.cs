using System.Net.Http; namespace Arq.Lab.Library.Http; public static class HttpInventoryCatalog { public static string HandlerName() => typeof(HttpClientHandler).Name; }
