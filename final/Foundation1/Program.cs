using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Creating Objects (from actual YouTube videos)
        Comment oneOne = new Comment("@BigNonsense", "As a newer player, I identify with Aims just getting excited by decks doing cool things.");
        Comment oneTwo = new Comment("@royk9529", "I want to call out my boy Kibler too! At 52:00 Kibler discovers twice with Throne and Pantlaza but due to Pantlaza's OPT, he can only discover once! I love you Kibler!");
        Comment oneThree = new Comment("@WiLDRAGE777", "That reaction when Aims finds out about the Dihada / Odric interactions is so wholesome.  Seeing new players learn cool stuff is what makes Magic great.");
        Comment oneFour = new Comment("@ALTR_no_EGO", "Eilidh's frustrated editor vfx are priceless... And the growl, too! 😂 We appreciate you Eilidh! Seriously.");
        List<Comment> comments = new List<Comment>(){oneOne, oneTwo, oneThree, oneFour};
        Video first = new Video("Commander at Home #28 - Pantlaza vs Windgrace vs Don Andres vs Dihada feat DrLupo and Aims", "Commander At Home", 5820, comments);

        Comment twoOne = new Comment("@DraakjeYoblama", "Working with these frictionless water physics, I think the best design would be a straight wall with a trench behind it. When the water flows over the wall, it will fill up the trench.");
        Comment twoTwo = new Comment("@drrodopszin", "It made me crave a first person game where you randomly wake up as one citizen of a town about to be hit by a giant tsunami and you need to survive.");
        Comment twoThree = new Comment("@Wasbever_14", "As a Dutchman whom is constantly at war with the sea this is a pretty good video");
        Comment twoFour = new Comment("@randomaccessfemale", "2:29 Person in the city: 'Those aren't mountains...'");
        List<Comment> comments2 = new List<Comment>(){twoOne, twoTwo, twoThree, twoFour};
        Video second = new Video("Engineering MEGA TSUNAMI sea defenses in Cities Skylines!", "Real Civil Engineer", 1043, comments2);

        Comment threeOne = new Comment("@rps4400", "You are like if Real Civil Engineer and CodeBullet had a child and I love it");
        Comment threeTwo = new Comment("@ItsVasl", "when the world needed him the most, he returned");
        Comment threeThree = new Comment("@peptobepto", "HE’S BACK!!!");
        Comment threeFour = new Comment("@Rodasboyy", "Around 4:22 wouldn't it be better for visualization and filming purposes to do a 10x10 grid of bridges?");
        List<Comment> comments3 = new List<Comment>(){threeOne, threeTwo, threeThree, threeFour};
        Video third = new Video("Evolving Genetic AI Optimizes Poly Bridge Problems", "AstroSam", 598, comments3);

        Comment fourOne = new Comment("@hommhommhomm", "Imagine needing to debug this when the creator has left the company");
        Comment fourTwo = new Comment("@skills697", "Wow, I don't usually stop and like random videos (from a \"random coder\")... but anyone crazy enough to solve this kind of problem with RegEx deserves applause. Impressive!");
        Comment fourThree = new Comment("@imanuelbaca2468", "This is insanely informative and entertaining I love making one line solutions and evil hacks to pass code war challenges. This is phenomenal!");
        Comment fourFour = new Comment("@SunSnowGravity", "Smart solution showing how versatile are regular expressions. Using only basics shows mastery!");
        List<Comment> comments4 = new List<Comment>(){fourOne, fourTwo, fourThree, fourFour};
        Video fourth = new Video("Evil Regex Hacking in Codewars - An Outrageous Solution to Find if a King is in Check", "TheRandomCoder", 836, comments4);


        // Displaying videos with comments
        List<Video> videos = new List<Video>(){first, second, third, fourth};
        
        foreach (Video x in videos)
        {
            x.Display();
        }
    }

}