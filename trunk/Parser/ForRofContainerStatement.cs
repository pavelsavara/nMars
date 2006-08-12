using System;
using System.Collections.Generic;
using System.Text;

namespace nMars.Parser
{
    public class ForRofContainerStatement : Statement
    {
        public ForRofContainerStatement (string label, string comment)
        {
            Label = label;
            Comment = comment;
        }

        public void Add(ContainerStatement container)
        {
            if (container != null)
                Container = container;
        }
        public ContainerStatement Container;
        public string Label;
        public string Comment;
    }
}
