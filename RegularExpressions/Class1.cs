using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace RegularExpressions
{
    public class Class1
    {
        static void Main(string[] args)
        {
            string Identifier = @"^[A-Za-z_][A-Za-z0-9_]*$"; //begins with a letter or underscore
            string ReservedWords = @"^(var| val| fun| class| if|else| while| for | in| return| true|false| null|new| print| input| break| continue)$";
            // all reserved words in Rynix
            string DataTypes =@"^(Int|Float|String|Bool|Char|Array)$";

            string integer = @"^-?\d+$";
            string floating_point = @"^-?\d+.\d+$";

            string Boolean = @"^(true|false|null)$";

            string stringRegex = @"^""[\w\W]*""$";
            string Character = @"^'[\w\W]'$";

            string singleLineCommentRegex = @"^//.*$";
            string multiLineCommentRegex = @"^/\*[\s\S]*?\*/$";

            string operators = @"^[+|-|*|%]+$";

            // var name: Type = value
            string variableDeclaration = @"^var\s+[a-zA-Z_][a-zA-Z0-9_]*\s*:\s*(Int|Float|String|Bool|Char|Array<\w+>)\s*=\s*.+$";
            //val name :Type =value
            string ConstantsDeclaration = @"^val\s+[a-zA-Z_][a-zA-Z0-9_]*\s*:\s*(Int|Float|String|Bool|Char)\s*=\s*.+$";
            //x=y 
            string assignmentRegex = @"^[a-zA-Z_][a-zA-Z0-9_]*\s*=\s*.+$";
            //if x>y { }
            string Ifstatement = @"^if\s+.+\s*\{[\s\S]*\}$";
            //if x>y { } else {  }
            string IfElsestatement = @"^if\s+.+\s*\{[\s\S]*\}\s*else\s*\{[\s\S]*\}$";
            //while x = true { }
            string whileLoop = @"^while\s+.+\s*\{[\s\S]*\}$";
            //for i in 1..10 { print i}
            string forloop = @"^for\s+[a-zA-Z_][a-zA-Z0-9_]*\s+in\s+.+\s*\{[\s\S]*\}$";
            // range pattern (1..10)
            string Range = @"\d+\.\.\d+$";

            string breakStatement = @"^\s*break\s*$";
            string continueStatement = @"^\s*continue\s*$";

            // Function Parameters & Return
            string parameters = @"\([^)]*\)";
            string returnType = @":\s*(Int|Float|String|Bool|Char|Array<\w+>)";
            string returnStatement = @"^\s*return\s+.+;?$";

            // fun name(params): Type { ... }
            string functionDefinition = @"^fun\s+[a-zA-Z_][a-zA-Z0-9_]*\s*\([^)]*\)\s*:\s*(Int|Float|String|Bool|Char|Array<\w+>)\s*\{[\s\S]*\}$";

           
            // name(arguments) ->
            string functionCall = @"^[a-zA-Z_][a-zA-Z0-9_]*\s*\([^)]*\)$";

            //var numbers: Array < Int > = [10, 20, 30]
            string arrayDeclaration = @"^var\s+[a-zA-Z_][a-zA-Z0-9_]*\s*:\s*Array<\w+>\s*=\s*\[[^\]]*\]$";

            // Array access
            string arrayAccess = @"^[a-zA-Z_][a-zA-Z0-9_]*\s*\[\d+\]$";
            //ba2y 7agten elarray looping we ellength of array mn elrynix programming language pdf
            //v ar size: Int = numbers.length
            string arraylength = @"^var\s+[a-zA-Z_][a-zA-Z0-9_]*\s*:\s*(Int|Float)\s*=\s*[a-zA-Z_][a-zA-Z0-9_]*\.length\s*$";
            // for item in numbers { print(item) }
            string arraylooping = @"^for\s+[a-zA-Z_][a-zA-Z0-9_]*\s+in\s+[a-zA-Z_][a-zA-Z0-9_]*\s*\{[\s\S]*\}$";
            // Class definition
            string classDefinition = @"^class\s+[a-zA-Z_][a-zA-Z0-9_]*\s*\{[\s\S]*\}$";

            // var student: Student = new Student()
            string objectCreation = @"^var\s+[a-zA-Z_][a-zA-Z0-9_]*\s*:\s*[a-zA-Z_][a-zA-Z0-9_]*\s*=\s*new\s+[a-zA-Z_][a-zA-Z0-9_]*\s*\([^)]*\)$";
            //ba2y object properties done mn elrynix programming language pdf
            
            string ObjectProperties = @"^[a-zA-Z_][a-zA-Z0-9_]*\.[a-zA-Z_][a-zA-Z0-9_]*\s*=\s*.+$";
            // Constructor 
            string constructor = @"^init\s*\([^)]*\)\s*\{[\s\S]*\}$";

            // Method inside class
            string methodRegex = @"^fun\s+[a-zA-Z_][a-zA-Z0-9_]*\s*\([^)]*\)\s*:\s*(Int|Float|String|Bool|Char|Void|Array<\w+>)\s*\{[\s\S]*\}$";

            // Input & Output
            string printCall = @"^print\s*\([^)]*\)$";
            string inputCall = @"^var\s+[a-zA-Z_][a-zA-Z0-9_]*\s*:\s*(Int|Float|String|Bool|Char|Array<\w+>)\s*=\s*input\s*\(\)$";
            //ba2y elscope of variables , null values ,and null checking mn elrynix programming language pdf

            string nullassignment = @"^(var|val)\s+[a-zA-Z_][a-zA-Z0-9_]*\s*:\s*(Int|Float|String|Bool|Char|Array<\w+>)\s*=\s*null\s*$";

            string nullcomparison = @"^[a-zA-Z_][a-zA-Z0-9_]*\s*(==|!=)\s*null\s*$";


            Console.WriteLine(Regex.IsMatch("studentName", Identifier));
            Console.WriteLine(Regex.IsMatch("1user", Identifier));
            Console.WriteLine(Regex.IsMatch("var", ReservedWords));
            Console.WriteLine(Regex.IsMatch("Int", DataTypes));
            Console.WriteLine(Regex.IsMatch("15.75", floating_point));
            Console.WriteLine(Regex.IsMatch("-5", integer));
            Console.WriteLine(Regex.IsMatch("true", Boolean));
            Console.WriteLine(Regex.IsMatch("\"Hello Rynix\"", stringRegex));
            Console.WriteLine(Regex.IsMatch("'A'", Character));
            Console.WriteLine(Regex.IsMatch("// Store age", singleLineCommentRegex));
            Console.WriteLine(Regex.IsMatch("/*comment*/", multiLineCommentRegex));
            Console.WriteLine(Regex.IsMatch("+", operators));
            Console.WriteLine(Regex.IsMatch("var length :Int =50 ", variableDeclaration));
            Console.WriteLine(Regex.IsMatch("val length :Int =50 ", ConstantsDeclaration));
            Console.WriteLine(Regex.IsMatch("length=50 ", assignmentRegex));
            Console.WriteLine(Regex.IsMatch("if length=50 { length ++;}", Ifstatement));
            Console.WriteLine(Regex.IsMatch("if length=50 { length ++;} else { length = 5; }", IfElsestatement));
            Console.WriteLine(Regex.IsMatch("while length=50 { length ++;}", whileLoop));
            Console.WriteLine(Regex.IsMatch("for i in 1..10 { length ++;}", forloop));
            Console.WriteLine(Regex.IsMatch("1..10", Range));
            Console.WriteLine(Regex.IsMatch("break", breakStatement));
            Console.WriteLine(Regex.IsMatch("continue", continueStatement));
            Console.WriteLine(Regex.IsMatch("(a: Int, b: Int)", parameters));
            Console.WriteLine(Regex.IsMatch(": Int", returnType));
            Console.WriteLine(Regex.IsMatch("return a * b", returnStatement));
            Console.WriteLine(Regex.IsMatch("fun multiply(a: Int, b: Int): Int {return a * b}", functionDefinition));
            Console.WriteLine(Regex.IsMatch("print(\"Hello\")", functionCall));
            Console.WriteLine(Regex.IsMatch("var names: Array<String> = [\"Ali\",\"Sara\",\"Omar\"]", arrayDeclaration));
            Console.WriteLine(Regex.IsMatch("numbers[0]", arrayAccess));
            Console.WriteLine(Regex.IsMatch("var size: Int = numbers.length", arraylength));
            Console.WriteLine(Regex.IsMatch("for item in numbers { print(item) }", arraylooping));
            Console.WriteLine(Regex.IsMatch("class Student {var name: String var age: Int }", classDefinition));
            Console.WriteLine(Regex.IsMatch("var student : Student = new Student()", objectCreation)); 
            Console.WriteLine(Regex.IsMatch("student.name = \"Ahmed\"", ObjectProperties)); 
            Console.WriteLine(Regex.IsMatch("init(n: String, a: Int) {name = n age = a}", constructor)); 
            Console.WriteLine(Regex.IsMatch("fun display(): Void {print(name)}}}", methodRegex)); 
            Console.WriteLine(Regex.IsMatch("print(\"Hello Rynix\")", printCall)); 
            Console.WriteLine(Regex.IsMatch("var name: String = input()", inputCall));
            Console.WriteLine(Regex.IsMatch("var x : Int = null", nullassignment));
            Console.WriteLine(Regex.IsMatch("name == null", nullcomparison));

        }
    }
}
