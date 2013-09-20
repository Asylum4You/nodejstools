﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the Apache License, Version 2.0, please send an email to 
 * vspython@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * ***************************************************************************/

using System.ComponentModel.Composition;
using TestUtilities.SharedProject;

namespace Microsoft.Nodejs.Tests.UI {
    public sealed class NodejsTestDefintions {
        [Export]
        [ProjectExtension(".njsproj")]
        [ProjectTypeGuid("9092AA53-FB77-4645-B42D-1CCCA6BD08BD")]
        [CodeExtension(".js")]
        [SampleCode("console.log('hi');")]
        internal static ProjectTypeDefinition ProjectTypeDefinition = new ProjectTypeDefinition();
    }
}
