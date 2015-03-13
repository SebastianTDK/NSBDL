using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NSBDL_Projet
{
    /// <summary>
    /// Reads the csv Student Name and retrieves a list
    /// </summary>
    class FileReader
    {
        /// <summary>
        /// This method reads the file and retrieves a List of Student Objects
        /// </summary>
        /// <param name="path">the path of the file</param>
        /// <returns></returns>
        public List<Student> CSVtoList(string path){
            //Instanciate
            List<Student> studentList = new List<Student>();

            //Stream Reader
            StreamReader myStream = new StreamReader(path, Encoding.Default);
            //read first line
            
            //read all the lines
            while (!myStream.EndOfStream)
            {
                //Inialise
                Student student = new Student();
                var ln = myStream.ReadLine();
                var value = ln.Split(';');

                student.LastName = value[0];
                student.FirstName = value[1];

                studentList.Add(student);

            }
            return studentList;
        }

    }
}
