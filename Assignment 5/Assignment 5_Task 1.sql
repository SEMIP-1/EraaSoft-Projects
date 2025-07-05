--Assignment 5_Task 1
----------------------------------------------------
--Step 1
create database The_film_industry
Go
----------------------------------------------------
--Step 2
use The_film_industry
Go
----------------------------------------------------
--Step 3
create schema members
go
create schema production 
go
create schema Release
go
----------------------------------------------------
--Step 4
create table members.actor
(--table 1
	act_id int primary key,
	act_fname varchar(20),
	act_lname varchar(20),
	act_gender varchar(1)
)
go
create table members.director
(--table 2
	dir_id int primary key,
	dir_fname varchar(20),
	dir_lname varchar(20)
)
go
create table production.movie
(--table 3
	mov_id int primary key,
	mov_title varchar(50),
	mov_year int,
	mov_time int,
	mov_lang varchar(50),
	mov_dt_rel date,
	mov_rel_country varchar(5),
)
go
create table production.movie_direction
(--table 4
	dir_id int references members.director(dir_id) ,
	mov_id int references production.movie(mov_id)
)
go
create table members.movie_cast
(--table 5
	act_id int references members.actor(act_id),
	mov_id int references production.movie(mov_id),
	_role varchar(30)
)
go
create table Release.reviewer
(--table 6
	rev_id int primary key,
	rev_name varchar(50)
)
go
create table production.genres
(--table 7
	gen_id int primary key,
	gen_title varchar(20)
)
go
create table production.movie_genres
(--table 8
	mov_id int references production.movie(mov_id),
	gen_id int references production.genres(gen_id)
)
go
create table Release.rating
(--table 9
	mov_id int references production.movie(mov_id),
	rev_id int references Release.reviewer(rev_id),
	rev_stars int,
	num_o_ratings int
)
go
----------------------------------------------------