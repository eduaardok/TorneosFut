﻿using pruebas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TorneosFut.Class
{
    class csJugador
    {
        csConexion csConexion;
        private string _idJugador;
        private string _nombreJugador;
        private string _apellidoJugador;
        private string _sexo;
        private string _fechaNacimiento;
        private string _posicion;
        private string _nacionalidad;
        private string _peso;
        private string _altura;
        private string _piernaHabil;
        private string _imagenJugador;
        public csJugador(string u, string c)
        {
            csConexion = new csConexion(u,c);
        }
        public string IDJugador
        {
            get => _idJugador;
            set => _idJugador = value;
        }
        public string NombreJugador
        {
            get => _nombreJugador;
            set => _nombreJugador = value;
        }
        public string ApellidoJugador
        {
            get => _apellidoJugador;
            set => _apellidoJugador = value;
        }
        public string Sexo
        {
            get => _sexo;
            set => _sexo = value;
        }
        public string FechaNacimiento
        {
            get => _fechaNacimiento;
            set => _fechaNacimiento = value;
        }
        public string Posicion
        {
            get => _posicion;
            set => _posicion = value;
        }
        public string Nacionalidad
        {
            get => _nacionalidad;
            set => _nacionalidad = value;
        }
        public string Peso
        {
            get => _peso;
            set => _peso = value;
        }
        public string Altura
        {
            get => _altura;
            set => _altura = value;
        }
        public string PiernaHabil
        {
            get => _piernaHabil;
            set => _piernaHabil = value;
        }

        public string ImagenJugador
        {
            get => _imagenJugador;
            set => _imagenJugador = value;
        }
        public DataTable mostrarJugador()
        {
            return csConexion.ListDGV("select IDJugador,NombreJugador,ApellidoJugador,Sexo,FechaNacimiento,"
                                   + "Posicion,Nacionalidad,Peso,Altura,PiernaHabil from Jugador");
        }
        public DataTable ListaidJugadores()
        {
            DataTable dt = csConexion.ListDGV("Select IDJugador from Jugador");
            return dt;
        }
        public DataTable ListadeJugadores()
        {
            DataTable dt = csConexion.ListDGV("Select * from Jugador");
            return dt;
        }
        public DataTable ListadeJugadoresFiltro(string filtro)
        {
            DataTable dt;
            dt = csConexion.ListDGV($"select IDJugador,NombreJugador,ApellidoJugador,Sexo,FechaNacimiento, Posicion,Nacionalidad,Peso,Altura,PiernaHabil from Jugador where IDJugador like '%{filtro}%' " +
                    $"or NombreJugador like '%{filtro}%' or ApellidoJugador like '%{filtro}%' or Posicion like '%{filtro}%'");
            return dt;
        }
        public bool AgregarJugador(string idJugador, TextBox Txtnombre, TextBox txtapellido, ComboBox cmbsexo, DateTimePicker dtpNacimiento,
                                      ComboBox CmbPosicion, TextBox TxtNacionalidad, TextBox txtpeso, TextBox txtaltura, ComboBox cmbpierna, string imagen)
        {
            NombreJugador = Txtnombre.Text;
            ApellidoJugador = txtapellido.Text;
            Sexo = cmbsexo.Text;
            FechaNacimiento = dtpNacimiento.Value.ToString();
            MessageBox.Show(FechaNacimiento);
            Posicion = CmbPosicion.Text;
            Nacionalidad = TxtNacionalidad.Text;
            Peso = txtpeso.Text;
            Altura = txtaltura.Text;
            PiernaHabil = cmbpierna.Text;
            IDJugador = idJugador;
            ImagenJugador = imagen;
            string xmlJugador =
                "<Jugadores>" +
                "    <Jugador>" +
                $"        <IDJugador>{IDJugador}</IDJugador>" +
                $"        <NombreJugador>{NombreJugador}</NombreJugador>" +
                $"        <ApellidoJugador>{ApellidoJugador}</ApellidoJugador>" +
                $"        <Sexo>{Sexo}</Sexo>" +
                $"        <FechaNacimiento>{FechaNacimiento}</FechaNacimiento>" +
                $"        <Posicion>{Posicion}</Posicion>" +
                $"        <Nacionalidad>{Nacionalidad}</Nacionalidad>" +
                $"        <Peso>{Peso}</Peso>" +
                $"        <Altura>{Altura}</Altura>" +
                $"        <PiernaHabil>{PiernaHabil}</PiernaHabil>" +
                $"        <ImagenJugador>{ImagenJugador}</ImagenJugador>" +
                "    </Jugador>" +
                "</Jugadores>";
            if (csConexion.Consulta($"DECLARE @cadenaa VARCHAR(MAX) = '{xmlJugador}'; EXEC spRegistraJugador @cadenaa;"))
                return true;
            else
                return false;
        }

    }
}