using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entity
{
    /// <summary>
    /// ������ϸ��¼
    /// </summary>
    [Table("SearchDetails")]
    public class SearchDetails
    {
        public SearchDetails()
        {
            SearchTime = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        /// <summary>
        /// �ؼ���
        /// </summary>
        [Required(ErrorMessage = "�ؼ��ʲ���Ϊ��")]
        public string KeyWords { get; set; }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        [Column(TypeName = "datetime2")]
        public DateTime SearchTime { get; set; }

        /// <summary>
        /// ������IP
        /// </summary>
        public string IP { get; set; }
    }
}