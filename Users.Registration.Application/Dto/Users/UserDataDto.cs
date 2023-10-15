using System.Runtime.Serialization;

namespace Users.Registration.Application.Dto.Users
{
    /// <summary>
    /// Информация о пользователе
    /// </summary>
    [DataContract]
    public class UserDataDto
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [DataMember]
        public long Id { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        [DataMember]
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        [DataMember]
        public string MiddleName { get; set; }
    }
}