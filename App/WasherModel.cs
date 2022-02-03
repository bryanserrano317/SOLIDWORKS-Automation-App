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
        // Grab the user input from WasherForm.cs
        public double outsideD { get; set; }
        public double insideD { get; set; }
        public double thickness { get; set; }

        // SOLIDWORKS API Stuff
        SldWorks swApp;
        ModelDoc2 swModel;
        Feature swFeature;
        bool status;
        string defaultPartTemplate;

        // Where the magic happens!
        public void CreatePart()
        {
            // Grab instance of SOLIDWORKS
            swApp = GetSolidworksAPI.GetApplication();

            // Let SOLIDWORKS know I'm going to design a part
            defaultPartTemplate = swApp.GetUserPreferenceStringValue((int)swUserPreferenceStringValue_e.swDefaultTemplatePart);

            // SOLIDWORKS will open a new part document window
            swApp.NewDocument(defaultPartTemplate, 0, 0, 0);

            // The new part window is now active and set to design
            swModel = (ModelDoc2)swApp.ActiveDoc;

            // Find a spot to insert new plane
            swFeature = swModel.FeatureByPositionReverse(2);
            swFeature.Name = "RefPlane";

            // Select plane to sketch on
            status = swModel.Extension.SelectByID2("RefPlane", "Plane", 0, 0, 0, false, 0, null, 0);

            // Insert a sketch
            swModel.InsertSketch2(true);

            // Insert outside circle using dimensions from user input
            swModel.CreateCircleByRadius2(0, 0, 0, outsideD);

            // Insert inside circle sing dimensions from user input
            swModel.CreateCircleByRadius2(0, 0, 0, insideD);

            // Exit Sketch
            swFeature = swModel.FeatureByPositionReverse(0);

            // Set name of Sketch
            swFeature.Name = "Sketch1";

            // Select the Sketch
            status = swModel.Extension.SelectByID2("Sketch1", "SKETCH", 0, 0, 0, false, 0, null, 0);

            // Extrude the Sketch
            swModel.FeatureManager.FeatureExtrusion3(true, false, false, 0, 0, thickness, 0, false, false, false, false, 0, 0, false, false, false, false, false, false, false, 0, 0, false);

            // Adjust view so you can see the part
            swModel.ViewZoomtofit2();

            // Do a nice little rebuild to wrap up the design
            swModel.ForceRebuild3(true);
        }
    }
}
