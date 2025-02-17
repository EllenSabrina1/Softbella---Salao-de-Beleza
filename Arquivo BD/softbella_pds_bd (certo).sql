create database SoftBella_pds_bd;
use SoftBella_pds_bd;

# Alunas: Anna Flávya, Bianca Eshiley, Iannay Luiza, Emilly Santana, Ellen Sabrina e Larah Schultes. 

create table Cliente(
id_cli int primary key,
cpf_cli varchar(300),
rg_cli varchar(300),
telefone_cli varchar(300),
email_cli varchar(300),
nome_cli varchar(300),
cidade_cli varchar(300),
rua_cli varchar(300),
bairro_cli varchar(300),
numero_cli varchar(300),
sexo_cli varchar(300),
tipo_cabelo_cli varchar(300),
data_nasc_cli date
);

insert into Cliente (id_cli, cpf_cli, rg_cli, telefone_cli, email_cli, nome_cli, cidade_cli, rua_cli, bairro_cli, numero_cli, sexo_cli, tipo_cabelo_cli, data_nasc_cli) 
values (1, '123.456.789-00', 'MG-12.345.678', '(11) 98765-4321', 'joao.silva@email.com', 'João Silva', 'São Paulo', 'Rua das Flores', 'Jardim das Palmeiras', '123', 'Masculino', 'Liso', '1985-06-15');

insert into Cliente (id_cli, cpf_cli, rg_cli, telefone_cli, email_cli, nome_cli, cidade_cli, rua_cli, bairro_cli, numero_cli, sexo_cli, tipo_cabelo_cli, data_nasc_cli) 
values (2, '234.567.890-01', 'SP-23.456.789', '(11) 98876-5432', 'maria.oliveira@email.com', 'Maria Oliveira', 'Rio de Janeiro', 'Av. Brasil', 'Centro', '456', 'Feminino', 'Cacheado', '1990-09-22');

insert into Cliente (id_cli, cpf_cli, rg_cli, telefone_cli, email_cli, nome_cli, cidade_cli, rua_cli, bairro_cli, numero_cli, sexo_cli, tipo_cabelo_cli, data_nasc_cli) 
values (3, '423.527.234.11', 'SP-23.456.789', '(11) 98876-5555', 'tata.oira@email.com', 'Talita Oira', 'Rio de Janeiro', 'Av. Brasil', 'Centro', '321', 'Feminino', 'Liso', '1990-02-22');

update Cliente set telefone_cli = '(11) 99999-8888' where id_cli = 1;

delete from Cliente where id_cli = 2;
select * from Cliente;

create table Funcionario(
id_fun int primary key,
cpf_fun varchar(300),
rg_fun varchar(300),
telefone_fun varchar(300),
email_fun varchar(300),
nome_fun varchar(300),
cidade_fun varchar(300),
rua_fun varchar(300),
bairro_fun varchar(300),
numero_fun varchar(300),
sexo_fun varchar(300),
data_nasc_fun date,
area_atuacao_fun varchar(300)
);

insert into Funcionario (id_fun, cpf_fun, rg_fun, telefone_fun, email_fun, nome_fun, cidade_fun, rua_fun, bairro_fun, numero_fun, sexo_fun, data_nasc_fun, area_atuacao_fun) 
values (1, '111111111', '749894290', '(69) 9999-3892', 'talita@exemplo.com', 'Talita Medeiros', 'Petrolina - RO', 'Rua Noé Inácio', 'Ernandes ','3562', 'Feminino', '1990-06-10', 'Especialista em Cachos' ); 

insert into Funcionario (id_fun, cpf_fun, rg_fun, telefone_fun, email_fun, nome_fun, cidade_fun, rua_fun, bairro_fun, numero_fun, sexo_fun, data_nasc_fun, area_atuacao_fun) 
values (2, '222222222', '123456789', '(69) 9888-1234', 'maria@exemplo.com', 'Maria Silva', 'Porto Velho - RO', 'Avenida Brasil', 'Centro', '4578', 'Feminino', '1985-03-22', 'Consultora de Imagem');

UPDATE Funcionario 
SET telefone_fun = '(69) 99262-3432', email_fun = 'novoemail@exemplo.com' 
WHERE id_fun = 1;

DELETE FROM Funcionario WHERE id_fun = 1;

