﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace GittiGidiyorTestProject.Feature
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("GittiGidiyorFeature")]
    public partial class GittiGidiyorFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GittiGidiyorFeature.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "GittiGidiyorFeature", "\tIn order to avoid silly mistakes\r\n\tAs a math idiot\r\n\tI want to be told the sum o" +
                    "f two numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("GittiGidiyorTest")]
        [NUnit.Framework.CategoryAttribute("gittigidiyor")]
        public virtual void GittiGidiyorTest()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GittiGidiyorTest", null, new string[] {
                        "gittigidiyor"});
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
testRunner.And("GittiGidiyor.com açılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 9
testRunner.And("Login yapılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 10
testRunner.And("Kullanıcı adı \'username\' girilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 11
testRunner.And("Şifre adı \'password\' girilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 12
testRunner.And("Giriş yapılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 13
testRunner.And("Bebek,Anne kategorisinin üzerine gelinir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 14
testRunner.And("Biberon Maması linkine tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 15
testRunner.And("Fiyat aralığı seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 16
testRunner.And("Ücretsiz Kargo seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 17
testRunner.And("ikinci ürün seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 18
testRunner.And("Sepete eklenir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 19
testRunner.And("Alışveriş tamamlaya tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 20
testRunner.And("Ad \'Merve\' yazılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 21
testRunner.And("Soyad \'Kurun\' yazılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 22
testRunner.And("Şehir \'İstanbul\' seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 23
testRunner.And("İlçe \'Kağıthane\' seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 24
testRunner.And("Adres \'İstanbul-Kağıthane\' girilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 25
testRunner.And("Telefon Numarası \'1234567\' girilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 26
testRunner.And("Kaydet ve Devam Et tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 27
testRunner.And("Devam Et butonuna tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 28
testRunner.And("Kredi Kartı numarası \'1234567890122345\' girilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 29
testRunner.And("Ad Soyad \'Merve Kurun\' girilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 30
testRunner.And("Son Kullanma ayı \'01\' yılı \'2020\' girilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 31
testRunner.And("Güvenlik Kodu \'123\' girilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 32
testRunner.And("Ödeme Yap tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("GittiGidiyorTestWithAdress")]
        [NUnit.Framework.CategoryAttribute("gittigidiyorWithAddAddress")]
        public virtual void GittiGidiyorTestWithAdress()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GittiGidiyorTestWithAdress", null, new string[] {
                        "gittigidiyorWithAddAddress"});
#line 35
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 36
testRunner.And("GittiGidiyor.com açılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 37
testRunner.And("Login yapılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 38
testRunner.And("Kullanıcı adı \'username\' girilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 39
testRunner.And("Şifre adı \'password\' girilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 40
testRunner.And("Giriş yapılır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 41
testRunner.And("Bebek,Anne kategorisinin üzerine gelinir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 42
testRunner.And("Biberon Maması linkine tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 43
testRunner.And("Fiyat aralığı seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 44
testRunner.And("Ücretsiz Kargo seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 45
testRunner.And("ikinci ürün seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 46
testRunner.And("Sepete eklenir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 47
testRunner.And("Alışveriş tamamlaya tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 48
testRunner.And("Adres seçilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 49
testRunner.And("Devam Et butonuna tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 50
testRunner.And("Kredi Kartı numarası \'1234567890122345\' girilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 51
testRunner.And("Ad Soyad \'Merve Kurun\' girilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 52
testRunner.And("Son Kullanma ayı \'01\' yılı \'2020\' girilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 53
testRunner.And("Güvenlik Kodu \'123\' girilir", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line 54
testRunner.And("Ödeme Yap tıklanır", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

