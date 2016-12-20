using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MidiScaleTest
{
    public partial class Form1 : Form
    {
        private string[] noteNames = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B", };

        public Form1()
        {
            int handle = 0;
            var numDevs = Midi.midiOutGetNumDevs();
            MidiOutCaps myCaps = new MidiOutCaps();
            var res = Midi.midiOutGetDevCaps(0, ref myCaps, (UInt32)Marshal.SizeOf(myCaps));

            res = Midi.midiOutOpen(ref handle, 0, null, 0, 0);
            res = Midi.midiOutShortMsg(handle, 0x000019C0);
            res = Midi.midiOutShortMsg(handle, 0x007F3C90);
            res = Midi.midiOutClose(handle);

            InitializeComponent();
            updateMinMajComboText();
            updateNote();
        }

        private void keyScroll_ValueChanged(object sender, EventArgs e)
        {
            updateMinMajComboText();
        }

        private void updateMinMajComboText()
        {
            key = keyScroll.Value;
            scale = (majMinCombo.SelectedIndex == 1) ? KeyScale.Minor : scale = KeyScale.Major;

            majMinCombo.Items.Clear();
            majMinCombo.Items.AddRange(new object[] {
                String.Format("{0} Major", noteNames[key]),
                String.Format("{0} Minor", noteNames[key])
            });

            majMinCombo.SelectedIndex = (scale == KeyScale.Major) ? 0 : 1;
        }

        private void noteScroll_Scroll(object sender, ScrollEventArgs e)
        {
            updateNote();
        }

        private void updateNote()
        {
            note = noteScroll.Value % 12;
            octave = noteScroll.Value / 12;
            noteButton.Text = String.Format("{0}{1}", noteNames[note], octave);
        }

        private int key;
        enum KeyScale {
            Major,
            Minor
        };
        KeyScale scale;
        private int note;
        private int octave;
    }
}
