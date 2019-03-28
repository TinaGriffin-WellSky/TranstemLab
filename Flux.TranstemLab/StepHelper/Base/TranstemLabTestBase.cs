using Flux.Core;
using TechTalk.SpecFlow;
using Flux.Web;
using System;

namespace Flux.TranstemLab.StepHelper.Base
{
    [Binding]
    public class TranstemLabTestBase : BddTestBase
    {
        [BeforeFeature]
        public static void TranstemLabTimeSetup()
        {
            string browserName = string.Empty;
            try
            {
                browserName = WebEnvironment.AppSettings["BrowserType"].ToLower();
                bddHooks.Environment.InitializeDriver(browserName);
            }
            catch (Exception e)
            {
                CustomExceptionHandler.CustomException(e, "Error occurred while trying to launch '" + browserName + "'.");
            }
        }
    }
}

