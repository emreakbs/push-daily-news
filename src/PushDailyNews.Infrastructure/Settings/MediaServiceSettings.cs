using PushDailyNews.Infrastructure.Exception;

namespace PushDailyNews.Infrastructure.Settings
{
    public class MediaServiceSettings: IApiSetting
    {
        public string Url { get; set; }
        public ApiMethod GetRss { get; set; }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Url))
                throw new SettingsValidationException("MediaServiceSettings", "Url", "Empty");

            if (string.IsNullOrWhiteSpace(Url))
                throw new SettingsValidationException("MediaServiceSettings", "RSS.Path", "Empty");
        }
    }
}
