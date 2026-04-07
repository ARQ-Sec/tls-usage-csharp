using System.Net.Http; namespace Arq.Lab.Library.Http; public static class SecureServiceRegistration { public static HttpClientHandler Build() => new HttpClientHandler(); }
