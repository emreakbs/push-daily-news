using System;
using System.Runtime.Serialization;
namespace PushDailyNews.Infrastructure.Exception
{
    [Serializable]
    public class SettingsValidationException : Exception
    {
        public SettingsValidationException(string v1, string v2, string v3)
        {
        }
        public SettingsValidationException(SerializationInfo serializationInfo, StreamingContext context) : base(serializationInfo, context)
        {
        }
        public SettingsValidationException(string message) : base(message)
        {
        }
        public SettingsValidationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
