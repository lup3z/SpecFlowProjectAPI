﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowProjectAPI.Features
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Enviar y recibir mensajes en RabbitMQ")]
    public partial class EnviarYRecibirMensajesEnRabbitMQFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "demoRabbitMQ.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureSetupAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly();
            global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Enviar y recibir mensajes en RabbitMQ", null, global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
            await testRunner.OnFeatureStartAsync(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
            await testRunner.OnFeatureEndAsync();
            global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verificar que el mensaje Json se envía correctamente")]
        [NUnit.Framework.CategoryAttribute("rabbitmq")]
        public async System.Threading.Tasks.Task VerificarQueElMensajeJsonSeEnviaCorrectamente()
        {
            string[] tagsOfScenario = new string[] {
                    "rabbitmq"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verificar que el mensaje Json se envía correctamente", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 5
    await testRunner.GivenAsync("un contenedor RabbitMQ está en funcionamiento", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 6
    await testRunner.WhenAsync("envío un mensaje \"{\"type\": \"simple\", \"content\": \"Hello, World\"}\" a la cola", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 7
    await testRunner.ThenAsync("el mensaje \"{\"type\": \"simple\", \"content\": \"Hello, World\"}\" debería ser recibido c" +
                        "orrectamente", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verificar que el mensaje Json + objeto se envía correctamente")]
        [NUnit.Framework.CategoryAttribute("rabbitmq")]
        public async System.Threading.Tasks.Task VerificarQueElMensajeJsonObjetoSeEnviaCorrectamente()
        {
            string[] tagsOfScenario = new string[] {
                    "rabbitmq"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verificar que el mensaje Json + objeto se envía correctamente", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 10
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 11
    await testRunner.GivenAsync("un contenedor RabbitMQ está en funcionamiento", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 12
    await testRunner.WhenAsync("envío un mensaje \"{\"type\": \"complex\", \"content\": {\"text\": \"Hello\", \"number\": 123}" +
                        "}\" a la cola", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 13
    await testRunner.ThenAsync("el mensaje \"{\"type\": \"complex\", \"content\": {\"text\": \"Hello\", \"number\": 123}}\" deb" +
                        "ería ser recibido correctamente", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verificar que el mensaje Json + Array se envía correctamente")]
        [NUnit.Framework.CategoryAttribute("rabbitmq")]
        public async System.Threading.Tasks.Task VerificarQueElMensajeJsonArraySeEnviaCorrectamente()
        {
            string[] tagsOfScenario = new string[] {
                    "rabbitmq"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verificar que el mensaje Json + Array se envía correctamente", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 16
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 17
    await testRunner.GivenAsync("un contenedor RabbitMQ está en funcionamiento", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 18
    await testRunner.WhenAsync("envío un mensaje \"{\"type\": \"list\", \"content\": [\"item1\", \"item2\", \"item3\"]}\" a la " +
                        "cola", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 19
    await testRunner.ThenAsync("el mensaje \"{\"type\": \"list\", \"content\": [\"item1\", \"item2\", \"item3\"]}\" debería ser" +
                        " recibido correctamente", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
