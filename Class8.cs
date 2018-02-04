// Decompiled with JetBrains decompiler
// Type: Class8
// Assembly: WindowsApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5810AC99-674B-4B41-BCEC-6D5ABE1706F8
// Assembly location: C:\Users\gorno\Desktop\vm\Stub.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

[StandardModule]
internal sealed class Class8
{
  [DebuggerHidden]
  [EditorBrowsable(EditorBrowsableState.Never)]
  public Class8()
  {
  }

  [DebuggerHidden]
  private void method_1<T>(ref T o)
  {
    o = default (T);
  }

  [DebuggerHidden]
  [SpecialName]
  internal T0 get_Prop_0()
  {
    if ((object) Class3.Class6<T0>.gparam_0 == null)
      Class3.Class6<T0>.gparam_0 = Activator.CreateInstance<T0>();
    return Class3.Class6<T0>.gparam_0;
  }
}
