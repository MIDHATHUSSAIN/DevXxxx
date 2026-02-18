using DevX.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DevX.Helper
{
     class AccessingData
    {
        string path = "C:\\Users\\mhussain\\source\\repos\\DevX\\Model\\data.xml";
        XmlRootAttribute xRoot = new XmlRootAttribute();
        public ObservableCollection<Student> RetrivingData()
        {
            try
            {   
                xRoot.ElementName = "Students";
                xRoot.IsNullable = true;
                XmlSerializer serializer = new XmlSerializer(typeof(ObservableCollection<Student>), xRoot);
                using (StreamReader reader = new StreamReader(path))
                {


                    var students = (ObservableCollection<Student>)serializer.Deserialize(reader);

                    return students;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }

        public void SavingData()
        {
            try
            {

            }
            catch (Exception ex) { 

               Console.WriteLine(ex.Message);
            }

        }

        public void UpdatingData()
        {
            try
            {

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeletingData()
        {
            try
            {

            }
            catch (Exception ex) {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
