using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using KB.Models;

namespace Interface
{
    public partial class DataGridViewDragNDrop<T> : DataGridView
    {
        public DataGridViewDragNDrop()
        {
            InitializeComponent();
            AllowDrop = true;
            MouseMove += dataGridView1_MouseMove;
            MouseDown += dataGridView1_MouseDown;
            DragOver += dataGridView1_DragOver;
            DragDrop += dataGridView1_DragDrop;
        }

        public BindingList<T> DataSourceRows
        {
            get => _dataSourceRows;
            set
            {
                _dataSourceRows = value;
                DataSource = value;
            }
        }

        private BindingList<T> _dataSourceRows;
        
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;
        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {

                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = DoDragDrop(
                    Rows[rowIndexFromMouseDown],
                    DragDropEffects.Move);
                }
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            rowIndexFromMouseDown = HitTest(e.X, e.Y).RowIndex;
        if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
             // The DragSize indicates the size that the mouse can move 
             // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)),
                                    dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void dataGridView1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop =
                HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                var rowToMove = DataSourceRows[rowIndexFromMouseDown];
                DataSourceRows.RemoveAt(rowIndexFromMouseDown);
                DataSourceRows.Insert(rowIndexOfItemUnderMouseToDrop, rowToMove);
            }
        }
    }
}