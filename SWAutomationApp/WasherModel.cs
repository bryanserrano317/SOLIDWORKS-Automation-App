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
    public class WasherModel
    {
        public string Partname { get; set; }
        public double outsideD { get; set; }
        public double insideD { get; set; }
        public double thickness { get; set; }

        SldWorks swApp;
        ModelDoc2 swModel;
        Feature swFeature;
        bool status;
        string defaultPartTemplate;

        public void CreatePart()
        {
            swApp = GetSolidworksAPI.GetApplication();

            defaultPartTemplate = swApp.GetUserPreferenceStringValue((int)swUserPreferenceStringValue_e.swDefaultTemplatePart);

            swModel = (ModelDoc2)swApp.ActiveDoc;

            swFeature = swModel.FeatureByPositionReverse(2);
            swFeature.Name = "RefPlane";

            status = swModel.Extension.SelectByID2("RefPlane", "Plane", 0, 0, 0, false, 0, null, 0);

            swModel.InsertSketch2(true);

            swModel.CreateCircleByRadius2(0, 0, 0, outsideD);

            swModel.CreateCircleByRadius2(0, 0, 0, insideD);

            swFeature = swModel.FeatureByPositionReverse(0);

            swFeature.Name = "Sketch1";

            status = swModel.Extension.SelectByID2("Sketch1", "SKETCH", 0, 0, 0, false, 0, null, 0);

            swModel.FeatureManager.FeatureExtrusion3(true, false, false, 0, 0, thickness, 0, false, false, false, false, 0, 0, false, false, false, false, false, false, false, 0, 0, false);
            swModel.ViewZoomtofit2();

            swModel.ForceRebuild3(true);

        }

    }
}
