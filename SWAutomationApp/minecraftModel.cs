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
            swApp = GetSolidworksAPI.GetApplication();


            defaultPartTemplate = swApp.GetUserPreferenceStringValue((int)swUserPreferenceStringValue_e.swDefaultTemplatePart);


            swModel = (ModelDoc2)swApp.ActiveDoc;

            swModel.InsertSketch2(true);


            status = swModel.SketchManager.SketchUseEdge3(false, false);

            swModel.ClearSelection2(true);

            swFeature = ((Feature)(swModel.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, 0.001, 0.001, false, false, false, false, 1, 1, false, false, false, false, false, true, true, 0, 0, false)));


        }

    }
}
