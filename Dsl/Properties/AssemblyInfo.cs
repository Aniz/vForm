#region Using directives

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

#endregion

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle(@"")]
[assembly: AssemblyDescription(@"")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(@"Ufba")]
[assembly: AssemblyProduct(@"visualForm")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: System.Resources.NeutralResourcesLanguage("en")]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion(@"1.0.0.0")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: ReliabilityContract(Consistency.MayCorruptProcess, Cer.None)]

//
// Make the Dsl project internally visible to the DslPackage assembly
//
[assembly: InternalsVisibleTo(@"Ufba.visualForm.DslPackage, PublicKey=002400000480000094000000060200000024000052534131000400000100010077EB1E3EAD2B86E262FBC1237F125C15D1FCB46C441E93FBC6B576F3A372BFB9E72080C176E1D881BEDE5E42B23CD0B160C82C3926F8A39EFD9DCE2BFACE48D8F09BF2CDBFABAF8AF34A7166B49CFF316EAEC893791ED6FA85F884F7F4233952EFD4E59D5DEECCC7CD6C15B2324DCF4D1C7C12A6A068B5E42796C73F35F981A4")]