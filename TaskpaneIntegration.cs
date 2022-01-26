
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swpublished;
using System.IO;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Solidworks.BlankAddin
{
  /// <summary>
  /// Our SolidWorks takspane addin
  /// adds and registers entries, responds to solidworks, connets, disconnets, creates the taskpane widow
  /// </summary>
  public class TaskpaneIntegration : ISwAddin 
    {
    #region Private Members

    /// <summary>
    /// The cookie to the current instance of SolidWorks we are running inside of
    /// </summary>
    private int mSwCookie;


    /// <summary>
    /// The taskpane view of our add-inn 
    /// </summary>
    private TaskpaneView taskpaneView;



    /// <summary>
    /// The UI control that is going to be inside the SolidWorks taskpane view
    /// </summary>
    private TaskpaneHostUI mTaskpaneHost;

    /// <summary>
    /// Current instance of the SolidWorks application
    /// </summary>
    private SldWorks mSolidWorksApplication;

		#endregion

		#region Public Members
    /// <summary>
    /// The unique ID to the taskpane used for registration in COM 
    /// </summary>
		public const string SWTASKPANE_PROGID = "Solidworks.BlankAddin.Taskpane";
		#endregion

		#region SolidWorks Add-in Callbacks

    /// <summary>
    /// Called when SolidWorks has loaded our add-in and wants us to do our connection logic
    /// </summary>
    /// <param name="ThisSW">The current SolidWorks instance</param>
    /// <param name="Cookie">The current SolidWorks cookie ID</param>
    /// <returns></returns>
		public bool ConnectToSW(object ThisSW, int Cookie)
    {
      //Store a referennce to the current SolidWorks instance 
      mSolidWorksApplication = (SldWorks)ThisSW;

      //Store cookie ID 
      mSwCookie = Cookie;

      //Setup callback info 
      var ok = mSolidWorksApplication.SetAddinCallbackInfo2(0, this, mSwCookie);

      //Create our UI
      LoadIU();

      //Return our UI
      return true;
    }

	

		/// <summary>
		/// Called when SolidWorks is about to unload our add-in and wants us to do our disconnection logic
		/// </summary>
		/// <returns></returns>
		public bool DisconnectFromSW()
    {
      // Clean our UI
      UnloadUI();

      //Return ok
      return true;
    }

		
		#endregion


		#region Create UI

		private void LoadIU()
    {
      //Find location to our taskpane icon 
      var imagePath = Path.Combine(Path.GetDirectoryName(typeof(TaskpaneIntegration).Assembly.CodeBase).Replace(@"file:\", ""), "logo-small.png");

      //Create out Taskpane
      var mTaskpaneView = mSolidWorksApplication.CreateTaskpaneView2(imagePath, "Woo! My first SwAddin!");

      //Load out UI into the taskpane
      //mTaskpaneHost = (TaskpaneHostUI)mTaskpaneView
    }

    private void UnloadUI()
    {
      throw new System.NotImplementedException();
    }


    #endregion
  }
}