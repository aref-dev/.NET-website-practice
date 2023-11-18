using aref_final.Data;
using Microsoft.EntityFrameworkCore;

namespace aref_final.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new aref_finalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<aref_finalContext>>()))
            {
                if (context == null || context.Toy == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Toy.Any())
                {
                    return;   // DB has been seeded
                }

                context.Toy.AddRange(
                    new Toy
                    {
                        Name = "KAI - The Artificial Intelligence Robot",
                        Description = "Kit for building a 6-legged robot with machine-learning capabilities\r\nEncourages spatial reasoning, logic, STEM learning, problem-solving\r\nUse the app to collect data and assign gestures and sounds to KAI's 5 functions\r\nTrain your AI model to more accurately recognize patterns in the data\r\nFeatures remote-control mode and gyroscope mode\r\nDisplay emotions and messages on the robot's LED face display\r\nFeatures a lesson in creating your own AI using household items (paper and cups)\r\nIncludes 123 building pieces\r\n64-page instruction manual included\r\nRequires 4 AAA batteries - Not included\r\nRequires smart device with either iOS or Android operating system\r\nHigh-quality materials - Exceptional build-and-learn experience",
                        Price = 100,
                        Category = "STEM",
                        ImageFileName = "images/stem/1.jpg"
                    },
                    new Toy
                    {
                        Name = "Sky Surfer Airplane Launcher",
                        Description = "Kit for building an airplane launcher for testing different airplane designs\r\nEncourages spatial reasoning, logic, STEM skills, creativity\r\nLauncher is easy to build in about 30 minutes (but not too easy!)\r\nAdjustable thruster launches planes from 10 to over 30 feet - or more!\r\nInstruction booklet features plane designs, ideas, paper, card stock\r\nTest your planes, compete with friends to see which ones will fly the furthest!\r\nIncludes 14 die-cut wooden pieces, 2 foam pads, wooden dowel, 15 elastics, cool decals, 6 sheets of paper, 2 O-rings, twist-tie, clay, glue, sandpaper\r\n20-page instruction booklet included\r\nLauncher measures 16 inches long\r\nHigh-quality materials - Exceptional build-and-learn experience",
                        Price = 20,
                        Category = "STEM",
                        ImageFileName = "images/stem/2.jpg"
                    },
                    new Toy
                    {
                        Name = "Leonardo da Vinci Catapult",
                        Description = "Kit for building a catapult based on Leonardo da Vinci's design\r\nEncourages spatial reasoning, logic, STEM skills\r\nEasy to make in about an hour\r\nAll parts are pre-cut and ready to build\r\nParts are pegged for extra strength\r\nFinished catapult can launch the clay ball over 13 feet!\r\nIncludes catapult parts and clay ball\r\nDetailed building instructions included\r\nFinished model measures 16.5 x 16.5 inches\r\nMade of natural, untreated wood from sustainable forests",
                        Price = 20,
                        Category = "STEM",
                        ImageFileName = "images/stem/3.jpg"
                    },
                    new Toy
                    {
                        Name = "Leonardo da Vinci Trebuchet",
                        Description = "Kit for building a trebuchet based on Leonardo da Vinci's design\r\nEncourages spatial reasoning, logic, STEM skills\r\nEasy to make in about an hour\r\nAll parts are pre-cut and ready to build\r\nParts are pegged for extra strength\r\nIncludes trebuchet parts and clay ball\r\nDetailed building instructions included\r\nFinished model measures 24.5 x 12.5 inches\r\nMade of natural, untreated wood from sustainable forests",
                        Price = 20,
                        Category = "STEM",
                        ImageFileName = "images/stem/4.jpg"
                    },
                    new Toy
                    {
                        Name = "Science & Play Build Mechanics - Firen Engine",
                        Description = "Construction kit for building a motorized fire engine, then 4 more amazing vehicles\r\nEncourages spatial reasoning, logic, STEM skills, creativity, imaginative play\r\nParts simply snap together\r\nManual steering mechanism\r\nWheels driven by the motor\r\nRotating ladder driven by the motor\r\nLadder can be raised and lowered\r\nCan be rebuilt into 4 more models - Airport rescue truck, amphibious fire engine, pick-up with patrol boat, telescopic lift truck\r\nMore than 540 interchangeable components, includes electric motor\r\nPrinted instructions for fire engine included\r\nDownload the free app for digital instructions for other models\r\nApp not compatible with Windows operating systems\r\nLadder measures 11 inches long\r\nRequires 4 AA batteries - Not included\r\nQuality materials - Exceptional build-and-play experience\r\nMade in Italy",
                        Price = 70,
                        Category = "STEM",
                        ImageFileName = "images/stem/5.jpg"
                    },
                    new Toy
                    {
                        Name = "National Geographic Explorer Series Rock Tumbler",
                        Description = "Rock tumbler designed for young beginners\r\nEncourages curiosity, an interest in science and geology\r\nPolish the included rocks, then find more rocks of your own to polish!\r\nFeatures fastenings for turning polished rocks into jewelry\r\nHigh-quality, leak-proof design for exceptional rock tumbling experience\r\nIncludes tumbling machine, leak-proof tumbling barrel, bag of rough gemstones (250g), 4 bags of polishing grit (20g each), rock strainer, 5 jewelry settings\r\nDetailed learning guide and instructions included\r\nHigh durability for polishing rocks again and again",
                        Price = 65,
                        Category = "STEM",
                        ImageFileName = "images/stem/6.jpg"
                    },
                    new Toy
                    {
                        Name = "National Geographic Paper Making Craft Kit",
                        Description = "Kit for making paper out of bark-fiber pulp\r\nEncourages creativity, inspires an interest in science, engineering\r\nEasy, straightforward, step-by-step instructions\r\nUse food coloring to color your paper\r\nUse paint to turn your new paper into artwork\r\nLearn about recycling as you turn old paper into pulp to make new paper\r\nEverything kids need to make 10 sheets of craft paper\r\nIncludes 50g bark-fiber paper pulp, wooden silk-screen mold, silk mesh sheet, plastic tray, mixing container, sponge, wooden stir stick, food coloring (yellow, red, blue), palette, pipette, paintbrush, 6 tubes of paint (pink, red, green, blue, yellow, orange)\r\nKid-friendly instructions and learning guide included\r\nHigh-quality materials - Exceptional crafting experience",
                        Price = 27,
                        Category = "STEM",
                        ImageFileName = "images/stem/7.jpg"
                    },
                    new Toy
                    {
                        Name = "National Geographic Herb Garden Growing Kit",
                        Description = "Kit for growing basil, oregano, and chives from seed\r\nInspires an interest in botany, gardening, science\r\nFeatures paint, brushes, stickers for decorating planting pots\r\nSimple instructions make planting and growing easy and straightforward\r\nLearning guide teaches about the science of plant growth\r\nIncludes 3 stainless steel planting pots, seeds (basil, oregano, chive), 3 peat pellets, garden shovel, 3 wooden garden labels, 6 paints, 2 brushes, paint pallet, 30 nature-themed stickers\r\nKid-friendly instructions and illustrated learning guide included\r\nHigh-quality materials - Exceptional plant-growing experience",
                        Price = 31,
                        Category = "STEM",
                        ImageFileName = "images/stem/8.jpg"
                    },
                    new Toy
                    {
                        Name = "National Geographic Flower Garden Growing Kit",
                        Description = "Kit for growing zinnias, cosmos, and nasturtium from seed\r\nInspires an interest in botany, gardening, science\r\nFeatures paint, brushes, stickers for decorating planting pots\r\nSimple instructions make planting and growing easy and straightforward\r\nLearning guide teaches about the science of plant growth\r\nIncludes 3 stainless steel planting pots, seeds (cosmos, nasturtium, zinnias), 3 peat pellets, garden shovel, 3 wooden garden labels, 6 paints, 2 brushes, palette, 30 nature-themed stickers\r\nKid-friendly instructions and illustrated learning guide included\r\nHigh-quality materials - Exceptional plant-growing experience",
                        Price = 32,
                        Category = "STEM",
                        ImageFileName = "images/stem/9.jpg"
                    },
                    new Toy
                    {
                        Name = "Worm Farm",
                        Description = "Habitat for keeping and observing worms\r\nEncourages scientific exploration and discovery\r\nEverything you need to create the perfect habitat\r\nObserve the secret underground lives of worms!\r\nDoubles as a mini garden - Grow plants for the worms to eat! (plant seeds not included)\r\nLearn how worms help plants grow, their role in planet management\r\nIncludes worm farm moldings (front, back, sides, flag, lid, base), themed scenery stickers, worm privacy sliders, pipette and tweezers, 2 bags of colored sand, 2 plugs\r\nDetailed instruction booklet included\r\nWorms not included - Worms can be collected from your own backyard\r\nHigh-quality materials and construction",
                        Price = 20,
                        Category = "STEM",
                        ImageFileName = "images/stem/10.jpg"
                    },
                    new Toy
                    {
                        Name = "TV Time 90s Shows - 1000pc Puzzle",
                        Description = "Advanced jigsaw puzzle featuring stills from all your favorite 90s TV shows\r\nChallenge your spatial reasoning, logic, problem-solving, and critical thinking skills\r\nBright colors, vivid details - a fun, straightforward puzzle-solving experience\r\nIncludes 1000-piece puzzle, sturdy storage box\r\nFinished puzzle measures 19.25 x 26.75 inches\r\nChipboard used in puzzle is made of recycled material\r\nHigh-quality materials and construction - Exceptional jigsaw puzzle experience",
                        Price = 17,
                        Category = "Puzzles",
                        ImageFileName = "images/puzzles/1.jpg"
                    },
                    new Toy
                    {
                        Name = "Meffert's Maltese Gear",
                        Description = "Gear-based puzzle cube shaped like a Maltese cross\r\nEncourages spatial reasoning, logic, problem-solving, critical thinking\r\nCube made up of gears that spin together\r\nFeatures hollow corners that let you see straight through it\r\nTwist and turn to mix it up, then twist and turn to solve it!\r\nIncludes one Maltese Gear\r\nMeasures 2.4 x 2.4 x 2.4 inches\r\nHigh-quality materials and construction - Exceptional puzzle cube experience",
                        Price = 27,
                        Category = "Puzzles",
                        ImageFileName = "images/puzzles/2.jpg"
                    },
                    new Toy
                    {
                        Name = "Grecian Computer",
                        Description = "Dial-based brainteaser challenge\r\nEncourages math skills, problem-solving, critical thinking, logic\r\nTurn the dials to make each column add up to 42\r\nDifficulty level of 5 out of 5\r\nIncludes one Grecian Computer puzzle\r\nMeasures 6.5 x 6.93 x 2.36 inches\r\nHigh-quality wood construction - Exceptional gameplay",
                        Price = 15,
                        Category = "Puzzles",
                        ImageFileName = "images/puzzles/3.jpg"
                    },
                    new Toy
                    {
                        Name = "Caesar's Codex",
                        Description = "Ancient Rome themed brainteaser challenge\r\nEncourages logic, critical thinking, problem-solving, pattern recognition\r\nFigure out how the printed symbols interact to give you the code that unlocks the box\r\nOnce solved, becomes a cool place to store cherished treasures\r\nDifficulty level 4 out of 5\r\nIncludes one Caesar's Codex puzzle\r\nMeasures 6.69 x 6.1 x 2.12 inches\r\nMade entirely of solid wood",
                        Price = 16,
                        Category = "Puzzles",
                        ImageFileName = "images/puzzles/4.jpg"
                    },
                    new Toy
                    {
                        Name = "Constantin Puzzles C'est La Vie",
                        Description = "Wooden maze brainteaser puzzle\r\nEncourages spatial reasoning, logic, problem-solving, critical thinking\r\nRemove the metal ring by following the notches in the maze\r\nCreated by famed puzzle inventor Jean Claude Constantin\r\nLevel 4 out of 5 difficulty\r\nIncludes one C'est La Vie puzzle\r\nMeasures 6 x 1.5 x 6 inches\r\nHigh-quality solid wood and metal",
                        Price = 20,
                        Category = "Puzzles",
                        ImageFileName = "images/puzzles/5.jpg"
                    },
                    new Toy
                    {
                        Name = "Gradient Puzzle Large - Pink Yellow Orange",
                        Description = "Design-less jigsaw puzzle with color that fades from pink to yellow\r\nEncourages spatial reasoning, color-discernment skills, problem-solving, critical thinking\r\nA unique jigsaw puzzle challenge\r\nMade with thick-stock, high-quality art paper\r\nIncludes one 1000-piece gradient puzzle\r\nPackaged in sturdy storage box\r\nFinished puzzle measures 20 x 28 inches\r\nGlossy art paper over 2mm chipboard\r\nHigh-quality materials and construction - Lasting durability",
                        Price = 35,
                        Category = "Puzzles",
                        ImageFileName = "images/puzzles/6.jpg"
                    },
                    new Toy
                    {
                        Name = "Flashbacks Let The Good Times Roll 1000 pc Puzzle",
                        Description = "1000-piece puzzle featuring collage of classic toys\r\nEncourages spatial reasoning, problem-solving, critical thinking\r\nVibrant colors, vivid pictures for a straightforward puzzle-solving experience\r\nIncludes one 1000-piece puzzle\r\nFinished puzzle measures 19.25 x 26.75 inches\r\nRandom cut pieces\r\nPuzzle board made of recycled materials\r\nHigh-quality construction for a tight, interlocking fit",
                        Price = 17,
                        Category = "Puzzles",
                        ImageFileName = "images/puzzles/7.jpg"
                    },
                    new Toy
                    {
                        Name = "Ridley's Donut Lover's Jigsaw Puzzle 1000 pc",
                        Description = "1000-piece jigsaw puzzle featuring illustrations of 55 delicious-looking donuts\r\nEncourages fine motor skills, spatial reasoning, problem-solving, critical thinking\r\nEach donut is vibrantly illustrated, clearly labeled\r\nFinished puzzle can be easily framed in a standard 22x28-inch frame (not included)\r\nIncludes 1000-piece puzzle, sturdy cylinder storage container\r\nFinished puzzle measures 27.5 x 21.6 inches\r\nHigh-quality materials - Exceptional jigsaw-puzzle experience",
                        Price = 20,
                        Category = "Puzzles",
                        ImageFileName = "images/puzzles/8.jpg"
                    },
                    new Toy
                    {
                        Name = "1000 Piece Family Puzzle - Cool Cats AZ",
                        Description = "Adorable puzzle featuring a vibrant variety of cats in alphabetical order\r\nEncourages fine motor skills, spatial reasoning, critical thinking, problem-solving\r\nFeatures adorable cats big, small, short-haired, fluffy\r\nDesigned by Carolyn Gavin\r\nIncludes one 1000-piece puzzle, packaged in sturdy storage box\r\nFinished puzzle measures 27 x 20 inches\r\nPuzzle greyboard contains 90% recycled paper\r\nPackaging contains 70% recycled paper\r\nPrinted with nontoxic inks\r\nHigh-quality construction - Lasting durability, exceptional jigsaw-puzzle experience",
                        Price = 9,
                        Category = "Puzzles",
                        ImageFileName = "images/puzzles/9.jpg"
                    },
                    new Toy
                    {
                        Name = "Owls and Birds Gallery Puzzle - 1000pcs",
                        Description = "Large, amazingly detailed forest-themed jigsaw puzzle\r\nEncourages spatial reasoning, logic, problem-solving, critical thinking\r\nFinished puzzle is a mesmerizing work of art to admire!\r\nFeatures matching poster to use as template or to hang as a work of art\r\nIncludes 1000 puzzle pieces, poster, sturdy storage box\r\nFinished puzzle measures 36 x 12 inches\r\nHigh-quality materials - Exceptional jigsaw puzzle experience",
                        Price = 20,
                        Category = "Puzzles",
                        ImageFileName = "images/puzzles/10.jpg"
                    },
                    new Toy
                    {
                        Name = "National Geographic Power Rocket",
                        Description = "Rechargeable, reusable propeller-powered rocket\r\nEncourages STEM learning, outdoor play, active play\r\nPropeller spins to send the rocket soaring\r\nRocket opens to become a propeller itself for a safe, smooth landing\r\nPress the button to set it to one of 3 different launch heights\r\nFlies up to 200 feet into the air!\r\nUp to 20 launches on a single charge\r\nLearning guide teaches about science of flight, aerodynamics, and space\r\nIncludes power rocket with rechargeable battery, rocket launch pad, charging cable, set of decal stickers\r\nDetailed instructions and learning guide included\r\nHigh-quality materials and construction - Exceptional learning experience",
                        Price = 41,
                        Category = "Outdoors",
                        ImageFileName = "images/outdoors/1.jpg"
                    },
                    new Toy
                    {
                        Name = "Slackers Ninja Rope Ladder - 8 Foot",
                        Description = "Accessory ladder for Ninjaline obstacle course\r\nBuilds coordination, balance, and strength\r\nFor ages 5-10\r\nWeight limit: 175 lbs max\r\nKit Includes: Durable and UV resistant rope with solid wood rungs",
                        Price = 30,
                        Category = "Outdoors",
                        ImageFileName = "images/outdoors/2.jpg"
                    },
                    new Toy
                    {
                        Name = "Flame Bow & Arrows Set with Bulls Eye",
                        Description = "Bow and arrow set for practicing archery skills\r\nEncourages active play, outdoor play, dexterity, hand-eye coordination\r\nGet outside and practice your skills shooting various targets!\r\nTwo Bros Bows were created by kid inventors Duncan and Hayden when they were 10 and 7\r\nPackaging is made from recycled materials, and is completely recyclable\r\nBow is pre-strung with rubber-capped ends\r\nArrows are made of wooden shaft tipped with safe foam, covered in fabric matching the bow\r\nA grow-with-me skill toy, add challenges as your skills increase\r\nLarge enough for teens and grown-ups, too!\r\nIncludes: one pre-strung Flame-patterned bow with red and orange flames on black with foam grip, two soft-tipped arrows with a Flame pattern, target\r\nMade in the USA",
                        Price = 35,
                        Category = "Outdoors",
                        ImageFileName = "images/outdoors/3.jpg"
                    },
                    new Toy
                    {
                        Name = "Capture the Flag REDUX",
                        Description = "Glow-in-the-dark version of the classic game of capture the flag\r\nEncourages coordination, outdoor play, active play, group play\r\nGlowing game pieces for a thrillingly futuristic experience\r\nFeatures 6 game variations, plus 6 all new games to try\r\nAccommodates anywhere from 4 to 20 players\r\nIncludes 10 LED glow bracelets, 8 jail markers, 5 territory lights, 2 orbs (to use as the \"flag\")\r\nDetailed game rules and instructions included\r\nBatteries are included and replaceable\r\nEach bracelet uses two CR1220 watch batteries\r\nExceptionally durable - Built to be dropped, stepped on",
                        Price = 50,
                        Category = "Outdoors",
                        ImageFileName = "images/outdoors/4.jpg"
                    },
                    new Toy
                    {
                        Name = "SuperSize 3-D Nylon Kite - Dragon",
                        Description = "Large nylon kite designed to look like a 3D dragon\r\nEncourages outdoor play, coordination, exercise\r\nBecome a dragon tamer!\r\nFeatures ripstop fabric, skytails, line with large handle\r\nIllustrated instructions make assembling kite easy\r\nStep-by-step instructions make flying kite easy, too!\r\nIncludes 3D Dragon Kite, 170-foot line with handle\r\nHigh quality nylon materials, strong design\r\nBuilt for lasting durability, exceptional flying experience\r\n",
                        Price = 36,
                        Category = "Outdoors",
                        ImageFileName = "images/outdoors/5.jpg"
                    },
                    new Toy
                    {
                        Name = "4FUN Lawn Skee",
                        Description = "Lawn game version of the classic skee ball\r\nEncourages gross motor skills, coordination, outdoor play, active play\r\n7-foot ramp secures to ground with stakes, features adjustable ramp stand\r\nRamp rolls up for easy storage in the included storage bag\r\nArrange the 3 rings any way you want\r\nLaunch the balls off the ramp to land in one of the rings\r\nFirst player or team to score 100 points wins the game!\r\nIncludes 7-foot ramp, 6 foam balls, 3 multi-colored scoring rings, zip-up storage bag\r\nAll you need is a grassy area with at least 15 feet of space!\r\nHigh-quality materials and construction - Lasting durability, year after year",
                        Price = 62,
                        Category = "Outdoors",
                        ImageFileName = "images/outdoors/6.jpg"
                    },
                    new Toy
                    {
                        Name = "Solar Balloon",
                        Description = "Balloon that floats when heated by the sun\r\nEncourages scientific learning, a mesmerized science class\r\nChildren see the wonders of science first-hand, not just from a textbook\r\nGreat for science class demonstrations\r\nMesmerize judges at science fair\r\nDemonstrates buoyancy, convection, thermodynamics, solar power\r\nTeaches Bernoullis Principle, Pascals Principle\r\nFlies as high as a rooftop! - Tethered by a string\r\nTakes 1 to 2 hours for full flight\r\nIncludes 50 x 2.5 foot solar balloon, 400 feet of string\r\nDetailed instructions and scientific learning guide included\r\nDurable materials for sure flight every time\r\nMade in the U.S.A.",
                        Price = 20,
                        Category = "Outdoors",
                        ImageFileName = "images/outdoors/7.jpg"
                    },
                    new Toy
                    {
                        Name = "Djubi ParaShoot",
                        Description = "Slingshot launcher with ball that automatically releases a parachute\r\nEncourages gross motor skills, coordination, active play, outdoor play\r\nFuturistic ring-shaped launcher launches ball up to 80 feet into the air\r\nTimer built into ball launches parachute at the peak of its flight\r\nRun, catch the ball, and do it all over again!\r\nIncludes Djubi launcher, ParaShoot ball\r\nHigh-quality materials and construction - Lasting durability",
                        Price = 17,
                        Category = "Outdoors",
                        ImageFileName = "images/outdoors/8.jpg"
                    },
                    new Toy
                    {
                        Name = "Huckleberry Sand Tools",
                        Description = "Set of 3 bamboo sand-sculpting tools\r\nEncourages spatial reasoning, creativity, planning, problem-solving\r\nSmoothing tool features straight side and 2 curved sides - convex and concave\r\nTexture tool features 3 textures - big stairsteps, small stairsteps, wavy\r\nUse the brush to clean away excess debris\r\nIncludes smoothing tool, texture tool, brush\r\nHigh-quality bamboo",
                        Price = 16,
                        Category = "Outdoors",
                        ImageFileName = "images/outdoors/9.jpg"
                    },
                    new Toy
                    {
                        Name = "Wicked Big Sports Basket Heads",
                        Description = "Hilarious game of tossing balls into baskets\r\nEncourages gross motor skills, coordination, active play, cooperative play\r\nOne player on each team straps inflatable basket to their head\r\nPlayers try to toss balls into their teammate's basket\r\nFirst team to get all of their balls into their basket wins!\r\nGreat for backyard parties, team building\r\nIncludes 2 inflatable baskets with straps, 8 balls\r\nDetailed game rules and instructions included\r\nQuality materials and construction - Exceptional gameplay",
                        Price = 18,
                        Category = "Outdoors",
                        ImageFileName = "images/outdoors/10.jpg"
                    }


                );
                context.SaveChanges();
            }
        }
    }
}
