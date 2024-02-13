SELECT n.Nama, COUNT(m.NIM) AS count
FROM Mahasiswa_Nim n
    JOIN Mahasiswa_Tanggal m ON n.NIM = m.NIM
GROUP BY m.NIM;