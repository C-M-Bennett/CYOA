using System;
using Pastel;
using Color = System.Drawing.Color;

// colour examples:
// Console.WriteLine("Yay colours!".Pastel("#cf2be9"));
// Console.WriteLine($"TEST! Press {"ENTER".Pastel(Color.FromArgb(165, 229, 250))} to continue");

//yellow = 207, 153, 6
//orange = 209, 85, 19

/* Case template:

case "":
Console.WriteLine("\n.");
Console.WriteLine($" {"".Pastel(Color.FromArgb(207, 153, 6))}  {"".Pastel(Color.FromArgb(207, 153, 6))} ");
break;
*/

namespace CYOA
{
    class Choices
    {

        public static void Choice1()
        {
            Console.WriteLine($"\n\nYou can stay in the {"HOUSE".Pastel(Color.FromArgb(207, 153, 6))}, wander in the {"GARDEN ".Pastel(Color.FromArgb(207, 153, 6))}or head to the {"ROAD".Pastel(Color.FromArgb(207, 153, 6))}.");
            Console.WriteLine($"{"Where do you go?\n".Pastel(Color.FromArgb(209, 85, 19))}\n");

            string choice1 = Console.ReadLine().ToUpper();

            switch (choice1)
            {
                case "ROAD":
                    Console.WriteLine("\nYou head towards the busy road.");
                    Console.WriteLine($"Do you quickly {"RUN".Pastel(Color.FromArgb(207, 153, 6))} or carefully {"WALK".Pastel(Color.FromArgb(207, 153, 6))} across?");
                    break;

                case "GARDEN":
                    Console.WriteLine("\nYou head towards the sunny garden.");
                    Console.WriteLine($"Do you walk in the {"GRASS".Pastel(Color.FromArgb(207, 153, 6))} or explore the {"SHED".Pastel(Color.FromArgb(207, 153, 6))}?");
                    break;

                case "HOUSE":
                    Console.WriteLine("\nYou stay inside the cosy house and hear a noise...");
                    Console.WriteLine($"Do you ignore it and go to the {"WINDOW".Pastel(Color.FromArgb(207, 153, 6))} or do you {"INVESTIGATE".Pastel(Color.FromArgb(207, 153, 6))}?");
                    break;

                default:
                    Console.WriteLine("\nThat isn't one of the options, try again!");
                    Choice1();
                    break;
            }
        }


        public static void Choice2()
        {
            string choice2 = Console.ReadLine().ToUpper();

            switch (choice2)
            {
                case "RUN":
                case "WALK":
                    Console.WriteLine("\nYou run across the road and make it halfway.");
                    Console.WriteLine($"Do you quickly {"RUN".Pastel(Color.FromArgb(207, 153, 6))} the rest of the way or do you {"WALK".Pastel(Color.FromArgb(207, 153, 6))} carefully?");
                    break;

                case "GRASS":
                    Console.WriteLine("\nYou pad onto the freshly cut grass.");
                    Console.WriteLine($"Do you {"LIE".Pastel(Color.FromArgb(207, 153, 6))} down in the sun or do you watch for {"BIRDS".Pastel(Color.FromArgb(207, 153, 6))}?");
                    break;

                case "SHED":
                    Console.WriteLine("\nYou find yourself in a musty toolshed");
                    Console.WriteLine($"Do you have a good {"SCRATCH".Pastel(Color.FromArgb(207, 153, 6))} at the wood or do you {"SNEAK".Pastel(Color.FromArgb(207, 153, 6))} around?");
                    break;

                case "WINDOW":
                    Console.WriteLine("\nThe windowsill is lovely and sunny.");
                    Console.WriteLine("You lie down in the sun and fall asleep as a cat is wont to do.");
                    Console.WriteLine("\n\nThe End");
                    Console.WriteLine("Press 'Enter' to continue.".Pastel(Color.FromArgb(9, 176, 148)));
                    Console.ReadLine();
                    TitleScreen.SunEnd();
                    break;

                case "INVESTIGATE":
                    Console.WriteLine("\nYou see a parcel has been posted through the door.");
                    Console.WriteLine($"Do you {"SIT".Pastel(Color.FromArgb(207, 153, 6))} on it or do you {"TEAR".Pastel(Color.FromArgb(207, 153, 6))} at it?");
                    break;

                default:
                    Console.WriteLine("\nThat isn't one of the options, try again!");
                    Choice2();
                    break;
            }
        }


