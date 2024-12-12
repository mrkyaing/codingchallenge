// Creating Instance of Publishers
using EDA.Practice;

Publisher youtube = new Publisher("https://www.youtube.com/@prodevmm", 2000);
Publisher devToBlog = new Publisher("https://dev.to/absjabed", 1000);

//Create Instances of Subscribers
Subscriber sub1 = new Subscriber("MG");
Subscriber sub2 = new Subscriber("ZARNI");
Subscriber sub3 = new Subscriber("JAMES");

//Pass the publisher obj to their Subscribe function
sub1.Subscribe(devToBlog); //sub1 subscribes to devToBlog publisher
//sub3.Subscribe(devToBlog);

//sub1.Subscribe(youtube);
//sub2.Subscribe(youtube);

sub1.Unsubscribe(devToBlog);


// Concurrently running multiple publishers thread for mocking continious notification update firing.
Task task1 = Task.Factory.StartNew(() => youtube.Publish());
Task task2 = Task.Factory.StartNew(() => devToBlog.Publish());
Task.WaitAll(task1, task2);
