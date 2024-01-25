using System;
using System.Security.Principal;

namespace ElevatedWebRole.Models
{
    public class ViewModel
    {
        public bool IsElevated => new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
        public string EnvironmentVariable => Environment.GetEnvironmentVariable("CLOUDSERVICE_TEST_VARIABLE") ?? "<not set>";
    }
}