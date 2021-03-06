﻿using System;
using System.Windows.Forms;
using System.Xml;
using System.Drawing;

namespace WachtrijApp
{
    public partial class FormWachtrij : Form
    {
        int aantalKlikken = 0;
        public FormWachtrij()
        {
            InitializeComponent();
        }

        //  Er is op het logo geklikt. Die actie start een event welke de onderstaande methode aanroept.
        private void AttractieLogo_Click(object sender, EventArgs e)
        {
            VerwerkWachtrijSensorData();

            VerwerkAttractieStatusData();
        }

        private void VerwerkWachtrijSensorData()
        {
            //  Roep de methode aan welke de wachttijd berekend.
            double Wachttijd = BerekenWachttijd();

            //  Gebruik de wachttijd om de tekst in de label 'labelWachttijdMelding' aan te passen.
            this.labelWachttijdMelding.Text = $"{Wachttijd} minuten";
        }

        //  Deze methode leest de sensordata in het betreffende XML bestand.
        //  Deze methode berekend vervolgens de de wachttijd in minuten en geeft deze terug.
        private double BerekenWachttijd()
        {
            double Wachttijd = 0;

            //  Lees het XML WachtrijSensoren bestand uit welke meet waar mensen staan te wachten.
            XmlDocument doc = new XmlDocument();
            doc.Load("SensorData\\WachtrijSensoren.xml");

            //  Selecteer de XML node 'Sensor01' en lees vervolgens de waarde binnen het element.
            //  Wanneer de sensor geen mensen detecteerd, geef de tot nu to berekende wachttijd terug.
            //  Wanneer de sensor wel mensen detecteerd, bereken de nieuwe wachttijd en ga door naar de volgende sensor.
            string node01 = doc.DocumentElement.SelectSingleNode("/Sensoren/Sensor01").InnerText;
            if (node01 == "False")
            {
                return Wachttijd;
            }
            Wachttijd += 6;

            string node02 = doc.DocumentElement.SelectSingleNode("/Sensoren/Sensor02").InnerText;
            if (node02 == "False")
            {
                return Wachttijd;
            }
            Wachttijd += 3.5;

            string node03 = doc.DocumentElement.SelectSingleNode("/Sensoren/Sensor03").InnerText;
            if (node03 == "False")
            {
                return Wachttijd;
            }
            Wachttijd += 3.5;

            string node04 = doc.DocumentElement.SelectSingleNode("/Sensoren/Sensor04").InnerText;
            if (node04 == "False")
            {
                return Wachttijd;
            }
            Wachttijd += 3.5;

            string node05 = doc.DocumentElement.SelectSingleNode("/Sensoren/Sensor05").InnerText;
            if (node05 == "False")
            {
                return Wachttijd;
            }
            Wachttijd += 3.5;

            string node06 = doc.DocumentElement.SelectSingleNode("/Sensoren/Sensor06").InnerText;
            if (node06 == "False")
            {
                return Wachttijd;
            }
            Wachttijd += 3.5;

            string node07 = doc.DocumentElement.SelectSingleNode("/Sensoren/Sensor07").InnerText;
            if (node07 == "False")
            {
                return Wachttijd;
            }
            Wachttijd += 3.5;

            string node08 = doc.DocumentElement.SelectSingleNode("/Sensoren/Sensor08").InnerText;
            if (node08 == "False")
            {
                return Wachttijd;
            }
            Wachttijd += 3.5;

            string node09 = doc.DocumentElement.SelectSingleNode("/Sensoren/Sensor09").InnerText;
            if (node09 == "False")
            {
                return Wachttijd;
            }
            Wachttijd += 3.5;

            string node10 = doc.DocumentElement.SelectSingleNode("/Sensoren/Sensor10").InnerText;
            if (node10 == "False")
            {
                return Wachttijd;
            }
            Wachttijd += 3.5;

            string node11 = doc.DocumentElement.SelectSingleNode("/Sensoren/Sensor11").InnerText;
            if (node11 == "False")
            {
                return Wachttijd;
            }
            Wachttijd += 3.5;

            string node12 = doc.DocumentElement.SelectSingleNode("/Sensoren/Sensor12").InnerText;
            if (node12 == "False")
            {
                return Wachttijd;
            }
            Wachttijd += 3.5;

            return Wachttijd;
        }

        private void VerwerkAttractieStatusData()
        {
            //  Lees het XML AttractieStatus bestand uit welke de data van de karretjes uitleest.
            XmlDocument doc = new XmlDocument();
            doc.Load("SensorData\\AttractieStatus.xml");

            //  Selecteer de XML node 'Kar01' en lees vervolgens de waarde binnen het element.
            //  Converteer de statuc-code in een status-beschrijving.
            //  Gebruik de status-beschrijving om de tekst in de label 'labelKar1' aan te passen.
            string node1 = doc.DocumentElement.SelectSingleNode("/Status/Kar01").InnerText;
            string status1 = ConvertStatus(node1);
            this.labelKar1.Text = $"Kar 1: {status1}";

            string node2 = doc.DocumentElement.SelectSingleNode("/Status/Kar02").InnerText;
            string status2 = ConvertStatus(node2);
            this.labelKar2.Text = $"Kar 2: {status2}";

            string node3 = doc.DocumentElement.SelectSingleNode("/Status/Kar03").InnerText;
            string status3 = ConvertStatus(node3);
            this.labelKar3.Text = $"Kar 3: {status3}";

        }

        //  Een methode welke een status-code omzet naar een status-beschrijving
        private string ConvertStatus(string StatusNr)
        {
            if (StatusNr == "0")
            {
                return "in-onderhoud";
            }

            if (StatusNr == "1")
            {
                return "in/uitstappen";
            }

            if (StatusNr == "2")
            {
                return "Klaar voor vertrek";
            }

            if (StatusNr == "3")
            {
                return "Op avontuur";
            }

            if (StatusNr == "4")
            {
                return "Komt binnen";
            }

            return "";
        }

        private void labelTitel_Click(object sender, EventArgs e)
        {
            aantalKlikken += 1;
            if (aantalKlikken == 3)
            {
                aantalKlikken = 0;
                Random rn = new Random();
                int R, G, B;
                R = rn.Next(0, 255);
                B = rn.Next(0, 255);
                G = rn.Next(0, 255);

                labelTitel.ForeColor = Color.FromArgb(R, G, B);
            }
        }    

        private void btnStatusUpdate_Click(object sender, EventArgs e)
        {
            VerwerkAttractieStatusData();
        }

        private void tmrUpdateStatus_Tick(object sender, EventArgs e)
        {
            VerwerkAttractieStatusData();
        }

        private void btnResetStatus_Click(object sender, EventArgs e)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("SensorData\\AttractieStatus.xml");

            foreach (XmlNode node in doc)
            {
                foreach (XmlNode childNode in node.ChildNodes)
                {
                    childNode.InnerText = "0";
                }

            }

            doc.Save("SensorData\\AttractieStatus.xml");
            VerwerkAttractieStatusData();
        }
    }
}
