-- Crear base de datos (opcional si ya existe)
-- El nombre de la base de datos debe ser DB_#CARNET
-- CREATE DATABASE PeliculasDB;
-- GO

-- Usar la base de datos
-- USE PeliculasDB;
-- GO

-- Tabla municipio
CREATE TABLE municipio (
    codigo_muni INT IDENTITY(10, 1) PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL
);

-- Tabla direccion
CREATE TABLE direccion (
    codigo_dir INT IDENTITY(10, 1) PRIMARY KEY,
    direccion NVARCHAR(255) NOT NULL,
    codigo_muni INT NOT NULL,
    FOREIGN KEY (codigo_muni) REFERENCES municipio(codigo_muni)
);

-- Tabla genero
CREATE TABLE genero (
    codigo_genero INT IDENTITY(10, 1) PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL
);

-- Tabla director
CREATE TABLE director (
    codigo_director INT IDENTITY(10, 1) PRIMARY KEY,
    nombre NVARCHAR(100) NOT NULL
);

-- Tabla cliente
CREATE TABLE cliente (
    codigo_cliente INT IDENTITY(10, 1) PRIMARY KEY,
    usuario NVARCHAR(50) NOT NULL,
    contrasenia NVARCHAR(MAX) NOT NULL,
    nombre NVARCHAR(100) NOT NULL,
    fecha_nacimiento DATE,
    codigo_dir INT NOT NULL,
    tipo NVARCHAR(50),
    FOREIGN KEY (codigo_dir) REFERENCES direccion(codigo_dir)
);

-- Tabla pelicula
CREATE TABLE pelicula (
    codigo_pelicula INT IDENTITY(10, 1) PRIMARY KEY,
    nombre NVARCHAR(200) NOT NULL,
    minutos INT,
    codigo_genero INT NOT NULL,
    codigo_director INT NOT NULL,
    FOREIGN KEY (codigo_genero) REFERENCES genero(codigo_genero),
    FOREIGN KEY (codigo_director) REFERENCES director(codigo_director)
);

-- Tabla favoritos (tabla de relación para "genera feedback" y "es calificada")
CREATE TABLE favoritos (
    codigo_rep INT IDENTITY(10, 1) PRIMARY KEY,
    codigo_cliente INT NOT NULL,
    codigo_pelicula INT NOT NULL,
    favorito BIT,
    calificacion INT,
    comentario NVARCHAR(MAX),
    FOREIGN KEY (codigo_cliente) REFERENCES cliente(codigo_cliente),
    FOREIGN KEY (codigo_pelicula) REFERENCES pelicula(codigo_pelicula)
);

-- Tabla watchlist (tabla de relación para "se guarda en" y "agrega a")
CREATE TABLE watchlist (
    codigo_watchlist INT IDENTITY(10, 1) PRIMARY KEY,
    codigo_cliente INT NOT NULL,
    codigo_pelicula INT NOT NULL,
    FOREIGN KEY (codigo_cliente) REFERENCES cliente(codigo_cliente),
    FOREIGN KEY (codigo_pelicula) REFERENCES pelicula(codigo_pelicula)
);

ALTER TABLE cliente
ADD CONSTRAINT chk_tipo_cliente
CHECK (tipo IN ('admin', 'cliente'));