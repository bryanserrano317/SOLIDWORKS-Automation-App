using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.IO;
using System.Windows.Forms;

namespace automationapp
{
    public class minecraftModelHelper
    {
        public string Partname { get; set; }

        SldWorks swApp;
        ModelDoc2 swModel;
        Feature swFeature;
        bool status;
        string defaultPartTemplate;

        public void CreatePart()
        {
            swApp = GetSolidworksAPI.GetApplication();

            defaultPartTemplate = swApp.GetUserPreferenceStringValue((int)swUserPreferenceStringValue_e.swDefaultTemplatePart);

            swApp.NewDocument(defaultPartTemplate, 0, 0, 0);

            swModel = (ModelDoc2)swApp.ActiveDoc;

            swFeature = swModel.FeatureByPositionReverse(2);
            swFeature.Name = "RefPlane";

            status = swModel.Extension.SelectByID2("RefPlane", "Plane", 0, 0, 0, false, 0, null, 0);

            swModel.InsertSketch2(true);

            swModel.CreateLine2(0, 0, 0, 1, 0, 0);

            swModel.CreateLine2(1, 0, 0, 1, 1, 0);

            swModel.CreateLine2(1, 1, 0, 0, 1, 0);

            swModel.CreateLine2(0, 0, 0, 0, 1, 0);

            swModel.ClearSelection2(true);

            swFeature = ((Feature)(swModel.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, 1, 1, false, false, false, false, 1, 1, false, false, false, false, false, true, true, 0, 0, false)));

            swModel.ShowNamedView2("*Trimetric", 8);

            swModel.ViewZoomtofit2();
        }

    }
}
