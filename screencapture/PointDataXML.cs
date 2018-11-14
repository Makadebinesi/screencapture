using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace screencapture
{
    /// <summary>
    /// Для сериализации полученых данных в XML (Не используется)
    /// </summary>
    [Serializable]
    public class PointDataXML
    {
        public List<PointDataXML> arrayPointsData;
        XmlSerializer formatter = new XmlSerializer(typeof(List<PointDataXML>));

        [XmlAttribute]
        public int gazeX { get; set; }
        [XmlAttribute]
        public int gazeY { get; set; }
        [XmlAttribute]
        public int mouseX { get; set; }
        [XmlAttribute]
        public int mouseY { get; set; }
        [XmlAttribute]
        public double timeStamp { get; set; }
        [XmlAttribute]
        public decimal frame { get; set; }


        public PointDataXML() { }

        private PointDataXML(int gazeY, int gazeX, int mouseY, int mouseX, double timeStamp, decimal frame)
        {
            this.gazeY = gazeY;
            this.gazeX = gazeX;
            this.mouseY = mouseY;
            this.mouseX = mouseX;
            this.timeStamp = timeStamp;
            this.frame = frame;
        }


        public void LogWriting(double tempGazeX, double tempGazeY, double mouseCursorX, double mouseCursorY, double timeCounter, decimal frameCounter)
        {
            arrayPointsData.Add(new PointDataXML((int)tempGazeX, (int)tempGazeY, (int)mouseCursorX, (int)mouseCursorY, timeCounter, frameCounter));
        }

        public void LogSerialize(string fileNameLog)
        {
            using (FileStream fs = new FileStream(fileNameLog, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, arrayPointsData);
            }
        }

    }
}
