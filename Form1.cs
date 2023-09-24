using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatpro
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> knowledgeBase;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string defaultMsg= richTextBox1.Text;
            
            string msg = tb3.Text;
            tb3.Clear();
            richTextBox1.Text = defaultMsg + $"You: {msg}\n";
            //tb1.AppendText($"You: {msg}\n");
            defaultMsg = richTextBox1.Text;
            string response = SimulateChatbotResponse(msg);
            richTextBox1.Text = defaultMsg +"\n"+ $"Chatbot: {response}\n";
            //tb1.AppendText($"Chatbot: {response}\n");

           
        }
        private string SimulateChatbotResponse(string message)
        {
            // Replace this with your chatbot's response logic
            if (knowledgeBase.ContainsKey(message))
            {
                string value= knowledgeBase[message];
                return value;
            }
            else
            {
                return "not found";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            knowledgeBase = new Dictionary<string, string>
        {
            { "What is your name?", "I am Chatbot, here to assist you!" },
            { "Hi","Hello there!How can I help you?" },
            { "Hello","Hello there!How can I help you?" },
            { "What is the admission age?", "Children aged 3 to 5 are eligible for admission." },
            { "What documents are required?", "You will need to provide a birth certificate and proof of address." },
            { "What are the admission fees?", "Admission fees depend on your location. Please visit our website for details." },
            { "Is financial aid available?", "Yes, we offer financial aid for qualified families. Please contact our admissions office for more information." },
            { "What is the admission process?", "The admission process includes filling out an application, attending an interview, and providing the necessary documents." },
            { "Can my child start before turning 3?", "We only admit children who have reached the age of 3 by the start of the school year." },
            { "Can I schedule a tour?", "Yes, you can schedule a school tour by contacting our admissions office." },
            { "Default Response", "I'm sorry, I don't have information on that topic. Please contact our admissions office for more details." }
        
        //{ "What are the facilities providing here","Play" }
            // Add more questions and answers here
        };
        }
    }
}
