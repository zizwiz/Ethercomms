# Ethercomms
[![Open Source Love](https://badges.frapsoft.com/os/v1/open-source.svg?v=103)](https://github.com/ellerbrock/open-source-badges/)

An outline frame work of two apps to help start a comms App

This file is in the Apps as the helpfile which contains pictures. The readme does not contain the pictures.

I have over the years used many bits of code to test Ethernet Comms for many devices. I always wanted to get time to build a Client and Server from the ground up.

Here is my small attempt to do this. Hopefully, I have made it so that if you need somewhere to start you can pick it up and run with it, modifying it to your needs and making it far better than is shown here.

The Solution has two projects in it. One called Ethercomms and the other called EtherListen. I made one a listener socket and the other a TCP Socket. This way you can use it to develop your comms if you do not have the device you are using handy to use.

1.	EtherListen

This implements a Listening Socket that receives the data and sends it back out at present. Later we will see where this happens and how we can change it to see what is send and send back a proper reply.

The UI is straight forward. As this is a listener you put in the IP address and Port number and then click on “Open Listener”. The “Open Listener” button will change to a “Close Listener” button. When the data comes in it will be written to the main Rich Text Box. 

There is also a Checkbox you can untick if you also want to see the received text as ASCII. Once the stream of data is in the part of the code where we can decipher it and work out what to send as a reply you can encode it just how you want. I usually keep everything as Hex Strings as these are easy to work with, but you can use what you are familiar with. Maybe I can learn from what you use.
 
1.1.	Turning to the Code

Here I just put in some simple ways of doing this. They may not be the best way of doing it, but I find they are easy to understand and one can build it from this point into a better and more sophisticated App. I always find getting something to allow me to start is good and easier that starting from scratch each time.

Here we look in the folder called Comms and we find the file called Comms.cs. You may want to convert this into a class or something better. This is probably the place you want to start because here we get the received data and prepare the return data. If you are emulating your device this is where you do the magic.

In this file we see a function called “decypher” which takes a byte array and returns a byte array 

This input array is what is read from the receiving buffer which you find in Form1.cs

The output array is what you send back to Form1 and which is sent back to the device that sent the items in.

In the function called “decypher” is where we will do the work on the received data and work out what to return. At present I just return what I receive but you can change that depending on your needs. 

If you had commands being sent with parameters, it would be here that you could check the command and then have a case statement to send the data to each command function. Each function could be kept as a separate class/file/folder etc.
 
2.	EtherComms

This will implement an app that will allow you to send data to a device or in this example to the listener.

Here you can add you, data as a Hex string or ASCII string. This will be sent to the listener who will reply. You will then see the data written to the rich text box. The rich text box is housed in a tabbed view which will allow you to modify and extend the functionality of the app. The second tab in this example is just blank.

2.1.	Turning to the Code

When you click on the Send button it comes into Form1 and to the btn_send_Click function. Here it will send the data you put in the text box exactly as it is over to the instance of the client class. 

Once inside the client Class we go to the “Send” function. In here we prepare the data for sending to the Listener/device e.g. if it is ASCII we need to make it Hex. We then send this out.

When we next get a reply. In the Client Class there is a function called Connect. This connects us to the network and when that is done we start a thread that is listening for data called OnDataReceived.

This thread is in the client Class and it sits listening for incoming data and once it gets some it sends it back to Form1 to the function called “Decypher”.

I have put this function in a file called decipher in a folder called comms. This may not be the best way to do this, but it allows you to see what is happening easily and from there on you can go and change the code as you need and make better Classes, Functions etc. As said earlier this is all about getting you started and developing your app from this framework. You may not want the threads but in case you do I show how to use Invoke to prevent cross threading and so on.

In the “decypher” function I show what you may want to do if you have many commands. There may be different or better ways of doing this, but I show just a simple method. It may create lots of files but for me one file per command is good. That way in a few months’ time when you have to do maintenance on the App it is easy to find where you need to be. 

Today you know, Tomorrow you may remember but Next Month you will probably have forgotten and as say try and keep it simple. 
