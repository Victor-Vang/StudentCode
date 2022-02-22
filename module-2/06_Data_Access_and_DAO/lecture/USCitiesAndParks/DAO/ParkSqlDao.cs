using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using USCitiesAndParks.Models;

namespace USCitiesAndParks.DAO
{
    public class ParkSqlDao : IParkDao
    {
        private readonly string connectionString;

        public ParkSqlDao(string connString)
        {
            connectionString = connString;
        }

        public Park GetPark(int parkId)
        {
            throw new NotImplementedException();
        }

        public IList<Park> GetParksByState(string stateAbbreviation)
        {
            IList<Park> parks = new List<Park>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT park.* FROM park JOIN park_state ON park.park_id = park_state.park_id WHERE park_state.state_abbreviation = @state_abbreviation", conn);

                cmd.Parameters.AddWithValue("@state_abbreviation", stateAbbreviation);

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    Park park = new Park();
                    park.ParkId = Convert.ToInt32(reader["park_id"]);
                    park.ParkName = Convert.ToString(reader["park_name"]);
                    park.DateEstablished = Convert.ToDateTime(reader["date_established"]);
                    park.Area = Convert.ToDecimal(reader["area"]);
                    park.HasCamping = Convert.ToBoolean(reader["has_camping"]);
                    parks.Add(park);
                }
            }
            return parks;
        }

        public Park CreatePark(Park park)
        {
            throw new NotImplementedException();
        }

        public void UpdatePark(Park park)
        {
            throw new NotImplementedException();
        }

        public void DeletePark(int parkId)
        {
            throw new NotImplementedException();
        }

        public void AddParkToState(int parkId, string state_abbreviation)
        {
            throw new NotImplementedException();
        }

        public void RemoveParkFromState(int parkId, string state_abbreviation)
        {
            throw new NotImplementedException();
        }

        private Park CreateParkFromReader(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
