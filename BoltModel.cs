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
    public class BoltModel
    {
        // Grab dimnesion
        public double lengthDim { get; set;}
        public double thicknessDim { get; set; }

        // SOLIDWORKS API Stuff
        SldWorks swApp;
        ModelDoc2 swModel;
        Feature swFeature;
        bool status;
        string defaultPartTemplate;

        // Where the magic happens
        public void CreatePart()
        {
            swApp = GetSolidworksAPI.GetApplication();

            defaultPartTemplate = swApp.GetUserPreferenceStringValue((int)swUserPreferenceStringValue_e.swDefaultTemplatePart);

            swApp.NewDocument(defaultPartTemplate, 0, 0, 0);

            swModel = (ModelDoc2)swApp.ActiveDoc;

            swFeature = swModel.FeatureByPositionReverse(1);
            swFeature.Name = "Front Plane";

            status = swModel.Extension.SelectByID2("Front-Plane", "Plane", 0, 0, 0, false, 0, null, 0);

            swModel.InsertSketch2(true);

            swModel.CreateCircleByRadius2(0, 0, 0, lengthDim / 5);

            swFeature = swModel.FeatureByPositionReverse(0);

            swFeature.Name = "Sketch1";

            status = swModel.Extension.SelectByID2("Sketch1", "SKETCH", 0, 0, 0, false, 0, null, 0);

            swModel.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, lengthDim/7, lengthDim/7, false, false, false, false, lengthDim/7, lengthDim/7, false, false, false, false, true, true, true, 0, 0, false);

            status = swModel.Extension.SelectByID2("BossExtrude1", "FACE", 0, 0, 0, false, 0, null, 0);

            swModel.InsertSketch2(true);

            swModel.CreateCircleByRadius2(0, 0, 0, thicknessDim);

            swModel.InsertSketch2(true);

            swFeature = swModel.FeatureByPositionReverse(0);

            swFeature.Name = "Sketch2";

            status = swModel.Extension.SelectByID2("Sketch2", "SKETCH", 0, 0, 0, false, 0, null, 0);

            swModel.FeatureManager.FeatureExtrusion3(true, false, false, 0, 0, (lengthDim + (lengthDim / 7)), 0, false, false, false, false, 0, 0, false, false, false, false, false, false, false, 0, 0, false);
             
            swModel.ViewZoomtofit2();

            swModel.ForceRebuild3(true);

            status = swModel.Extension.SelectByID2("Front-Plane", "Plane", 0, 0, 0, false, 0, null, 0);

            swModel.InsertSketch2(true);

            swFeature = swModel.FeatureByPositionReverse(0);

            swModel.SketchManager.CreatePolygon(0, 0, 0, lengthDim / 9, 0, 0, 6, true);

            swModel.FeatureManager.FeatureCut4(true, false, false, 0, 0, lengthDim / 9, lengthDim / 9, false, false, false, false, lengthDim / 9, lengthDim / 9, false, false, false, false, false, true, true, true, true, false, 0, 0, false, false);

            swModel.ForceRebuild3(true);

            swModel.ShowNamedView2("*Trimetric", 8);

            swModel.ViewZoomtofit2();
            


        }

    }
}