        public static void Choice3()
        {
            string choice3 = Console.ReadLine().ToUpper();

            switch (choice3)
            {
                case "RUN":
                    Console.WriteLine("\nYou set off running the rest of the way without looking both ways like a good kitty should.");
                    Console.WriteLine("You never reach the other side...");
                    Console.WriteLine("\n\nThe End");
                    Console.WriteLine("Press 'Enter' to continue.".Pastel(Color.FromArgb(9, 176, 148)));
                    Console.ReadLine();
                    TitleScreen.FailEnd();
                    break;

                case "WALK":
                    Console.WriteLine("\nYou look both ways and carefully walk the rest of the way.");
                    Console.WriteLine($"You make it to a field on the other side of the road. \nDo you {"SNEAK".Pastel(Color.FromArgb(207, 153, 6))} under the fence in front of you or do you head around the {"EDGE".Pastel(Color.FromArgb(207, 153, 6))} of the field?");
                    break;

                //lie in sun ending again - make endings into methods?
                case "LIE":
                    Console.WriteLine("\nYou lie down in the sun and fall asleep as a cat is wont to do. The sounds of tweeting birds enter your dreams and you stalk and chase them.");
                    Console.WriteLine("\n\nThe End");
                    Console.WriteLine("Press 'Enter' to continue.".Pastel(Color.FromArgb(9, 176, 148)));
                    Console.ReadLine();
                    TitleScreen.SunEnd();
                    break;

                case "BIRDS":
                    Console.WriteLine("\nYou decide to climb the nearby tree, from which you can keep a better watch for birds. Gotta protect your kingdom after all. \nYou are up quite high but from here you can see a group of birds clearly plotting something over on the shed roof. You can also see that the branches of this tree connect with another tree giving you a safe route across the road.");
                    Console.WriteLine($" Do you {"POUNCE".Pastel(Color.FromArgb(207, 153, 6))} on the unsuspecting birds? Or do you walk along the {"BRANCHES".Pastel(Color.FromArgb(207, 153, 6))} towards adventure?");
                    break;

                case "SCRATCH":
                    Console.WriteLine("\nThere's plenty of wood in here to sharpen your claws on and you leave some satisfying marks.");
                    Console.WriteLine($"Is that enough of that and you take a {"LOOK".Pastel(Color.FromArgb(207, 153, 6))} around? Or do you hunt for more {"WOOD".Pastel(Color.FromArgb(207, 153, 6))} to scratch?");
                    break;

                case "SNEAK":
                    Console.WriteLine("\nYou snoop around the toolshed and it smells metalic and warm and exiting.");
                    Console.WriteLine("Next to a box you see a small furry creature. You stop and assume the hunting position; head to the ground, ears flat and butt wiggling because your tail has a mind of it's own");
                    Console.WriteLine("\n\nYou Pounce!");
                    Console.WriteLine("Press 'Enter' to continue.".Pastel(Color.FromArgb(9, 176, 148)));
                    Console.ReadLine();
                    TitleScreen.MouseEnd();
                    break;

                case "SIT":
                    Console.WriteLine("\nIt's a cardboard box. You sit on it. Life is good. \nAs you get comfy you notice it smells AMAZING");
                    Console.WriteLine($"Do you curl up and go to {"SLEEP".Pastel(Color.FromArgb(207, 153, 6))} or does curiosity get the better of you and you {"TEAR".Pastel(Color.FromArgb(207, 153, 6))} it open after all?");
                    break;

                case "TEAR":
                    Console.WriteLine("\nYou start tearing and chewing on the box. \nInside you find something that smells AMAZING. \nIt's minty and luxurious and everything you ever wanted.");
                    Console.WriteLine($"Do you {"CHEW".Pastel(Color.FromArgb(207, 153, 6))} on the tasty cardboard more or do you dig into the box {"MORE".Pastel(Color.FromArgb(207, 153, 6))}?");
                    break;

                default:
                    Console.WriteLine("\nThat isn't one of the options, try again!");
                    Choice3();
                    break;
            }
        }


