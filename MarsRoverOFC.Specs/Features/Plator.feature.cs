﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MarsRoverOFC.Specs.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PlateauFeature : object, Xunit.IClassFixture<PlateauFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Plator.feature"
#line hidden
        
        public PlateauFeature(PlateauFeature.FixtureData fixtureData, MarsRoverOFC_Specs_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Plateau", "Valida a criação de um plator.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create a valid plateau")]
        [Xunit.TraitAttribute("FeatureTitle", "Plateau")]
        [Xunit.TraitAttribute("Description", "Create a valid plateau")]
        [Xunit.TraitAttribute("Category", "plator")]
        public virtual void CreateAValidPlateau()
        {
            string[] tagsOfScenario = new string[] {
                    "plator"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a valid plateau", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
 testRunner.Given("i have entered \"5 5\" into the input line on console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.When("i press enter the result is processed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.Then("the result should be Plator { X = 5, Y = 5 }", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create a valid plateau 1")]
        [Xunit.TraitAttribute("FeatureTitle", "Plateau")]
        [Xunit.TraitAttribute("Description", "Create a valid plateau 1")]
        [Xunit.TraitAttribute("Category", "plator")]
        public virtual void CreateAValidPlateau1()
        {
            string[] tagsOfScenario = new string[] {
                    "plator"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a valid plateau 1", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 12
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 13
 testRunner.Given("i have entered \"0 0\" into the input line on console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 14
 testRunner.When("i press enter the result is processed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.Then("the result should be Plator { X = 0, Y = 0 }", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create a invalid plateau 1")]
        [Xunit.TraitAttribute("FeatureTitle", "Plateau")]
        [Xunit.TraitAttribute("Description", "Create a invalid plateau 1")]
        [Xunit.TraitAttribute("Category", "plator")]
        public virtual void CreateAInvalidPlateau1()
        {
            string[] tagsOfScenario = new string[] {
                    "plator"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a invalid plateau 1", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 18
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 19
 testRunner.Given("i have entered \"5 5 \" into the input line on console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 20
 testRunner.When("i press enter the result is processed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.Then("the result should be \"Não foi possível criar o Plator!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create a invalid plateau 2")]
        [Xunit.TraitAttribute("FeatureTitle", "Plateau")]
        [Xunit.TraitAttribute("Description", "Create a invalid plateau 2")]
        [Xunit.TraitAttribute("Category", "plator")]
        public virtual void CreateAInvalidPlateau2()
        {
            string[] tagsOfScenario = new string[] {
                    "plator"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a invalid plateau 2", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 24
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 25
 testRunner.Given("i have entered \" 5 5 \" into the input line on console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 26
 testRunner.When("i press enter the result is processed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.Then("the result should be \"Não foi possível criar o Plator!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create a invalid plateau 3")]
        [Xunit.TraitAttribute("FeatureTitle", "Plateau")]
        [Xunit.TraitAttribute("Description", "Create a invalid plateau 3")]
        [Xunit.TraitAttribute("Category", "plator")]
        public virtual void CreateAInvalidPlateau3()
        {
            string[] tagsOfScenario = new string[] {
                    "plator"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a invalid plateau 3", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 30
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 31
 testRunner.Given("i have entered \" 5 5\" into the input line on console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 32
 testRunner.When("i press enter the result is processed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.Then("the result should be \"Não foi possível criar o Plator!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create a invalid plateau 4")]
        [Xunit.TraitAttribute("FeatureTitle", "Plateau")]
        [Xunit.TraitAttribute("Description", "Create a invalid plateau 4")]
        [Xunit.TraitAttribute("Category", "plator")]
        public virtual void CreateAInvalidPlateau4()
        {
            string[] tagsOfScenario = new string[] {
                    "plator"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a invalid plateau 4", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 36
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 37
 testRunner.Given("i have entered \"5\" into the input line on console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 38
 testRunner.When("i press enter the result is processed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 39
 testRunner.Then("the result should be \"Não foi possível criar o Plator!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create a invalid plateau 5")]
        [Xunit.TraitAttribute("FeatureTitle", "Plateau")]
        [Xunit.TraitAttribute("Description", "Create a invalid plateau 5")]
        [Xunit.TraitAttribute("Category", "plator")]
        public virtual void CreateAInvalidPlateau5()
        {
            string[] tagsOfScenario = new string[] {
                    "plator"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a invalid plateau 5", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 42
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 43
 testRunner.Given("i have entered \"A B\" into the input line on console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 44
 testRunner.When("i press enter the result is processed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 45
 testRunner.Then("the result should be \"Não foi possível criar o Plator!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create a invalid plateau 6")]
        [Xunit.TraitAttribute("FeatureTitle", "Plateau")]
        [Xunit.TraitAttribute("Description", "Create a invalid plateau 6")]
        [Xunit.TraitAttribute("Category", "plator")]
        public virtual void CreateAInvalidPlateau6()
        {
            string[] tagsOfScenario = new string[] {
                    "plator"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a invalid plateau 6", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 48
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 49
 testRunner.Given("i have entered \"A 5\" into the input line on console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 50
 testRunner.When("i press enter the result is processed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 51
 testRunner.Then("the result should be \"Não foi possível criar o Plator!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create a invalid plateau 7")]
        [Xunit.TraitAttribute("FeatureTitle", "Plateau")]
        [Xunit.TraitAttribute("Description", "Create a invalid plateau 7")]
        [Xunit.TraitAttribute("Category", "plator")]
        public virtual void CreateAInvalidPlateau7()
        {
            string[] tagsOfScenario = new string[] {
                    "plator"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a invalid plateau 7", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 54
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 55
 testRunner.Given("i have entered \"5 B\" into the input line on console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 56
 testRunner.When("i press enter the result is processed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 57
 testRunner.Then("the result should be \"Não foi possível criar o Plator!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create a invalid plateau 8")]
        [Xunit.TraitAttribute("FeatureTitle", "Plateau")]
        [Xunit.TraitAttribute("Description", "Create a invalid plateau 8")]
        [Xunit.TraitAttribute("Category", "plator")]
        public virtual void CreateAInvalidPlateau8()
        {
            string[] tagsOfScenario = new string[] {
                    "plator"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a invalid plateau 8", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 60
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 61
 testRunner.Given("i have entered \"\" into the input line on console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 62
 testRunner.When("i press enter the result is processed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 63
 testRunner.Then("the result should be \"Não foi possível criar o Plator!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create a invalid plateau 9")]
        [Xunit.TraitAttribute("FeatureTitle", "Plateau")]
        [Xunit.TraitAttribute("Description", "Create a invalid plateau 9")]
        [Xunit.TraitAttribute("Category", "plator")]
        public virtual void CreateAInvalidPlateau9()
        {
            string[] tagsOfScenario = new string[] {
                    "plator"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a invalid plateau 9", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 66
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 67
 testRunner.Given("i have entered \" \" into the input line on console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 68
 testRunner.When("i press enter the result is processed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
 testRunner.Then("the result should be \"Não foi possível criar o Plator!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create a invalid plateau 10")]
        [Xunit.TraitAttribute("FeatureTitle", "Plateau")]
        [Xunit.TraitAttribute("Description", "Create a invalid plateau 10")]
        [Xunit.TraitAttribute("Category", "plator")]
        public virtual void CreateAInvalidPlateau10()
        {
            string[] tagsOfScenario = new string[] {
                    "plator"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a invalid plateau 10", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 72
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 73
 testRunner.Given("i have entered \"-1 0\" into the input line on console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 74
 testRunner.When("i press enter the result is processed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 75
 testRunner.Then("the result should be \"Não foi possível criar o Plator!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create a invalid plateau 11")]
        [Xunit.TraitAttribute("FeatureTitle", "Plateau")]
        [Xunit.TraitAttribute("Description", "Create a invalid plateau 11")]
        [Xunit.TraitAttribute("Category", "plator")]
        public virtual void CreateAInvalidPlateau11()
        {
            string[] tagsOfScenario = new string[] {
                    "plator"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a invalid plateau 11", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 78
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 79
 testRunner.Given("i have entered \"-1 -1\" into the input line on console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 80
 testRunner.When("i press enter the result is processed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 81
 testRunner.Then("the result should be \"Não foi possível criar o Plator!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Create a invalid plateau 12")]
        [Xunit.TraitAttribute("FeatureTitle", "Plateau")]
        [Xunit.TraitAttribute("Description", "Create a invalid plateau 12")]
        [Xunit.TraitAttribute("Category", "plator")]
        public virtual void CreateAInvalidPlateau12()
        {
            string[] tagsOfScenario = new string[] {
                    "plator"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a invalid plateau 12", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 84
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 85
 testRunner.Given("i have entered \"0 -1\" into the input line on console", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 86
 testRunner.When("i press enter the result is processed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 87
 testRunner.Then("the result should be \"Não foi possível criar o Plator!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PlateauFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PlateauFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
