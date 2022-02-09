﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace HOSTEL_SYSTEM_MANAGEMENT
{
    internal class RoomClass
    {
        // in this class we will manage rooms
         
        DBConnect connect = new DBConnect();

        //function to get a list of room's type

        public DataTable getRoomType()
        {
            string selectQuery = "SELECT * FROM `category`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        // function to add a new room
        public bool addRoom(string no, int type, string phone, string status)
        {
            string insertQuerry = "INSERT INTO `room`(`RoomId`, `RoomType`, `RoomPhone`, `RoomStatus`) VALUES (@no,@type,@ph,@sts)";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            //@no,@type,@ph,@sts
            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = no;
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@sts", MySqlDbType.VarChar).Value = status;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

        }

        // Create a function to get a table of room's list
        public DataTable getRoomList()
        {
            string selectQuery = "SELECT * FROM `room`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //function to edit/update a room
        public bool editRoom(string no, int type, string phone, string status)
        {
            string editQuerry = "UPDATE `room` SET `RoomType`=@type,`RoomPhone`=@ph,`RoomStatus`=@sts WHERE `RoomId`=@no";
            MySqlCommand command = new MySqlCommand(editQuerry, connect.GetConnection());
            //@no,@type,@ph,@sts
            command.Parameters.Add("@no", MySqlDbType.VarChar).Value = no;
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@sts", MySqlDbType.VarChar).Value = status;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

        }

        //function to remove a room
        //we only need the room No
        public bool removeRoom(string id)
        {
            string insertQuerry = "DELETE FROM `room` WHERE `RoomId`=@id";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            //@id
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

        }
    }
}
