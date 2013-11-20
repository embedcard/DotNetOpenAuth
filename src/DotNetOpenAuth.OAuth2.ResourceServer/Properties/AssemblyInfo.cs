//-----------------------------------------------------------------------
// <copyright file="AssemblyInfo.cs" company="Outercurve Foundation">
//     Copyright (c) Outercurve Foundation. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

// We DON'T put an AssemblyVersionAttribute in here because it is generated in the build.

using System;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Web.UI;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyCopyright("Copyright © 2012 Outercurve Foundation")]
[assembly: CLSCompliant(true)]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("7d73990c-47c0-4256-9f20-a893add9e289")]

#if StrongNameSigned
// See comment at top of this file.  We need this so that strong-naming doesn't
// keep this assembly from being useful to shared host (medium trust) web sites.
[assembly: AllowPartiallyTrustedCallers]

[assembly: InternalsVisibleTo("DotNetOpenAuth.Test, PublicKey=0024000004800000940000000602000000240000525341310004000001000100754e783ed5a560211c754bc482cd166c37b33534e9b5674618b9b52cfc6d96da3b339df42f1ac90833e0690ce86d59d62f4c3855c23fd5ad3453c9b89393222516eec3bd03aaeb88668c340c43f2554cf3f4e894c3fa3f44420901934800d1f4a25d50a4043eb9ee0eb14f27b3e0bc327af387999c67c68556c72bf3d7645abd")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2, PublicKey=0024000004800000940000000602000000240000525341310004000001000100c547cac37abd99c8db225ef2f6c8a3602f3b3606cc9891605d02baa56104f4cfc0734aa39b93bf7852f7d9266654753cc297e7d2edfe0bac1cdcf9f717241550e0a7b191195b7667bb4f64bcb8e2121380fd1d9d46ad2d92d2d15605093924cceaf74c4861eff62abf69b9291ed0a340e113be11e6a7d3113e92484cf7045cc7")]
#else
[assembly: InternalsVisibleTo("DotNetOpenAuth.Test")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
#endif
