using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiApplication
{
    internal class ChatEngine
    {
        private string userName = ""; 
        private string favouriteTopic = ""; 
        private string lastTopic = ""; 
        private Random rng = new Random();

        private Dictionary<string, List<string>> keywordResponses = new Dictionary<string, List<string>>();
        private List<string> worriedWords = new List<string>();
    }
}
