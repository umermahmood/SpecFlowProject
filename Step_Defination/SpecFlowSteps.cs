using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProject
{
    [Binding]
    class SpecFlowSteps
    {

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int Numbers)
        {
            Console.WriteLine(Numbers);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Then Press Add");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            if (result == 120)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
                throw new Exception("The value is different");
            }

        }

    }
}
