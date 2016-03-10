using System;
using System.Drawing;
using System.Windows.Forms;

namespace WhiteBoard
{
    public partial class WhiteBoard : Form
    {
        // The current editing mode of the canvas.
        System.Windows.Controls.InkCanvasEditingMode mode;

        public WhiteBoard()
        {
            InitializeComponent();
            InitializeCanvas();
        }

        /// <summary>
        /// Called when a touch input is about to be received by the canvas.
        /// </summary>
        private void Canvas_PreviewTouchDown(object sender, System.Windows.Input.TouchEventArgs e)
        {
            // Save the current editing mode.
            if (canvas.EditingMode != System.Windows.Controls.InkCanvasEditingMode.None)
                mode = canvas.EditingMode;

            // Check if touch is disabled.
            if (touchDisabledBox.Checked)
                // Disable all editing.
                canvas.EditingMode = System.Windows.Controls.InkCanvasEditingMode.None;
        }

        /// <summary>
        /// Called when a touch input is about to leave the canvas.
        /// </summary>
        private void Canvas_PreviewTouchUp(object sender, System.Windows.Input.TouchEventArgs e)
        {
            // Return the editing mode back to normal.
            canvas.EditingMode = mode;
        }

        /// <summary>
        /// Called when the Clear Button is clicked.
        /// </summary>s
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear all of the strokes from the canvas.
            canvas.Strokes.Clear();
        }

        /// <summary>
        /// Called when the Black Button is clicked.
        /// </summary>
        private void blackButton_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Set the editing mode of the canvas to ink.
            canvas.EditingMode = System.Windows.Controls.InkCanvasEditingMode.Ink;
            // Set the drawing color of the canvas to black.
            canvas.DefaultDrawingAttributes.Color = System.Windows.Media.Color.FromRgb(0, 0, 0);
        }

        /// <summary>
        /// Called when the Red Button is clicked.
        /// </summary>
        private void redButton_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Set the editing mode of the canvas to ink.
            canvas.EditingMode = System.Windows.Controls.InkCanvasEditingMode.Ink;
            // Set the drawing color of the canvas to red.
            canvas.DefaultDrawingAttributes.Color = System.Windows.Media.Color.FromRgb(255, 0, 0);
        }

        /// <summary>
        /// Called when the Green Button is clicked.
        /// </summary>
        private void greenButton_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Set the editing mode of the canvas to ink.
            canvas.EditingMode = System.Windows.Controls.InkCanvasEditingMode.Ink;
            // Set the drawing color of the canvas to green.
            canvas.DefaultDrawingAttributes.Color = System.Windows.Media.Color.FromRgb(0, 255, 0);
        }

        /// <summary>
        /// Called when the Blue Button is clicked.
        /// </summary>
        private void blueButton_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Set the editing mode of the canvas to ink.
            canvas.EditingMode = System.Windows.Controls.InkCanvasEditingMode.Ink;
            // Set the drawing color of the canvas to blue.
            canvas.DefaultDrawingAttributes.Color = System.Windows.Media.Color.FromRgb(0, 0, 255);
        }

        /// <summary>
        /// Called when the erase button is clicked.
        /// </summary>
        private void eraseButton_Click(object sender, EventArgs e)
        {
            // Set the editing mode for the canvas to erase by point.
            canvas.EditingMode = System.Windows.Controls.InkCanvasEditingMode.EraseByPoint;
        }

        /// <summary>
        /// Called when the Erase Strokes Button is clicked.
        /// </summary>
        private void eraseStrokesButton_Click(object sender, EventArgs e)
        {
            // Set the editing mode for the canvas to erase by stroke.
            canvas.EditingMode = System.Windows.Controls.InkCanvasEditingMode.EraseByStroke;
        }

        /// <summary>
        /// Called when the stylus button is pressed while the stylus is hovering over
        /// the ink canvas.
        /// </summary>
        private void Canvas_StylusButtonDown(object sender, System.Windows.Input.StylusButtonEventArgs e)
        {
            // Check if the barrel button was pressed.
            if (e.StylusButton.Guid == System.Windows.Input.StylusPointProperties.BarrelButton.Id)
                // Set the editing mode of the canvas to erase by stroke.
                canvas.EditingMode = System.Windows.Controls.InkCanvasEditingMode.EraseByStroke;
        }

        /// <summary>
        /// Called when the stylus button is released while the stylus is hovering over
        /// the ink canvas,
        /// </summary>
        private void Canvas_StylusButtonUp(object sender, System.Windows.Input.StylusButtonEventArgs e)
        {
            // Check if the barrel button was released.
            if (e.StylusButton.Guid == System.Windows.Input.StylusPointProperties.BarrelButton.Id)
                // Set the editing mode of the canvas to ink.
                canvas.EditingMode = System.Windows.Controls.InkCanvasEditingMode.Ink;
        }

        /// <summary>
        /// Called when the stroke width slider is dragged by the user.
        /// </summary>
        private void strokeWidthBar_Scroll(object sender, EventArgs e)
        {
            // Change the canvas's stroke width to the specified width.
            canvas.DefaultDrawingAttributes.Width = strokeWidthBar.Value;
        }

        /// <summary>
        /// Called when the full screen toggle button is clicked.
        /// </summary>
        private void fullScreenToggleButton_Click(object sender, EventArgs e)
        {
            // Check if the form is already full screen.
            if (FormBorderStyle == FormBorderStyle.None)
            {
                // Return the form back to a regular windowed state.
                FormBorderStyle = FormBorderStyle.Sizable;

                // Change te button's text.
                fullScreenToggleButton.Text = "Full Screen";
            }

            else
            {
                // Make the form full screen.
                WindowState = FormWindowState.Minimized;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;

                // Change the button's text.
                fullScreenToggleButton.Text = "Exit Full Screen";
            }
        }

        /// <summary>
        /// Called when the choose color button is pressed.
        /// </summary>
        private void chooseColorButton_MouseClick(object sender, MouseEventArgs e)
        {
            // Open the color dialog.
            var result = colorDialog.ShowDialog();

            // Check if the user selected a color.
            if (result != DialogResult.Cancel)
                // Set the color of the canvas to the selcted color.
                canvas.DefaultDrawingAttributes.Color = System.Windows.Media.Color.FromArgb(
                    colorDialog.Color.A,
                    colorDialog.Color.R,
                    colorDialog.Color.G,
                    colorDialog.Color.B
                );
        }
    }
}
