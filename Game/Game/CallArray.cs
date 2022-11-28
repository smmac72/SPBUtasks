public class CallArray
{
    public string[,] CallList = new string[16, 7];
    public string[,] AnswerList = new string[16, 7];
    public string[] Names = new string[16] { "Alan", "Step", "Ann", "Jason", "Unknown", "Foren", "Jake", "Eugene", "Dane", "Unknown", "Cock", "Mellissa", "Phil", "Unknown", "Diane", "Unknown" };
    public string[] Ages = new string[16] { "Mid 40-s", "Around 20", "Around 20", "20 to 25", "Early 60s", "Early 20s", "A child", "30-40 years", "Around 25 years", "Early 20s", "27 y.o. cock", "Teenager", "In his 60s", "Mid 30s", "Mid 30s", "Female" };
    public string[] Locations = new string[16] { "Bam st.", "Friendly South", "Downtown East", "City Hall", "Friendly North", "City Hall", "Bam st.", "Downtown West", "Downtown South", "3rd Friendly st.", "Somewhere in Friendly Houses", "2nd Friendly st.", "Downtown Center", "Friendly North", "3rd Friendly st.", "The Tower" };
    public string[] Reasons = new string[16] { "Armed Robbery", "Animal Cruelty", "Domestic Violence", "A homeless dude existing", "Suspected Kidnapping", "Accidental Hit and Run", "Heart Attack", "Attempted Suicide", "Blunt Skull Trauma", "Going into Labor", "Explosion", "Body Found", "Attempted Murder", "Terrorism", "Breaking in with Murder", "9/11" };
    public string[] Resolve = new string[16] { "Robbers have escaped with $1290", "Kids were taken to jail (bruh)", "The perp is successfully detained", "Homeless guy was detained", "A female body was found",
                                               "Tesla Model 3 drove on autopilot into a City Hall potlock. Nobody was hurt", "Jake will see his grandma again", "Daughter was taken to the ER", "The man was successfully woken up",
                                               "This dude is the happiest father now!", "Cock's house was never the same. But still livable", "The body was successfully found", "The perp was detained at the nearest KFC",
                                               "Medics are working at the scene. The car owner is still in critical", "Diane was saved :)", "2977 deaths. Yes, 9/11 operators carry this weight :("};
    public int[] HouseX = new int[16] { 6, 13, 7, 7, 1, 7, 7, 7, 10, 10, 6, 7, 10, 1, 12, 4 };
    public int[] HouseY = new int[16] { 16, 6, 39, 50, 5, 50, 12, 29, 29, 6, 8, 10, 39, 11, 6, 39 };

    public bool[] AbleFindName;
    public int[] RequiredUnits;
    public CallArray()
    {
        AbleFindName = new bool[16] { true, true, true, true, false, true, true, true, true, false, true, true, true, false, true, false };
        RequiredUnits = new int[16] { 100,100,100,100,100,010,010,010,010,010,001,110,110,101,110,111 };

        CallList[0, 0] = "There're two masked dudes walking into a 7/11 with a shotgun";
        CallList[0, 1] = "Name's Alan. My number is 202-45154486";
        CallList[0, 2] = "It's the 7/11 on the Bam street";
        CallList[0, 3] = "Yup, they're aiming at the clerk. He's doing something under the counter";
        CallList[0, 4] = "Alright, I'm waiting. Thank you";

        CallList[1, 0] = "Hey, I see some kids throwing rocks at their pet dog";
        CallList[1, 1] = "Name's Step. Yeah, watching through the window.";
        CallList[1, 2] = "Southern side of Friendly Houses. They're like on the road.";
        CallList[1, 3] = "No, nobody else. Just three kids.";
        CallList[1, 4] = "Thanks, see ya";

        CallList[2, 0] = "Please help... He's hitting me with all the force..";
        CallList[2, 1] = "It's Ann. I can't do it anymore.";
        CallList[2, 2] = "Eastern Downtown building, floor 63. You'll hear..";
        CallList[2, 3] = "Alright, I will! I promise..";
        CallList[2, 4] = "Please hurry";

        CallList[3, 0] = "Greetings, I'm trying to evade a homeless drunk here";
        CallList[3, 1] = "Jason Yankee. J-A-S-O-N Y-A-N-K-E-E. No phone, calling from a phonebooth.";
        CallList[3, 2] = "Just across the city hall";
        CallList[3, 3] = "No harm, just messing with city hall workers. Can't punch him myself *laugh*";
        CallList[3, 4] = "Yeah, waiting, fellas. Thank you!";

        CallList[4, 0] = "I need help. This man is following me.";
        CallList[4, 1] = "Please send somebody over.";
        CallList[4, 2] = "Northern side of Friendly Houses. He's in a black van.";
        CallList[4, 3] = "I tried. Nobody opened...";
        CallList[4, 4] = "Hurry please...";

        CallList[5, 0] = "Please do something! It's a bloodshed!";
        CallList[5, 1] = "It's Smith. Foren Smith, your deputy mayor!";
        CallList[5, 2] = "INSIDE THE GODDAMN CITY HALL!";
        CallList[5, 3] = "Some guy just rammed the wall. I cannot describe this...";
        CallList[5, 5] = "Alright.";

        CallList[6, 0] = "Please come by! My grandma's feeiling ill!";
        CallList[6, 1] = "I'm Jake";
        CallList[6, 2] = "A yellow house. I can see city hall from here, I can't say where I am...";
        CallList[6, 3] = "She just grabbed her heart and dropped.. Please.. Come..";
        CallList[6, 5] = "*crying* Thank you..";

        CallList[7, 0] = "I need help. I need help. It's my fault...";
        CallList[7, 1] = "It's Eugene. Number is 8-800-555-35-35";
        CallList[7, 2] = "Western side of Downtown, floor 47, apartment 343. Please hurry.";
        CallList[7, 3] = "My daughter tried to cut herself. This is all my fault. She's unconcious. There's lots of blood...";
        CallList[7, 5] = "Please just hurry";

        CallList[8, 0] = "9/11? There's a person lying down the stairs";
        CallList[8, 1] = "Call me Dane";
        CallList[8, 2] = "Southern Downtown, I can meet the medics.";
        CallList[8, 3] = "Yes, unconcious. A blunt trauma, a bit of blood";
        CallList[8, 5] = "Alright, thank you. I'm waiting";

        CallList[9, 0] = "My wife is going into labor. 141, 3rd Friendly";
        CallList[9, 1] = "My name is... Goddamn, she's giving birth, come on!";
        CallList[9, 2] = "Just hurry";
        CallList[9, 3] = "Yes, I've been visiting future dads courses. I am ready";
        CallList[9, 5] = "I am ready. I am ready. I am ready!";

        CallList[10, 0] = "There's a house burning in Friendly!";
        CallList[10, 1] = "No name, it's MY HOUSE... ALRIGHT. It's Cock. It's never been funnier";
        CallList[10, 2] = "Just Friendly. Something exploded all over Friendly";
        CallList[10, 3] = "Nobody in the house. Just hurry, it's my work day";
        CallList[10, 6] = "Yeah-yeah, I won't. Waiting";

        CallList[11, 0] = "Hello... There's .. ther.. body";
        CallList[11, 1] = "Mellissa.. I can't.. remember number";
        CallList[11, 2] = "2nd of.. Frien.. Friendly. Please come..";
        CallList[11, 3] = "Yes, it was me";
        CallList[11, 4] = "Please hurry";
        CallList[11, 5] = "I can't.. anymore";

        CallList[12, 0] = "Goddamn, there's a World War 3 on the streets!";
        CallList[12, 1] = "Phil. It's Phil. And somebody just straight up shot a dude entering his car";
        CallList[12, 2] = "In the very centre. Downtown. The dude's bleeding";
        CallList[12, 3] = "Perp left. Orange Mustang with a black stripe";
        CallList[12, 4] = "Yeah, waiting";
        CallList[12, 5] = "This dude needs it so much right now";

        CallList[13, 0] = "Something just exploded. A car? It's a car!";
        CallList[13, 1] = "Sorry, can't hear you. A car. Exploded";
        CallList[13, 2] = "Can't hear. I am going deaf. Northern Friendly?";
        CallList[13, 3] = "What? There's AN ARM. Just come!";
        CallList[13, 4] = "Say again?";
        CallList[13, 6] = "I can't hear, but I'll be waiting!";

        CallList[14, 0] = "Please help. Somebody is in my house...";
        CallList[14, 1] = "Dia.. Diane. He's down there. I can hear him...";
        CallList[14, 2] = "*shots* THIRD FRIENDLY, HURRY";
        CallList[14, 3] = "*no response*";
        CallList[14, 4] = "*no response*";
        CallList[14, 5] = "*no response*";

        CallList[15, 0] = "(muttering to herself in distressed state) Holy Mary mother of God!";
        CallList[15, 1] = "Is it...is it...are they going to be able to get somebody up here?";
        CallList[15, 2] = "Oh god, I'm on the 83rd floor...";
        CallList[15, 3] = "Please!";
        CallList[15, 4] = "VERY hot! We're all on the other side of Liberty, and it's very, very hot.";
        CallList[15, 5] = "It's very, very, very hot.";
        CallList[15, 6] = "Tthe floor's completely engulfed. We're on the floor and we can't breathe.";

        AnswerList[0, 0] = "9/11 dispatch on the line. What's the emergency?";
        AnswerList[0, 1] = "Alright, state your name and phone number please";
        AnswerList[0, 2] = "Can you state the location of this 7/11?";
        AnswerList[0, 3] = "Is any of the store personnel in any danger?";
        AnswerList[0, 4] = "We're sending a patrol unit to the store. Please do not approach the store";

        AnswerList[1, 0] = "Dispatch. What's the emergency?";
        AnswerList[1, 1] = "I'm gonna need your name. Are you safe from them?";
        AnswerList[1, 2] = "And where exactly is this happening?";
        AnswerList[1, 3] = "Do you see anybody else in danger?";
        AnswerList[1, 4] = "I am sending a patrol car to Friendly Houses. They'll be in a minute.";

        AnswerList[2, 0] = "9/11, how can I help?";
        AnswerList[2, 1] = "Calm down, you are safe with me. What is your name?";
        AnswerList[2, 2] = "Where are you? We will send police for you";
        AnswerList[2, 3] = "You will do it! Just a bit longer. Everything's gonna be alright";
        AnswerList[2, 4] = "Just a minute. They'll be here soon..";

        AnswerList[3, 0] = "Dispatch. What's the emergency?";
        AnswerList[3, 1] = "I'm gonna need your name. And a phone number, please";
        AnswerList[3, 2] = "Where are you now?";
        AnswerList[3, 3] = "Is this person threatening anybody?";
        AnswerList[3, 4] = "We're sending a police unit to City Hall. Do not interact with this person";

        AnswerList[4, 0] = "9/11, how can I help?";
        AnswerList[4, 1] = "Alright, just tell me your name";
        AnswerList[4, 2] = "Where are you right now?";
        AnswerList[4, 3] = "Did you try to hide in the houses nearby?";
        AnswerList[4, 4] = "I am sending a patrol car to Friendly Houses. Hold on, you're gonna be safe";

        AnswerList[5, 0] = "9/11 dispatch. What's the emergency?";
        AnswerList[5, 1] = "Alright, I'm gonna need your name";
        AnswerList[5, 2] = "Where is this bloodshed?";
        AnswerList[5, 3] = "Tell me what happened";
        AnswerList[5, 5] = "An EMS unit is on its way. They'll be there shortly";

        AnswerList[6, 0] = "9/11, how can I help?";
        AnswerList[6, 1] = "Hey, little guy. Please tell me your name";
        AnswerList[6, 2] = "Can you say where are you?";
        AnswerList[6, 3] = "What happened?";
        AnswerList[6, 5] = "Come on, little guy. Everything's gonna be okay. Medics will be here any minute, just hold the door for them";

        AnswerList[7, 0] = "Dispatch. What's the emergency?";
        AnswerList[7, 1] = "Please, talk with me. What's your name?";
        AnswerList[7, 2] = "Where are you right now?";
        AnswerList[7, 3] = "Tell me what happened";
        AnswerList[7, 5] = "Do not blame yourself. Medics will be with her shortly. Just hug your daughter for me!";

        AnswerList[8, 0] = "9/11 dispatch, state your emergency";
        AnswerList[8, 1] = "Alright, what's your name?";
        AnswerList[8, 2] = "Where has he fallen down?";
        AnswerList[8, 3] = "Is he unconcious?";
        AnswerList[8, 5] = "Medics will arrive shortly. Please do meet them";

        AnswerList[9, 0] = "Dispatch here";
        AnswerList[9, 1] = "Wow, can you give me your name?";
        AnswerList[9, 2] = "Where are you?";
        AnswerList[9, 3] = "I can connect you with medical unit for further instructions";
        AnswerList[9, 5] = "Best of luck to your young family! Medics are almost there";

        AnswerList[10, 0] = "Dispatch, 9/11. How can I help?";
        AnswerList[10, 1] = "Understood. Can I have your name, please?";
        AnswerList[10, 2] = "Can I get a more precise location?";
        AnswerList[10, 3] = "Is there anybody in the house?";
        AnswerList[10, 6] = "Firefighter crew is on its way. Please wait";

        AnswerList[11, 0] = "9/11 dispatch, how can I be of service today?";
        AnswerList[11, 1] = "A body.. Can I have your name?";
        AnswerList[11, 2] = "Where is it lying?";
        AnswerList[11, 3] = "Did you find the body?";
        AnswerList[11, 4] = "Police is en route to your location";
        AnswerList[11, 5] = "Medics are coming shortly, you can do it!";

        AnswerList[12, 0] = "Dispatch. What's the emergency?";
        AnswerList[12, 1] = "First, what's your name?";
        AnswerList[12, 2] = "Can I have the location?";
        AnswerList[12, 3] = "Is the criminal threatening anyone?";
        AnswerList[12, 4] = "We've contacted the local PD, police is on its way";
        AnswerList[12, 5] = "Medic team is coming shortly";

        AnswerList[13, 0] = "9/11, how can I help?";
        AnswerList[13, 1] = "A car? Can I have your name?";
        AnswerList[13, 2] = "Where was the explosion?";
        AnswerList[13, 3] = "Is anybody hurt?";
        AnswerList[13, 4] = "Police is coming";
        AnswerList[13, 6] = "Fire Department is on its way";

        AnswerList[14, 0] = "How can I help? 9/11 Dispatch";
        AnswerList[14, 1] = "Alright, tell me everything. I am ready to help";
        AnswerList[14, 2] = "Where is your house?";
        AnswerList[14, 3] = "What is happening?";
        AnswerList[14, 4] = "POLICE SENT";
        AnswerList[14, 5] = "Hold on, Diane..";

        AnswerList[15, 0] = "Good morning";
        AnswerList[15, 1] = "Ma'am, how're you doing?";
        AnswerList[15, 2] = "86-what? Floor?";
        AnswerList[15, 3] = "Okay, stay calm with me, okay? I understand...";
        AnswerList[15, 4] = "Anybody's unconscious, everybody's awake?";
        AnswerList[15, 5] = "You’ve got to be very, very careful... how they approach you, okay? Now you stay calm";
        AnswerList[15, 6] = "Ma'am, we're coming up to you";
    }
}