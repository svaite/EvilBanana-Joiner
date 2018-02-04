// Decompiled with JetBrains decompiler
// Type: Class7
// Assembly: WindowsApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5810AC99-674B-4B41-BCEC-6D5ABE1706F8
// Assembly location: C:\Users\gorno\Desktop\vm\Stub.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[HideModuleName]
[CompilerGenerated]
[StandardModule]
[DebuggerNonUserCode]
internal sealed class Class7
{
  [HelpKeyword("My.Settings")]
  internal static Class0 Class0_0
  {
    [SpecialName] get
    {
      Class0 class0 = Class1.get_Class0_0();
      return class0;
    }
  }

  [DebuggerHidden]
  private static T smethod_0<T>(T gparam_0) where T : new()
  {
    return (object) gparam_0 != null ? gparam_0 : Activator.CreateInstance<T>();
  }
}
