// Decompiled with JetBrains decompiler
// Type: Class3
// Assembly: WindowsApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5810AC99-674B-4B41-BCEC-6D5ABE1706F8
// Assembly location: C:\Users\gorno\Desktop\vm\Stub.exe

using dummy_ptr;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

[HideModuleName]
[StandardModule]
[GeneratedCode("MyTemplate", "11.0.0.0")]
internal sealed class Class3
{
  private static readonly Class3.Class6<Class2> class6_0 = new Class3.Class6<Class2>();
  private static readonly Class3.Class6<Class1> class6_1 = new Class3.Class6<Class1>();
  private static readonly Class3.Class6<User> class6_2 = new Class3.Class6<User>();
  private static ResourceManager resourceManager_0;
  private static CultureInfo cultureInfo_0;

  [HelpKeyword("My.Computer")]
  internal static Class2 Class2_0
  {
    [DebuggerHidden] get
    {
      return Class3.class6_0.get_Prop_0();
    }
  }

  [HelpKeyword("My.Application")]
  internal static Class1 Class1_0
  {
    [DebuggerHidden, SpecialName] get
    {
      return Class3.class6_1.get_Prop_0();
    }
  }

  [HelpKeyword("My.User")]
  internal static User User_0
  {
    [DebuggerHidden, SpecialName] get
    {
      return Class3.class6_2.get_Prop_0();
    }
  }

  [HelpKeyword("My.Forms")]
  internal static Class3.Class4 Class4_0
  {
    [DebuggerHidden, SpecialName] get
    {
      return Class3.Class4.class6_3.get_Prop_0();
    }
  }

  [HelpKeyword("My.WebServices")]
  internal static Class3.Class5 Class5_0
  {
    [DebuggerHidden, SpecialName] get
    {
      return Class3.Class4.class6_4.get_Prop_0();
    }
  }

  static Class3()
  {
    Class3.Class4.class6_3 = new Class3.Class6<Class3.Class4>();
    Class3.Class4.class6_4 = new Class3.Class6<Class3.Class5>();
  }

  public Class3()
    : this()
  {
  }

  [DebuggerHidden]
  [EditorBrowsable(EditorBrowsableState.Never)]
  public Class3()
    : this()
  {
  }

  [SpecialName]
  internal static CultureInfo get_CultureInfo_0()
  {
    return Class3.cultureInfo_0;
  }

