using System.Collections.Generic;

namespace nMars.Parser
{
    public class ForRofContainerStatement : ContainerStatement
    {
        public ForRofContainerStatement(List<string> labels, string comment)
        {
            Labels = labels;
            Comment = comment;
        }

        public List<string> Labels;
        public string Comment;
    }
}