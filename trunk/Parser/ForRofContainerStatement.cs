using System.Collections.Generic;

namespace nMars.Parser
{
    public class ForRofContainerStatement : Statement
    {
        public ForRofContainerStatement(List<string> labels, string comment)
        {
            Labels = labels;
            Comment = comment;
        }

        public void Add(ContainerStatement container)
        {
            if (container != null)
                Container = container;
        }

        public ContainerStatement Container;
        public List<string> Labels;
        public string Comment;
    }
}