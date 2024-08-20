using System;

namespace Comments
{
    class Program
    {
        /// XML Comments are used to help provide documentation
        /// They start with triple-slashes and have a special syntax
        /// <summary>
        /// This is the main sample application function
        /// </summary>
        /// <parm name="args"> An array of string arguments from the command line </parm>
        /// <return>
        /// No return value
        /// </return>
        static void Main(string[] args)
        {
            // Single line comment start with two slashes
            Console.WriteLine("Hello World!");
            /* Multiple line comments start with a slash and a star
            and can continue for several lines
            untile a closing star and slash are encountered*/
        }
    }
}

