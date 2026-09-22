using Wh40kCharacterList.Core.IngameEntities.CharacterProperties;

namespace Wh40kCharacterList.Core.Language;

public class RussianLanguagePack : ILanguagePack
{
    public string TranslateSkill(Skill skill)
    {
        return skill switch
        {
            Skill.Acrobatics => "Акробатика",
            Skill.Awareness => "Бдительность",
            Skill.Barther => "Бартер",
            Skill.Blather => "Трёп",
            Skill.Carouse => "Кутёж",
            Skill.Charm => "Обаяние",
            Skill.ChemUse => "Химиспользование",
            Skill.Ciphers => "Шифры",
            Skill.Climb => "Карабканье",
            Skill.Command => "Командование",
            Skill.Commerce => "Коммерция",
            Skill.CommonLore => "Общие знания",
            Skill.Concealment => "Маскировка",
            Skill.Contortionist => "Ловкач",
            Skill.Deceive => "Обман",
            Skill.Demolition => "Взрывчатка",
            Skill.Disguise => "Переодевание",
            Skill.Dodge => "Уклонение",
            Skill.Drive => "Вождение",
            Skill.Evaluate => "Оценка",
            Skill.ForbiddenLore => "Запретные знания",
            Skill.Gamble => "Азартные игры",
            Skill.Inquiry => "Розыск",
            Skill.Interrogation => "Допрос",
            Skill.Intimidate => "Запугивание",
            Skill.Invocation => "Воззвание",
            Skill.LipReading => "Чтение по губам",
            Skill.Literacy => "Грамотность",
            Skill.Logic => "Логика",
            Skill.Medicae => "Медика",
            Skill.Navigation => "Навигация",
            Skill.Performer => "Исполнитель",
            Skill.Pilot => "Пилотирование",
            Skill.Psyniscience => "Психонаука",
            Skill.ScholasticLore => "Учёные знания",
            Skill.Scrunity => "Внимательность",
            Skill.Search => "Поиск",
            Skill.SecretTongue => "Тайный язык",
            Skill.Security => "Взлом",
            Skill.Shadowing => "Слежка",//in the sheet there is unrelevant "Предсказывание"
            Skill.SilentMove => "Тихое движение",
            Skill.SleightOfHand => "Ловкость рук",
            Skill.SpeakLanguage => "Знание языка",
            Skill.Survival => "Выживание",
            Skill.Swim => "Плавание",
            Skill.TechUse => "Техпользование",
            Skill.Tracking => "Выслеживание",
            Skill.Trade => "Ремесло",
            Skill.Wrangling => "Животноводство",
            _ => "Неизвестный навык",
        };
    }
}
