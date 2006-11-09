using System.Collections.Generic;

namespace nMars.RedCode
{
    public interface IProject
    {
        Rules Rules { get; }
        IList<IWarrior> Warriors { get; }
        IList<int> ForcedAddresses { get; }
    }

    public class Project : IProject
    {
        public Project()
        {
        }

        public Project(Rules rules)
        {
            this.rules = rules;
        }

        private IList<IWarrior> warriors = new List<IWarrior>();
        private IList<int> forcedAddresses = null;
        private Rules rules = Rules.DefaultRules;

        public Rules Rules
        {
            get { return rules; }
            set { rules = value; }
        }

        public IList<IWarrior> Warriors
        {
            get { return warriors; }
        }

        public IList<int> ForcedAddresses
        {
            get { return forcedAddresses; }
            set { forcedAddresses = value; }
        }
    }
}