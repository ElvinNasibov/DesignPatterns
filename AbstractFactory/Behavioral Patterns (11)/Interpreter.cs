using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{

    class Interpreter
    {

    }

    class Context
    {
        public char Vocabulary { get; set; }
        public string Source { get; set; }
        public bool Result { get; set; }
        public int Position { get; set; }
    }

    abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }

    class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            context.Result = 
                (context.Source[context.Position] == context.Vocabulary);
        }
    }

    class NonTerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            if (context.Position < context.Source.Length)
            {
                TerminalExpression expression = new TerminalExpression();
                expression.Interpret(context);
                context.Position++;

                if (context.Result)
                {
                    NonTerminalExpression nonTerminalExpression = new NonTerminalExpression();
                    nonTerminalExpression.Interpret(context);
                }
            }

        }
    }


    /*
    Console.WriteLine("--------------------------- Interpreteur");
    Context context = new Context
    {
    Vocabulary = 'a',
    Source = "aaa"
    };

    var expression = new NonTerminalExpression();
    expression.Interpret(context);
    Console.WriteLine(context.Result);

    Console.ReadKey();
    */

}
