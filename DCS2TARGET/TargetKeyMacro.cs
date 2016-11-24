using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCS2TARGET
{
    class TargetKeyMacro
    {
        private string name,category,command;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = makeNameSafe(value);
            }
        }

        public string Category
        {
            get
            {
                return this.category;
            }

            set
            {
                category = value.Replace(((char)160).ToString(), "");
                category.Trim();
                if (category.Equals(""))
                {
                    category = "Not Categorized";
                }
            } 
        }

        public string Command
        {
            get
            {
                return this.command;
            }
            set
            {
                string safe = value;
                StringBuilder safeKeys = new StringBuilder();
                safe = safe.Replace("\"", "");
                //safe = safe.Replace(((char)160).ToString(), "");
                safe = safe.Trim();
                string[] keys = safe.Split('-');
                for (int i = 0; i < keys.Length;i++) 
                {
                    string key = keys[i];
                    foreach (List<string> commandFilter in CommandMappings.commandFilters)
                    {
                        
                        if (key.Equals(commandFilter.ElementAt(0)))
                        {
                           key= commandFilter.ElementAt(1);
                        }
                    }
                    safeKeys.Append(key);
                    if (i < (keys.Length - 1))
                    {
                        safeKeys.Append(" + ");
                    }
                }

                command =  safeKeys.ToString();
            }
        }

        private string makeNameSafe(string aName)
        {
            string safe;
            safe = aName.Replace(" ", "_");
            safe.Replace(((char)160).ToString(), "");
            
            if (Char.IsDigit(safe.ToCharArray()[0])) {
                safe = "_" + safe;
            }
            return safe;
        }

    }
}