create table Produto(
id_pro int primary key,
nome_pro varchar(300),
marca_pro varchar(300),
grupo_pro varchar(300),
estoque_venda_pro varchar(300),
medida_unidade_pro varchar(300),
nome_fornecedor_pro varchar(300),
contato_fornecedor_pro varchar(300),
cidade_pro varchar (300),
custo_pro int,
preco_venda_pro double,
lucro_pro int
);

insert into Produto (id_pro, nome_pro, marca_pro, grupo_pro, estoque_venda_pro, medida_unidade_pro, nome_fornecedor_pro, contato_fornecedor_pro, cidade_pro, custo_pro, preco_venda_pro, lucro_pro) 
values (1, 'Shampoo', 'Pantene', 'Procter & Gamble', 50, 5, 'Cásio Ferreira', '(00) 0000-0000', 'Ji-Paraná', 200.00, 39.99, 20.00);

insert into Produto (id_pro, nome_pro, marca_pro, grupo_pro, estoque_venda_pro, medida_unidade_pro, nome_fornecedor_pro, contato_fornecedor_pro, cidade_pro, custo_pro, preco_venda_pro, lucro_pro)
 values (2, 'Condicionador', 'Pantene', 'Procter & Gamble', 50, 5, 'Cásio Ferreira', '(00) 0000-0000','Ji-Paraná', 200.00, 39.99, 20.00);
 
insert into Produto (id_pro, nome_pro, marca_pro, grupo_pro, estoque_venda_pro, medida_unidade_pro, nome_fornecedor_pro, contato_fornecedor_pro, cidade_pro, custo_pro, preco_venda_pro, lucro_pro) 
values (3, 'Óleo Capilar', 'Pantene', 'Procter & Gamble', 50, 5, 'Cásio Ferreira', '(00) 0000-0000', 'Ji-Paraná', 200.00, 39.99, 20.00);
  
alter table Produto add id_pro_fk int;
alter table Produto add foreign key (id_pro_fk) references Produto (id_pro);

update Produto set nome_pro = 'Shampoo A', marca_pro = 'DaBelle', grupo_pro = 'Polyser', estoque_venda_pro = 40, medida_unidade_pro = 10, 
nome_fornecedor_pro = 'Sandro Lisboa', contato_fornecedor_pro = '(11) 1111-1111', cidade_pro = 'Porto Velho', custo_pro = 100.00 where id_pro = 1;

delete from Produto where id_pro = 1;

create table Estoque(
id_est int primary key,
nome_est varchar(300),
marca_est varchar(300),
grupo_est varchar(300),
produto_est varchar(300),
quantidade_est varchar(300),
fracionar_est varchar(300),
custo_est double,
lucro_est int,
fornecedor_est varchar(300),
contato_fornecedor_est varchar(300),
email_fornecedor varchar(300),
id_pro_fk int,
FOREIGN KEY (id_pro_fk) REFERENCES Produto(id_pro)
);  

insert into Estoque (id_est, nome_est, marca_est, grupo_est, produto_est, quantidade_est, fracionar_est, custo_est, lucro_est, fornecedor_est, contato_fornecedor_est, email_fornecedor)
values (1 , 'Estoque A', 'Marca X', 'Grupo 1', 'Produto A', 100, 'Sim', 50.0, 20, 'Fornecedor A',  '123456789', 'fornecedor@exemplo.com');
 
alter table Estoque add id_est_fk int;
alter table Estoque add foreign key (id_est_fk) references estoque (id_est);

update Estoque set nome_est = 'Estoque B', marca_est = 'Marca z', grupo_est = 'Grupo 2', produto_est = 'Produto B', quantidade_est = 200, fracionar_est = 'sim', custo_est = 40.00, 
lucro_est = 30, fornecedor_est = 'For B', contato_fornecedor_est = '987654321', email_fornecedor = 'Fornecedor@exem.com' where id_est = 1;

delete from Estoque where id_est = 1;

create table Servico(
id_ser int primary key,
grupo_ser varchar(300),
nome_servico_ser varchar(300),
tempo_necessario_ser varchar(300),
profissional_ser varchar(300),
valor_vista_ser varchar(300),
valor_prazo_ser varchar(300),
produtos_utilizados_ser varchar(300),
id_fun_fk int,
FOREIGN KEY (id_fun_fk) REFERENCES Funcionario(id_fun)
);

