namespace Your.App;

internal static class CredentialStorage {
    private const string TokenAlias = "access_token";
    private static string AppleFix { get; set; }
    public async static void WriteToken(string token) {
#if __IOS__
        AppleFix = token;
        return;
#endif
        await SecureStorage.Default.SetAsync(TokenAlias, token);
    }
    public static void ClearToken() {
        SecureStorage.Default.Remove(TokenAlias);
    }
    public static string ReadToken() {
#if __IOS__
        return AppleFix;
#endif
        var task = SecureStorage.Default.GetAsync(TokenAlias);
        task.Wait();
        return task.Result;
    }
}