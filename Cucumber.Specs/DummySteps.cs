using TechTalk.SpecFlow;
using Xunit;

[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace Cucumber.Specs {
    [Binding]
    public class DummySteps {
        int firstValue = 0;
        int secondValue = 0;

        [Given(@"a value of (.*)")]
        public void GivenAValue(int firstValue)
        {
            this.firstValue = firstValue;
        }

        [When(@"comparing it to (.*)")]
        public void WhenComparingTo(int secondValue)
        {
            this.secondValue = secondValue;
        }

        [Then(@"the values should be equal")]
        public void ValuesShouldBeEqual() {
            Assert.True(this.firstValue == this.secondValue);
        }
    }
}
