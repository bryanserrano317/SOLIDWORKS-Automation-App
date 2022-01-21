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
    public class LegoModel
    {
        public string Partname { get; set; }

        public double Dim_A { get; set; }
        public double Dim_B { get; set; }
        public double Dim_D1 { get; set; }
        public double Dim_D2 { get; set; }
        public double Dim_D3 { get; set; }
        public double Dim_H1 { get; set; }
        public double Dim_H2 { get; set; }

        SldWorks swApp;
        ModelDoc2 swModel;
        Feature swFeature;
        RenderMaterial swAppearance;
        IModelDocExtension swModelDocExt;
        int nDecalID;
        bool status;
        string defaultPartTemplate;
        string strName;
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

            swModel.CreateLine2(0, 0, 0, Dim_A, 0, 0);

            swModel.CreateLine2(Dim_A, 0, 0, Dim_A, Dim_A, 0);

            swModel.CreateLine2(Dim_A, Dim_A, 0, 0, Dim_A, 0);

            swModel.CreateLine2(0, 0, 0, 0, Dim_A, 0);

            swModel.InsertSketch2(true);

            swFeature = swModel.FeatureByPositionReverse(0);
            swFeature.Name = "Sketch1";

            status = swModel.Extension.SelectByID2("Sketch1", "SKETCH", 0, 0, 0, false, 0, null, 0);

            swModel.FeatureManager.FeatureExtrusion3(true, false, false, 0, 0, Dim_H1, 0, false, false, false, false, 0, 0, false, false, false, false, false, false, false, 0, 0, false);

            status = swModel.Extension.SelectByID2("", "FACE", Dim_B / 2, Dim_H1, Dim_H1, false, 0, null, 0);

            swModel.InsertSketch2(true);

            swModel.CreateCircleByRadius2(Dim_B, Dim_B, 0, Dim_D3 / 2);
            swModel.CreateCircleByRadius2(Dim_A - Dim_B, Dim_B, 0, Dim_D3 / 2);
            swModel.CreateCircleByRadius2(Dim_A - Dim_B, Dim_A - Dim_B, 0, Dim_D3 / 2);
            swModel.CreateCircleByRadius2(Dim_B, Dim_A - Dim_B, 0, Dim_D3 / 2);

            swModel.InsertSketch2(true);

            swFeature = swModel.FeatureByPositionReverse(0);

            swFeature.Name = "Sketch2";

            status = swModel.Extension.SelectByID2("Sketch2", "SKETCH", 0, 0, 0, false, 0, null, 0);

            swModel.FeatureManager.FeatureExtrusion3(true, false, false, 0, 0, Dim_H2, 0, false, false, false, false, 0, 0, false, false, false, false, true, false, false, 0, 0, false);

            swModel.ViewZoomtofit2();

            swModel.ForceRebuild3(true);
            
            /* Coming Soon (Automated Appeareance Setter)
            //strName = @"C:\Program Files\SOLIDWORKS Corp\SOLIDWORKS\data\graphics\Materials\metal\aluminum\blue anodized aluminum.p2m";

            swAppearance = swModelDocExt.CreateRenderMaterial("C:\\Program Files\\SOLIDWORKS Corp\\SOLIDWORKS\\data\\graphics\\Materials\\metal\\aluminum\\blue anodized aluminum.p2m");

            status = swAppearance.AddEntity(swModel);

            status = swModelDocExt.AddRenderMaterial(swAppearance, out nDecalID);

            swModel.ForceRebuild3(true);

            swModel.SaveAs3(root.ToString() + "\\" + Partname + ".sldprt", (int)swSaveAsVersion_e.swSaveAsCurrentVersion, (int)swSaveAsOptions_e.swSaveAsOptions_CopyAndOpen);

            */
        } // end CreatePart
    } // end class LegoModel
} // end namespace
