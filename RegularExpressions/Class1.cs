using System.Text.RegularExpressions;

namespace RegularExpressions
{
    public class Class1
    {
        static void Main(string[] args)
        {
            string Identifier = @"^[A-Za-z_][A-Za-z0-9_]*$"; //begins with a letter or underscore
            string ReservedWords = @"^(var| val| fun| class| if|else| while| for | in| return| true|false| null|new| print| input| break| continue)$";
            // all reserved words in Rynix
            string DataTypes =@"^(int|float|string|bool|char|array)$";

            string integer = @"^-?\d+$";
            string floating_point = @"^-?\d+.\d+$";

            string Boolean = @"^(true|false|null)$";

            string stringRegex = @"^""[\w\W]*""$";
            string Character = @"^'[\w\W]'$";

            string singleLineCommentRegex = @"^//.*$";
            string multiLineCommentRegex = @"^/\*[\s\S]*?\*/$";

            string operators = @"^[+|-|*|%]+$";

            // var name: Type = value
            string variableDeclaration = @"^var\s+[a-zA-Z_][a-zA-Z0-9_]*\s*:\s*(int|float|string|bool|char|Array<\w+>)\s*=\s*.+$";

            Console.WriteLine(Regex.IsMatch("studentName", Identifier));
            Console.WriteLine(Regex.IsMatch("1user", Identifier));
            Console.WriteLine(Regex.IsMatch("var", ReservedWords));
            Console.WriteLine(Regex.IsMatch("int", DataTypes));
            Console.WriteLine(Regex.IsMatch("15.75", floating_point));
            Console.WriteLine(Regex.IsMatch("-5", integer));
            Console.WriteLine(Regex.IsMatch("true", Boolean));
            Console.WriteLine(Regex.IsMatch("\"Hello Rynix\"", stringRegex));
            Console.WriteLine(Regex.IsMatch("'A'", Character));
            Console.WriteLine(Regex.IsMatch("// Store age", singleLineCommentRegex));
            Console.WriteLine(Regex.IsMatch("/*comment*/", multiLineCommentRegex));
            Console.WriteLine(Regex.IsMatch("+", operators));
            Console.WriteLine(Regex.IsMatch("var length :int =50 ", variableDeclaration));




        }
    }
}
