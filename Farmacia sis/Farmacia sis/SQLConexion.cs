using System.Data;
using System.Data.SqlClient;
using System.Security.Policy;

namespace Farmacia_sis
{
    public class SQLConexion
    {
        private string strConexion;
        public SqlConnection con;
        public SQLConexion(string strConexion)
        {
            this.strConexion = strConexion;
            con = new SqlConnection(strConexion);
        }


        public bool Conectar()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (SqlException ex)
            {
               
            }
            return false;
        }
        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        public void GetClientes(DataGridView data)
        {
            SqlCommand com = new SqlCommand();

            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "listarclientes";
            com.Connection = this.con;
            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable dt = new DataTable();
            da.Fill(dt);

            data.DataSource = dt;

        }
        public void Insertarcliente(string nombre, string cedula, string tel)
        {
            try
            {
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "InsertarCliente";
                com.Connection = this.con;

                SqlParameter[] sp = new SqlParameter[3];
                sp[0] = new SqlParameter("@PNombre", SqlDbType.VarChar);
                sp[0].Value = nombre;
                sp[1] = new SqlParameter("@cedula", SqlDbType.VarChar);
                sp[1].Value = cedula;
                sp[2] = new SqlParameter("@telefono", SqlDbType.VarChar);
                sp[2].Value = tel;
                com.Parameters.AddRange(sp);
                com.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void GetProductos(DataGridView data)
        {
            SqlCommand com = new SqlCommand();

            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "listarProductos";
            com.Connection = this.con;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable dt = new DataTable();
            da.Fill(dt);

            data.DataSource = dt;

        }
        public SqlDataReader GetProductoID(int id)
        {
            SqlCommand com = new SqlCommand();

            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "getProducto";
            com.Parameters.Add("@id", SqlDbType.Int).Value = id;
            com.Connection = this.con;

            SqlDataReader lector;
            lector = com.ExecuteReader();
            return lector;


        }
        public DataSet1 ReportCliente()
        {
            DataSet1 ds = new DataSet1();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ListarClientes";
            cmd.Connection = con;
            SqlDataAdapter das = new SqlDataAdapter(cmd);

            das.Fill(ds, "ListarClientes");

            return ds;
        }
        public DataSet1 ProductosMasVendidos()
        {
            DataSet1 ds = new DataSet1();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ProductosMasVendidos";
            cmd.Connection = con;
            SqlDataAdapter das = new SqlDataAdapter(cmd);

            das.Fill(ds, "ProductosMasVendidos");

            return ds;
        }
        public DataSet1 ProductosConExistencias()
        {
            DataSet1 ds = new DataSet1();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listarProductosExistentes";
            cmd.Connection = con;
            SqlDataAdapter das = new SqlDataAdapter(cmd);

            das.Fill(ds, "listarProductosExistentes");

            return ds;
        }
        public DataSet1 ProductosSinExistencias()
        {
            DataSet1 ds = new DataSet1();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listarProductosNOExistentes";
            cmd.Connection = con;
            SqlDataAdapter das = new SqlDataAdapter(cmd);

            das.Fill(ds, "listarProductosNOExistentes");

            return ds;
        }
        public DataSet1 RFacturas()
        {
            DataSet1 ds = new DataSet1();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listarFacturas";
            cmd.Connection = con;
            SqlDataAdapter das = new SqlDataAdapter(cmd);

            das.Fill(ds, "listarFacturas");

            return ds;
        }
        public DataSet1 ReportProveedor()
        {
            DataSet1 ds = new DataSet1();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listarProveedores";
            cmd.Connection = con;
            SqlDataAdapter das = new SqlDataAdapter(cmd);

            das.Fill(ds, "listarProveedores");

            return ds;
        }
        public void ActProducto(int id, string nombre, string precio, string desc, string prese, string proveedor)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[6];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                param[1] = new SqlParameter("@PNombrePr", SqlDbType.VarChar);
                param[1].Value = nombre;
                param[2] = new SqlParameter("@descripcion", SqlDbType.VarChar);
                param[2].Value = desc;
                param[3] = new SqlParameter("@presentacion", SqlDbType.VarChar);
                param[3].Value = prese;
                param[4] = new SqlParameter("@precio", SqlDbType.VarChar);
                param[4].Value = precio;
                param[5] = new SqlParameter("@proveedor", SqlDbType.VarChar);
                param[5].Value = proveedor;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EditarProducto";
                cmd.Connection = this.con;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
                MessageBox.Show("Actualizado..");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la Actualizacion " + ex.Message);
                return;
            }

        }
        public void NuevaFactura(string idc, float subt, float t, string date)
        {
            try
            {
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "NuevaFactura";
                com.Connection = this.con;
                SqlParameter[] sp = new SqlParameter[4];
                sp[0] = new SqlParameter("@idcliente", SqlDbType.VarChar);
                sp[0].Value = idc;
                sp[1] = new SqlParameter("@subTotal", SqlDbType.Float);
                sp[1].Value = subt;
                sp[2] = new SqlParameter("@Total", SqlDbType.Float);
                sp[2].Value = t;
                sp[3] = new SqlParameter("@fecha_y_hora", SqlDbType.VarChar);
                sp[3].Value = date;

                com.Parameters.AddRange(sp);
                com.ExecuteNonQuery();
                MessageBox.Show("Facturacion completada!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void NuevoDetalle(string prod, string cantidad)
        {
            try
            {
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "NuevoDetalle";
                com.Connection = this.con;
                SqlParameter[] sp = new SqlParameter[3];
                sp[0] = new SqlParameter("@idfactura", SqlDbType.Int);
                sp[0].Value = UltimoID();
                sp[1] = new SqlParameter("@idproducto", SqlDbType.VarChar);
                sp[1].Value = prod;
                sp[2] = new SqlParameter("@cantidadcomprada", SqlDbType.VarChar);
                sp[2].Value = cantidad;
                com.Parameters.AddRange(sp);
                com.ExecuteNonQuery();            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private int UltimoID()
        {
            int id;
            SqlCommand com = new SqlCommand();
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "GetUltimoIDFac";
            com.Connection = this.con;
            SqlDataReader r = com.ExecuteReader();
            r.Read();
            id = r.GetInt32(0);
            r.Close();
            return id;
        }
        public void GetFacturas(DataGridView data)
        {
            SqlCommand com = new SqlCommand();

            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "ListarFacturas";
            com.Connection = this.con;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable dt = new DataTable();
            da.Fill(dt);

            data.DataSource = dt;

        }
        public void GetFacturas(DataGridView data, int id)
        {
            SqlCommand com = new SqlCommand();

            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "getDetalles";
            com.Parameters.Add("@idFac", SqlDbType.Int).Value = id;
            com.Connection = this.con;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable dt = new DataTable();
            da.Fill(dt);

            data.DataSource = dt;

        }
        public SqlDataReader GetFacturas(int id)
        {
            SqlCommand com = new SqlCommand();

            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "listarFacturaID";
            com.Parameters.Add("@idFac", SqlDbType.Int).Value = id;
            com.Connection = this.con;

            SqlDataReader lector;
            lector = com.ExecuteReader();
            return lector;
        }
        public void InsertarProducto(string nombre, string desc, string prese, float prec, int cant, string fecha, string prov)
        {
            try
            {
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "NuevoProducto";
                com.Connection = this.con;

                SqlParameter[] sp = new SqlParameter[7];
                sp[0] = new SqlParameter("@PNombrePr", SqlDbType.VarChar);
                sp[0].Value = nombre;
                sp[1] = new SqlParameter("@Descripcion", SqlDbType.VarChar);
                sp[1].Value = desc;
                sp[2] = new SqlParameter("@presentacion", SqlDbType.VarChar);
                sp[2].Value = prese;
                sp[3] = new SqlParameter("@Precio", SqlDbType.Float);
                sp[3].Value = prec;
                sp[4] = new SqlParameter("@cantidad ", SqlDbType.Int);
                sp[4].Value = cant;
                sp[5] = new SqlParameter("@fecha_caducidad", SqlDbType.VarChar);
                sp[5].Value = fecha;
                sp[6] = new SqlParameter("@proveedor", SqlDbType.VarChar);
                sp[6].Value = prov;
                com.Parameters.AddRange(sp);
                com.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void EliminarProducto(int id)
        {
            try
            {
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "Eliminarproducto";
                com.Parameters.Add("idP", SqlDbType.Int).Value = id;
                com.Connection = this.con;;
                com.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado el producto");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EliminarFactura(int id)
        {
            try
            {
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "Eliminarfactura";
                com.Parameters.Add("idfactura", SqlDbType.Int).Value = id;
                com.Connection = this.con; ;
                com.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado la factura.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void GetProveedores(DataGridView data)
        {
            SqlCommand com = new SqlCommand();

            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "listarProveedores";
            com.Connection = this.con;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable dt = new DataTable();
            da.Fill(dt);

            data.DataSource = dt;

        }
        public void EliminarProveedor(int id)
        {
            try
            {
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "EliminarProveedor";
                com.Parameters.Add("idpr", SqlDbType.Int).Value = id;
                com.Connection = this.con; ;
                com.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado el proveedor.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EliminarCliente(int id)
        {
            try
            {
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "EliminarCliente";
                com.Parameters.Add("idcliente", SqlDbType.Int).Value = id;
                com.Connection = this.con; ;
                com.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado el proveedor.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public SqlDataReader GetClientes(int id)
        {
            SqlCommand com = new SqlCommand();

            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "ListarClienteID";
            com.Parameters.Add("@idcliente", SqlDbType.Int).Value = id;
            com.Connection = this.con;

            SqlDataReader lector;
            lector = com.ExecuteReader();
            return lector;
        }
        public SqlDataReader GetProveedores(int id)
        {
            SqlCommand com = new SqlCommand();

            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "listarProveedoresID";
            com.Parameters.Add("@idp", SqlDbType.Int).Value = id;
            com.Connection = this.con;

            SqlDataReader lector;
            lector = com.ExecuteReader();
            return lector;
        }
        public void ActCliente(int id, string nombre, string ced, string telefono)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                param[1] = new SqlParameter("@nombre", SqlDbType.VarChar);
                param[1].Value = nombre;
                param[2] = new SqlParameter("@cedula", SqlDbType.VarChar);
                param[2].Value = ced;
                param[3] = new SqlParameter("@tel", SqlDbType.VarChar);
                param[3].Value = telefono;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EditarCliente";
                cmd.Connection = this.con;
                cmd.Parameters.AddRange(param);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actualizado..");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error en la Actualizacion " + ex.Message);
                return;
            }

        }
        public void ActProveedor(int id, string nombre, string direcc, string tel)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@id", SqlDbType.Int);
                param[0].Value = id;
                param[1] = new SqlParameter("@NombrePr", SqlDbType.VarChar);
                param[1].Value = nombre;
                param[2] = new SqlParameter("@direccion", SqlDbType.VarChar);
                param[2].Value = direcc;
                param[3] = new SqlParameter("@telefono", SqlDbType.VarChar);
                param[3].Value = tel;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "EditarProveedor";
                cmd.Connection = this.con;
                cmd.Parameters.AddRange(param);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actualizado..");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la Actualizacion " + ex.Message);
                return;
            }

        }
        public void ActStock(int id, int cant)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@idpro", SqlDbType.Int);
                param[0].Value = id;
                param[1] = new SqlParameter("@cantidadEntrante", SqlDbType.Int);
                param[1].Value = cant;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SetStock";
                cmd.Connection = this.con;
                cmd.Parameters.AddRange(param);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actualizado..");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la Actualizacion " + ex.Message);
                return;
            }

        }
        public void InsertarProveedor(string nombre, string direc, string tel)
        {
            try
            {
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "NuevoProveedor";
                com.Connection = this.con;

                SqlParameter[] sp = new SqlParameter[3];
                sp[0] = new SqlParameter("@PNombreP", SqlDbType.VarChar);
                sp[0].Value = nombre;
                sp[1] = new SqlParameter("@direccionP", SqlDbType.VarChar);
                sp[1].Value = direc;
                sp[2] = new SqlParameter("@telefonoP", SqlDbType.VarChar);
                sp[2].Value = tel;
                com.Parameters.AddRange(sp);
                com.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
