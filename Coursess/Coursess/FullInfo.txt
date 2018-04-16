SELECT
  Nagruzka.Nomer_group AS [Номер группы]
 ,Nagruzka.Kolischestvo_chasov * Predmet.Price AS Цена
 ,CONCAT(Prepodavateli.Family, ' ' ,Prepodavateli.Name , ' ',Prepodavateli.Surname  ) AS [Преподаватель]
 ,TypeZanaytia.Name_Type AS [Тип занятия]
 ,Predmet.Name_Predmeta AS [Название предмета]
 ,Groups.[Kolischestvo Stydent] AS [Количество студентов]
 ,Specialnosti.Name_spec AS [Название специальности]
 ,Otdelenie.Name_Otdela AS [Название факультета]
FROM dbo.Nagruzka
INNER JOIN dbo.Groups
  ON Nagruzka.Nomer_group = Groups.id_nom_group
INNER JOIN dbo.Otdelenie
  ON Groups.Otdelenie = Otdelenie.id_Otdelenia
INNER JOIN dbo.Predmet
  ON Nagruzka.id_Predmet = Predmet.id_Predmeta
INNER JOIN dbo.Prepodavateli
  ON Nagruzka.kod_Prepodavatelya = Prepodavateli.id_prepod
INNER JOIN dbo.Specialnosti
  ON Groups.Specialnost = Specialnosti.id_Speci
INNER JOIN dbo.TypeZanaytia
  ON Nagruzka.id_Type_zan = TypeZanaytia.id_type
WHERE Groups.[Open] = 0
