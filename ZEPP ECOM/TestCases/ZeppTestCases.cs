using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZEPP_ECOM.PageClasses;

namespace ZEPP_ECOM.TestCases
{
    public class ZeppTestCases : BaseClass
    {
        [Test]
        public void OpenMobileNumber()
        {
            ZeppPages zeppTestCases = new ZeppPages(driver);
            zeppTestCases.VerifyingOtp();
        }
        [Test]
        public void OpenEmail()
        {
            ZeppPages zeppTestCases = new ZeppPages(driver);
            zeppTestCases.EnterEmail();


        }
    }
}
