namespace Keepnote_Step1.Models
{
    public class Notes
    {
        public int NoteId { get; set; }
        public string NoteTitle { get; set; }
        public string NoteContent { get; set; }
        public bool Status { get; set; }
        public DateTime CreateDate { get; set; }


    }
}
