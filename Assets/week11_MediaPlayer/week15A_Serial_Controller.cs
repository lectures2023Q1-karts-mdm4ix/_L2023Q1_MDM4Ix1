using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System;
using System.Linq;

public class week15A_Serial_Controller : MonoBehaviour
{
    SerialPort arduino;
    public string portName;
    public string serialIn;
    public GameObject Media_Controller;

    void Start()
    {
        string[] ports = SerialPort.GetPortNames();
        foreach(string port in ports)
        {
            print(port);
        }

        portName = "/dev/tty.usbmodem14101";

        if (ports.Contains(portName))
        {
            arduino = new SerialPort(portName.ToString(), 9600);
            arduino.Open();
            arduino.ReadTimeout = 3000;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (arduino.IsOpen)
        {
            try
            {
                serialIn = arduino.ReadLine();
                print(serialIn);
                if (!string.IsNullOrEmpty(serialIn))
                {
                    serialIn = serialIn.Trim();
                    // 0 --> do nothing
                    // 1 --> play
                    // 2 --> stop
                    // 3 --> prev
                    // 4 --> next
                    if(serialIn.ToLower() == "1")
                    {
                        print("play media");
                        Media_Controller.SendMessage("OnClick_PlayMedia");
                    }
                    else if(serialIn.ToLower() == "2")
                    {
                        print("stop media");
                        Media_Controller.SendMessage("OnClick_StopMedia");
                    }
                    else if(serialIn.ToLower() == "3")
                    {
                        print("prev media");
                        Media_Controller.SendMessage("OnClick_PrevMedia");
                    }
                    else if(serialIn.ToLower() == "4")
                    {
                        print("next media");
                        Media_Controller.SendMessage("OnClick_NextMedia");
                    }
                }
            }
            catch (Exception e)
            {
                print(e);
            }
        }
    }
}
