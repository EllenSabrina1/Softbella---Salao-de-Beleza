create database Cadastro_Pds;
use Cadastro_Pds;


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


