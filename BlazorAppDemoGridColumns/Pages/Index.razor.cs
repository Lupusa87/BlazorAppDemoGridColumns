using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppDemoGridColumns.Pages
{
    public partial class Index
    {

        List<Column> columnsList = new List<Column>();


        int SelectedIndex=0;



        protected override void OnInitialized()
        {

            for (int i = 0; i < 8; i++)
            {
                columnsList.Add(new Column() { id = i, Name = "Col " + (i + 1) });
            }


            base.OnInitialized();
        }


        private void onSelect(int i)
        {
            Console.WriteLine(i);
            SelectedIndex = i;
        }

        private void AddRemoveColumn()
        {
            columnsList[SelectedIndex].IsShown = !columnsList[SelectedIndex].IsShown;
        }


        private string GetStyle(int i)
        {
            string result = "margin:5px;margin-left:15px;cursor:pointer;";


            if (columnsList[i].IsShown)
            {
                result += "color:blue;";
            }
            else
            {
                result += "color:green;";

            }


            if (i== SelectedIndex)
            {
                return result +="background:lightgray";
            }
            else
            {
                return result;
            }
        }
    }



    public class Column
    {
        public int id { get; set; }

        public string Name { get; set; }

        public bool IsShown { get; set; }
    }
}
