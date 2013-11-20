//-----------------------------------------------------------------------
// <copyright file="AssemblyInfo.cs" company="Microsoft">
//     Copyright (c) Microsoft. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyCompany("Microsoft")]
[assembly: AssemblyCopyright("Copyright © Microsoft 2011")]
[assembly: CLSCompliant(true)]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("c89b7e57-2735-4407-bcb9-dfe9bb9493a2")]

#if StrongNameSigned

[assembly: InternalsVisibleTo("DotNetOpenAuth.AspNet.Test, PublicKey=0024000004800000940000000602000000240000525341310004000001000100754e783ed5a560211c754bc482cd166c37b33534e9b5674618b9b52cfc6d96da3b339df42f1ac90833e0690ce86d59d62f4c3855c23fd5ad3453c9b89393222516eec3bd03aaeb88668c340c43f2554cf3f4e894c3fa3f44420901934800d1f4a25d50a4043eb9ee0eb14f27b3e0bc327af387999c67c68556c72bf3d7645abd")]
#else
[assembly: InternalsVisibleTo("DotNetOpenAuth.AspNet.Test")]
#endif
