Assumption made (1-5)
=============
1. Send sms command payload is a json string with attribute : phoneNumber and smsText i.e.

   {'phoneNumber':'254721110000','smsText': 'test message'}

2. 3rd-party implementation will handle the major sms configuration params,  only phoneNumber and textSms params are handled in the application .
3. A single text message will be pushed out at a time rather than a batch.
4. Both subscriber & publisher implementation will not be handled on the shared code snippet.
5. The sms wrapper to the api does not provide a mechanism to re-send a failed message.

Additionally, the excercise has been published on github account & CI/CD setup on a free circleCI account. The console application runs in the main method. To run the application get a clone of the project from github & import the same on visual studio (I am using visual studio 2019).
Then run the project from visual studio.

No completed:
=============
The logger interface has been developed but the implementation of the same is not complete.
I have not fully covered all the test cases.

Structure

The application as been structured as follows:

1. Application listens to SmSCommand & consumes the said requests through a subscriber method (not covered in this scope).

2. A message is originated to a receipient via async http api call to the 3rd-party sms provider (implementation sms service not covered in this scope).

3. Server responses (delivery status receipts) are logged & published to an MQ queue for immediate processing.

4. 