        public static void Choice4()
        {
            string choice4 = Console.ReadLine().ToUpper();

            switch (choice4)
                {
                case "SNEAK":
                    Console.WriteLine("\nYou've squeezed under the fence and are confronted by a field of bulls!");
                    Console.WriteLine($"Do you {"RUN".Pastel(Color.FromArgb(207, 153, 6))} for it and dodge your way around them or do you slowly {"BACK".Pastel(Color.FromArgb(207, 153, 6))} away and find another way?");
                    break;

                case "EDGE":
                    Console.WriteLine("\nYou've creeped around the edge of the fence and up on top of it.");
                    Console.WriteLine($"From here you can see two fields, one full of large angry creatures with {"HORNS".Pastel(Color.FromArgb(207, 153, 6))}  and one full of bumbling {"FLUFFY".Pastel(Color.FromArgb(207, 153, 6))} animals. Which do you choose? ");
                    break;

                case "POUNCE":
                    Console.WriteLine("\nYou jump down on to the shed roof, scattering the unsuspecting birds.");
                    Console.WriteLine($"From here you can clearly see someone has just posted somehting through the door of the {"HOUSE".Pastel(Color.FromArgb(207, 153, 6))} but the {"SHED".Pastel(Color.FromArgb(207, 153, 6))} smells warm and inviting. Where do you go?");
                    break;

                case "BRANCHES":
                    Console.WriteLine("\nThe pathway of branches leads you safely over the busy road to the fences on the other side.");
                    Console.WriteLine($" {"".Pastel(Color.FromArgb(207, 153, 6))}  {"".Pastel(Color.FromArgb(207, 153, 6))} "); //ideally point to same pathway as WALK choice in option 3?
                    break;

                case "LOOK":
                    Console.WriteLine("\nLooking around the shed, a couple of things catch your attention.");
                    Console.WriteLine($"A scurrying {"NOISE".Pastel(Color.FromArgb(207, 153, 6))} from the corner competes with a strange {"SMELL".Pastel(Color.FromArgb(207, 153, 6))} from on the worktop. Which do you investigate?");
                    break;

                case "WOOD":
                    Console.WriteLine("\nYou look around and through the window see the cherry tree with its twisting branches. Purrfect!.\nYou scratch at the bark and it's satisfyingly rough so you spring up the tree.");
                    //link to BIRDS choice3
                    break;

                case "SLEEP":// have a new cardboard box ending for this one? Tired and Sun dont really fit
                    Console.WriteLine("\nThe smell of catnip wafts into your dreams as you imagine you are a cat god, which isn't too different from reality really.");
                    Console.WriteLine("\n\nThe End");
                    Console.WriteLine("Press 'Enter' to continue.".Pastel(Color.FromArgb(9, 176, 148)));
                    Console.ReadLine();
                    TitleScreen.TiredEnd();
                    break;

                case "TEAR": //TEAR in previous option

                    break;

                case "CHEW":
                    Console.WriteLine("\nThe cardboard tastes like catnip and it is the best of all the worlds. You keep eating it. \nUnfortunately the cardboard doesn't want to stay eaten and you cough it up all over the carpet. ");
                    Console.WriteLine($"Now there is a parcel with bits missing from it and those missing bits are a soggy lump.\nDo you {"LEAVE".Pastel(Color.FromArgb(207, 153, 6))}, after all it's not your parcel so not your mess? Or do you find somewhere to {"HIDE".Pastel(Color.FromArgb(207, 153, 6))} from the inevitable scolding you'll get?");
                    break;

                case "MORE":
                    Console.WriteLine("\nWho knew you could get catnip posted through your door?! Cats truly are favoured by the Gods..");
                    Console.WriteLine($"You roll around in the delicious herb until life is in hyperdrive. Do you go to {"PLAY".Pastel(Color.FromArgb(207, 153, 6))} in the garden or do you find somewhere to {"SLEEP".Pastel(Color.FromArgb(207, 153, 6))} it off?");
                    break;

                default:
                    Console.WriteLine("\nThat isn't one of the options, try again!");
                    Choice4();
                    break;
            }
        }


