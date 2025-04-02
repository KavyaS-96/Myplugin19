using System;
using System.Drawing;
using Grasshopper;
using Grasshopper.Kernel;

namespace Myplugin19
{
  public class Myplugin19Info : GH_AssemblyInfo
  {
    public override string Name => "Myplugin19";

    //Return a 24x24 pixel bitmap to represent this GHA library.
    public override Bitmap Icon => null;

    //Return a short string describing the purpose of this GHA library.
    public override string Description => "";

    public override Guid Id => new Guid("90548cf6-4045-48b5-8cf4-88ff1f1e8b24");

    //Return a string identifying you or your company.
    public override string AuthorName => "";

    //Return a string representing your preferred contact details.
    public override string AuthorContact => "";

    //Return a string representing the version.  This returns the same version as the assembly.
    public override string AssemblyVersion => GetType().Assembly.GetName().Version.ToString();
  }
}