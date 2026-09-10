-- Read
-- 1. Seleciona todas as tabelas através do * da tabela Vendas
SELECT * FROM Vendas;
GO
-- 2. Seleciona todas as colunas da tabela Vendas onde o faturamento é maior que 100
SELECT * FROM Vendas WHERE Faturamento > 100;
GO
-- 3. Seleciona as colunas Tipo e Lucro da tabela Vendas onde o tipo é igual a Camisa
-- LIKE é usado para buscar padrões em uma coluna, nesse caso, estamos buscando todas as linhas onde a coluna Tipo contém a palavra 'Camisa'.
-- LIKE % é um operador que permite buscar por padrões em uma coluna. O % é um curinga que representa qualquer sequência de caracteres, 
-- Então '%Cam%' significa qualquer valor que comece com 'Cam'.
SELECT Tipo, Lucro FROM Vendas WHERE Tipo LIKE '%Cam%';
GO