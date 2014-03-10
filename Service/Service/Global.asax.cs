using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Service {
    public class Global : System.Web.HttpApplication {


        private static Random randomGenerator = null;
        public static Random RandomGenerator {
            get {
                if (randomGenerator == null) {
                    randomGenerator = new Random();

                }
                return randomGenerator;
            }
        }

        protected void Application_Start(object sender, EventArgs e) {

        }

        protected void Session_Start(object sender, EventArgs e) {

        }

        protected void Application_BeginRequest(object sender, EventArgs e) {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e) {

        }

        protected void Application_Error(object sender, EventArgs e) {

        }

        protected void Session_End(object sender, EventArgs e) {

        }

        protected void Application_End(object sender, EventArgs e) {

        }
    }
}