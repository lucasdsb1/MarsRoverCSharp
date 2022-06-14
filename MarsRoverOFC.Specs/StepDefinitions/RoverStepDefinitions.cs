using System;
using MarsRoverOFC.Models;
using MarsRoverOFC.Services;
using TechTalk.SpecFlow;

namespace MarsRoverOFC.Specs.StepDefinitions
{
    [Binding]
    [Scope(Tag = "rover")]
    public class RoverStepDefinitions
    {
        private readonly RoverService _roverService = new();
        private char _result;
        private Rover rover;
        
        [Given(@"direction is ""([^""]*)""")]
        public void GivenDirectionIs(string p0)
        {
            rover = new Rover(
                new Plator(5, 5),
                new Posicao(0, 0, char.Parse(p0)),
                new List<char>() { }
            );
        }


        [When(@"i turn ""([^""]*)""")]
        public void WhenITurn(string p0)
        {
            rover.Movimentos = new List<char>() { char.Parse(p0) };
            _result = _roverService.ExecutarMovimentos(rover).Posicao.Direcao;
        }

        [Then(@"the result should be ""([^""]*)""")]
        public void ThenTheResultShouldBe(string p0)
        {
            Assert.Equal(_result, char.Parse(p0));
        }
    }
}
