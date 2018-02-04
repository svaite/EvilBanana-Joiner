// Decompiled with JetBrains decompiler
// Type: Class0
// Assembly: WindowsApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5810AC99-674B-4B41-BCEC-6D5ABE1706F8
// Assembly location: C:\Users\gorno\Desktop\vm\Stub.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
internal sealed class Class0 : ApplicationSettingsBase
{
  public const string string_0 = "4.0.0.0";

  public static Class0 Class0_0
  {
    [SpecialName] get
    {
      Class0 class00 = WindowsApplication2.My.Resources.Resources.class0_0;
      return class00;
    }
  }

  public Class0()
    : this()
  {
  }

  public Class0()
    : this()
  {
    // ISSUE: reference to a compiler-generated method
    ((WindowsApplication2.My.Resources.Resources) this).method_0();
  }

  [DebuggerNonUserCode]
  protected virtual void Dispose([In] bool obj0)
  {
    try
    {
      // ISSUE: reference to a compiler-generated field
      if ((!obj0 ? 0 : (((WindowsApplication2.My.Resources.Resources) this).icontainer_0 != null ? 1 : 0)) == 0)
        return;
      // ISSUE: reference to a compiler-generated field
      ((WindowsApplication2.My.Resources.Resources) this).icontainer_0.Dispose();
    }
    finally
    {
      // ISSUE: explicit non-virtual call
      __nonvirtual (((Form) this).Dispose(obj0));
    }
  }
}
