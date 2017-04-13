﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GameCore.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PlayerCharacterFeature : Xunit.IClassFixture<PlayerCharacterFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PlayerCharacter.feature"
#line hidden
        
        public PlayerCharacterFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PlayerCharacter", "\tIn order to play the game\r\n\tAs a human player\r\n\tI want my character attributes t" +
                    "o be correctly represented", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line 7
 testRunner.Given("I am a new player", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        public virtual void SetFixture(PlayerCharacterFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.TheoryAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Health Reduction")]
        [Xunit.TraitAttribute("Category", "PlayerHealth")]
        [Xunit.InlineDataAttribute("0", "100", new string[0])]
        [Xunit.InlineDataAttribute("10", "90", new string[0])]
        public virtual void HealthReduction(string damage, string health, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "PlayerHealth"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Health Reduction", @__tags);
#line 11
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 12
 testRunner.When(string.Format("I take {0} damage", damage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then(string.Format("My health should be {0}", health), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Taking too much damage results in player\'s death")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Taking too much damage results in player\'s death")]
        [Xunit.TraitAttribute("Category", "PlayerHealth")]
        public virtual void TakingTooMuchDamageResultsInPlayerSDeath()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Taking too much damage results in player\'s death", new string[] {
                        "PlayerHealth"});
#line 20
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 21
 testRunner.When("I take 10 damage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
  testRunner.And("I take 90 damage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.Then("My health should be 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.And("I should be dead", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Impact of Initial resistance and race on health")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Impact of Initial resistance and race on health")]
        [Xunit.TraitAttribute("Category", "Elf")]
        public virtual void ImpactOfInitialResistanceAndRaceOnHealth()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Impact of Initial resistance and race on health", new string[] {
                        "Elf"});
#line 27
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 28
  testRunner.And("I have an initial resistace of 10", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
  testRunner.And("I am of Race  Elf", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.When("I take 40 damage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.Then("My health should be 90", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Impact of Initial resistance and race on health using data table")]
        [Xunit.TraitAttribute("Category", "Elf")]
        [Xunit.InlineDataAttribute("40", "90", new string[0])]
        [Xunit.InlineDataAttribute("10", "100", new string[0])]
        public virtual void ImpactOfInitialResistanceAndRaceOnHealthUsingDataTable(string damage, string health, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Elf"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Impact of Initial resistance and race on health using data table", @__tags);
#line 34
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "attribute",
                        "value"});
            table1.AddRow(new string[] {
                        "resistance",
                        "10"});
            table1.AddRow(new string[] {
                        "race",
                        "Elf"});
#line 35
  testRunner.And("I have following attributes", ((string)(null)), table1, "And ");
#line 39
 testRunner.When(string.Format("I take {0} damage", damage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.Then(string.Format("My health should be {0}", health), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Impact of sleep on health")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Impact of sleep on health")]
        [Xunit.TraitAttribute("Category", "PlayerHealth")]
        [Xunit.TraitAttribute("Category", "LastSlept")]
        public virtual void ImpactOfSleepOnHealth()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Impact of sleep on health", new string[] {
                        "PlayerHealth",
                        "LastSlept"});
#line 48
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 49
 testRunner.Given("I last slept 3 days ago", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
 testRunner.When("I take 1 damage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.Then("My health should be 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Total value of Weapons")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Total value of Weapons")]
        public virtual void TotalValueOfWeapons()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Total value of Weapons", ((string[])(null)));
#line 54
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Value"});
            table2.AddRow(new string[] {
                        "Sword",
                        "50"});
            table2.AddRow(new string[] {
                        "Hammer",
                        "60"});
            table2.AddRow(new string[] {
                        "Gun",
                        "100"});
#line 55
 testRunner.Given("I have following weapons", ((string)(null)), table2, "Given ");
#line 60
 testRunner.Then("Total value of weapons should be 210", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Initial Health value")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Initial Health value")]
        public virtual void InitialHealthValue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Initial Health value", ((string[])(null)));
#line 62
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 63
 testRunner.Given("My current health is 50", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 64
 testRunner.When("I take 20 damage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
  testRunner.Then("My health should be 30", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Take damage for elves")]
        [Xunit.TraitAttribute("FeatureTitle", "PlayerCharacter")]
        [Xunit.TraitAttribute("Description", "Take damage for elves")]
        [Xunit.TraitAttribute("Category", "Elf")]
        public virtual void TakeDamageForElves()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Take damage for elves", new string[] {
                        "Elf"});
#line 68
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 69
 testRunner.When("I take 20 damage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 70
 testRunner.Then("My health should be 80", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PlayerCharacterFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PlayerCharacterFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
