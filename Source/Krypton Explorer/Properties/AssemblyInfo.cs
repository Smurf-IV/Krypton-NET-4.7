﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2012. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, PO Box 1504, 
//  Glen Waverley, Vic 3150, Australia and are supplied subject to licence terms.
// 
//  Version 4.5.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Security;
using System.Resources;
using System.Reflection;
using System.Diagnostics;
using System.Security.Permissions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: AssemblyVersion("17.10.3.15")]
[assembly: AssemblyFileVersion("17.10.3.15")]
[assembly: AssemblyInformationalVersion("4.5.2.0")]
[assembly: AssemblyCopyright("© Component Factory Pty Ltd 2012. All rights reserved.")]
[assembly: AssemblyProduct("Krypton Explorer")]
[assembly: AssemblyDefaultAlias("KryptonExplorer.dll")]
[assembly: AssemblyTitle("Krypton Explorer")]
[assembly: AssemblyCompany("Component Factory")]
[assembly: AssemblyDescription("Krypton Explorer")]
[assembly: AssemblyConfiguration("Production")]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: StringFreezing]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: AllowPartiallyTrustedCallers()]
[assembly: Dependency("System", LoadHint.Always)]
[assembly: Dependency("System.Drawing", LoadHint.Always)]
[assembly: Dependency("System.Windows.Forms", LoadHint.Always)]
[assembly: Dependency("ComponentFactory.Krypton.Toolkit", LoadHint.Always)]
[assembly: Dependency("ComponentFactory.Krypton.Navigator", LoadHint.Always)]
