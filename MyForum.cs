namespace ConsoleForum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MyForum : Forum
    {
        public MyForum()
            : base() 
        { 
        }

        public override void Run()
        {
            base.Run();
        }

        protected override void Setup()
        {            
        }

        protected override void ExecuteCommandLoop()
        {
            base.ExecuteCommandLoop();
        }
    }
}
