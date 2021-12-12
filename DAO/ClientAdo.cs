﻿using Metier1;
using System;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public  class ClientAdo
    {
        public void Inserer(Client C)
        {
            SqlCommand cmdaj = new SqlCommand("insert into Client(CIN_Cl,Nom_Cl,Pren_Cl,Ville_Cl,Tel_Cl) values (@Cin,@Nom,@Pren,@Ville,@Tel)", Connexion.cn);
            cmdaj.Parameters.AddWithValue("@Cin", C.CIN_Cl);
            cmdaj.Parameters.AddWithValue("@Nom", C.Nom_Cl);
            cmdaj.Parameters.AddWithValue("@Pren", C.Pren_Cl);
            cmdaj.Parameters.AddWithValue("@Ville", C.Ville_Cl);
            cmdaj.Parameters.AddWithValue("@Tel", C.Tel_Cl);
            cmdaj.ExecuteNonQuery();
        }
        public static bool Existe_Client(Int64 Cin)
        {
            SqlCommand cverif = new SqlCommand("select * from Client where CIN_Cl = @Cin", Connexion.cn);
            cverif.Parameters.AddWithValue("@Cin", Cin);
            SqlDataReader drverif = cverif.ExecuteReader();
            if (drverif.HasRows == true)
            {
                drverif.Close();
                return true;
            }
            else
            {
                drverif.Close();
                return false;
            }
        }
        public void Supprimer(Int64 Cin)
        {
            string req = "delete from Client where CIN_Cl = @Cin";
            SqlCommand cmdsupp = new SqlCommand(req, Connexion.cn);
            cmdsupp.Parameters.AddWithValue("@Cin", Cin);
            cmdsupp.ExecuteNonQuery();
        }
        public void Modifier(Client C)
        {
            string req = "update Client set Nom_Cl=@Nom,Pren_Cl=@Pren, Ville_Cl=@Ville, Tel_Cl=@Tel where CIN_Cl =@Cin";
            SqlCommand cmdmaj = new SqlCommand(req, Connexion.cn);
            cmdmaj.Parameters.AddWithValue("@Nom", C.Nom_Cl);
            cmdmaj.Parameters.AddWithValue("@Pren", C.Pren_Cl);
            cmdmaj.Parameters.AddWithValue("@Ville", C.Ville_Cl);
            cmdmaj.Parameters.AddWithValue("@Tel", C.Tel_Cl);
            cmdmaj.Parameters.AddWithValue("@Cin", C.CIN_Cl);
            cmdmaj.ExecuteNonQuery();
        }

        public static DataTable Liste_Client()
        {
            DataTable dtcl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Client", Connexion.cn);
            da.Fill(dtcl);
            return dtcl;
        }
        public static DataTable Liste_Client(Int64 Cin)
        {
            DataTable dtcl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Client where CIN_Cl=@Cin", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Cin", Cin);
            da.Fill(dtcl);
            return dtcl;
        }
        public static DataTable Liste_Client_Cde(Int64 NCde)
        {
            DataTable dtcl = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select cl.* from Client cl, Commande c where cl.CIN_Cl=c.CIN_Cl and c.Num_Cde=@Num", Connexion.cn);
            da.SelectCommand.Parameters.AddWithValue("@Num", NCde);
            da.Fill(dtcl);
            return dtcl;
        }
    }
}
