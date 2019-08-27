-- Описание вопроса приводит к проблеме связи многие ко многим, 
-- что нарушает нормализованность базы
-- изначально нужно разбить эту связь и ввести дополнительную таблицу 
-- Article (Id, Title) <- TagsList (ArticleId, TagId) -> Tag (Id, Value)
-- Теги можно склеить в выводе

select Article.Id, Title, STRING_AGG(Value, ', ') as Tags
from TagsList
right join Article on Article.Id = ArticleId
inner join Tag on Tag.Id = TagId
group by Article.Id, Title
order by Title