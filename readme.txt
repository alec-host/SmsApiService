Assumption made (1-4)

1. Send sms command payload is a json string with attribute : phoneNumber and smsText i.e.

   {'phoneNumber':'254721110000','smsText': 'test message'}

2. 3rd-party implementation will handle other sms configuration params, the application will only handle a phoneNumber and textSms.
3. Only one text message will be pushed out at a time rather than a batch.
4. Both subscriber & publisher implementation will not be handled at the shared code snippet.


Further the excercise has been published on my github account & CI for the same setup on circleCI.

The console application runs in the main method. 
