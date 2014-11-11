private void speechStuff(){
            //define your event handlers for speech recognition
            //you will need to look up how to integrate speech stuff wiht windows.
            //probably start listening to voice events here
            //add your event handlers etc.
            //event handlers would call the methods in unity, such as: 
            //
            //AppCallbacks.Instance.InvokeOnAppThread(() =>
            //{
            //    //do things from unity context here
            //    HelperHello.TurnMeBlue(s2);
            //}, false);

            //Unity is ready, lets roll.
            //This is setting the action from unity, so when
            //unity does something exciting, you can execute .NET code.
            UnitySpeechBridge.HelloWorld = () =>
            {
                while (true)
                {
                    //Maybe you want to have an API that
                    //makes the computer talk to you
                    //or something.

                    //this is where you can call .NET stuff
                    int i = 0;
                    i++;

                    //maybe it says "You collided"
                }
            };
            //end that example

            //Example of setting the values for the other function
            //this is an example of telling Unity what IDoStuff is
            //in which IDoStuff might be having .net libraries that Unity
            //doesn't support have your computer do text to voice
            //
            //You are just simply setting a function that exists in Unity and Unity can call it, when it needs.
            UnitySpeechBridge.IDoStuff = (string s) =>
            {
                //have your code that spits out voice stuff from .NET here
                //if you have try catch and .net fails on you
                //maybe you are making a service call, and you don't have internet
                //you could then return false instead so unity knows what to do with it.
                return true;//this value returns to unity
            };
            //endexample

            //start example of calling unity code from vs when something exciting happens
            //like picking up somebody speaking.

            //words the api gets
            string s2 = "HELLO WORLD!";

            //make something turn blue with words or something...
            //This could for example move a chess peice 
            //you can pass which peice needss to be moved
            //Unity can take care of that.

            AppCallbacks.Instance.InvokeOnAppThread(() =>
            {
                //do things from unity context here
                UnitySpeechBridge.TurnMeBlue(s2);
            }, false);

            //end that example
        }