  [SpecialName]
  internal static void set_CultureInfo_0([In] CultureInfo obj0)
  {
    Class3.cultureInfo_0 = obj0;
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
  internal sealed class Class4
  {
    private static Class3.Class6<Class3.Class4> class6_3;
    private static readonly Class3.Class6<Class3.Class5> class6_4;

    public GForm0 GForm0_0
    {
      [DebuggerHidden, SpecialName] get
      {
        ((\u007B8773286b\u002Dcf90\u002D4c8b\u002D93ad\u002D4343348e6425\u007D) this).gform0_0 = Class3.Class4.smethod_0<GForm0>(((\u007B8773286b\u002Dcf90\u002D4c8b\u002D93ad\u002D4343348e6425\u007D) this).gform0_0);
        return ((\u007B8773286b\u002Dcf90\u002D4c8b\u002D93ad\u002D4343348e6425\u007D) this).gform0_0;
      }
      [DebuggerHidden, SpecialName] set
      {
        if (value == ((\u007B8773286b\u002Dcf90\u002D4c8b\u002D93ad\u002D4343348e6425\u007D) this).gform0_0)
          return;
        if (value != null)
          throw new ArgumentException("Property can only be set to Nothing");
        ((Class3.Class4) this).method_0<GForm0>(ref ((\u007B8773286b\u002Dcf90\u002D4c8b\u002D93ad\u002D4343348e6425\u007D) this).gform0_0);
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    public Class4()
    {
    }

    [DebuggerHidden]
    [SpecialName]
    internal static Class1 get_Class1_0()
    {
      return Class3.class6_1.get_Prop_0();
    }

    [DebuggerHidden]
    [SpecialName]
    internal static User get_User_0()
    {
      return Class3.class6_2.get_Prop_0();
    }

    [DebuggerHidden]
    [SpecialName]
    internal static Class3.Class4 get_Class4_0()
    {
      return Class3.Class4.class6_3.get_Prop_0();
    }

    [DebuggerHidden]
    [SpecialName]
    internal static Class3.Class5 get_Class5_0()
    {
      return Class3.Class4.class6_4.get_Prop_0();
    }

    [DebuggerHidden]
    private static T smethod_0<T>([In] T obj0) where T : Form, new()
    {
      T obj;
      if (((object) obj0 == null ? 1 : (obj0.IsDisposed ? 1 : 0)) != 0)
      {
        if (Class3.Class6<>.hashtable_0 != null)
        {
          if (Class3.Class6<>.hashtable_0.ContainsKey((object) typeof (T)))
            throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
        }
        else
          Class3.Class6<>.hashtable_0 = new Hashtable();
        Class3.Class6<>.hashtable_0.Add((object) typeof (T), (object) null);
        try
        {
          obj = Activator.CreateInstance<T>();
        }
        catch (TargetInvocationException ex) when (
        {
          // ISSUE: unable to correctly present filter
          ProjectData.SetProjectError((Exception) ex);
          if (ex.InnerException != null)
          {
            SuccessfulFiltering;
          }
          else
            throw;
        }
        )
        {
          TargetInvocationException invocationException;
          throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[1]
          {
            invocationException.InnerException.Message
          }), invocationException.InnerException);
        }
        finally
        {
          Class3.Class6<>.hashtable_0.Remove((object) typeof (T));
        }
      }
      else
        obj = obj0;
      return obj;
    }

    [DebuggerHidden]
    private void method_0<T>([In] ref T obj0) where T : Form
    {
      obj0.Dispose();
      obj0 = default (T);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object disposing)
    {
      return this.Equals(RuntimeHelpers.GetObjectValue(disposing));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode()
    {
      return this.GetHashCode();
    }
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
  internal sealed class Class5
  {
    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public Class5()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal System.Type method_1()
    {
      return typeof (Class3.Class4);
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string ToString()
    {
      return this.ToString();
    }

    [DebuggerHidden]
    [SpecialName]
    public GForm0 get_GForm0_0()
    {
      ((\u007B8773286b\u002Dcf90\u002D4c8b\u002D93ad\u002D4343348e6425\u007D) this).gform0_0 = Class3.Class4.smethod_0<GForm0>(((\u007B8773286b\u002Dcf90\u002D4c8b\u002D93ad\u002D4343348e6425\u007D) this).gform0_0);
      return ((\u007B8773286b\u002Dcf90\u002D4c8b\u002D93ad\u002D4343348e6425\u007D) this).gform0_0;
    }

    [DebuggerHidden]
    [SpecialName]
    public void set_GForm0_0(GForm0 value)
    {
      if (value == ((\u007B8773286b\u002Dcf90\u002D4c8b\u002D93ad\u002D4343348e6425\u007D) this).gform0_0)
        return;
      if (value != null)
        throw new ArgumentException("Property can only be set to Nothing");
      ((Class3.Class4) this).method_0<GForm0>(ref ((\u007B8773286b\u002Dcf90\u002D4c8b\u002D93ad\u002D4343348e6425\u007D) this).gform0_0);
    }

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object gparam_0)
    {
      return this.Equals(RuntimeHelpers.GetObjectValue(gparam_0));
    }

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode()
    {
      return this.GetHashCode();
    }
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  [ComVisible(false)]
  internal sealed class Class6<T> where T : new()
  {
    [ThreadStatic]
    private static Hashtable hashtable_0;

    internal T Prop_0
    {
      [DebuggerHidden, SpecialName] get
      {
        if ((object) Class3.Class6<T0>.gparam_0 == null)
          Class3.Class6<T0>.gparam_0 = Activator.CreateInstance<T0>();
        return Class3.Class6<T0>.gparam_0;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerHidden]
    internal System.Type method_0()
    {
      return typeof (Class3.Class5);
    }

    [DebuggerHidden]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string ToString()
    {
      return this.ToString();
    }
  }
}
