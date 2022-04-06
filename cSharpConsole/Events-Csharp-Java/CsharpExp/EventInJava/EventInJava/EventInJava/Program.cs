using System;
using System.Collections.Generic;

namespace EventInJava
{
    public interface  MetronomeEvent 
    {
      public  void Tick(DateTime dateTime);
    }
    public class MetronomeEventDelegate : MetronomeEvent
    {
        public void Tick(DateTime dateTime)
        {
            System.Console.WriteLine(dateTime);
        }
    }

    class EventFiringSource
    {
        protected List<MetronomeEvent> listenerList;
        public void addMetronomeEventListener(MetronomeEvent listener)
        {
            if (listenerList == null)
            {
                listenerList = new List<MetronomeEvent>();
            }
            listenerList.Add(listener);
        }
        public void fireMetronomeEvent()
        {
            if (listenerList!=null && listenerList.Count!=0)
            {
                foreach (var listener in listenerList)
                {
                    listener.Tick(new DateTime());
                }
            }
        }
    }

    class Program  
    {
       
       static  void   Main(string[] args)
        {
            EventFiringSource eventFiringSource = new();
            eventFiringSource.addMetronomeEventListener(new MetronomeEventDelegate());
            eventFiringSource.fireMetronomeEvent();
           

        }


        
    }
}
