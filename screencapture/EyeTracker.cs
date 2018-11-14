using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tobii.Interaction;
using Tobii.Interaction.Framework;

namespace screencapture
{
    class EyeTracker
    {
        public Host eyeHost;//Точка доступа к api айтрекера
        public FixationDataStream fixationDataStream;//Поток координат с айтрекера с enum содержащим состояние фиксации взгляда
        public double gazeX, gazeY;//координаты для записи из потока
        FixationDataEventType fixationDataEventType;//Перечисление (Begin - взгляд зафиксировался, Data - взгляд фиксирован, End - конец фиксации взгляда) 

        private static EyeTracker eyeTracker;
        private EyeTracker() { }
        public static EyeTracker GetEyeTracker()
        {
            if (eyeTracker == null)
                eyeTracker = new EyeTracker();
            return eyeTracker;
        }

        public void StartEyeStream()
        {
            eyeHost = new Host();
            fixationDataStream = eyeHost.Streams.CreateFixationDataStream(FixationDataMode.Slow);
            eyeHost.EnableConnection();

            //событие возникающее при получении новых данных с айтрекера
            fixationDataStream.Next += (o, fixation) =>
            {
                fixationDataEventType = fixation.Data.EventType;
                gazeX = fixation.Data.X;
                gazeY = fixation.Data.Y;
            };
        }

        public void StopEyeStream()
        {            
            eyeHost.DisableConnection();
            eyeHost.Dispose();
        }
    }
}
