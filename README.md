# Rest helper for Sinch verification API
Full documenation for the rest apis can be found here
https://www.sinch.com/docs/verification/rest/

It only supports SMS wich is really the only mehtod you should use serverside at the moment. 

Click here for more [Verifiation Tutorials](https://www.sinch.com/tutorials/?tags%5B%5D=verification&utm_source=sinch&utm_medium=xlink&utm_campaign=verifyall)


**Installation**

```ruby
pm> install-package Sinch.Verification
```

**Usage**

```csharp
public async Task<VerificationResponse> StartVerification()
{
using (var client = new Sinch.Verification.Client(appkey, appsecret))
  {
    return await client.StartSMSVerification("+15612600684");
  }
}

public async Task<VerificationResponse> VerifyCode(string number, string code)
{
  using (var client = new Sinch.Verification.Client(appkey, appsecret))
  {
    return await client.VerifySMSCode(number, code)
  }
}
```
