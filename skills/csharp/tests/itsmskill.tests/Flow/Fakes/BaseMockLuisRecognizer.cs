// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ITSMSkill.Tests.Flow.Utterances;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.AI.Luis;
using Microsoft.Bot.Builder.Dialogs;

namespace ITSMSkill.Tests.Flow.Fakes
{
    public class BaseMockLuisRecognizer<TConvert> : ITelemetryRecognizer
    {
        private readonly BaseTestUtterances<TConvert> utterancesManager;

        public BaseMockLuisRecognizer(params BaseTestUtterances<TConvert>[] utterancesManagers)
        {
            utterancesManager = utterancesManagers[0];

            for (int i = 1; i < utterancesManagers.Length; ++i)
            {
                foreach (var pair in utterancesManagers[i])
                {
                    if (!utterancesManager.TryAdd(pair.Key, pair.Value))
                    {
                        throw new Exception($"Key:{pair.Key} already exists!");
                    }
                }
            }
        }

        public bool LogPersonalInformation { get; set; } = false;

        public IBotTelemetryClient TelemetryClient { get; set; } = new NullBotTelemetryClient();

        public Task<RecognizerResult> RecognizeAsync(ITurnContext turnContext, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<T> RecognizeAsync<T>(ITurnContext turnContext, CancellationToken cancellationToken)
    where T : IRecognizerConvert, new()
        {
            var text = turnContext.Activity.Text;
            var mockResult = (T)(utterancesManager.GetValueOrDefault(text, utterancesManager.NoneIntent) as object);
            return Task.FromResult(mockResult);
        }

        public Task<T> RecognizeAsync<T>(DialogContext dialogContext, CancellationToken cancellationToken = default(CancellationToken))
    where T : IRecognizerConvert, new()
        {
            throw new NotImplementedException();
        }

        public Task<RecognizerResult> RecognizeAsync(ITurnContext turnContext, Dictionary<string, string> telemetryProperties, Dictionary<string, double> telemetryMetrics, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public Task<T> RecognizeAsync<T>(ITurnContext turnContext, Dictionary<string, string> telemetryProperties, Dictionary<string, double> telemetryMetrics, CancellationToken cancellationToken = default(CancellationToken))
            where T : IRecognizerConvert, new()
        {
            throw new NotImplementedException();
        }
    }
}
