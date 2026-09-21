SET XACT_ABORT ON;
BEGIN TRANSACTION;

DECLARE @basePathMoto NVARCHAR(400) =
N'C:\Users\Back\Documents\DEVBACKEND\Banco De Dados\Aula06\Cars\Cars\Fotos\Motos\';
DECLARE @basePathCarro NVARCHAR(400) = N'C:\Users\Back\Documents\DEVBACKEND\Banco De Dados\Aula06\Cars\Cars\Fotos\Carros\';
-- C:\Users\Back\Documents\DEVBACKEND\Banco de Dados\Aula06\Cars\Cars\Fotos\Motos\Moto1.jpg
-- C:\Users\Back\Documents\DEVBACKEND\Banco de Dados\Aula06\Cars\Cars\Fotos\Carros\Carro1.jpg
;WITH Sequencia AS (
   SELECT
       Id, -- chave primária da tabela Estoque (ajuste se for outro nome)
       Tipo,
       ROW_NUMBER() OVER (PARTITION BY Tipo ORDER BY Id) AS SeqNum
   FROM Estoque
   WHERE Tipo IN (1, 2)
)
UPDATE e
SET Foto = CASE
       WHEN s.Tipo = 1 THEN @basePathMoto + N'Moto' + CAST(s.SeqNum AS NVARCHAR(10)) + N'.jpg'
       WHEN s.Tipo = 2 THEN @basePathCarro + N'Carro' + CAST(s.SeqNum AS NVARCHAR(10)) + N'.jpg'
   END
FROM Estoque e
INNER JOIN Sequencia s ON e.Id = s.Id;

COMMIT TRANSACTION;

GO