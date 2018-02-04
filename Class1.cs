// Decompiled with JetBrains decompiler
// Type: Class1
// Assembly: WindowsApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5810AC99-674B-4B41-BCEC-6D5ABE1706F8
// Assembly location: C:\Users\gorno\Desktop\vm\Stub.exe

using Microsoft.VisualBasic.ApplicationServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal class Class1 : ConsoleApplicationBase
{
  [SpecialName]
  public static Class0 get_Class0_0()
  {
    // ISSUE: reference to a compiler-generated field
    // ISSUE: variable of a compiler-generated type
    Class0 class00 = WindowsApplication2.My.Resources.Resources.class0_0;
    return class00;
  }
}
