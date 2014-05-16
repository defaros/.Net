/*==============================================================*/
/* Nom de SGBD :  Microsoft SQL Server 2008                     */
/* Date de création :  16/05/2014 00:57:32                      */
/*==============================================================*/


if exists (select 1
            from  sysobjects
           where  id = object_id('ADMINISTRATEUR')
            and   type = 'U')
   drop table ADMINISTRATEUR
go

if exists (select 1
            from  sysobjects
           where  id = object_id('FILIERE')
            and   type = 'U')
   drop table FILIERE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('QUESTION')
            and   type = 'U')
   drop table QUESTION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('REPONSE')
            and   type = 'U')
   drop table REPONSE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('UTILISATEUR')
            and   type = 'U')
   drop table UTILISATEUR
go

/*==============================================================*/
/* Table : ADMINISTRATEUR                                       */
/*==============================================================*/
create table ADMINISTRATEUR (
   ID_ADMINISTRATEUR    int                  not null,
   LOGIN_ADMINISTRATEUR text                 null,
   MDP_ADMINISTRATEUR   text                 null,
   constraint PK_ADMINISTRATEUR primary key nonclustered (ID_ADMINISTRATEUR)
)
go

/*==============================================================*/
/* Table : FILIERE                                              */
/*==============================================================*/
create table FILIERE (
   ID_FILIERE           int                  not null,
   NOM_FILIERE          text                 null,
   DESCRIPTION_FILIERE  text                 null,
   constraint PK_FILIERE primary key nonclustered (ID_FILIERE)
)
go

/*==============================================================*/
/* Table : QUESTION                                             */
/*==============================================================*/
create table QUESTION (
   ID_QUESTION          int                  not null,
   TEXTE_QUESTION       text                 null,
   TYPE_QUESTION        text                 null,
   constraint PK_QUESTION primary key nonclustered (ID_QUESTION)
)
go

/*==============================================================*/
/* Table : REPONSE                                              */
/*==============================================================*/
create table REPONSE (
   ID_REPONSE           int                  not null,
   ID_QUESTION          int                  not null,
   TEXTE_REPONSE        text                 null,
   POINT_REPONSE        int                  null,
   constraint PK_REPONSE primary key nonclustered (ID_REPONSE)
)
go

/*==============================================================*/
/* Table : UTILISATEUR                                          */
/*==============================================================*/
create table UTILISATEUR (
   ID_UTILISATEUR       int                  not null,
   PSEUDO_UTILISATEUR   text                 null,
   SCORE_UTILISATEUR    int                  null,
   constraint PK_UTILISATEUR primary key nonclustered (ID_UTILISATEUR)
)
go

