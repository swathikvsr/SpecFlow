using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowTest
{
   [Binding]
   public class CalculatorSteps
   {
      private int result { get; set; }
      private Calculator calculator = new Calculator();

      [Given(@"I have entered (.*) into the calculator")]
      public void GivenIHaveEnteredIntoTheCalculator(int number)
      {
         calculator.FirstNumber = number;
      }

      [Given(@"I have also entered (.*) into the calculator")]
      public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
      {
         calculator.SecondNumber = number;
      }

      [When(@"I press add")]
      public void WhenIPressAdd()
      {
         result = calculator.Add();
      }

      [When(@"I press sub")]
      public void WhenIPressSub()
      {
         result = calculator.Sub();
      }


      [Then(@"the result should be (.*) on the screen")]
      public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
      {
         Assert.AreEqual(expectedResult, result);
      }
   }
}
