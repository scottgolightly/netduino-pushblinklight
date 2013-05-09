using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace netduino_pushblinklight
{
    public class Program
    {
        public static void Main()
        {
            // write your code here
            OutputPort led = new OutputPort(Pins.ONBOARD_LED, false);
            InputPort button = new InputPort(Pins.ONBOARD_BTN, false, Port.ResistorMode.Disabled);
            bool buttonState = false;

            while (true)
            {
                buttonState = button.Read();
                led.Write(buttonState);
            }

        }

    }
}