INSERT INTO Funcionario (id_fun, nome_fun) 
VALUES (1, 'João Silva');

INSERT INTO Servico (id_ser, grupo_ser, nome_servico_ser, tempo_necessario_ser, profissional_ser, valor_vista_ser, valor_prazo_ser, produtos_utilizados_ser, id_fun_fk)
VALUES (1, 'Cacheado', 'Corte em camadas', '2 horas', 'Anna Flavya', '50.00', '60.00', 'Tesoura', 1);

INSERT INTO Servico (id_ser, grupo_ser, nome_servico_ser, tempo_necessario_ser, profissional_ser, valor_vista_ser, valor_prazo_ser, produtos_utilizados_ser, id_fun_fk)
VALUES (2, 'Liso', 'Corte em camadas', '1 hora', 'Mariana', '80.00', '70.00', 'Tesoura', 1);

UPDATE Servico 
SET valor_vista_ser = '50.00', valor_prazo_ser = '60.00' 

WHERE id_ser = 1;

DELETE FROM Servico WHERE id_ser = 1;

create table Caixa(
id_caixa int primary key,
data_transacao date,
tipo_transacao varchar(100),
valor_transacao double,
descricao_transacao varchar(500), 
id_fun_fk int,
FOREIGN KEY (id_fun_fk) REFERENCES Funcionario(id_fun)
);
INSERT INTO Funcionario (id_fun, nome_fun) VALUES (102, 'Marina Silva');

insert into Caixa (id_caixa, data_transacao, tipo_transacao, valor_transacao, descricao_transacao, id_fun_fk) values  
(1, '2025-02-12', 'Entrada', 300.00, 'Pagamento por corte de cabelo e escova', 102);

SELECT id_fun FROM Funcionario WHERE id_fun = 101;

Delete from Caixa where id_caixa = 1;
Update Caixa set tipo_transacao = 'Saída', descricao_transacao = 'Compra de Escova secadora' WHERE id_caixa = 2;

create table Receber(
id_receber int primary key,
id_cli_fk int,
valor_total double,
valor_pago double,
saldo_devido double,
data_vencimento date,
data_pagamento date,
status_pagamento varchar(100),
forma_pagamento varchar(100),
descricao_recebimento varchar(300),
id_fun_fk int,
FOREIGN KEY (id_cli_fk) REFERENCES Cliente(id_cli),
FOREIGN KEY (id_fun_fk) REFERENCES Funcionario(id_fun)
);

INSERT INTO Receber ( id_receber, id_cli_fk, valor_total, valor_pago, saldo_devido, data_vencimento, data_pagamento, status_pagamento, 
forma_pagamento, descricao_recebimento, id_fun_fk ) VALUES (1, 3, 300.00, 300.00, 0.00, '2025-02-20', '2025-02-12', 'Pago', 'Cartão de Crédito', 'Pagamento de serviço de corte e escova', 2);

Update Receber set status_pagamento = 'Pendente' where id_receber = 2;

Delete from Receber where id_receber = 4;

select * from Receber;

create table pop_up_agendar(
id_pop int not null primary key auto_increment,
dia_pop date,
retorno_pop date,
serviço_pop varchar(100),
hora_pop time,
tempo_pop time,
profissional_pop varchar(100),
observacoes_pop varchar (300)
);

INSERT INTO pop_up_agendar (dia_pop, retorno_pop, serviço_pop, hora_pop, tempo_pop, profissional_pop, observacoes_pop) 
VALUES 
('2025-02-14', '2025-03-14', 'Coloração', '10:00:00', '02:00:00', 'Anna Flávya', 'Cliente deseja tonalidade loiro mel.');

INSERT INTO pop_up_agendar (dia_pop, retorno_pop, serviço_pop, hora_pop, tempo_pop, profissional_pop, observacoes_pop) 
VALUES 
('2025-02-15', '2025-03-15', 'Corte de cabelo', '14:30:00', '01:00:00', 'Emilly', 'Cliente quer corte em camadas.');

INSERT INTO pop_up_agendar (dia_pop, retorno_pop, serviço_pop, hora_pop, tempo_pop, profissional_pop, observacoes_pop) 
VALUES 
('2025-02-16', '2025-03-16', 'Tratamento Capilar', '09:00:00', '01:30:00', 'Bianca', 'Cliente precisa de hidratação profunda.');

