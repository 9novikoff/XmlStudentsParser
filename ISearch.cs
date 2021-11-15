using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XmlStudentCirclesParser
{
    interface ISearch
    {
        List<Circle> Search(Circle circle);
    }

    class LinqToXmlAlgorithm : ISearch
    {
        public List<Circle> Search(Circle circle)
        {
            List<Circle> circles = new List<Circle>();
            var doc = XDocument.Load(MainForm.circlesFilePathXML);

            var temp = (from currentCircle in doc.Descendants(MainForm.Circle)
                        where ((circle.Name == null || currentCircle.Attribute(MainForm.CircleName).Value == circle.Name) &&
                        (circle.Faculty == null || currentCircle.Attribute(MainForm.Faculty).Value == circle.Faculty) &&
                        (circle.Schedule == null || currentCircle.Attribute(MainForm.Schedule).Value == circle.Schedule) &&
                        (circle.Monitor == null || currentCircle.Attribute(MainForm.Monitor).Value == circle.Monitor) &&
                        (circle.Subject == null || currentCircle.Attribute(MainForm.Subject).Value == circle.Subject))
                        select currentCircle).ToList();

            foreach (var item in temp)
            {
                circles.Add(GetCircleFromNode(item));
            }

            return circles;
        }

        private Circle GetCircleFromNode(XElement node)
        {
            Circle res = new Circle();

            res.Name = node.Attribute(MainForm.CircleName).Value;
            res.Faculty = node.Attribute(MainForm.Faculty).Value;
            res.Schedule = node.Attribute(MainForm.Schedule).Value;
            res.Monitor = node.Attribute(MainForm.Monitor).Value;
            res.Subject = node.Attribute(MainForm.Subject).Value;

            return res;
        }
    }

    class DOMAlgorithm : ISearch
    {
        public List<Circle> Search(Circle circle)
        {
            List<Circle> circles = new List<Circle>();
            XmlDocument doc = new XmlDocument();
            doc.Load(MainForm.circlesFilePathXML);

            XmlNode node = doc.DocumentElement;

            foreach(XmlNode item in node.ChildNodes)
            {
                string Name = item.Attributes[MainForm.CircleName].Value;
                string Faculty = item.Attributes[MainForm.Faculty].Value;
                string Schedule = item.Attributes[MainForm.Schedule].Value;
                string Monitor = item.Attributes[MainForm.Monitor].Value;
                string Subject = item.Attributes[MainForm.Subject].Value;

                if ((circle.Name == null || Name == circle.Name) &&
                        (circle.Faculty == null || Faculty == circle.Faculty) &&
                        (circle.Schedule == null || Schedule == circle.Schedule) &&
                        (circle.Monitor == null || Monitor == circle.Monitor) &&
                        (circle.Subject == null || Subject == circle.Subject))
                    circles.Add(new Circle(Name, Faculty, Schedule, Monitor, Subject));
            }

            return circles;
        }

    }

    class SAXAlgorithm : ISearch
    {
        public List<Circle> Search(Circle circle)
        {
            List<Circle> circles = new List<Circle>();
            XmlReader xmlReader = new XmlTextReader(MainForm.circlesFilePathXML);

            while (xmlReader.Read())
            {

                if (xmlReader.HasAttributes)
                    while (xmlReader.MoveToNextAttribute())
                    {
                        Circle currentCircle = GetFillCircle(xmlReader, circle);

                        if (currentCircle != null)
                            circles.Add(currentCircle);
                    }
            }

            return circles;
        }

        private Circle GetFillCircle(XmlReader xmlReader, Circle circle)
        {
            string Name = "";
            string Faculty = "";
            string Schedule = "";
            string Monitor = "";
            string Subject = "";

            if (xmlReader.Name.Equals(MainForm.CircleName) && (circle.Name == null || xmlReader.Value.Equals(circle.Name)))
            {
                Name = xmlReader.Value;

                xmlReader.MoveToNextAttribute();

                if (xmlReader.Name.Equals(MainForm.Faculty) && (circle.Faculty == null || xmlReader.Value.Equals(circle.Faculty)))
                {
                    Faculty = xmlReader.Value;

                    xmlReader.MoveToNextAttribute();

                    if (xmlReader.Name.Equals(MainForm.Schedule) && (circle.Schedule == null || xmlReader.Value.Equals(circle.Schedule)))
                    {
                        Schedule = xmlReader.Value;

                        xmlReader.MoveToNextAttribute();

                        if (xmlReader.Name.Equals(MainForm.Monitor) && (circle.Monitor == null || xmlReader.Value.Equals(circle.Monitor)))
                        {
                            Monitor = xmlReader.Value;

                            xmlReader.MoveToNextAttribute();

                            if (xmlReader.Name.Equals(MainForm.Subject) && (circle.Subject == null || xmlReader.Value.Equals(circle.Subject)))
                            {
                                Subject = xmlReader.Value;

                                return (new(Name, Faculty, Schedule, Monitor, Subject));
                            }
                        }
                    }
                }
            }
            return null;
        }
    }
}
