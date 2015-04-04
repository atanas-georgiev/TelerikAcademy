namespace MyTunesShop
{
    using System;
    using System.Collections.Generic;

    public class Band : Performer, IBand
    {
        private List<string> members;

        public Band(string name)
            : base(name)
        {
            this.members = new List<string>();
        }

        public override PerformerType Type
        {
            get
            {
                return PerformerType.Band;
            }
        }

        public IList<string> Members
        {
            get { return this.members; }
        }

        public void AddMember(string memberName)
        {
            if (string.IsNullOrWhiteSpace(memberName))
            {
                throw new ArgumentException("Name of member is required.");
            }

            this.members.Add(memberName);
        }
    }
}