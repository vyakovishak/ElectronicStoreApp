using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicStoreApp
{
    class StoreService
    {
        public List<string> CheckValues(Dictionary<string, string> userInputs)
        {
            List<string> failedBoxes = new List<string>();
            foreach (var item in userInputs)
            {
                int ignoreMe;
                bool parseSuccess = int.TryParse(item.Value.ToString(), out ignoreMe);
                if (item.Key.ToString() == "First Name" || item.Key.ToString() == "Last Name" || item.Key.ToString() == "State")
                {
                    if (parseSuccess == true || item.Value.ToString() == "")
                    {
                        failedBoxes.Add(item.Key.ToString());
                    }
                }
                else 
                {
                    if (item.Value.ToString() == "")
                    {
                        failedBoxes.Add(item.Key.ToString());
                    }
                }
            }
            return failedBoxes;
        }
        


    }
}
