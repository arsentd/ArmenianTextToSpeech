using System;
using System.Windows.Forms;
using ArmenianTextToSpeech;

namespace Visualizer
{
    public partial class VisualizerForm : Form
    {
        public VisualizerForm()
        {
            InitializeComponent();
        }

        private void ButtonSpeak_Click(object sender, EventArgs e)
        {
            Speak();
        }

        private void TextBoxWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void TextBoxWord_TextChanged(object sender, EventArgs e)
        {
            TextBoxWord.Text = TextBoxWord.Text.Replace(" " , string.Empty);
        }

        private void Speak()
        {
            var word = TextBoxWord.Text;
            try
            {
                var speed = (int)NumericUpDownSpeed.Value;

                var speech = new Speech();
                speech.Speak(word, speed);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Speak();
            }
        }
    }
}