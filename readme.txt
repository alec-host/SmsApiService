Assumption made (1-5)

1. Send sms command payload is a json string with attribute : phoneNumber and smsText i.e.

   {'phoneNumber':'254721110000','smsText': 'test message'}

2. 3rd-party implementation will handle other sms configuration params, the application will only handle a phoneNumber and textSms.
3. Only one text message will be pushed out at a time rather than a batch.
4. Both subscriber & publisher implementation will not be handled at the shared code snippet.
5. The sms wrapper attempts to send an sms once, hence no mechanism has been provided to attempt a re-send.


Further the excercise has been published on my github account & CI for the same setup on circleCI.

The console application runs in the main method. Get a clone of the project from github & import the same on visual studio.
Then run the project.

No completed: 
The logger interface has been developed but the implementation of the same is not done.
Not all test cases has been covered.

Structure

The application as been structured as follows:

1. Application listens to SmSCommand & consumes the same through subscriber method (not covered in this scope).

2. A message is originated to a receipient via async http api call to sms providers (implementation sms service not covered in this scope).

3. Sms server responses (delivery status receipts) are logged & published to an MQ queue for processing.

4. 