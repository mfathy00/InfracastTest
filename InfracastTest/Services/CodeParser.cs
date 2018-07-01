using System;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using InfracastTest.Interfaces;

namespace InfracastTest.Services
{
    public class CodeParser:ICodeParser
    {
        readonly string _code;

        public CodeParser()
        {
            string currentFile = new System.Diagnostics.StackTrace(true).GetFrame(0).GetFileName();
            _code = String.Empty;
            using (StreamReader read = File.OpenText(currentFile))
            {
                _code = read.ReadToEnd();
            }
        }
        public int GetTotalBlocks()
        {
            var openbrackets = _code.Count(x => x == '{');
            var closebrackets = _code.Count(x => x == '}');
            var totalBlocks = (openbrackets + closebrackets) / 2;
            return totalBlocks;
        }

        public int GetTotalStatments()
        {
            var totalStatments = _code.Count(x => x == ';');
            return totalStatments;
        }

        public int GetTotalExperession()
        {
            string pattern = @"[+\/-\/*\=(.*?)];$";
            var totalExperession = Regex.Matches(_code, pattern, RegexOptions.Multiline).Count;
            return totalExperession;
        }
    }
}
