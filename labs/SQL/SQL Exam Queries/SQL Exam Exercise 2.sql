/* 2.1 */
drop database test
drop table SpartanTable

create database test
create table SpartanTable
(
	title nvarchar(50) NOT NULL,
	firstName nvarchar(50) NOT NULL,
	lastName nvarchar(50) NOT NULL,
	university nvarchar(50) NOT NULL,
	courseTaken nvarchar (50) NOT NULL,
	mark nvarchar(50) NOT NULL,
)

INSERT INTO SpartanTable VALUES ('Mr', 'Alexander', 'Johnson', 'Brunel', 'Games Design', '2:1')
INSERT INTO SpartanTable VALUES ('Dr', 'Liam', 'Russell', 'Cairo', 'Cat Herding', '1st')
INSERT INTO SpartanTable VALUES ('Elder', 'Tobias', 'Soutar', 'Thebes', 'Gaia Studies', '1st')
INSERT INTO SpartanTable VALUES ('Archdeacon', 'Kieron', 'Newman', 'Roma', 'Super Mario Bros 2', 'Mastapeece')
INSERT INTO SpartanTable VALUES ('Epihipparch', 'Samuel', 'Ige', 'Constantinople', 'Literal Horse Racing', '1st++')
INSERT INTO SpartanTable VALUES ('Lord', 'Sanru', 'Geezah', 'MIT', 'Mechanical Engineering', '1st')
INSERT INTO SpartanTable VALUES ('Ms', 'Theresa', 'Oronsaye', 'Lunar', 'Astro-Agriculture', '1st hons')
INSERT INTO SpartanTable VALUES ('Shōgun', 'Brook', 'Harris', 'Kyoto', 'Martial Arts', '2:1')


select * from SpartanTable
