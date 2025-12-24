using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing.Text;

namespace NotesApp.Data
{
    public static class DatabaseHelper
    {
    

        private static readonly string connectionString =
            @"Data Source=Data\Notes.db;Version=3;";

        // 🔹 Tablo oluştur
        public static void Initialize()
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string sql = @"
                CREATE TABLE IF NOT EXISTS Notes (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Title TEXT,
                    Content TEXT,
                    FontName TEXT,
                    FontSize INTEGER,
                    IsBold INTEGER,
                    TextColor INTEGER,
                    CreatedDate TEXT
                );";

                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static DataRow GetNoteById(int id)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string sql = "SELECT * FROM Notes WHERE Id = @Id";

                using (var da = new SQLiteDataAdapter(sql, con))
                {
                    da.SelectCommand.Parameters.AddWithValue("@Id", id);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt.Rows.Count > 0 ? dt.Rows[0] : null;
                }
            }
        }


        // 🔹 Not ekle
        public static void AddNote(
            string title,
            string content,
            string fontName,
            float fontSize,
            bool isBold,
            int textColor)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string sql = @"
                INSERT INTO Notes
                (Title, Content, FontName, FontSize, IsBold, TextColor, CreatedDate)
                VALUES
                (@Title, @Content, @FontName, @FontSize, @IsBold, @TextColor, @Date);";

                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Content", content);
                    cmd.Parameters.AddWithValue("@FontName", fontName);
                    cmd.Parameters.AddWithValue("@FontSize", fontSize);
                    cmd.Parameters.AddWithValue("@IsBold", isBold ? 1 : 0);
                    cmd.Parameters.AddWithValue("@TextColor", textColor);
                    cmd.Parameters.AddWithValue("@Date",
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                    cmd.ExecuteNonQuery();
                }
            }
        }
        //Notları Güncelle
        public static void UpdateNote(
        int id,
        string title,
        string content,
        string fontName,
        float fontSize,
        bool isBold,
        int textColor)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string sql = @"
        UPDATE Notes SET
            Title = @Title,
            Content = @Content,
            FontName = @FontName,
            FontSize = @FontSize,
            IsBold = @IsBold,
            TextColor = @TextColor
        WHERE Id = @Id;";

                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Content", content);
                    cmd.Parameters.AddWithValue("@FontName", fontName);
                    cmd.Parameters.AddWithValue("@FontSize", fontSize);
                    cmd.Parameters.AddWithValue("@IsBold", isBold ? 1 : 0);
                    cmd.Parameters.AddWithValue("@TextColor", textColor);
                    cmd.Parameters.AddWithValue("@Id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        // 🔹 Notları getir
        public static DataTable GetNotes()
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();

                string sql = "SELECT * FROM Notes ORDER BY Id DESC";

                using (var da = new SQLiteDataAdapter(sql, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // 🔹 Not sil
        public static void DeleteNote(int id)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                var cmd = new SQLiteCommand(
                    "DELETE FROM Notes WHERE Id=@Id", con);

                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

