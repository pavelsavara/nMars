using com.calitha.goldparser.structure;

namespace com.calitha.goldparser.content
{
    /// <summary>
    /// The Parameter define miscellaneous parameters of the compiled grammar.
    /// </summary>
    public class Parameters
    {
        private string name;
        private string version;
        private string author;
        private string about;
        private bool caseSensitive;
        private int startSymbol;

        public Parameters(Record record)
        {
            if (record.Entries.Count != 7)
                throw new CGTContentException("Invalid number of entries for parameters");
            byte header = record.Entries[0].ToByteValue();
            if (header != 80) //'P'
                throw new CGTContentException("Invalid parameters header");
            name = record.Entries[1].ToStringValue();
            version = record.Entries[2].ToStringValue();
            author = record.Entries[3].ToStringValue();
            about = record.Entries[4].ToStringValue();
            caseSensitive = record.Entries[5].ToBoolValue();
            startSymbol = record.Entries[6].ToIntValue();
        }

        public string Name
        {
            get { return name; }
        }

        public string Version
        {
            get { return version; }
        }

        public string Author
        {
            get { return author; }
        }

        public string About
        {
            get { return about; }
        }

        public bool CaseSensitive
        {
            get { return caseSensitive; }
        }

        public int StartSymbol
        {
            get { return startSymbol; }
        }
    }
}