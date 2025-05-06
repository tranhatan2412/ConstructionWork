if not exists (
    select
        *
    from
        sys.databases
    where
        name='QuanLyCongTrinh'
) create database QuanLyCongTrinh go use QuanLyCongTrinh go if not exists (
    select
        *
    from
        sys.tables
    where
        name='CongTrinh'
)
create table
    CongTrinh (
        ID int identity (1, 1),
        Name nvarchar (255) not null,
        Location nvarchar (255) not null,
        Year int check (Year>0),
        constraint pk_CongTrinh primary key (ID)
    )