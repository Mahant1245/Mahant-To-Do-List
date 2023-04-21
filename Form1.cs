using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace To_Do_List
{
    public partial class Form1 : Form
    {
        List<string> todo = new List<string>();
        List<string> completed = new List<string> ();
        string Todofilename = "todo.txt";
        string Completedfilename = "completed.txt";
        public Form1()
        {
            InitializeComponent();
            var readfile1 = File.ReadAllLines("todo.txt");//read the whole file
            todo=new List<string> (readfile1);//replace the todolist with whats saved in the text file
            
            //similar method for completed list
            var readfile2 = File.ReadAllLines("completed.txt");
            completed=new List<string> (readfile2);

            //load the list to the listbox when loaded
            TodoListbox.Items.Add(todo);
            CompletedItemListbox.Items.Add(completed);
        }

        private void AddTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            todo.Add(AddTextbox.Text);//adds to the list
            TodoListbox.Items.Add(AddTextbox.Text);//adds to the listbox
            AddTextbox.Clear();
            
            StreamWriter sw = new StreamWriter(Todofilename);//writes to the file
            sw.WriteLine(todo);
            sw.Close(); 
        }

        

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            TodoListbox.Items.Remove(RemoveTextbox.Text);//removes from the listbox
            todo.Remove(RemoveTextbox.Text);//removes from the list
            completed.Add(RemoveTextbox.Text);//adds to the completed list
            
            StreamWriter sw = new StreamWriter(Completedfilename);//adds to the completed
            sw.WriteLine(completed);
            sw.Close();
            
            CompletedItemListbox.Items.Add(RemoveTextbox.Text);//add the removed activity to completed textbox
            RemoveTextbox.Clear();
        }

        private void RemoveAllBtn_Click(object sender, EventArgs e)
        {
            

            string showtodo = string.Join("\n", todo);//joins the content of the whole list as a string
            CompletedItemListbox.Items.Add(showtodo);
            TodoListbox.Items.Clear();
            todo.Clear();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            //makes everything null
            todo.Clear();
            completed.Clear();
            TodoListbox.Items.Clear();
            CompletedItemListbox.Items.Clear();        
        }

        private void label6_Click(object sender, EventArgs e)
        {
          
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            File.WriteAllText("todo.txt", "");//replace evrything in the text file with ""

            //writes all the items in the list to file so when we close the program it is saved in the text file.
            StreamWriter sw = new StreamWriter(Todofilename);
            for (int i = 0; i < todo.Count; i++)
            {
                sw.WriteLine(todo[i]);
            }
            sw.Close();

            StreamWriter Sw = new StreamWriter(Completedfilename);
            for (int i = 0; i < todo.Count; i++)
            {
                Sw.WriteLine(completed[i]);
            }
            Sw.Close();

            Application.Exit();

        }
    }
}
       