UPDATE pop_up_agendar SET hora_pop = '11:00:00', observacoes_pop = 'Cliente deseja tonalidade castanho claro.'WHERE profissional_pop = 'Anna Flávya' AND serviço_pop = 'Coloração';

DELETE FROM pop_up_agendar WHERE profissional_pop = 'Emilly' AND serviço_pop = 'Corte de cabelo';

select * from pop_up_agendar;

create table consultar_agenda (
  id_conAgen int not null primary key auto_increment,   
  cpf_conAgen varchar(14) unique,                        
  nom_conAgene varchar(255),
  email_conAgen varchar(255),
  celular_conAgen varchar(20),
  id_pop_fk int,
  foreign key (id_pop_fk) references pop_up_agendar(id_pop) 
);

insert into consultar_agenda (cpf_conAgen, nom_conAgene, email_conAgen, celular_conAgen, id_pop_fk) values ('123.456.789-00', 'Ana Silva', 'ana@email.com', '11999990000', 1);    ##
insert into consultar_agenda (cpf_conAgen, nom_conAgene, email_conAgen, celular_conAgen, id_pop_fk) values ('555.666.777-00', 'Mariana Oliveira', 'mariana@email.com', '11977772222', 3);

delete from consultar_agenda where cpf_conAgen = '987.654.321-00';

update consultar_agenda set email_conAgen = 'novoemail@email.com', celular_conAgen = '11900001111' where id_conAgen = '1';

select * from consultar_agenda;

create table ConsultaProduto(
id_con int primary key,
produto_con varchar(200), 
nome_con varchar(200),
marcar_con varchar(200),
quantidade_con int,
custo_con double,
lucro_con double
);

insert into ConsultaProduto (id_con, produto_con, nome_con, marcar_con, quantidade_con, custo_con, lucro_con) values (1, 'Produto A', 'Cliente 1', 'Marca X', 10, 50.0, 20.0);

alter table ConsultaProduto add id_con_fk int;
alter table ConsultaProduto add foreign key (id_con_fk) references ConsultaProduto (id_con);

update ConsultaProduto set id_con_fk = 1 where id_con = 1;

delete from ConsultaProduto where id_con = 2;

create table ConsultarCliente(
id_con_cli int primary key, 
nome_con_cli varchar(300),
rg_con_cli varchar(20),
rua_con_cli varchar(300),
num_con_cli int,
bairro_con_cli varchar(300),
cidade_con_cli varchar(200),
id_con_cli_fk int,
foreign key (id_con_cli_fk) references Cliente(id_cli)
);
select * from consultarcliente;

insert into ConsultarCliente (id_con_cli, nome_con_cli, rg_con_cli, rua_con_cli, num_con_cli, bairro_con_cli, cidade_con_cli, id_con_cli_fk) 
values (1, 'João Silva', 'MG12345678', 'Rua das Flores', 101, 'Centro', 'Belo Horizonte', 1);

insert into ConsultarCliente (id_con_cli, nome_con_cli, rg_con_cli, rua_con_cli, num_con_cli, bairro_con_cli, cidade_con_cli, id_con_cli_fk) 
values (2, 'Maria Oliveira', 'SP87654321', 'Avenida Paulista', 200, 'Jardins', 'São Paulo', 1);

update ConsultarCliente set cidade_con_cli = 'Campinas', bairro_con_cli = 'Cambuí' where id_con_cli = 2;

delete from ConsultarCliente where id_con_cli = 1;  

create table Agenda_Rapida(
id_agen int primary key, 
nome_agen varchar(300),
hora_agen time, 
tempo_agen time,
servico_agen varchar(300),
profissional_agen varchar(300)
);

insert into Agenda_Rapida (id_agen, nome_agen, hora_agen, tempo_agen, servico_agen, profissional_agen)
values (1, 'Ana Souza', '10:00:00', '01:00:00', 'Manicure', 'Joana Silva');

insert into Agenda_Rapida (id_agen, nome_agen, hora_agen, tempo_agen, servico_agen, profissional_agen)
values (2, 'Carlos Pereira', '14:00:00', '01:30:00', 'Corte de Cabelo', 'Rita Oliveira');

