using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ElectronicStoreApp.Properties;
namespace ElectronicStoreApp
{
    class test
    {
       public void tests()
        {
            string bImage = "0x6666643866666530303031303461343634393436303030313032303030303031303030313030303066666462303034333030303530333034303430343033303530343034303430353035303530363037306330383037303730373037306630613062303930633131306631323132313130663131313031333136316331373133";
            byte[] array = Encoding.ASCII.GetBytes(bImage);
            MemoryStream ms = new MemoryStream(array);
            ms.Seek(0,SeekOrigin.Begin);
            Image.FromStream(ms);
 
        }
    }
}
