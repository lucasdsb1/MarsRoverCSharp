using System;
using MarsRoverOFC.Models;
using MarsRoverOFC.Services;
using MarsRoverOFC.Services.Interfaces;
using TechTalk.SpecFlow;

namespace MarsRoverOFC.Specs.StepDefinitions
{
    [Binding]
    public class PlatorStepDefinitions
    {
        private readonly PlatorService _platorService = new();
        private dynamic _result;
        private string _input;

        [Given(@"i have entered ""([^""]*)"" into the input line on console")]
        public void GivenIHaveEnteredIntoTheInputLineOnConsole(string p0)
        {
            _input = p0;
        }

        [When(@"i press enter the result is processed")]
        public void WhenIPressEnterTheResultIsProcessed()
        {
            try
            {
                _result = _platorService.ConverterParaPlator(_input);
            }
            catch (Exception ex)
            {
                _result = ex;
            }
        }

        [Then(@"the result should be Plator \{ X = (.*), Y = (.*) }")]
        public void ThenTheResultShouldBe(int p0, int p1)
        {
            var plator = (Plator) _result;
            plator.Should().BeEquivalentTo(new Plator(p0, p1));
        }

        [Then(@"the result should be ""([^""]*)""")]
        public void ThenTheResultShouldBe(string p0)
        {
            var ex = (Exception) _result;
            Assert.Equal(ex.Message, p0);
        }
    }
}
