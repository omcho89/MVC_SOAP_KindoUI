using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace SOAP_i_to.Controllers
{
    public class SoapController : Controller
    {
        //
        // GET: /Soap/

        public ActionResult Index()
        {
            
            com.solveworkforce.quintiles.dev.ESErrorInfo outa;
            
            Test.IndexMetricsTrainingEffectivenessScoreResponse res = new Test.IndexMetricsTrainingEffectivenessScoreResponse();
            com.solveworkforce.quintiles.dev.ESWebService serviceRequest = new com.solveworkforce.quintiles.dev.ESWebService();
            com.solveworkforce.quintiles.dev.IndexMetricsTrainingEffectivenessScoreResults serviceResponse;
            
            //Here happens the aquisition of informations on the left side of screen, they are collected in dictionary "informationLeft"
            Dictionary<string, float> informationLeft = new Dictionary<string, float>();
            
            //Training Effectiveness Index
            serviceResponse = serviceRequest.IndexMetricsTrainingEffectivenessScore("All countries", "Value", "", "USD", "Scofield Financial", "All Workforce Categories"
           , "2013 Q4", "Training Effectiveness Index", out outa);
            informationLeft.Add("Training Effectiveness Index", (float)serviceResponse.RowSet.Rows[0].Actual.Value);
            //change
            serviceResponse = serviceRequest.IndexMetricsTrainingEffectivenessScore("All countries", "Value", "", "USD", "Scofield Financial", "All Workforce Categories"
            , "2013 Q4", "Training Effectiveness Index Change", out outa);
            informationLeft.Add("Training Effectiveness Index - change", (float)serviceResponse.RowSet.Rows[0].Actual.Value);

             //Training Impact
            serviceResponse = serviceRequest.IndexMetricsTrainingEffectivenessScore("All countries", "Value", "", "USD", "Scofield Financial", "All Workforce Categories"
           , "2013 Q4", "Training Impact", out outa);
            informationLeft.Add("Training Impact", (float)serviceResponse.RowSet.Rows[0].Actual.Value);
            //change
            serviceResponse = serviceRequest.IndexMetricsTrainingEffectivenessScore("All countries", "Value", "", "USD", "Scofield Financial", "All Workforce Categories"
            , "2013 Q4", "Training Impact Percent Change", out outa);
            informationLeft.Add("Training Impact - change", (float)serviceResponse.RowSet.Rows[0].Actual.Value);

            //High Performer Retention Rate
            serviceResponse = serviceRequest.IndexMetricsTrainingEffectivenessScore("All countries", "Value", "", "USD", "Scofield Financial", "All Workforce Categories"
            , "2013 Q4", "High Performer Retention Rate", out outa);
            informationLeft.Add("High Performer Retention Rate - 5core", (float)serviceResponse.RowSet.Rows[0].Actual.Value);
            informationLeft.Add("High Performer Retention Rate - benchmark", (float)serviceResponse.RowSet.Rows[0].Benchmark.Value);
            //change
            serviceResponse =serviceRequest.IndexMetricsTrainingEffectivenessScore("All countries", "Value", "", "USD", "Scofield Financial", "All Workforce Categories"
            , "2013 Q4", "High Performer Retention Rate Change", out outa);
            informationLeft.Add("High Performer Retention Rate - change", (float)serviceResponse.RowSet.Rows[0].Actual.Value);

            //Training Performance Differential Impact
            serviceResponse = serviceRequest.IndexMetricsTrainingEffectivenessScore("All countries", "Value", "", "USD", "Scofield Financial", "All Workforce Categories"
           , "2013 Q4", "Training Performance Differential Impact", out outa);
            informationLeft.Add("Training Performance Differential Impact - 5core", (float)serviceResponse.RowSet.Rows[0].Actual.Value);
            informationLeft.Add("Training Performance Differential Impact - benchmark", (float)serviceResponse.RowSet.Rows[0].Benchmark.Value);
            //change
            serviceResponse = serviceRequest.IndexMetricsTrainingEffectivenessScore("All countries", "Value", "", "USD", "Scofield Financial", "All Workforce Categories"
            , "2013 Q4", "Training Performance Differential Impact Percent Change", out outa);
            informationLeft.Add("Training Performance Differential Impact - change", (float)serviceResponse.RowSet.Rows[0].Actual.Value);

            //Training Investment per FTE
            serviceResponse = serviceRequest.IndexMetricsTrainingEffectivenessScore("All countries", "Value", "", "USD", "Scofield Financial", "All Workforce Categories"
           , "2013 Q4", "Training Investment per FTE", out outa);
            informationLeft.Add("Training Investment per FTE - 5core", (float)serviceResponse.RowSet.Rows[0].Actual.Value);
            informationLeft.Add("Training Investment per FTE - benchmark", (float)serviceResponse.RowSet.Rows[0].Benchmark.Value);
            //change
            serviceResponse = serviceRequest.IndexMetricsTrainingEffectivenessScore("All countries", "Value", "", "USD", "Scofield Financial", "All Workforce Categories"
            , "2013 Q4", "Training Investment per FTE Percent Change", out outa);
            informationLeft.Add("Training Investment per FTE - change", (float)serviceResponse.RowSet.Rows[0].Actual.Value);

            //Satisfaction with Training
            serviceResponse = serviceRequest.IndexMetricsTrainingEffectivenessScore("All countries", "Value", "", "USD", "Scofield Financial", "All Workforce Categories"
           , "2013 Q4", "Satisfaction with Training", out outa);
            informationLeft.Add("Satisfaction with Training - 5core", (float)serviceResponse.RowSet.Rows[0].Actual.Value);
            informationLeft.Add("Satisfaction with Training - benchmark", (float)serviceResponse.RowSet.Rows[0].Benchmark.Value);
            //change
            serviceResponse = serviceRequest.IndexMetricsTrainingEffectivenessScore("All countries", "Value", "", "USD", "Scofield Financial", "All Workforce Categories"
            , "2013 Q4", "Satisfaction with Training Change", out outa);
            informationLeft.Add("Satisfaction with Training - change", (float)serviceResponse.RowSet.Rows[0].Actual.Value);

            
           
            
            //Here comes history, information on the right side of page, collected in dictionary "informationRight"
            Dictionary<string, float> informationRight = new Dictionary<string, float>();
            com.solveworkforce.quintiles.dev.IndexMetricsTrainingEffectivenessIndexHistoricalResults history =
                           serviceRequest.IndexMetricsTrainingEffectivenessIndexHistorical("All countries", "Value", "", "USD", "Scofield Financial", "All Workforce Categories"
                           , "", "Training Effectiveness Index", out outa);

            informationRight.Add("Q1-12", (float)history.RowSet.Rows[0].Col1.Value);
            informationRight.Add("Q2-12", (float)history.RowSet.Rows[0].Col2.Value);
            informationRight.Add("Q3-12", (float)history.RowSet.Rows[0].Col3.Value);
            informationRight.Add("Q4-12", (float)history.RowSet.Rows[0].Col4.Value);
            informationRight.Add("Q1-13", (float)history.RowSet.Rows[0].Col5.Value);
            informationRight.Add("Q2-13", (float)history.RowSet.Rows[0].Col6.Value);
            informationRight.Add("Q3-13", (float)history.RowSet.Rows[0].Col7.Value);
            informationRight.Add("Q4-13", (float)history.RowSet.Rows[0].Col8.Value);
            informationRight.Add("Q1-14", (float)history.RowSet.Rows[0].Col9.Value);
            informationRight.Add("Q2-14", (float)history.RowSet.Rows[0].Col10.Value);
            informationRight.Add("Q3-14", (float)history.RowSet.Rows[0].Col11.Value);
           



            return View();
        }

    }
}
