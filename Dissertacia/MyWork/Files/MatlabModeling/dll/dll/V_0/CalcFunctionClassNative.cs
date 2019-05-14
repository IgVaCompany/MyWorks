/*
* MATLAB Compiler: 6.4 (R2017a)
* Date: Mon Jan 07 10:36:39 2019
* Arguments:
* "-B""macro_default""-W""dotnet:CalcFunction_v_1,CalcFunctionClass,4.0,private""-T""link:
* lib""-d""C:\Users\Vasilii\Documents\MyWorks\trunk\Dissertacia\MyWork\Files\MatlabModelin
* g\dll\dll\V_0""-v""class{CalcFunctionClass:C:\Users\Vasilii\Documents\MyWorks\trunk\Diss
* ertacia\MyWork\Files\MatlabModeling\Second_step\CalcFunction_v_1.m}"
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace CalcFunction_v_1Native
{

  /// <summary>
  /// The CalcFunctionClass class provides a CLS compliant, Object (native) interface to
  /// the MATLAB functions contained in the files:
  /// <newpara></newpara>
  /// C:\Users\Vasilii\Documents\MyWorks\trunk\Dissertacia\MyWork\Files\MatlabModeling\Sec
  /// ond_step\CalcFunction_v_1.m
  /// </summary>
  /// <remarks>
  /// @Version 4.0
  /// </remarks>
  public class CalcFunctionClass : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static CalcFunctionClass()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "CalcFunction_v_1.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the CalcFunctionClass class.
    /// </summary>
    public CalcFunctionClass()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~CalcFunctionClass()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the CalcFunction_v_1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// CALCFUNCTION_V_0 Summary of this function goes here
    /// Detailed explanation goes here
    /// cd('C:\Users\Vasilii\Documents\MyWorks\trunk\Dissertacia\MyWork\Files\MatlabModeli
    /// ng\dll\Vusual\New\Assets');
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object CalcFunction_v_1()
    {
      return mcr.EvaluateFunction("CalcFunction_v_1", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the CalcFunction_v_1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// CALCFUNCTION_V_0 Summary of this function goes here
    /// Detailed explanation goes here
    /// cd('C:\Users\Vasilii\Documents\MyWorks\trunk\Dissertacia\MyWork\Files\MatlabModeli
    /// ng\dll\Vusual\New\Assets');
    /// </remarks>
    /// <param name="time">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object CalcFunction_v_1(Object time)
    {
      return mcr.EvaluateFunction("CalcFunction_v_1", time);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the CalcFunction_v_1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// CALCFUNCTION_V_0 Summary of this function goes here
    /// Detailed explanation goes here
    /// cd('C:\Users\Vasilii\Documents\MyWorks\trunk\Dissertacia\MyWork\Files\MatlabModeli
    /// ng\dll\Vusual\New\Assets');
    /// </remarks>
    /// <param name="time">Input argument #1</param>
    /// <param name="velocityInsertion">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object CalcFunction_v_1(Object time, Object velocityInsertion)
    {
      return mcr.EvaluateFunction("CalcFunction_v_1", time, velocityInsertion);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the CalcFunction_v_1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// CALCFUNCTION_V_0 Summary of this function goes here
    /// Detailed explanation goes here
    /// cd('C:\Users\Vasilii\Documents\MyWorks\trunk\Dissertacia\MyWork\Files\MatlabModeli
    /// ng\dll\Vusual\New\Assets');
    /// </remarks>
    /// <param name="time">Input argument #1</param>
    /// <param name="velocityInsertion">Input argument #2</param>
    /// <param name="velocityRotation">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object CalcFunction_v_1(Object time, Object velocityInsertion, Object 
                             velocityRotation)
    {
      return mcr.EvaluateFunction("CalcFunction_v_1", time, velocityInsertion, velocityRotation);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the CalcFunction_v_1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// CALCFUNCTION_V_0 Summary of this function goes here
    /// Detailed explanation goes here
    /// cd('C:\Users\Vasilii\Documents\MyWorks\trunk\Dissertacia\MyWork\Files\MatlabModeli
    /// ng\dll\Vusual\New\Assets');
    /// </remarks>
    /// <param name="time">Input argument #1</param>
    /// <param name="velocityInsertion">Input argument #2</param>
    /// <param name="velocityRotation">Input argument #3</param>
    /// <param name="clcFlag">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object CalcFunction_v_1(Object time, Object velocityInsertion, Object 
                             velocityRotation, Object clcFlag)
    {
      return mcr.EvaluateFunction("CalcFunction_v_1", time, velocityInsertion, velocityRotation, clcFlag);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the CalcFunction_v_1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// CALCFUNCTION_V_0 Summary of this function goes here
    /// Detailed explanation goes here
    /// cd('C:\Users\Vasilii\Documents\MyWorks\trunk\Dissertacia\MyWork\Files\MatlabModeli
    /// ng\dll\Vusual\New\Assets');
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CalcFunction_v_1(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "CalcFunction_v_1", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the CalcFunction_v_1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// CALCFUNCTION_V_0 Summary of this function goes here
    /// Detailed explanation goes here
    /// cd('C:\Users\Vasilii\Documents\MyWorks\trunk\Dissertacia\MyWork\Files\MatlabModeli
    /// ng\dll\Vusual\New\Assets');
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="time">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CalcFunction_v_1(int numArgsOut, Object time)
    {
      return mcr.EvaluateFunction(numArgsOut, "CalcFunction_v_1", time);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the CalcFunction_v_1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// CALCFUNCTION_V_0 Summary of this function goes here
    /// Detailed explanation goes here
    /// cd('C:\Users\Vasilii\Documents\MyWorks\trunk\Dissertacia\MyWork\Files\MatlabModeli
    /// ng\dll\Vusual\New\Assets');
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="time">Input argument #1</param>
    /// <param name="velocityInsertion">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CalcFunction_v_1(int numArgsOut, Object time, Object 
                               velocityInsertion)
    {
      return mcr.EvaluateFunction(numArgsOut, "CalcFunction_v_1", time, velocityInsertion);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the CalcFunction_v_1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// CALCFUNCTION_V_0 Summary of this function goes here
    /// Detailed explanation goes here
    /// cd('C:\Users\Vasilii\Documents\MyWorks\trunk\Dissertacia\MyWork\Files\MatlabModeli
    /// ng\dll\Vusual\New\Assets');
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="time">Input argument #1</param>
    /// <param name="velocityInsertion">Input argument #2</param>
    /// <param name="velocityRotation">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CalcFunction_v_1(int numArgsOut, Object time, Object 
                               velocityInsertion, Object velocityRotation)
    {
      return mcr.EvaluateFunction(numArgsOut, "CalcFunction_v_1", time, velocityInsertion, velocityRotation);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the CalcFunction_v_1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// CALCFUNCTION_V_0 Summary of this function goes here
    /// Detailed explanation goes here
    /// cd('C:\Users\Vasilii\Documents\MyWorks\trunk\Dissertacia\MyWork\Files\MatlabModeli
    /// ng\dll\Vusual\New\Assets');
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="time">Input argument #1</param>
    /// <param name="velocityInsertion">Input argument #2</param>
    /// <param name="velocityRotation">Input argument #3</param>
    /// <param name="clcFlag">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] CalcFunction_v_1(int numArgsOut, Object time, Object 
                               velocityInsertion, Object velocityRotation, Object clcFlag)
    {
      return mcr.EvaluateFunction(numArgsOut, "CalcFunction_v_1", time, velocityInsertion, velocityRotation, clcFlag);
    }


    /// <summary>
    /// Provides an interface for the CalcFunction_v_1 function in which the input and
    /// output
    /// arguments are specified as an array of Objects.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// CALCFUNCTION_V_0 Summary of this function goes here
    /// Detailed explanation goes here
    /// cd('C:\Users\Vasilii\Documents\MyWorks\trunk\Dissertacia\MyWork\Files\MatlabModeli
    /// ng\dll\Vusual\New\Assets');
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of Object output arguments</param>
    /// <param name= "argsIn">Array of Object input arguments</param>
    /// <param name= "varArgsIn">Array of Object representing variable input
    /// arguments</param>
    ///
    [MATLABSignature("CalcFunction_v_1", 4, 9, 0)]
    protected void CalcFunction_v_1(int numArgsOut, ref Object[] argsOut, Object[] argsIn, params Object[] varArgsIn)
    {
        mcr.EvaluateFunctionForTypeSafeCall("CalcFunction_v_1", numArgsOut, ref argsOut, argsIn, varArgsIn);
    }

    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
