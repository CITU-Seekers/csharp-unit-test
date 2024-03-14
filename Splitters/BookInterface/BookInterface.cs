using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeChum
{
    public partial class BookInterface : Form
    {
        public BookInterface()
        {
            InitializeComponent();
        }

        private void BookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBook = bookListBox.SelectedItem.ToString();

            if (selectedBook == "Harry Potter and the Sorcerer's Stone")
            {
                chapterTextBox.Text = "Chapter 1: The Boy Who Lived\r\n\nMr. and Mrs. Dursley, of number four, Privet Drive, were\r\nproud to say that they were perfectly normal, thank\r\nyou very much. They were the last people you’d expect to be involved in anything strange or mysterious, because they just didn’t\r\nhold with such nonsense.\r\nMr. Dursley was the director of a firm called Grunnings, which\r\nmade drills. He was a big, beefy man with hardly any neck, although he did have a very large mustache. Mrs. Dursley was thin\r\nand blonde and had nearly twice the usual amount of neck, which\r\ncame in very useful as she spent so much of her time craning over\r\ngarden fences, spying on the neighbors. The Dursleys had a small\r\nson called Dudley and in their opinion there was no finer boy anywhere.\r\nThe Dursleys had everything they wanted, but they also had a\r\nsecret, and their greatest fear was that somebody would discover it.\r\nM";
            }
            else if (selectedBook == "Harry Potter and the Chamber of Secrets")
            {
                chapterTextBox.Text = "Chapter 1: The Worst Birthday\r\n\nNot for the first time, an argument had broken out over breakfast\r\nat number four, Privet Drive. Mr Vernon Dursley had been woken\r\nin the early hours of the morning by a loud, hooting noise from\r\nhis nephew Harry’s room.\r\n‘Third time this week!’ he roared across the table. ‘If you can’t\r\ncontrol that owl, it’ll have to go!’\r\nHarry tried, yet again, to explain.\r\n‘She’s bored,’ he said. ‘She’s used to flying around outside. If I\r\ncould just let her out at night ...’\r\n‘Do I look stupid?’ snarled Uncle Vernon, a bit of fried egg dangling from his bushy moustache. ‘I know what’ll happen if that\r\nowl’s let out.’\r\nHe exchanged dark looks with his wife, Petunia.\r\nHarry tried to argue back but his words were drowned by a\r\nlong, loud belch from the Dursleys’ son, Dudley.\r\n‘I want more bacon.’\r\n‘There’s more in the frying pan, sweetums,’ said Aunt Petunia,\r\nturning misty eyes on her massive son. ‘We must feed you up\r\nwhile we’ve got the chance ... I don’t like the sound of that school\r\nfood ...’\r\n‘Nonsense, Petunia, I never went hungry when I was at\r\nSmeltings,’ said Uncle Vernon heartily. ‘Dudley gets enough, don’t\r\nyou, son?’\r\nDudley, who was so large his bottom drooped over either side\r\nof the kitchen chair, grinned and turned to Harry.\r\n‘Pass the frying pan.’\r\n‘You’ve forgotten the magic word,’ said Harry irritably.\r\nThe effect of this simple sentence on the rest of the family was\r\nincredible: Dudley gasped and fell off his chair with a crash that\r\nshook the whole kitchen; Mrs Dursley gave a small scream and\r\n\r\nclapped her hands to her mouth; Mr Dursley jumped to his feet,\r\nveins throbbing in his temples.";
            }
            else if (selectedBook == "Harry Potter and the Prisoner of Azkaban")
            {
                chapterTextBox.Text = "Chapter 1: Owl Post\r\n\nHarry Potter was a highly unusual boy in many ways. For one\r\nthing, he hated the summer holidays more than any other time of\r\nyear. For another, he really wanted to do his homework, but was\r\nforced to do it in secret, in the dead of night. And he also happened to be a wizard.\r\nIt was nearly midnight, and he was lying on his front in bed,\r\nthe blankets drawn right over his head like a tent, a torch in one\r\nhand and a large leather-bound book (A History of Magic, by\r\nBathilda Bagshot) propped open against the pillow. Harry moved\r\nthe tip of his eagle-feather quill down the page, frowning as he\r\nlooked for something that would help him write his essay, ‘WitchBurning in the Fourteenth Century Was Completely Pointless –\r\ndiscuss’.\r\nThe quill paused at the top of a likely-looking paragraph. Harry\r\npushed his round glasses up his nose, moved his torch closer to\r\nthe book and read:\r\nNon-magic people (more commonly known as Muggles) were\r\nparticularly afraid of magic in medieval times, but not very\r\ngood at recognising it. On the rare occasion that they did catch\r\na real witch or wizard, burning had no effect whatsoever. The\r\nwitch or wizard would perform a basic Flame-Freezing Charm\r\nand then pretend to shriek with pain while enjoying a gentle,\r\ntickling sensation. Indeed, Wendelin the Weird enjoyed being\r\nburnt so much that she allowed herself to be caught no fewer\r\nthan forty-seven times in various disguises.\r\nHarry put his quill between his teeth and reached underneath his\r\npillow for his ink bottle and a roll of parchment. Slowly and very\r\ncarefully he unscrewed the ink bottle, dipped his quill into it and\r\nbegan to write, pausing every now and then to listen, because if\r\nany of the Dursleys heard the scratching of his quill on their way\r\nto the bathroom, he’d probably find himself locked in the cupboard under the stairs for the rest of the summer. ";
            }
            else if (selectedBook == "The Sword of Summer")
            {
                chapterTextBox.Text = "Chapter 1: Good Morning! You’re Going to Die\r\n\nYEAH, I KNOW. You guys are going to read about how I died in agony, and you’re going be like, “Wow! That sounds cool, Magnus! Can I die in agony too?”\r\n\r\nNo. Just no.\r\n\r\nDon’t go jumping off any rooftops. Don’t run into the highway or set yourself on fire. It doesn’t work that way. You will not end up where I ended up.\r\n\r\nBesides, you wouldn’t want to deal with my situation. Unless you’ve got some crazy desire to see undead warriors hacking one another to pieces, swords flying up giants’ noses, and dark elves in snappy outfits, you shouldn’t even think about finding the wolf-headed doors.\r\n\r\nMy name is Magnus Chase. I’m sixteen years old. This is the story of how my life went downhill after I got myself killed.";
            }
            else if (selectedBook == "The Lightning Thief")
            {
                chapterTextBox.Text = "Chapter 1: I Accidentally Vaporize My Pre-Algebra Teacher\r\n\nLook, I didn’t want to be a half-blood.\r\nIf you’re reading this because you think you might be one, my advice is: close this book right now. Believe whatever lie your mom or dad told you about your birth, and try to lead a normal life.\r\nBeing a half-blood is dangerous. It’s scary. Most of the time, it gets you killed in painful, nasty ways.\r\nIf you’re a normal kid, reading this because you think it’s fiction, great. Read on. I envy you for being able to believe that none of this ever happened.\r\nBut if you recognize yourself in these pages—if you feel something stirring inside—stop reading immediately. You might be one of us. And once you know that, it’s only a matter of time before they sense it too, and they’ll come for you.\r\nDon’t say I didn’t warn you.My name is Percy Jackson.\r\nI'm twelve years old. Until a few months ago, I was a boarding\r\nstudent at Yancy Academy, a private school for troubled kids in\r\nupstate New York.\r\nAm I a troubled kid?\r\nYeah. You could say that.\r\nI could start at any point in my short miserable life to prove it, but\r\nthings really started going bad last May, when our sixth-grade\r\nclass took a field trip to Manhattan-twenty-eight mental-case kids\r\nand two teachers on a yellow school bus, heading to the\r\nMetropolitan Museum of Art to look at ancient Greek and Roman\r\nstuff.\r\nI know-it sounds like torture. Most Yancy field trips were.\r\nBut Mr. Brunner, our Latin teacher, was leading this trip, so I had\r\nhopes.\r\nMr. Brunner was this middle-aged guy in a motorized wheelchair.\r\nHe had thinning hair and a scruffy beard and a frayed tweed\r\njacket, which always smelled like coffee. You wouldn't think he'd\r\nbe cool, but he told stories and jokes and let us play games in\r\nclass. He also had this awesome collection of Roman armor and\r\nweapons, so he was the only teacher whose class didn't put me to\r\nsleep.\r\nI hoped the trip would be okay. At least, I hoped that for once I\r\nwouldn't get in trouble.\r\nBoy, was I wrong.";
            }
            else if (selectedBook == "The Maze Runner")
            {
                chapterTextBox.Text = "Chapter 1: Greenie\r\n\nHe began his new life standing up, surrounded by cold darkness and stale, dusty air.\r\nMetal ground against metal; a lurching shudder shook the floor beneath him. He fell down at the sudden movement and shuffled backward on his hands and feet, drops of sweat beading on his forehead despite the cool air. His back struck a hard metal wall; he slid along it until he hit the corner of the room. Sinking to the floor, he pulled his legs up tight against his body, hoping his eyes would soon adjust to the darkness.\r\n\r\nWith another jolt, the room jerked upward like an old lift in a mine shaft.\r\nHarsh sounds of chains and pulleys, like the workings of an ancient steel factory, echoed through the room, bouncing off the walls with a hollow, tinny whine. The lightless elevator swayed back and forth as it ascended, turning the boy’s stomach sour with nausea; a smell like burnt oil invaded his senses, making him feel worse. He wanted to cry, but no tears came; he could only sit there, alone, waiting.\r\n\r\nMy name is Thomas, he thought.\r\nThat… that was the only thing he could remember about his life.";
            }
            else if (selectedBook == "The Hunger Games")
            {
                chapterTextBox.Text = "Chapter 1: The Hunger Games\r\n\r\nWhen I wake up, the other side of the bed is cold. My fingers stretch out, seeking Prim’s warmth but finding only the rough canvas cover of the mattress. She must have had bad dreams and climbed in with our mother. Of course, she did. This is the day of the reaping.\r\n\r\nI prop myself up on one elbow. There’s enough light in the bedroom to see them. My little sister, Prim, curled up on her side, cocooned in my mother’s body, their cheeks pressed together. In sleep, my mother looks younger, still worn but not so beaten-down. Prim’s face is as fresh as a raindrop, as lovely as the primrose for which she was named. My mother was very beautiful once, too. Or so they tell me.\r\n\r\nSitting at Prim’s knees, guarding her, is the world’s ugliest cat. Mashed-in nose, half of one ear missing, eyes the color of rotting squash. Prim named him Buttercup, insisting that his muddy yellow coat matched the bright flower. He hates me. Or at least distrusts me. Even though it was years ago, I think he still remembers how I tried to drown him in a bucket when Prim brought him home. Scrawny kitten, belly swollen with worms, crawling with fleas. The last thing I needed was another mouth to feed. But Prim begged so hard, cried even, I had to let him stay. It turned out okay. My mother got rid of the vermin and he’s a born mouser. Even catches the occasional rat. Sometimes, when I clean a kill, I feed Buttercup the entrails. He has stopped hissing at me.\r\n\r\nEntrails. No hissing. This is the closest we will ever come to love.";
            }


        }

        private void cboBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (booksComboBox.SelectedItem.ToString() == "Harry Potter")
            {
                bookListBox.Items.Clear();
                bookListBox.Items.Add("Harry Potter and the Sorcerer's Stone");
                bookListBox.Items.Add("Harry Potter and the Chamber of Secrets");
                bookListBox.Items.Add("Harry Potter and the Prisoner of Azkaban");
                bookListBox.Items.Add("Harry Potter and the Goblet of Fire");
                bookListBox.Items.Add("Harry Potter and the Order of the Phoenix");
                bookListBox.Items.Add("Harry Potter and the Half-Blood Prince");
                bookListBox.Items.Add("Harry Potter and the Deathly Hallows");
            }
            else if (booksComboBox.SelectedItem.ToString() == "Magnus Chase")
            {
                bookListBox.Items.Clear();
                bookListBox.Items.Add("The Sword of Summer");
                bookListBox.Items.Add("The Hammer of Thor");
                bookListBox.Items.Add("The Ship of the Dead");
            }
            else if (booksComboBox.SelectedItem.ToString() == "Percy Jackson")
            {
                bookListBox.Items.Clear();
                bookListBox.Items.Add("The Lightning Thief");
                bookListBox.Items.Add("The Sea of Monsters");
                bookListBox.Items.Add("The Titan's Curse");
                bookListBox.Items.Add("The Battle of the Labyrinth");
                bookListBox.Items.Add("The Last Olympian");
            }
            else if (booksComboBox.SelectedItem.ToString() == "The Maze Runner")
            {
                bookListBox.Items.Clear();
                bookListBox.Items.Add("The Maze Runner");
                bookListBox.Items.Add("The Scorch Trials");
                bookListBox.Items.Add("The Death Cure");
                bookListBox.Items.Add("The Kill Order");
                bookListBox.Items.Add("The Fever Code");
            }
            else if (booksComboBox.SelectedItem.ToString() == "The Hunger Games")
            {
                bookListBox.Items.Clear();
                bookListBox.Items.Add("The Hunger Games");
                bookListBox.Items.Add("Catching Fire");
                bookListBox.Items.Add("Mockingjay");
            }
        }
    }
}
