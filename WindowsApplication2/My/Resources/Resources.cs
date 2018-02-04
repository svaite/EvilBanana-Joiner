// Decompiled with JetBrains decompiler
// Type: WindowsApplication2.My.Resources.Resources
// Assembly: WindowsApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5810AC99-674B-4B41-BCEC-6D5ABE1706F8
// Assembly location: C:\Users\gorno\Desktop\vm\Stub.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WindowsApplication2.My.Resources
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  [HideModuleName]
  [StandardModule]
  internal sealed class Resources
  {
    private static Class0 class0_0 = (Class0) SettingsBase.Synchronized((SettingsBase) new WindowsApplication2.My.Resources.Resources());
    private IContainer icontainer_0;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager_0
    {
      [SpecialName] get
      {
        if (object.ReferenceEquals((object) Class3.resourceManager_0, (object) null))
          Class3.resourceManager_0 = new ResourceManager("WindowsApplication2.Resources", typeof (WindowsApplication2.My.Resources.Resources).Assembly);
        return Class3.resourceManager_0;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo CultureInfo_0
    {
      [SpecialName] get
      {
        return Class3.cultureInfo_0;
      }
      [SpecialName] set
      {
        Class3.cultureInfo_0 = value;
      }
    }

    public Resources()
      : this()
    {
    }

    [DebuggerStepThrough]
    private void method_0()
    {
      // ISSUE: reference to a compiler-generated field
      this.icontainer_0 = (IContainer) new System.ComponentModel.Container();
      ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
      ((Form) this).Text = "Form1";
    }
  }
}
