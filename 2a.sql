SELECT DISTINCT n.Nama, m.Tanggal
FROM Mahasiswa_Tanggal m
         JOIN Mahasiswa_Nim n ON m.NIM = n.NIM
WHERE DAY(m.Tanggal) IN (15, 17) AND MONTH(m.tanggal) = 6;
