using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_5.add1
{
    class Dictionary
    {
        private string[] key = new string[5];
        private string[] value = new string[5];
        private string[] ua = new string[5];

        public Dictionary()
        {
            key[0] = "книга"; value[0] = "book"; ua[0] = "книга";
            key[1] = "ручка"; value[1] = "pen"; ua[1] = "ручка";
            key[2] = "солнце"; value[2] = "sun"; ua[2] = "сонце";
            key[3] = "яблоко"; value[3] = "apple"; ua[3] = "яблоко";
            key[4] = "стол"; value[4] = "table"; ua[4] = "стіл";
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < key.Length; i++)
                    if (key[i] == index)
                        return key[i] + " - " + value[i] + " - " + ua[i] + " с руского";
                    else if (value[i] == index)
                        return key[i] + " - " + value[i] + " - " + ua[i] + " с английского";
                    else if (ua[i] == index)
                        return key[i] + " - " + value[i] + " - " + ua[i] + " с украинского";
                return string.Format("{0} - нет перевода для этого слова.", index);
            }
        }
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < key.Length)
                    return key[index] + " - " + value[index] + " - " + ua[index];
                else
                    return "Попытка обращения за пределы массива.";
            }
        }
    }
}
