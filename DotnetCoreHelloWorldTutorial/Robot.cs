using System;
using System.Collections.Generic;
namespace DotnetCoreHelloWorldTutorial
{
    public abstract class Robot
    {
        private readonly List<string> _laws = new List<string>
            {
                "A robot may not injure a human being or, through inaction, allow a human being to come to harm.",
                "A robot must obey the orders given it by human beings, except where such orders would conflict with the First Law.",
                "A robot must protect its own existence as long as such protection does not conflict with the First or Second Law."
            };

        protected Robot(Version version)
        {
            Version = version;
        }

        public abstract string Greeting();

        public Version Version { get; set; }

        public virtual List<string> GetLaws()
        {
            return _laws;
        }

        
    }

    public class Sonny : Robot
    {
        public Sonny(Version v) : base(v)
        {

        }
        public override string Greeting()
        {
            return "Hello, my name is Sonny";
        }

        public override List<string> GetLaws()
        {
            List<string> laws = base.GetLaws();
            laws.Add("A robot may not harm humanity, or, by inaction, allow humanity to come to harm");
            return laws;
        }
    }
}

