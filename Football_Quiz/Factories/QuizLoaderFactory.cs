using Football_Quiz.Interfaces;
using System;
using System.Configuration;

namespace Football_Quiz.Factories
{
    public static class QuizLoaderFactory
    {
        public static IQuizLoader CreateLoader()
        {
            string loaderTypeName = ConfigurationManager.AppSettings["QuizLoaderType"];
            if (string.IsNullOrWhiteSpace(loaderTypeName))
                throw new InvalidOperationException("Missing configuration: QuizLoaderType");

            Type loaderType = Type.GetType(loaderTypeName);
            if (loaderType == null)
                throw new InvalidOperationException($"Unknown type: {loaderTypeName}");

            object instance = Activator.CreateInstance(loaderType);
            if (instance is IQuizLoader quizLoader)
                return quizLoader;

            throw new InvalidCastException($"{loaderTypeName} does not implement IQuizLoader");
        }
    }
}
