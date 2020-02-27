namespace MyThesis_Login_And_Registration
{
    class AppCache
    {
        public static string API { get; } = @"trnsl.1.1.20190620T162620Z.12aa50a722db8074.f235b6e205ea648f15758665be633f648abea34b";
        public static string UrlGetAvailableLanguages { get; } = @"https://translate.yandex.net/api/v1.5/tr.json/getLangs?key={0}&ui={1}";
        public static string UrlDetectSrcLanguage { get; } = @"https://translate.yandex.net/api/v1.5/tr.json/detect?key={0}&text={1}";
        public static string UrlTranslateLanguage { get; } = @"https://translate.yandex.net/api/v1.5/tr.json/translate?key={0}&text={1}&lang={2}";
    }
}