        public static void Choice5()
        {
            string choice5 = Console.ReadLine().ToUpper();

            switch (choice5)
            {
                case "RUN":
                    Console.WriteLine("\nYou dodge and weave through the field of bulls. They don't even see you until it's too late and you're at the next fence bordering 2 fields. You're the swiftest, cleverest cat that ever there was.");
                    Console.WriteLine($"There is a field full of temptingly long {"GRASS".Pastel(Color.FromArgb(207, 153, 6))} or another which smells earthy and has strange slow, {"FLUFFY".Pastel(Color.FromArgb(207, 153, 6))} creatures in iot. Which do you choose?");
                    break;

                case "BACK":
                    Console.WriteLine("\nYou back off from the angry looking bulls. It's a wise move.");
                    //link to EDGE choice4
                    break;

                case "HORNS": //link to SNEAK choice4
                    
                    break;

                case "FLUFFY":
                    Console.WriteLine("\nThis field is full of sheep! And they look fun to play with. Like a big ball of wool on legs!");
                    Console.WriteLine($"Do you {"RUN".Pastel(Color.FromArgb(207, 153, 6))} at them to see what happens? Or do you {"STALK".Pastel(Color.FromArgb(207, 153, 6))} them and see what you can find out?");
                    break;

                case "SHED": //I need this option to just call the first SHED Choice2 somehow so that it loops

                    break;

                case "HOUSE": //this option needs to call the HOUSE choice in Choice1
            
                    break;

                case "NOISE":
                    Console.WriteLine("\nSlowly stalking to where the skittering noise is coming from you spot a tiny ball of fur and whiskers. It's just what your human needs, they're rubbish at catching their own food!";
                    Console.WriteLine("You line up the perfect pounce... and jump!");
                    Console.WriteLine("\n\nThe End");
                    Console.WriteLine("Press 'Enter' to continue.".Pastel(Color.FromArgb(9, 176, 148)));
                    Console.ReadLine();
                    TitleScreen.MouseEnd();
                    break;

                case "SMELL":
                    Console.WriteLine("\nYou jump up onto the worktop and find you've landed on a freshly painted piece of wood. It smells a lot stronger up here and it's unpleasantly sticky.");
                    Console.WriteLine($"Do you lie down to try and {"CLEAN".Pastel(Color.FromArgb(207, 153, 6))} your paws or do you jump {"DOWN".Pastel(Color.FromArgb(207, 153, 6))} from this terrible place?");
                    break;

                case "LEAVE":
                    Console.WriteLine("\nYou look at teh lump of soggy cardboard in discust and wander away. That's someone elses mess to deal with.");
                    Console.WriteLine($"You head outside.");
                    //link to garden choice1?
                    break;

                case "HIDE":
                    Console.WriteLine("\nYou find a good spot inside the sofa to hide. They wont find you here for ages and by then they'll be worried something terrible has happened to you so you wont get told off \nBrilliant.");
                    Console.WriteLine("You get comfy and fall asleep");
                    Console.WriteLine("\n\nThe End");
                    Console.WriteLine("Press 'Enter' to continue.".Pastel(Color.FromArgb(9, 176, 148)));
                    Console.ReadLine();
                    TitleScreen.TiredEnd();
                    break;

                case "PLAY":
                    Console.WriteLine("\nYou are imbued with the energy taht is usually reserved for sprinting around the house at 1am. You decide to explore the garden");
                    //link to GARDEN option in choice1

                    break;

                case "SLEEP":
                    Console.WriteLine("\nThere is a shaft of sunlight coming through the glass and, maybe it's just because you're off your face on catnip, but it looks truly magical.");
                    Console.WriteLine("Curling up you can smell the sun on flower meadows and hear the soft rustle of rodents in the undergrowth as you drift off to sleep");
                    Console.WriteLine("\n\nThe End");
                    Console.WriteLine("Press 'Enter' to continue.".Pastel(Color.FromArgb(9, 176, 148)));
                    Console.ReadLine();
                    TitleScreen.SunEnd();
                    break;

                default:
                    Console.WriteLine("\nThat isn't one of the options, try again!");
                    Choice5();
                    break;
            }
        }


        public static void Choice6()
        {
            string choice6 = Console.ReadLine().ToUpper();

            switch (choice6)
            {
                case "GRASS":
                    Console.WriteLine("\nBolting into the long grass you pause to catch your breath. You lie still listening to the rustling of the leaves.");
                    Console.WriteLine($"Do you {"LIE".Pastel(Color.FromArgb(207, 153, 6))} still to breathe in the sun soaked leaves or to you {"LISTEN".Pastel(Color.FromArgb(207, 153, 6))} to the rustling?");
                    break;

//can I refer to the "fluffy" case in the previous option instead of repeating it here? might need to be IF statement instead maybe?
                case "FLUFFY":
                    Console.WriteLine("\nThis field is full of sheep! And they look fun to play with. Like a big ball of wool on legs!");
                    Console.WriteLine($"Do you {"RUN".Pastel(Color.FromArgb(207, 153, 6))} at them to see what happens? Or do you {"STALK".Pastel(Color.FromArgb(207, 153, 6))} them and see what you can find out?");
                    break;

                case "RUN":
                    Console.WriteLine("\nYou bunch your muscles and run at the sheep! \nThey scatter and you have a moment of understanding for what those stupid sheepdogs see in this.");
                    Console.WriteLine("Having thoroughly terrorised the poor creatures you take your rightful spot on the only hill so that you can lie down and survey your minions.");
                    Console.WriteLine("\n\nYou fall asleep.");
                    Console.WriteLine("Press 'Enter' to continue.".Pastel(Color.FromArgb(9, 176, 148)));
                    Console.ReadLine();
                    TitleScreen.TiredEnd();
                    break;

                case "STALK":
                    Console.WriteLine("\nProwling carefully around you realise the stupid wool brains don't suspect a thing but also that there are other animals here too...");
                    Console.WriteLine($"Do you {"RUN".Pastel(Color.FromArgb(207, 153, 6))} at them or do you investigate the other {"NOISES".Pastel(Color.FromArgb(207, 153, 6))}?");
                    break;

                case "CLEAN":
                    Console.WriteLine("\nYou sit down to get this weird substance off your feet. \nThat was a mistake.");
                    Console.WriteLine("You end up covered in paint. It's matting your fur together and licking it off has made you very sick.");
                    Console.WriteLine("\n\nThis may be a trip to the groomers. And maybe even the vets!.");
                    Console.WriteLine("Press 'Enter' to continue.".Pastel(Color.FromArgb(9, 176, 148)));
                    Console.ReadLine();
                    TitleScreen.FailEnd();
                    break;

                case "DOWN":
                    Console.WriteLine("\nYou jump off the hellish worktop. This results in a neat pattern of your pawprints on the shed floor in a fetching shade of purple.");
                    Console.WriteLine("You wander around a little more, marvelling in the artwork you're able to make with such little effort before returning outside where the grass removes what is left of the paint from between your toebeans.");
                    Console.WriteLine("\n\nYou curl up in the grass, a day well spent.");
                    Console.WriteLine("Press 'Enter' to continue.".Pastel(Color.FromArgb(9, 176, 148)));
                    Console.ReadLine();
                    TitleScreen.TiredEnd();
                    break;

                default:
                    Console.WriteLine("\nThat isn't one of the options, try again!");
                    Choice6();
                    break;
            }
        }


        public static void Choice7()
        {
            string choice7 = Console.ReadLine().ToUpper();

            switch (choice7)
            {
                case "LIE":
                    Console.WriteLine("\nYou close your eyes and breath deep of the sun toasted grass.");
                    Console.WriteLine("The warm sun is soothing after your tiring day. Maybe you'll just stay here a while.");
                    Console.WriteLine("\n\nThe End");
                    Console.WriteLine("Press 'Enter' to continue.".Pastel(Color.FromArgb(9, 176, 148)));
                    Console.ReadLine();
                    TitleScreen.TiredEnd();
                    break;

                case "LISTEN":
                    Console.WriteLine("\nYou slink through the grass, listening carefully and stalking the rustling noises you can hear.");
                    Console.WriteLine("Ahead of you there is a mouse. You stop and assume the hunting position; head to the ground, ears flat and butt wiggling because your tail has a mind of it's own");
                    Console.WriteLine("\n\nYou Pounce!");
                    Console.WriteLine("Press 'Enter' to continue.".Pastel(Color.FromArgb(9, 176, 148)));
                    Console.ReadLine();
                    TitleScreen.MouseEnd();
                    break;

                case "RUN": //a repeat of the RUN in the option before - can this be streamlined?
                    Console.WriteLine("\nYou bunch your muscles and run at the sheep! \nThey scatter and you have a moment of understanding for what those stupid sheepdogs see in this.");
                    Console.WriteLine("Having thoroughly terrorised the poor creatures you take your rightful spot on the only hill so that you can lie down and survey your minions.");
                    Console.WriteLine("\n\nYou fall asleep.");
                    Console.WriteLine("Press 'Enter' to continue.".Pastel(Color.FromArgb(9, 176, 148)));
                    Console.ReadLine();
                    TitleScreen.TiredEnd();
                    break;

                case "NOISES": //use NOISE from choice5?

                    break;

                default:
                    Console.WriteLine("\nThat isn't one of the options, try again!");
                    Choice7();
                    break;
            }
        }


    }
}



                