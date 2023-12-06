using Farmacia_sis.CRUDs;
namespace Farmacia_sis
{
    public partial class Inventario : Form
    {
       private int indexData=0;
       private SQLConexion con;
        public Inventario(SQLConexion con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            
            con.GetProductos(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
            if (!textBox1.Text.Equals(""))
            {
                foreach(DataGridViewRow r in dataGridView1.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    
                    if(r.Cells[1].Value.ToString()?.ToUpper().IndexOf(textBox1.Text.ToUpper())==0)
                    {
                        r.Visible = true;
                    }
                }
            }
            else
            {
                con.GetProductos(dataGridView1);
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            indexData = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[indexData].Selected = true;
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EditarProducto ed = new EditarProducto(con,int.Parse(dataGridView1.Rows[indexData].Cells[0].Value.ToString()));
            ed.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto pr = new AgregarProducto(con);
            pr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro que desea eliminar el elemento seleccionado?","Advertencia",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                con.EliminarProducto(int.Parse(dataGridView1.Rows[indexData].Cells[0].Value.ToString()));
                con.GetProductos(dataGridView1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarStock ast = new AgregarStock(con, int.Parse(dataGridView1.Rows[indexData].Cells[0].Value.ToString()));
            ast.Show();
        }
    }

}