insert into Agenda_Rapida (id_agen, nome_agen, hora_agen, tempo_agen, servico_agen, profissional_agen)
values (3, 'Maria Oliveira', '16:30:00', '00:45:00', 'Depilação', 'Luciana Costa');

update Agenda_Rapida set hora_agen = '15:00:00' where id_agen = 2;
delete from Agenda_Rapida where id_agen = 1;

select * from Agenda_Rapida;

create table Agendamento (
id_Agdt int not null primary key auto_increment,
cpf_Agdt varchar(14),
nome_Agdt varchar(100) not null,
email_Agdt varchar(150),
celular_Agdt varchar(20)
);

insert into agendamento values(1,'123.456.789-00', 'joão silva', 'joao@email.com', '(11) 91234-5678');
insert into agendamento values (2,'987.654.321-00', 'maria souza', 'maria@email.com', '(21) 99876-5432');

update agendamento set email_Agdt = 'joao.silva@email.com' where id_Agdt = 1;

delete from agendamento where id_Agdt = 1;

create table Relatorio_Servico(
id_rel_ser int primary key,
nome_servico_rel_ser varchar(300),
tempo_previsto_rel_ser date,
observacao_rel_ser varchar(300),
profissional_rel_ser varchar(300),
valor_vista_rel_ser double,
valor_prazo_ral_ser double,
id_ser_fk int,
foreign key (id_ser_fk) references Servico(id_ser)
);

INSERT INTO Relatorio_Servico (id_rel_ser, nome_servico_rel_ser, tempo_previsto_rel_ser, observacao_rel_ser, profissional_rel_ser, valor_vista_rel_ser, valor_prazo_ral_ser, id_ser_fk)  
VALUES (1, 'Corte em camadas', '2024-02-11', 'Cliente satisfeito', 'Ellen Sabrina', 50.00, 60.00, 2);

UPDATE Relatorio_Servico 
SET observacao_rel_ser = 'Cliente retornará para outro serviço' 
WHERE id_rel_ser = 1;

DELETE FROM Relatorio_Servico WHERE id_rel_ser = 1;

create table Caixa_Relatorio_Produto(
id_relatorio int primary key,
id_pro_fk int, 
data_relatorio date,
tipo_movimentacao varchar(100),
quantidade_movimentada int,
valor_unitario double,
valor_total double,
id_fun_fk int, 
FOREIGN KEY (id_pro_fk) REFERENCES Produto(id_pro),
FOREIGN KEY (id_fun_fk) REFERENCES Funcionario(id_fun)
);
INSERT INTO Funcionario (id_fun, nome_fun) VALUES (101, 'Felipe Castanhare');
INSERT INTO Produto (id_pro, nome_pro) VALUES (101, 'Selagem Aurea');

Insert into Caixa_Relatorio_Produto (id_relatorio, id_pro_fk, data_relatorio, tipo_movimentacao, quantidade_movimentada, valor_unitario, valor_total, id_fun_fk)   
values (1, 101, '2025-01-19', 'Venda', 3, 60.00, 180.00, 101); 

Create table ConsultaFichaAnaminetica (
id int auto_increment primary key,
tipo_cabelo varchar(255),
textura_cabelo varchar(255),
comprimento_cabelo varchar(255),
caracteristicas_cabelo varchar(255),
densidade_cabelo varchar(255),
gravida boolean,
procedimento_capilar_3m varchar(255),
usa_prancha_secador_modelador boolean,
frequentou_piscina_30d boolean,
alergia varchar(255),
tratamento_medico varchar(255),
outro_problema_info text
);

Insert into ConsultaFichaAnaminetica (tipo_cabelo, textura_cabelo, comprimento_cabelo, caracteristicas_cabelo, densidade_cabelo, gravida, procedimento_capilar_3m, usa_prancha_secador_modelador,
frequentou_piscina_30d, alergia, tratamento_medico, outro_problema_info) Values ('Cabelos Lisos', 'Fino', 'Curto', 'Sem frizz', 'Baixa', TRUE, 'Não', TRUE, FALSE, 'Nenhuma', 'Não', 'Nada a relatar');

update ConsultaFichaAnaminetica set tipo_cabelo = 'Ondulado' where id = 1;

delete from ConsultaFichaAnaminetica where id = 1;
 
 

