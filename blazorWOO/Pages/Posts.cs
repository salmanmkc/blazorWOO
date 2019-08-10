﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorWOO.Pages
{
    public class Posts
    {
        public List<post> posts = new List<post>();
        public Posts()
        {
            post OneSmallChange = new post("One Small Change","After telling my mother that I would be meeting the author(Rob Miles) of the C# 70-483 exam preparation book that I have been reading, she enquired whether or not I would be writing my own book. I honestly was taken a step back and second guessed myself. Would I have thought that I would be an author when I was 9 years old, perhaps, but that's when I took a major turn in my life? I used to love writing stories, conjuring up a whole new universe and having complete control over someone's thoughts, actions and consequences without any backlash; the possibilities are endless. Yet, at the same time, you know exactly what will happen by the end of the story, or you can let them be a surprise for yourself (I personally prefer the latter), letting the flow overtake your writing into its own abyss.", "/css/Assets/BlogImages/OneSmallChange/0.jfif", "I remember this one time in my primary school, Montpelier; we all had to write a book and marked by a deadline, we had to record the book. I got so indulged in writing the book (much like I do with programming today) that I never ended up recording the audio for it. My teacher would give feedback to my mother saying that she got annoyed that I had flute lessons because I always left the stories on cliffhangers (although sometimes I did this for dramatic effect). That thought makes me smile, to have a story that brings that effect onto someone. I miss that, I miss being in a world of creativity, being able to bring a change to someone's life. As I have gotten better at programming I have been able to incorporate that creativity back, as well as through different mediums such as photography and music.", "/css/Assets/BlogImages/OneSmallChange/1.png", "Upon meeting Rob, he told me that I should write my own blog, put myself out there, document anything that I find challenging, as there will be other people in the same situation as myself who will have the same problems, the same hurdles, the same or more or less similar. That point really got me. I tend to read a lot of documentation and guides online. I like taking the reading approach to a lot of things, and I get used to how to interpret that information, however not everyone understands that, and I can relate to how it used to be at the beginning. Whether it be reading Microsoft docs, bootstrap docs, reading textbooks, and I'm one of those who still loves reading. However, some of the time when starting something new I am a penguin in the Sahara desert, and it requires a lot of prerequisites. I'm pretty sure I'm not the only .net stack developer that prefers C# over JS, if I document my process then hopefully at least one person will be able to relate and follow along. At the same time it gives me a goal to attain to, for example, last Sunday I made 2 desktop applications, both small, and with one of them I decided to record a video documentary of my progress, the program was made to give me a notification on my desktop when sound levels get too high (I use audio interfaces which are put off to the side and I cannot see if my sound levels are too high unless I look to the side), the other one was just a type racing application since the website I use to test my typing speed has a server in the US, and my ping was substantially high enough to drastically make my typing speed seem lower than it really is, so I made a client-side application and added cool things like a progress bar. randomly generated texts, progress updates, which I can now use when I am travelling without an internet connection. Now, if this is something you're interested in seeing or reading about, stay tuned since I may be releasing this sort of thing too. At the same time, I have to juggle two jobs, but this is my hobby.", "/css/Assets/BlogImages/OneSmallChange/2.jfif", "This one small change to start writing helps me clear my mind, it helps me put myself into perspective, it helps me feel at ease with life and to keep myself grounded. The very process of releasing and expressions ones own emotions is known as catharsis. I recommend doing it yourself! My high school English teacher actually told me that I should start reading more non-fiction are opposed to fiction, which distanced me from the creativity side of English.. I had a diary which I started writing when I joined high school and slowly as English GCSE got closer, I started to hate English more and more, analysing Macbeth, analysing Of Mice and Men. Seriously, the fact that Curly's wife was standing at the door was supposed to signify that she was promiscuous? (Probably not, but things like this are scattered throughout the curriculum). Don't get me wrong, there's nothing wrong with reading this far into it, but for us as students to be graded based on how we interpret the meaning of a sentence or a word is utterly ridiculous in my opinion and deferred any chances of me pursuing a writing as a hobby or as a career.", "That moves me on to my next point. We need to stop caring about what other people think. Our value and self-worth are not decided by the views of other people, for all they could care about are of no importance to us either. Set your own goals, your own standards, and also keep your own judgements to yourself if you want others to do the same for you. I'm afraid there's no possible way to stop the influx of negativity that is projected by others onto us, let bygones be bygones. Instead, we have something better than that, the ability to control our own mindset and not let it affect us. I've encountered my fair share of bullying in my life, and the times where it has affected me the least is when I have ignored it and refused to pay attention to the matter and if serious enough, then report it. Bullies continue when they see they have an effect, it's a power trip for them. I like to take the moral high-ground and just not entertain their remarks. The main thing is the mindset. As Carol Dweck mentions in her book Mindset, your mindset is one of the most powerful things in the world. It can affect your well being, your relationships with others and even your education. If you think your ability is based off a test, and that your ability is static, then think again. If you think your IQ is a fixed measure of your intelligence, then think again. The psychologist Alfred Binet who co-created the IQ test himself believed that education and practice can bring fundamental changes to intelligence. I will leave you with a quote from his book Modern Ideas About Children:", "\"With practice, training, and above all, method, we manage to increase our attention, our memory, our judgement and literally to become more intelligent than we were before\" - Alfred Binet");
            posts.Add(OneSmallChange);
        }
    }
}
