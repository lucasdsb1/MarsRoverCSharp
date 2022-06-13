using System;
using MarsRoverOFC.Models;
using MarsRoverOFC.Services;
using MarsRoverOFC.Services.Interfaces;
using TechTalk.SpecFlow;

namespace MarsRoverOFC.Specs.StepDefinitions
{
    [Binding]
    public class PlateauStepDefinitions
    {
        private readonly PlatorService _platorService = new();
        private Plator _result;

        [Given(@"i have entered ""([^""]*)"" into the input line on console")]
        public void GivenIHaveEnteredIntoTheInputLineOnConsole(string p0)
        {
            var coordenadas = p0.Split(" ");

            Assert.Equal(2, coordenadas.Length);
            Assert.True((int.TryParse(coordenadas[0], out var x)));
            Assert.True((int.TryParse(coordenadas[1], out var y)));
            Assert.False(x < 0);
            Assert.False(y < 0);
        }

        [When(@"i press enter the result is processed")]
        public void WhenIPressEnterTheResultIsProcessed()
        {
            _result = _platorService.ConverterParaPlator("5 5");
        }

        [Then(@"the result should be Plator \{ X = (.*), Y = (.*) }")]
        public void ThenTheResultShouldBe(int p0, int p1)
        {
            _result.Should().BeEquivalentTo(new Plator(p0, p1));
        }

    }
}
