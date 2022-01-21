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
    public class minecraftModel
    {
        public string Partname { get; set; }

        SldWorks swApp;
        ModelDoc2 swModel;
        Feature swFeature;
        bool status;
        string defaultPartTemplate;

        public void CreatePart()
        {
            swApp = GetSolidworksAPI.GetApplication(); // get instance
            
            // Gets SOLIDWORKS ready to design a part rather than build an assembly or create a drawing
            defaultPartTemplate = swApp.GetUserPreferenceStringValue((int)swUserPreferenceStringValue_e.swDefaultTemplatePart);
            
            // Lets SOLIDWORKS know to activate the model 
            swModel = (ModelDoc2)swApp.ActiveDoc;
            
            // Opens Sketch Design menu 
            swModel.InsertSketch2(true);
            
            // API Call for Convert Entities. This call converts all edges from previous square block to be used for new block
            status = swModel.SketchManager.SketchUseEdge3(false, false);
            
            // Exit out of the Sketch menu
            swModel.ClearSelection2(true);
            
            // Extrude Sketch to a 1x1mm cube
            swFeature = ((Feature)(swModel.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, 0.001, 0.001, false, false, false, false, 1, 1, false, false, false, false, false, true, true, 0, 0, false)));

        }

    }
}
