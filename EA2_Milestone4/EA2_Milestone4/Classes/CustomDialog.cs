using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EA2_Milestone4.Classes
{
    class CustomDialog
    {

        //found this on stackoverflow.
        // https://stackoverflow.com/questions/5427020/prompt-dialog-in-windows-forms
        // was curious on finding a custom string dialog prompt to enter in a new score whenever a user wins

        public string showStringDialog(string text, string text2, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
                BackColor = Color.FromArgb(15, 18, 29),
                ForeColor = Color.FromArgb(200, 200, 200)
            };
            //after looking at these, did not know we can alter the object like this
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text , AutoSize = true,ForeColor = Color.FromArgb(200,200,200)};
            Label textLabel2 = new Label() { Left = 50, Top = 35, Text = text2, AutoSize = true,ForeColor = Color.FromArgb(200, 200, 200) };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 , MaxLength = 3, BackColor = Color.FromArgb(60, 60, 60), ForeColor = Color.FromArgb(200, 200, 200) };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70,DialogResult = DialogResult.OK, BackColor = Color.FromArgb(60, 60, 60), ForeColor = Color.FromArgb(200, 200, 200) };

            //guessing this is a listener wheenenver the user clicks it just closes the created form
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textLabel2);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text.ToUpper() : "";
        }

        
        //my attempt at making my own
        public bool showConfirmDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 200,
                Height = 120,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen,
                BackColor = Color.FromArgb(15, 18, 29),
                ForeColor = Color.FromArgb(200, 200, 200)
            };
            Label textLabel = new Label() { Left = 10, Top = 20, Text = text, AutoSize = true, ForeColor = Color.FromArgb(200,200,200) };
            Button confirmation = new Button() { Text = "Ok", Left = 40, Width = 100, Top = 50, DialogResult = DialogResult.OK, BackColor = Color.FromArgb(60, 60, 60), ForeColor = Color.FromArgb(200, 200, 200) };

            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(confirmation);

            return prompt.ShowDialog() == DialogResult.OK;
        }

    }
}
