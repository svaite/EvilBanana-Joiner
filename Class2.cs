// Decompiled with JetBrains decompiler
// Type: Class2
// Assembly: WindowsApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5810AC99-674B-4B41-BCEC-6D5ABE1706F8
// Assembly location: C:\Users\gorno\Desktop\vm\Stub.exe

using Microsoft.VisualBasic.Devices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Resources;
using System.Runtime.CompilerServices;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class Class2 : Computer
{
  [SpecialName]
  internal static ResourceManager get_ResourceManager_0()
  {
    if (object.ReferenceEquals((object) Class3.resourceManager_0, (object) null))
      Class3.resourceManager_0 = new ResourceManager("WindowsApplication2.Resources", typeof (WindowsApplication2.My.Resources.Resources).Assembly);
    return Class3.resourceManager_0;
  }
}
