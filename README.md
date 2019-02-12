# DataAnnotionTests
Demonstrate dataAnnotations:dataTypeAttribute:disableRegEx change

With .Net Framework 4.7.2 the default for app setting `dataAnnotations:dataTypeAttribute:disableRegEx` changed to `true`, which enforces users of `EmailAddressAttribute`, `UrlAttribute` and `PhoneAttribute` to mitigate the less accurate validation without the previously used regular expressions.

With .Net Core the possibilty to change the behaviour with an app setting was removed at all.

See https://docs.microsoft.com/en-us/dotnet/framework/migration-guide/runtime/4.7.1-4.7.2 and https://github.com/dotnet/dotnet-api-docs/issues/1201 for reference.
