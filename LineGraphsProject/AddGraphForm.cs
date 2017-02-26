using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineGraphsProject
{
    /// <summary>
    /// A form for choosing a graph type and range
    /// </summary>
    public partial class AddGraphForm : Form
    {
        private LineGraphDrawer drawer;
        private static Random rnd;

        /// <summary>
        /// The types of ILineGraphProviders which can be added
        /// </summary>
        private static List<Type> providerTypes;

        public AddGraphForm()
        {
            InitializeComponent();
            //this is using WinForms Data Binding mechanism, which allows any collection of objects to be used as data sources for controls
            //in the case of a ComboBox, the selected item (upcast to object) will later be available as sourceBox.SelectedItem
            sourceBox.DataSource = providerTypes;
            //DisplayMember is the name of the property to be displayed on the ComboBox
            //"Name" is a property of the Type class
            sourceBox.DisplayMember = "Name";

            this.colorBtn.BackColor = GenerateRandomColor();
        }

        private static Color GenerateRandomColor()
        {
            //(0xFF << 24) is for alpha, rnd.Next(0xFFFFFF) is for RGB
            // the pipe ('|') operator is bitwise OR
            return Color.FromArgb((0xFF << 24) | rnd.Next(0xFFFFFF));
        }

        //static constructor
        //called when the first instance is created, or a static property is first accessed
        static AddGraphForm()
        {
            providerTypes = new List<Type>();
            InitGraphProviders();
            rnd = new Random();
        }

        private static void InitGraphProviders()
        {
            AddProviderType<ImageGraphProvider>();
            AddProviderType<XmlGraphProvider>();
            AddProviderType<FunctionGraphProvider>();
            AddProviderType<TestGraphProvider>();
        }

        /// <summary>
        /// Adds the specified provider type so it can be selected by the user
        /// </summary>
        // new() means T must be initializable (not an Interface or abstract class)
        public static void AddProviderType<T>() where T : ILineGraphProvider, new()
        {
            //the typeof operator returns the object of type Type which belongs to the given type
            providerTypes.Add(typeof(T));
        }

        public LineGraphDrawer GetDrawer()
        {
            return this.drawer;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            float scaleX = (float)this.xScale.Value;
            if (scaleX == 0)
                scaleX = 1f;
            float scaleY = (float)this.yScale.Value;
            if (scaleY == 0)
                scaleY = 1f;

            //the created instance can always be cast to ILineGraphProvider, because the items in sourceBox.DataSource are only added 
            //by AddProviderType<T>() where T : ILineGraphProvider
            this.drawer = new LineGraphDrawer((ILineGraphProvider)Activator.CreateInstance((Type)sourceBox.SelectedItem), scaleX, scaleY, this.colorBtn.BackColor);
            this.Close();
        }
    }
}
