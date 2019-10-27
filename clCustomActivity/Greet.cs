using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.ComponentModel;

namespace clCustomActivity
{
    public class Greet : CodeActivity
    {
        [Category("Input")]
        public InArgument<string> FirstName { get; set; }

        [Category("Output")]
        public OutArgument<string> GreetingMessage { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            var firstName = FirstName.Get(context);
            GreetingMessage.Set(context, string.Format("Hi {0} Welcome to UiPath", firstName));
        }
    }
}
